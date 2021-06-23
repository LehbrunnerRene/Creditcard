using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
namespace CredCardLogic.UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Validate_SetNull_ThrowsArgumentException()
        {
            Creditcard.Logic.Checker.creditCardChecker(null);
        }
        [TestMethod]
        public void Validate_ToShortNumber_False()
        { 
           var actual = Creditcard.Logic.Checker.creditCardChecker("1223435567");
           var expected = false;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Validate_ToLongNumber_False()
        {
            var actual = Creditcard.Logic.Checker.creditCardChecker("12234355654545547983478957");
            var expected = false;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Validate_OnlyDigit_True()
        {
            var actual = Creditcard.Logic.Checker.creditCardChecker("2718281828458567");
            var expected = true;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Validate_BeginWithLetter_False()
        {
            var actual = Creditcard.Logic.Checker.creditCardChecker("A223435567");
            var expected = false;
            Assert.AreEqual(expected, actual);
        }
    }
}
