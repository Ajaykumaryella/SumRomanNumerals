using Microsoft.VisualStudio.TestTools.UnitTesting;
using SumRomanNumerals;
using System;

namespace SumRomanNumeralsTests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void ValidateInput_Return_True()
        {
            var result = Program.ValidateInput("X");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ValidateInput_Return_False()
        {
            var result = Program.ValidateInput("S");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void romanToInt_Return_Success()
        {
            var result = Program.romanToInt("M");
            Assert.AreEqual(result,1000);
        }
        [TestMethod]
        public void romanToInt_Return_94()
        {
            var result = Program.romanToInt("XCIV");
            Assert.AreEqual(result, 94);
        }

        [TestMethod]
        public void romanToInt_Return_450()
        {
            var result = Program.romanToInt("CDL");
            Assert.AreEqual(result, 450);
        }

        [TestMethod]
        public void romanToInt_Return_Negative()
        {
            var result = Program.romanToInt("S");
            Assert.AreEqual(result, -1);
        }


        [TestMethod]
        public void romanToInt_Return_Zero()
        {
            var result = Program.romanToInt("");
            Assert.AreEqual(result, 0);
        }

        [TestMethod]
        public void romanToValue_Return_Int()
        {
            var result = Program.romanToValue('D');
            Assert.AreEqual(result, 500);
        }

        [TestMethod]
        public void romanToValue_Return_Negative()
        {
            var result = Program.romanToValue('F');
            Assert.AreEqual(result, -1);
        }

        [TestMethod]
        public void intToRoman_Return_Roman()
        {
            var result = Program.intToRoman(47);
            Assert.AreEqual(result, "XLVII");
        }


        [TestMethod]
        public void intToRoman_Return_Roman_950()
        {
            var result = Program.intToRoman(950);
            Assert.AreEqual(result, "CML");
        }


        [TestMethod]
        public void intToRoman_Return_Roman_Empty()
        {
            var result = Program.intToRoman(0);
            Assert.AreEqual(result, "");
        }
    }
}
