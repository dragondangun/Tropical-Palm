using AngouriMath.Extensions;
using static AngouriMath.MathS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AngouriMath;
using Current = TropApprox.Current;
using static AngouriMath.Entity;

namespace TropicalPalm {
    internal static class ArraysFiller {
        static bool inftyCheck;
        public static bool InftyCheck {
            set => inftyCheck = value;
        }
        static Number.Real step = 1/10;
        public static Number.Real Step {
            set => step = value;
            get => step;
        }
        static Number.Real xFrom;
        public static Number.Real XFrom {
            set => xFrom = value;
        }

        static string f;
        public static string F {
            set => f = value;
        }

        public static Number.Real fillArrays(string P, Number.Real[] pY, Number.Real[] fY, Number.Real[] errY, Number.Real[] xArr, int range) {
            Number.Real rootMeanSquaredError = -1;

            try {
                if(range < 3) {
                    if(fY is not null) {
                        Number.Real squaredError = fillWithErrFunc(P, pY, xArr, fY, errY, 0, range);
                        rootMeanSquaredError = (Number.Real)MathS.Sqrt(squaredError / range);
                    }
                    else {
                        fillOnlyPolynomials(P, pY, xArr, 0, range);
                    }
                }
                else {
                    int oneThirdRange = range / 3;
                    int twoThirdRange = oneThirdRange + oneThirdRange;

                    CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
                    CancellationToken cancellationToken = cancellationTokenSource.Token;

                    if(f.Length != 0) {
                        Task<Number.Real> firstPart = Task.Run(() => fillWithErrFunc(P, pY, xArr, fY, errY, 0, oneThirdRange, cancellationTokenSource, cancellationToken));
                        Task<Number.Real> secondPart = Task.Run(() => fillWithErrFunc(P, pY, xArr, fY, errY, oneThirdRange, twoThirdRange, cancellationTokenSource, cancellationToken));
                        Task<Number.Real> thirdPart = Task.Run(() => fillWithErrFunc(P, pY, xArr, fY, errY, twoThirdRange, range, cancellationTokenSource, cancellationToken));
                        Task.WaitAll(firstPart, secondPart, thirdPart);

                        Number.Real squaredError = (firstPart.Result + secondPart.Result + thirdPart.Result).EvalNumerical().RealPart;
                        rootMeanSquaredError = (Number.Real)(MathS.Sqrt(squaredError / range).EvalNumerical().RealPart);
                    }
                    else {
                        Task firstPart = Task.Run(() => fillOnlyPolynomials(P, pY, xArr, 0, oneThirdRange, cancellationTokenSource, cancellationToken));
                        Task secondPart = Task.Run(() => fillOnlyPolynomials(P, pY, xArr, oneThirdRange, twoThirdRange, cancellationTokenSource, cancellationToken));
                        Task thirdPart = Task.Run(() => fillOnlyPolynomials(P, pY, xArr, twoThirdRange, range, cancellationTokenSource, cancellationToken));
                        Task.WaitAll(firstPart, secondPart, thirdPart);
                    }
                }
            }
            catch(AggregateException ae) {
                throw ae.InnerException;
            }

            if(inftyCheck) {
                correctInfty(pY);
            }

            return rootMeanSquaredError;
        }


