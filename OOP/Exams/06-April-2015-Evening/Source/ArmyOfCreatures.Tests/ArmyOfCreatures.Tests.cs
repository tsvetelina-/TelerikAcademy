using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text;

namespace ArmyOfCreatures.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Check_If_ProcessCommand_IsValid_If_Null_ThrowArgumentNullException()
        {
            var msg = ("battleManager");

            var ex = Assert.ThrowsException<ArgumentNullException>(() => ProcessCommand(null, arguments)).Message;

            Assert.AreEqual(ex, msg);
        }

        [TestMethod]
        public void Check_IfProcessCommandArgumentsIsNull_ShouldThrowArgumentNullException()
        {
            var msg = ("arguments");

            var ex = Assert.ThrowsException<ArgumentNullException>(() => ProcessCommand(battleManager, null)).Message;

            Assert.AreEqual(ex, msg);
        }

        [TestMethod]
        public void Check_IfArgumentsLengthIsLessThan2_ShouldThrowArgumentException()
        {
            var msg = ("Invalid number of arguments for add command");

            var ex = Assert.Throws<ArgumentException>(() => ProcessCommand(battleManager, null)).Message;

            Assert.AreEqual(ex, msg);
        }
    }
}
