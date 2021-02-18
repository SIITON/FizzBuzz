using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzz.Tests
{
    [TestClass]
    public class CheatSheetTest
    {
        private CheatSheet _sheet = new CheatSheet();
        [TestInitialize]

        public void Setup()
        {
            _sheet.InitFizzBuzzSheet();
        }

        [TestMethod]
        public void CanCheckFizz()
        {
            Assert.AreEqual("Fizz", _sheet.Check(3));
            Assert.AreEqual("Fizz", _sheet.Check(42));
            Assert.AreEqual("Fizz", _sheet.Check(18369));
        }
        [TestMethod]
        public void CanCheckBuzz()
        {
            Assert.AreEqual("Buzz", _sheet.Check(5));
            Assert.AreEqual("Buzz", _sheet.Check(40));
            Assert.AreEqual("Buzz", _sheet.Check(1070));
        }
        [TestMethod]
        public void CanCheckFizzBuzz()
        {
            Assert.AreEqual("FizzBuzz", _sheet.Check(15));
            Assert.AreEqual("FizzBuzz", _sheet.Check(90));
            Assert.AreEqual("FizzBuzz", _sheet.Check(3630));
        }
        [TestMethod]
        public void CanCheckFizzAsString()
        {
            Assert.IsTrue(_sheet.Check("Fizz", 3));
            Assert.IsFalse(_sheet.Check("Buzz", 42));
            Assert.IsTrue(_sheet.Check("Fizz", 18369));
        }
        [TestMethod]
        public void CanCheckBuzzAsString()
        {
            Assert.IsTrue(_sheet.Check("Buzz", 5));
            Assert.IsFalse(_sheet.Check("Fizz", 40));
            Assert.IsTrue(_sheet.Check("Buzz", 1070));
        }
        [TestMethod]
        public void CanCheckFizzBuzzAsString()
        {
            Assert.IsTrue(_sheet.Check("FizzBuzz", 15));
            Assert.IsFalse(_sheet.Check("Fizz", 90));
            Assert.IsTrue(_sheet.Check("FizzBuzz", 3630));
        }

        [TestMethod]
        public void CanExpandCheatSheetByCheckMethod()
        {
            Assert.AreEqual(99, _sheet.GetCountOfValues());
            _sheet.Check(901);
            Assert.AreEqual(1000, _sheet.GetCountOfValues());
        }
        [TestMethod]
        public void CanIncreaseSheetCapacityToIncludeMoreKeys()
        {
            Assert.AreEqual(99, _sheet.GetCountOfValues());
            _sheet.IncreaseCapacityToInclude(901);
            Assert.AreEqual(1000, _sheet.GetCountOfValues());
        }
    }
}
