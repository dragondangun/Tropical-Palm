using AngouriMath.Extensions;
using static AngouriMath.MathS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AngouriMath;

namespace TropicalPalm {
    internal static class ArraysFiller {
        static bool inftyCheck;
        public static bool InftyCheck {
            set => inftyCheck = value;
        }
        static double step = 0.1;
        public static double Step {
            set => step = value;
            get => step;
        }
        static double xFrom;
        public static double XFrom {
            set => xFrom = value;
        }

        public delegate double Algebra(Entity expr);
        static Algebra currAlgebra;
        public static Algebra CurrAlgebra {
            get => currAlgebra;
            set => currAlgebra = value;
        }

        static string f;
        public static string F {
            set => f = value;
        }

        public static double fillArrays(string P, double[] pY, double[] fY, double[] errY, double[] xArr, int range) {
            double rootMeanSquaredError = -1;

            try {
                if(range < 3) {
                    if(fY is not null) {
                        double squaredError = fillWithErrFunc(P, pY, xArr, fY, errY, 0, range);
                        rootMeanSquaredError = Math.Sqrt(squaredError / range);
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

                    if(fY is not null) {
                        Task<double> firstPart = Task.Run(() => fillWithErrFunc(P, pY, xArr, fY, errY, 0, oneThirdRange, cancellationTokenSource, cancellationToken));
                        Task<double> secondPart = Task.Run(() => fillWithErrFunc(P, pY, xArr, fY, errY, oneThirdRange, twoThirdRange, cancellationTokenSource, cancellationToken));
                        Task<double> thirdPart = Task.Run(() => fillWithErrFunc(P, pY, xArr, fY, errY, twoThirdRange, range, cancellationTokenSource, cancellationToken));
                        Task.WaitAll(firstPart, secondPart, thirdPart);

                        double squaredError = firstPart.Result + secondPart.Result + thirdPart.Result;
                        rootMeanSquaredError = Math.Sqrt(squaredError / range);
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


        public static double fillArrays(string P, string Q, double[] pY, double[] qY, double[] pbyqY, double[] fY, double[] errY, double[] xArr, int range) {
            double rootMeanSquaredError = -1;

            try {
                if(range < 3) {
                    if(fY is not null) {
                        double squaredError = fillWithErrFunc(P, Q, pY, qY, pbyqY, xArr, fY, errY, 0, range);
                        rootMeanSquaredError = Math.Sqrt(squaredError / range);
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
                        Task<double> firstPart = Task.Run(() => fillWithErrFunc(P, Q, pY, qY, pbyqY, xArr, fY, errY, 0, oneThirdRange, cancellationTokenSource, cancellationToken));
                        Task<double> secondPart = Task.Run(() => fillWithErrFunc(P, Q, pY, qY, pbyqY, xArr, fY, errY, oneThirdRange, twoThirdRange, cancellationTokenSource, cancellationToken));
                        Task<double> thirdPart = Task.Run(() => fillWithErrFunc(P, Q, pY, qY, pbyqY, xArr, fY, errY, twoThirdRange, range, cancellationTokenSource, cancellationToken));
                        Task.WaitAll(firstPart, secondPart, thirdPart);

                        double squaredError = firstPart.Result + secondPart.Result + thirdPart.Result;
                        rootMeanSquaredError = Math.Sqrt(squaredError / range);
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

        private static void fillOnlyPolynomials(string P, double[] pY, double[] xArr, int indexFrom, int indexTo) {
            double xValue;
            xValue = xFrom + indexFrom * step;
            var xVariable = Var("x");

            bool error = false;
            for(int i = indexFrom; i < indexTo; xValue += step, i++) {
                pY[i] = currAlgebra(P.Substitute(xVariable, xValue));
                error |= double.IsNaN(pY[i]);

                if(error) {
                    throw new NotFiniteNumberException($"When x is {xValue}:\npY={pY[i]}");
                }

                xArr[i] = xValue;
            }
        }

        private static void fillOnlyPolynomials(string P, string Q, double[] pY, double[] qY, double[] pbyqY, double[] xArr, int indexFrom, int indexTo) {
            double xValue;
            xValue = xFrom + indexFrom * step;
            var pbyq = $"({P})/({Q})";
            var xVariable = Var("x");

            bool error = false;
            for(int i = indexFrom; i < indexTo; xValue += step, i++) {
                pY[i] = currAlgebra(P.Substitute(xVariable, xValue));
                error |= double.IsNaN(pY[i]);
                qY[i] = currAlgebra(Q.Substitute(xVariable, xValue));
                error |= double.IsNaN(qY[i]);
                pbyqY[i] = currAlgebra(pbyq.Substitute(xVariable, xValue));
                error |= double.IsNaN(pbyqY[i]);

                if(error) {
                    throw new NotFiniteNumberException($"When x is {xValue}:\npY={pY[i]}\nqY={qY[i]}\npbyqY={pbyqY[i]}");
                }

                xArr[i] = xValue;
            }
        }

        private static void fillOnlyPolynomials(string P, string Q, double[] pY, double[] qY, double[] pbyqY, double[] xArr, int indexFrom, int indexTo, CancellationTokenSource cancellationTokenSource, CancellationToken cancellationToken) {
            double xValue;
            xValue = xFrom + indexFrom * step;
            var pbyq = $"({P})/({Q})";
            var xVariable = Var("x");

            bool error = false;
            for(int i = indexFrom; i < indexTo; xValue += step, i++) {
                pY[i] = currAlgebra(P.Substitute(xVariable, xValue));
                error |= double.IsNaN(pY[i]);
                qY[i] = currAlgebra(Q.Substitute(xVariable, xValue));
                error |= double.IsNaN(qY[i]);
                pbyqY[i] = currAlgebra(pbyq.Substitute(xVariable, xValue));
                error |= double.IsNaN(pbyqY[i]);

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

        private static void fillOnlyPolynomials(string P, double[] pY, double[] xArr, int indexFrom, int indexTo, CancellationTokenSource cancellationTokenSource, CancellationToken cancellationToken) {
            double xValue;
            xValue = xFrom + indexFrom * step;
            var xVariable = Var("x");

            bool error = false;
            for(int i = indexFrom; i < indexTo; xValue += step, i++) {
                pY[i] = currAlgebra(P.Substitute(xVariable, xValue));
                error |= double.IsNaN(pY[i]);

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

        private static double fillWithErrFunc(string P, double[] pY, double[] xArr, double[] fY, double[] errY, int indexFrom, int indexTo) {
            double xValue;
            double squaredError = 0;
            xValue = xFrom + indexFrom * step;
            var xVariable = Var("x");


            bool error = false;
            for(int i = indexFrom; i < indexTo; xValue += step, i++) {
                pY[i] = currAlgebra(P.Substitute(xVariable, xValue));
                error |= double.IsNaN(pY[i]);

                fY[i] = ((double)f.Substitute(xVariable, xValue).EvalNumerical().RealPart);
                error |= double.IsNaN(fY[i]);

                if(error) {
                    throw new NotFiniteNumberException($"When x is {xValue}:\npY={pY[i]}");
                }

                errY[i] = pY[i] - fY[i];
                squaredError += errY[i] * errY[i];
                xArr[i] = xValue;
            }

            return squaredError;
        }

        private static double fillWithErrFunc(string P, string Q, double[] pY, double[] qY, double[] pbyqY, double[] xArr, double[] fY, double[] errY, int indexFrom, int indexTo) {
            double xValue;
            double squaredError = 0;
            xValue = xFrom + indexFrom * step;
            var pbyq = $"({P})/({Q})";
            var xVariable = Var("x");


            bool error = false;
            for(int i = indexFrom; i < indexTo; xValue += step, i++) {
                pY[i] = currAlgebra(P.Substitute(xVariable, xValue));
                error |= double.IsNaN(pY[i]);
                qY[i] = currAlgebra(Q.Substitute(xVariable, xValue));
                error |= double.IsNaN(qY[i]);
                pbyqY[i] = currAlgebra(pbyq.Substitute(xVariable, xValue));
                error |= double.IsNaN(pbyqY[i]);

                fY[i] = ((double)f.Substitute(xVariable, xValue).EvalNumerical().RealPart);
                error |= double.IsNaN(fY[i]);

                if(error) {
                    throw new NotFiniteNumberException($"When x is {xValue}:\npY={pY[i]}\nqY={qY[i]}\npbyqY={pbyqY[i]}\nfY{fY[i]}");
                }

                errY[i] = pbyqY[i] - fY[i];
                squaredError += errY[i] * errY[i];
                xArr[i] = xValue;
            }

            return squaredError;
        }

        private static double fillWithErrFunc(string P, string Q, double[] pY, double[] qY, double[] pbyqY, double[] xArr, double[] fY, double[] errY, int indexFrom, int indexTo, CancellationTokenSource cancellationTokenSource, CancellationToken cancellationToken) {
            double xValue;
            double squaredError = 0;
            xValue = xFrom + indexFrom * step;
            var pbyq = $"({P})/({Q})";
            var xVariable = Var("x");


            bool error = false;
            for(int i = indexFrom; i < indexTo; xValue += step, i++) {
                pY[i] = currAlgebra(P.Substitute(xVariable, xValue));
                error |= double.IsNaN(pY[i]);
                qY[i] = currAlgebra(Q.Substitute(xVariable, xValue));
                error |= double.IsNaN(qY[i]);
                pbyqY[i] = currAlgebra(pbyq.Substitute(xVariable, xValue));
                error |= double.IsNaN(pbyqY[i]);

                fY[i] = ((double)f.Substitute(xVariable, xValue).EvalNumerical().RealPart);
                error |= double.IsNaN(fY[i]);

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

        private static double fillWithErrFunc(string P, double[] pY, double[] xArr, double[] fY, double[] errY, int indexFrom, int indexTo, CancellationTokenSource cancellationTokenSource, CancellationToken cancellationToken) {
            double xValue;
            double squaredError = 0;
            xValue = xFrom + indexFrom * step;
            var xVariable = Var("x");


            bool error = false;
            for(int i = indexFrom; i < indexTo; xValue += step, i++) {
                pY[i] = currAlgebra(P.Substitute(xVariable, xValue));
                error |= double.IsNaN(pY[i]);

                fY[i] = ((double)f.Substitute(xVariable, xValue).EvalNumerical().RealPart);
                error |= double.IsNaN(fY[i]);

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

        private static void correctInfty(double[] arr) {
            for(int i = 0; i < arr.Length; i++) {
                if(double.IsPositiveInfinity(arr[i])) {
                    arr[i] = 9000000d;
                }
                else if(double.IsNegativeInfinity(arr[i])) {
                    arr[i] = -9000000d;
                }
            }
        }

    }
}