        public static Number.Real fillArrays
        (
            string P, string Q,
            Number.Real[] pY, Number.Real[] qY, Number.Real[] pbyqY, Number.Real[] fY, Number.Real[] errY, Number.Real[] xArr,
            int range
        )
        {
            Number.Real rootMeanSquaredError = -1;

            try {
                if(range < 3) {
                    if(fY is not null) {
                        Number.Real squaredError = fillWithErrFunc(P, Q, pY, qY, pbyqY, xArr, fY, errY, 0, range);
                        rootMeanSquaredError = (Number.Real)(MathS.Sqrt(squaredError / range).EvalNumerical());
                    }
                    else {
                        fillOnlyPolynomials(P, Q, pY, qY, pbyqY, xArr, 0, range);
                    }
                }
                else {
                    int oneThirdRange = range / 3;
                    int twoThirdRange = oneThirdRange + oneThirdRange;

                    CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
                    CancellationToken cancellationToken = cancellationTokenSource.Token;

                    if(fY is not null) {
                        Task<Number.Real> firstPart = Task.Run(() => fillWithErrFunc(P, Q, pY, qY, pbyqY, xArr, fY, errY, 0, oneThirdRange, cancellationTokenSource, cancellationToken));
                        Task<Number.Real> secondPart = Task.Run(() => fillWithErrFunc(P, Q, pY, qY, pbyqY, xArr, fY, errY, oneThirdRange, twoThirdRange, cancellationTokenSource, cancellationToken));
                        Task<Number.Real> thirdPart = Task.Run(() => fillWithErrFunc(P, Q, pY, qY, pbyqY, xArr, fY, errY, twoThirdRange, range, cancellationTokenSource, cancellationToken));
                        Task.WaitAll(firstPart, secondPart, thirdPart);

                        Number.Real squaredError = firstPart.Result + secondPart.Result + thirdPart.Result;
                        rootMeanSquaredError = (Number.Real)(MathS.Sqrt(squaredError / range).EvalNumerical().RealPart);
                    }
                    else {
                        Task firstPart = Task.Run(() => fillOnlyPolynomials(P, Q, pY, qY, pbyqY, xArr, 0, oneThirdRange, cancellationTokenSource, cancellationToken));
                        Task secondPart = Task.Run(() => fillOnlyPolynomials(P, Q, pY, qY, pbyqY, xArr, oneThirdRange, twoThirdRange, cancellationTokenSource, cancellationToken));
                        Task thirdPart = Task.Run(() => fillOnlyPolynomials(P, Q, pY, qY, pbyqY, xArr, twoThirdRange, range, cancellationTokenSource, cancellationToken));
                        Task.WaitAll(firstPart, secondPart, thirdPart);
                    }
                }
            }
            catch(AggregateException ae) {
                throw ae.InnerException;
            }

            if(inftyCheck) {
                correctInfty(pY);
                correctInfty(qY);
                correctInfty(pbyqY);
            }

            return rootMeanSquaredError;
        }

        private static void fillOnlyPolynomials(string P, Number.Real[] pY, Number.Real[] xArr, int indexFrom, int indexTo) {
            Number.Real xValue = xFrom + indexFrom * step;
            var xVariable = Var("x");

            bool error = false;
            for(int i = indexFrom; i < indexTo; xValue += step, i++) {
                pY[i] = (Number.Real)Current.Algebra.Calculate(P.Substitute(xVariable, xValue));
                error |= isNaNTest(pY[i]);

                if(error) {
                    throw new NotFiniteNumberException($"When x is {xValue}:\npY={pY[i]}");
                }

                xArr[i] = xValue;
            }
        }

        private static void fillOnlyPolynomials(string P, string Q, Number.Real[] pY, Number.Real[] qY, Number.Real[] pbyqY, Number.Real[] xArr, int indexFrom, int indexTo) {
            Number.Real xValue = xFrom + indexFrom * step;
            var pbyq = $"({P})/({Q})";
            var xVariable = Var("x");

            bool error = false;
            for(int i = indexFrom; i < indexTo; xValue += step, i++) {
                pY[i] = (Number.Real)Current.Algebra.Calculate(P.Substitute(xVariable, xValue));
                error |= isNaNTest(pY[i]);
                qY[i] = (Number.Real)Current.Algebra.Calculate(Q.Substitute(xVariable, xValue));
                error |= isNaNTest(qY[i]);
                pbyqY[i] = (Number.Real)Current.Algebra.Calculate(pbyq.Substitute(xVariable, xValue));
                error |= isNaNTest(pbyqY[i]);

                if(error) {
                    throw new NotFiniteNumberException($"When x is {xValue}:\npY={pY[i]}\nqY={qY[i]}\npbyqY={pbyqY[i]}");
                }

                xArr[i] = xValue;
            }
        }

