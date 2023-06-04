using AngouriMath;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AngouriMath.Entity;

namespace TropicalPalm {
    public static class Tools {
        private static bool shortCoeffs = true;
        public static bool ShortCoeffs { get => shortCoeffs; set => shortCoeffs = value; }

        public struct PlotStruct {
            Number.Real[] pY;
            public Number.Real[] PY { get => pY; }
            Number.Real[] qY;
            public Number.Real[] QY { get => qY; }
            Number.Real[] pbyqY;
            public Number.Real[] PbyQY { get => pbyqY; }
            Number.Real[] fY;
            public Number.Real[] FY { get => fY; }
            Number.Real[] errY;
            public Number.Real[] ErrY { get => errY; }
            Number.Real[] xArr;
            public Number.Real[] XArr { get => xArr; }

            public PlotStruct(int range) {
                pY = new Number.Real[range];
                qY = new Number.Real[range];
                pbyqY = new Number.Real[range];
                fY = new Number.Real[range];
                errY = new Number.Real[range];
                xArr = new Number.Real[range];
            }

            public PlotStruct(Number.Real[] pY, Number.Real[] qY, Number.Real[] pbyqY, Number.Real[] fY, Number.Real[] errY, Number.Real[] xArr) {
                this.pY = pY;
                this.qY = qY;
                this.pbyqY = pbyqY;
                this.fY = fY;
                this.errY = errY;
                this.xArr = xArr;
            }
        }

        public static int calculateRange(string fromStr, string toStr) {
            double to, from;
            from = Convert.ToDouble(fromStr);
            to = Convert.ToDouble(toStr);

            return (int)Math.Ceiling(Math.Abs(to - from) / (double)ArraysFiller.Step) + 1;
        }

        public static void findMinMaxInVector(Entity.Matrix vector, out double min, out double max) {
            if(vector.RowCount == 0) {
                throw new ArgumentException("Vector must contain values");
            }

            min = double.MaxValue;
            max = double.MinValue;
            for(int i = 0; i < vector.RowCount; i++) {
                double v = (double)(Number.Real)vector[i];
                if(v < min) {
                    min = v;
                }
                if(v > max) {
                    max = v;
                }
            }
        }

        public static string processCoeffs(Entity entity) {
            return shortCoeffs ? ShortPolynomialsCoeffs(entity) : TrimZeros(entity);
        }

        public static string ShortPolynomialsCoeffs(Entity entity) {
            StringBuilder result = new();
            string temp;
            var arr = entity.ToString().Split(" ");
            foreach(var entry in arr) {
                if(entry.Contains('E')) {
                    result.Append($"({entry})");
                    continue;
                }

                var index = entry.IndexOf('.');
                if(index != -1) {
                    result.Append(entry[0..(index+3)]);
                    continue;
                }
                else {
                    result.Append(entry);
                }

            }

            return result.ToString();
        }

        public static string TrimZeros(Entity entity) {
            StringBuilder result = new();
            string temp;
            var arr = entity.ToString().Split(" ");
            foreach(var entry in arr) {
                if(entry.Contains('E')) {
                    result.Append($"({entry})");
                    continue;
                }

                if(!entry.Contains('.')) {
                    result.Append(entry);
                    continue;
                }

                if(entry[^1] == ')') {
                    temp = entry.TrimEnd(')');
                    temp = temp.TrimEnd('0');
                    temp = temp.Length == 0 ? "0" : temp;
                    temp += ')';
                }
                else {
                    temp = entry.TrimEnd('0');
                    temp = temp.Length == 0 ? "0" : temp;
                }

                result.Append(temp);
            }

            return result.ToString();
        }

        public static double[] RealToDouble(Number.Real[] arr) {
            double[] result = new double[arr.Length];

            for(int i = 0; i < arr.Length; i++) {
                result[i] = (double)arr[i];
            }

            return result;
        }

        public static string stringToPolynomial(string rawPolynomial) {
            string polynomial = "";
            string[] nomials = rawPolynomial.Split($"{Environment.NewLine}");
            foreach(string n in nomials) {
                string[] line = n.Split('\t');
                string coeff = line[0], power = line[1];
                polynomial += $"({coeff})*x^({power})+";
            }
            return polynomial[..^1];
        }
    }
}
