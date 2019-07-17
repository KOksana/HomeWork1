using HomeWork1.FbImplementation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HomeWork1.UnitTests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void When_Number_Is_Divisible_By_3_And_5()
        {
            Assert.AreEqual("FizzBuzz", FizzBuzz.PrintAndReturnResult(14, 15, 3, 5));
            Assert.AreEqual("FizzBuzz", FizzBuzz.PrintAndReturnResult(74, 75, 5, 3));
        }

        [TestMethod]
        public void When_Number_Is_Divisible_By_Only_3()
        {
            Assert.AreEqual("Fizz", FizzBuzz.PrintAndReturnResult(1, 3, 3, 7));
            Assert.AreEqual("Fizz", FizzBuzz.PrintAndReturnResult(80, 81, 3, 15));
        }

        [TestMethod]
        public void When_Number_Is_Divisible_By_Only_5()
        {
            Assert.AreEqual("Buzz", FizzBuzz.PrintAndReturnResult(29,30, 7, 5));
            Assert.AreEqual("Buzz", FizzBuzz.PrintAndReturnResult(64, 65, 3, 5));
        }

        [TestMethod]
        public void When_Number_Is_Not_Divisible_By_3_Or_5()
        {
            Assert.AreEqual("No Least Common Multiple for combination: 99, 100, 17, 19.", 
                FizzBuzz.PrintAndReturnResult(99, 100, 17, 19));
            Assert.AreEqual("No Least Common Multiple for combination: 6, 7, 19, 16.", 
                FizzBuzz.PrintAndReturnResult(6, 7, 19, 16));
        }
    }
}