        private static void fillOnlyPolynomials(string P, string Q, Number.Real[] pY, Number.Real[] qY, Number.Real[] pbyqY, Number.Real[] xArr, int indexFrom, int indexTo, CancellationTokenSource cancellationTokenSource, CancellationToken cancellationToken) {
            Number.Real xValue = xFrom + indexFrom * step;
            var pbyq = $"({P})/({Q})";
            var xVariable = Var("x");

            bool error = false;
            for(int i = indexFrom; i < indexTo; xValue += step, i++) {
                pY[i] = (Number.Real)Current.Algebra.Calculate(P.Substitute(xVariable, xValue));
                error |= isNaNTest(pY[i]);
                qY[i] = (Number.Real)Current.Algebra.Calculate(Q.Substitute(xVariable, xValue));
                error |= isNaNTest(qY[i]);
                pbyqY[i] = (Number.Real)Current.Algebra.Calculate(pbyq.Substitute(xVariable, xValue));
                error |= isNaNTest(pbyqY[i]);

                if(error) {
                    cancellationTokenSource.Cancel();
                    throw new NotFiniteNumberException($"When x is {xValue}:\npY={pY[i]}\nqY={qY[i]}\npbyqY={pbyqY[i]}");
                }

                if(cancellationToken.IsCancellationRequested) {
                    return;
                }

                xArr[i] = xValue;
            }
        }

        private static void fillOnlyPolynomials(string P, Number.Real[] pY, Number.Real[] xArr, int indexFrom, int indexTo, CancellationTokenSource cancellationTokenSource, CancellationToken cancellationToken) {
            Number.Real xValue = xFrom + indexFrom * step;
            var xVariable = Var("x");

            bool error = false;
            for(int i = indexFrom; i < indexTo; xValue += step, i++) {
                pY[i] = (Number.Real)Current.Algebra.Calculate(P.Substitute(xVariable, xValue));
                error |= isNaNTest(pY[i]);

                if(error) {
                    cancellationTokenSource.Cancel();
                    throw new NotFiniteNumberException($"When x is {xValue}:\npY={pY[i]}");
                }

                if(cancellationToken.IsCancellationRequested) {
                    return;
                }

                xArr[i] = xValue;
            }
        }

        private static Number.Real fillWithErrFunc(string P, Number.Real[] pY, Number.Real[] xArr, Number.Real[] fY, Number.Real[] errY, int indexFrom, int indexTo) {
            Number.Real squaredError = 0;
            Number.Real xValue = xFrom + indexFrom * step;
            var xVariable = Var("x");


            bool error = false;
            for(int i = indexFrom; i < indexTo; xValue += step, i++) {
                pY[i] = (Number.Real)Current.Algebra.Calculate(P.Substitute(xVariable, xValue));
                error |= isNaNTest(pY[i]);

                fY[i] = f.Substitute(xVariable, xValue).EvalNumerical().RealPart;
                error |= isNaNTest(fY[i]);

                if(error) {
                    throw new NotFiniteNumberException($"When x is {xValue}:\npY={pY[i]}");
                }

                errY[i] = pY[i] - fY[i];
                squaredError += errY[i] * errY[i];
                xArr[i] = xValue;
            }

            return squaredError;
        }

        private static Number.Real fillWithErrFunc(
            string P, string Q, 
            Number.Real[] pY, Number.Real[] qY, Number.Real[] pbyqY, Number.Real[] xArr, Number.Real[] fY, Number.Real[] errY,
            int indexFrom, int indexTo
        )
        {
            Number.Real xValue;
            Number.Real squaredError = 0;
            xValue = xFrom + indexFrom * step;
            var pbyq = $"({P})/({Q})";
            var xVariable = Var("x");


            bool error = false;
            for(int i = indexFrom; i < indexTo; xValue += step, i++) {
                pY[i] = (Number.Real)Current.Algebra.Calculate(P.Substitute(xVariable, xValue));
                error |= isNaNTest(pY[i]);
                qY[i] = (Number.Real)Current.Algebra.Calculate(Q.Substitute(xVariable, xValue));
                error |= isNaNTest(qY[i]);
                pbyqY[i] = (Number.Real)Current.Algebra.Calculate(pbyq.Substitute(xVariable, xValue));
                error |= isNaNTest(pbyqY[i]);

                fY[i] = f.Substitute(xVariable, xValue).EvalNumerical().RealPart;
                error |= isNaNTest(fY[i]);

                if(error) {
                    throw new NotFiniteNumberException($"When x is {xValue}:\npY={pY[i]}\nqY={qY[i]}\npbyqY={pbyqY[i]}\nfY{fY[i]}");
                }

                errY[i] = pbyqY[i] - fY[i];
                squaredError += errY[i] * errY[i];
                xArr[i] = xValue;
            }

            return squaredError;
        }

