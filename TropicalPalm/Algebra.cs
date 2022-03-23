using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TropicalPalm {
    internal class Algebra {
        public Algebra(binaryOperation plus, binaryOperation multiply, binaryOperation pow) {
            this.plus = plus;
            this.multiply = multiply;
            this.pow = pow;
        }

        public Algebra() {
            this.plus = (double x, double y) => { return x + y; };
            this.multiply = (double x, double y) => { return x * y; };
            this.pow = (double x, double y) => { return Math.Pow(x, y); };
        }

        private binaryOperation plus;
        private binaryOperation multiply;
        private binaryOperation pow;

        public binaryOperation Plus { 
            set { plus = value; }
        }
        public binaryOperation Multiply {
            set { multiply = value; }
        }
        public binaryOperation Pow {
            set { pow = value; }
        }
    }
}
