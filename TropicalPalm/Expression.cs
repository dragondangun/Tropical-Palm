using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TropicalPalm {
    internal class Expression {
        private ExpressionType type;

        public ExpressionType Type {
            get { return type; }
            set { type = value; }
        }

        private bool unparsable;

        public bool Unparsable {
            get { return unparsable; }
            set { unparsable = value; }
        }

        private List<Expression> parts;
        public List<Expression> Parts {
            get { return parts; }
            set { parts = value; }
        }

        public Expression() {
            parts = new List<Expression>();
            unparsable = false;
        }

        private Expression coeffitient;
        public Expression Coeffitient {
            get { return coeffitient; }
            set { coeffitient = value; }
        }

        private Expression coeffitientExponent;
        public Expression CoeffitientExponent {
            get { return coeffitientExponent; }
            set { coeffitientExponent = value; }
        }

        private Expression variable;
        public Expression Variable {
            get { return variable; }
            set { variable = value; }
        }

        private Expression variableExponent;
        public Expression VariableExponent {
            get { return variableExponent; }
            set { variableExponent = value; }
        }

        private Expression exponent;
        public Expression Exponent {
            get { return exponent; }
            set { exponent = value; }
        }
    }

    enum ExpressionType {
        ARITHMETIC = 0,
        POLYNOMIAL = 1,
        COMPLEX = 2,
    }
}
