using Cosmetics.Common;
using NUnit.Framework;
using System;
using Moq;

namespace CosmeticsTests
{
    [TestFixture]
    public class ValidatorTests
    {
        [Test]
        public void CheckIfNull_ShouldThrowNullReferenceException_WhenTheParameterObjIsNull()
        {

            var ex = Assert.Throws<NullReferenceException>(() => Validator.CheckIfNull(null, "msg"));

            Assert.AreEqual(ex.Message, "msg");
        }

        [Test]
        public void CheckIfNull_ShouldNOTThrowAnyExceptions_WhenTheParameterObjIsNOTNull()
        {
            var obj = new object();//"jhgffg"
            Assert.DoesNotThrow(() => Validator.CheckIfNull(obj, "msg"));
        }

        [Test]
        [TestCase(null)]
        [TestCase("")]
        public void CheckIfStringIsNullOrEmpty_ShouldThrowNullReferenceException_WhenTheParameterTextIsNullOrEmpty(string text)
        {
            Assert.Throws<NullReferenceException>(() => Validator.CheckIfStringIsNullOrEmpty(text));
        }

        [Test]
        public void CheckIfStringIsNullOrEmpty_ShouldNOTThrowAnyExceptions_WhenTheParameterTextIsNOTNullOrEmpty()
        {
            var text = "text";

            Assert.DoesNotThrow(() => Validator.CheckIfStringIsNullOrEmpty(text, null));
        }

        [Test]
        public void CheckIfStringLengthIsValid_ShouldThrowIndexOutOfRangeException_WhenTheLengthOfTheParameterTextIsLowerThantheMinimumAllowedValueOrGreaterThanTheMaximumAllowedValue()
        {
            var text = "text";
            int max = 20;
            int min = 5;

            Assert.Throws<IndexOutOfRangeException>(() => Validator.CheckIfStringLengthIsValid(text, max, min));
        }

        [Test]
        public void _5_CheckIfStringLengthIsValid_ShouldNOTThrowAnyExceptions_WhenTheLengthOfTheParameterTextIsInTheAllowedBoundaries()
        {
            var text = "text";
            int max = 20;
            int min = 2;

            Assert.DoesNotThrow(() => Validator.CheckIfStringLengthIsValid(text, max, min));
        }
    }
}
