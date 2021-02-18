using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace FizzBuzz.Tests
{
    [TestClass]
    public class GameTest
    {
        private CheatSheet _sheet = new CheatSheet();
        Game _game = new Game();
        [TestInitialize]

        public void Setup()
        {
            _sheet.AddFizzBuzzToSheet();
        }

        [TestMethod]
        public void GameInitializedCorrectly()
        {
            Assert.AreEqual(1, _game.turn);
            Assert.IsTrue(_game.userIsCorrect);
        }
    }
}
