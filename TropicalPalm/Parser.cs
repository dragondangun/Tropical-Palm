using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TropicalPalm {
    internal static class Parser {
        public static Expression Parse(string input) {
            return null;
        }

        private static bool CheckBrackets(string input) { 
            if(input.Count(c => c == '(') != input.Count(c => c == ')'))
                return false;

            int carriage = input.IndexOf('(');

            if(carriage == -1)
                return true;

            if(carriage < input.IndexOf(')'))
                return false;

            int balance = 1;

            while(true) {
                carriage = input.IndexOfAny("()".ToCharArray(), carriage);
                if(carriage == -1)
                    break;

                if(input[carriage] == '(') {
                    balance++;
                }
                else {
                    balance--;
                }
            }

            return balance == 0;
        }
    }
}
