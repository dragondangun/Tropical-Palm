using AngouriMath.Extensions;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static AngouriMath.Entity;
using static AngouriMath.MathS;

namespace TropicalPalm {
    internal static class Validation {
        public enum ErrorCodes {
            ALL_IS_GOOD = 0,
            P_UNCORRECT = 1,
            Q_UNCORRECT = 2,
            F_UNCORRECT = 3,
            POLYNOMIALS_EMPTY = 10,
            FROM_EMPTY = 40,
            TO_EMPTY = 50,
            UNCORRECT_BORDERS = 60,
        };

        public static void showError(ErrorCodes errorCode) {
            switch(errorCode) {
                case ErrorCodes.P_UNCORRECT:
                    MessageBox.Show("There's an error in P!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                case ErrorCodes.Q_UNCORRECT:
                    MessageBox.Show("There's an error in Q!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                case ErrorCodes.F_UNCORRECT:
                    MessageBox.Show("There's an error in F!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                case ErrorCodes.POLYNOMIALS_EMPTY:
                    MessageBox.Show("P(x) or Q(x) must be filled in!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                case ErrorCodes.FROM_EMPTY:
                    MessageBox.Show("From must be filled in!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                case ErrorCodes.TO_EMPTY:
                    MessageBox.Show("To must be filled in!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                case ErrorCodes.UNCORRECT_BORDERS:
                    MessageBox.Show("From must be less than to!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }
        }

        public static ErrorCodes checkInput(string p, string q, string xFrom, string xTo, string f) {
            if(p.Length == 0 && q.Length == 0)
                return ErrorCodes.POLYNOMIALS_EMPTY;

            if(xFrom.Length == 0)
                return ErrorCodes.FROM_EMPTY;
            if(xTo.Length == 0)
                return ErrorCodes.TO_EMPTY;

            double to, from;
            from = Convert.ToDouble(xFrom);
            to = Convert.ToDouble(xTo);

            if(to < from) {
                return ErrorCodes.UNCORRECT_BORDERS;
            }

            string pattern = "[arr-wyzA-WYZа-яА-Я]";
            var m = Regex.Match(p, pattern);
            if(m.Success)
                return ErrorCodes.P_UNCORRECT;

            m = Regex.Match(q, pattern);
            if(m.Success)
                return ErrorCodes.Q_UNCORRECT;

            if(p.Length > 0 && !isCurrentAlgebraExpressionCorrect(p)) {
                return ErrorCodes.P_UNCORRECT;
            }

            if(q.Length > 0 && !isCurrentAlgebraExpressionCorrect(q)) {
                return ErrorCodes.Q_UNCORRECT;
            }

            if(f.Length > 0 && !isConventionalAlgebraExpressionCorrect(f)) {
                return ErrorCodes.F_UNCORRECT;
            }

            return ErrorCodes.ALL_IS_GOOD;
        }

        public static bool isCurrentAlgebraExpressionCorrect(string expression) {
            bool result = true;
            var x = Var("x");

            try {
                TropApprox.Current.Algebra.Calculate(expression.Substitute(x, (Number.Real)4 / 10));
                if(!Form1.NonNegativeField) {
                    TropApprox.Current.Algebra.Calculate(expression.Substitute(x, -0.4));
                    TropApprox.Current.Algebra.Calculate(expression.Substitute(x, 0));
                }
            }
            catch {
                result = false;
            }

            return result;
        }

        public static bool isConventionalAlgebraExpressionCorrect(string expression) {
            bool result = true;
            var x = Var("x");

            try {
                expression.Substitute(x, 0.4).EvalNumerical();
                expression.Substitute(x, 0.0).EvalNumerical();
                if(!Form1.NonNegativeField) {
                    expression.Substitute(x, -0.4).EvalNumerical();
                }
            }
            catch {
                result = false;
            }

            return result;
        }

        public static bool containsInappropriateCharacters(string content) {
            return !Regex.Match(content, $"[1-9.{Environment.NewLine}\t]").Success;
        }
    }
}
