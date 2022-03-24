using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TropicalPalm.Tests {
    [TestClass]
    public class ParserTests {
        [TestMethod]
        public void CheckBrackets_llrlrlrr_treturned() {
            string input = "(()()())";
            bool expected = true;

            bool actual = Parser.CheckBrackets(input);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CheckBrackets_llrrr_freturned() {
            string input = "(()))";
            bool expected = false;

            bool actual = Parser.CheckBrackets(input);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CheckBrackets_lrlrrl_freturned() {
            string input = "()())(";
            bool expected = false;

            bool actual = Parser.CheckBrackets(input);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CheckBrackets_ssssss_treturned() {
            string input = "ssssss";
            bool expected = true;

            bool actual = Parser.CheckBrackets(input);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CheckBrackets_rllrss_freturned() {
            string input = ")(() s";
            bool expected = false;

            bool actual = Parser.CheckBrackets(input);

            Assert.AreEqual(expected, actual);
        }
    }
}
