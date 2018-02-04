using Cosmetics.Engine;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;

namespace CosmeticsTests
{
    [TestFixture]
    public class CommandTests
    {
        [Test]
        public void Parse_ShouldReturnNewCommand_WhenTheInputStringIsInTheRequiredValidFormat()
        {
            var command = Command.Parse("AddToCategory ForMale Cool");

            Assert.IsInstanceOf<Command>(command);
            Assert.AreEqual(command.Name, "AddToCategory");
            Assert.AreEqual(command.Parameters[0], "ForMale");


            //// Arrange
            //var validInput = "AddToCategory ForMale Cool";

            //// Act
            //var executionResult = Command.Parse(validInput);

            //// Assert
            //Assert.IsInstanceOf<Command>(executionResult);
        }

        [Test]
        public void Parse_ShouldSetCorrectValuesToTheNewlyReturnedCommandObjectsPropertiesNameAndParameters_WhenTheInputStringIsInTheValidRequiredFormat()
        {
            var command = Command.Parse("AddToCategory ForMale Cool");

            Assert.AreEqual(command.Name, "AddToCategory");
            Assert.AreEqual(command.Parameters[0], "ForMale");
            Assert.AreEqual(command.Parameters[1], "Cool");
        }

        [Test]
        public void Parse_ShouldThrowNullReferenceException_WhenTheInputStringIsNull()
        {
            string input = null;

            Assert.Throws<NullReferenceException>(() => Command.Parse(input));
        }

        [Test]
        public void Parse_ShouldThrowArgumentNullExceptionWithAMessageThatContainsTheStringName_WhenTheInputStringThatRepresentsTheCommandNameIsNullOrEmpty()
        {

            var ex = Assert.Throws<ArgumentNullException>(() => Command.Parse(""));

            Assert.AreEqual(ex.ParamName, "Name cannot be null or empty.");
        }

        [Test]
        public void Parse_ShouldThrowArgumentNullExceptionWithAMessageThatContainsTheStringList_WhenTheInputStringThatRepresentsTheCommandParametersIsNullOrEmpty()
        {
            var invalidInput = "AddToCategory ";

            // Act && Assert
            Assert.That(() => Command.Parse(invalidInput), Throws.ArgumentNullException.With.Message.Contains("List"));
        }
    }
}