        private static Number.Real fillWithErrFunc
        (
            string P, string Q,
            Number.Real[] pY, Number.Real[] qY, Number.Real[] pbyqY, Number.Real[] xArr, Number.Real[] fY, Number.Real[] errY,
            int indexFrom, int indexTo,
            CancellationTokenSource cancellationTokenSource, CancellationToken cancellationToken
        )
        {
            Number.Real xValue;
            Number.Real squaredError = 0;
            xValue = xFrom + indexFrom * step;
            var pbyq = $"({P})/({Q})";
            var xVariable = Var("x");


            bool error = false;
            for(int i = indexFrom; i < indexTo; xValue += step, i++) {
                pY[i] = (Number.Real)Current.Algebra.Calculate(P.Substitute(xVariable, xValue));
                error |= isNaNTest(pY[i]);
                qY[i] = (Number.Real)Current.Algebra.Calculate(Q.Substitute(xVariable, xValue));
                error |= isNaNTest(qY[i]);
                pbyqY[i] = (Number.Real)Current.Algebra.Calculate(pbyq.Substitute(xVariable, xValue));
                error |= isNaNTest(pbyqY[i]);

                fY[i] = f.Substitute(xVariable, xValue).EvalNumerical().RealPart;
                error |= isNaNTest(fY[i]);

                if(error) {
                    cancellationTokenSource.Cancel();
                    throw new NotFiniteNumberException($"When x is {xValue}:\npY={pY[i]}\nqY={qY[i]}\npbyqY={pbyqY[i]}\nfY{fY[i]}");
                }
                if(cancellationToken.IsCancellationRequested) {
                    return -1;
                }

                errY[i] = pbyqY[i] - fY[i];
                squaredError += errY[i] * errY[i];
                xArr[i] = xValue;
            }

            return squaredError;
        }

        private static Number.Real fillWithErrFunc
        (
            string P, 
            Number.Real[] pY, Number.Real[] xArr, Number.Real[] fY, Number.Real[] errY, 
            int indexFrom, int indexTo,
            CancellationTokenSource cancellationTokenSource, CancellationToken cancellationToken
        )
        {
            Number.Real xValue;
            Number.Real squaredError = 0;
            xValue = xFrom + indexFrom * step;
            var xVariable = Var("x");


            bool error = false;
            for(int i = indexFrom; i < indexTo; xValue += step, i++) {
                pY[i] = (Number.Real)Current.Algebra.Calculate(P.Substitute(xVariable, xValue));
                error |= isNaNTest(pY[i]);

                fY[i] = f.Substitute(xVariable, xValue).EvalNumerical().RealPart;
                error |= isNaNTest(fY[i]);

                if(error) {
                    cancellationTokenSource.Cancel();
                    throw new NotFiniteNumberException($"When x is {xValue}:\npY={pY[i]}");
                }
                if(cancellationToken.IsCancellationRequested) {
                    return -1;
                }

                errY[i] = pY[i] - fY[i];
                squaredError += errY[i] * errY[i];
                xArr[i] = xValue;
            }

            return squaredError;
        }

        private static bool isNaNTest(Number.Real number) {
            return number == MathS.NaN ||
                number == Number.Real.PositiveInfinity || 
                number == Number.Real.NegativeInfinity;
        }

        private static void correctInfty(Number.Real[] arr) {
            for(int i = 0; i < arr.Length; i++) {
                if(arr[i] == Number.Real.PositiveInfinity) {
                    arr[i] = 9000000d;
                }
                else if(arr[i] == Number.Real.NegativeInfinity) {
                    arr[i] = -9000000d;
                }
            }
        }

    }
}
