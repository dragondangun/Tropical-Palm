using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TropicalPalm {
    internal class Algebra {
        public Algebra(binaryOperation plus, binaryOperation multiply) {
            this.plus = plus;
            this.multiply = multiply;
        }

        public Algebra() {
            this.plus = (double x, double y) => { return x + y; };
            this.multiply = (double x, double y) => { return x * y; };
        }

        private binaryOperation plus;
        private binaryOperation multiply;

        public binaryOperation Plus { 
            set { plus = value; }
        }
        public binaryOperation Multiply {
            set { multiply = value; }
        }
    }
}
