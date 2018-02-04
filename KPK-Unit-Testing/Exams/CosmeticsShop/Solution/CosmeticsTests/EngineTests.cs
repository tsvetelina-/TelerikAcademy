using Cosmetics.Contracts;
using Cosmetics.Engine;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmeticsTests
{
    [TestFixture]
    public class EngineTests
    {
        [Test]
        public void CreateCategory_WhenThePassedInputStringIsInTheFormatThatRepresentsACreateCategory()
        {
            var factoryMocked = new Mock<ICosmeticsFactory>();
            var shopingCardMocked = new Mock<IShoppingCart>();
            var commandParserMocked = new Mock<ICommandParser>();
            var commandMocked = new Mock<ICommand>();
            var parameters = new List<string> { "ForMale" };

            commandMocked.Setup(
                m => m.Name).Returns("CreateCategory");

            commandMocked.Setup(
                m => m.Parameters).Returns(parameters);

            var commands = new List<ICommand> { commandMocked.Object };

            commandParserMocked.Setup(
                m => m.ReadCommands()).Returns(commands);

            var cosmeticsEngine = new CosmeticsEngineExtended(factoryMocked.Object,
                shopingCardMocked.Object, commandParserMocked.Object);

            cosmeticsEngine.Start();

            Assert.AreEqual(1, cosmeticsEngine.GetCategories.Count);
        }

        [Test]
        public void AddToCategory_ShouldResultInAddingTheSelectedProductInTheRespectiveCategory_WhenInputIsInCorrectFormat()
        {
            var factoryMocked = new Mock<ICosmeticsFactory>();
            var shopingCardMocked = new Mock<IShoppingCart>();
            var commandParserMocked = new Mock<ICommandParser>();
            var commandMocked = new Mock<ICommand>();
            var commands = new List<ICommand> { commandMocked.Object };
            var parameters = new List<string> { "ForMale", "White+" };
            var category = new Mock<ICategory>();
            var product = new Mock<IProduct>();

            commandParserMocked.Setup(
              m => m.ReadCommands()).Returns(commands);
            commandMocked.Setup(
                 m => m.Name).Returns("AddToCategory");
            commandMocked.Setup(
               m => m.Parameters).Returns(parameters);

            var cosmeticsEngine = new CosmeticsEngineExtended(factoryMocked.Object,
               shopingCardMocked.Object, commandParserMocked.Object);

            cosmeticsEngine.GetCategories.Add("ForMale", category.Object);
            cosmeticsEngine.GetProducts.Add("White+", product.Object);

            cosmeticsEngine.Start();


            category.Verify(
                m => m.AddProduct(It.IsAny<IProduct>()), Times.Exactly(1));
        }

        [Test]
        public void RemoveFromCategory_ShouldRemoveSelectedProduct_FromCategory()
        {
            var factoryMocked = new Mock<ICosmeticsFactory>();
            var shopingCardMocked = new Mock<IShoppingCart>();
            var commandParserMocked = new Mock<ICommandParser>();
            var commandMocked = new Mock<ICommand>();
            var commands = new List<ICommand> { commandMocked.Object };
            var parameters = new List<string> { "ForMale", "White+" };
            var category = new Mock<ICategory>();
            var product = new Mock<IProduct>();

            commandParserMocked.Setup(
              m => m.ReadCommands()).Returns(commands);
            commandMocked.Setup(
                 m => m.Name).Returns("RemoveFromCategory");
            commandMocked.Setup(
               m => m.Parameters).Returns(parameters);

            var cosmeticsEngine = new CosmeticsEngineExtended(factoryMocked.Object,
               shopingCardMocked.Object, commandParserMocked.Object);

            cosmeticsEngine.GetCategories.Add("ForMale", category.Object);
            cosmeticsEngine.GetProducts.Add("White+", product.Object);

            cosmeticsEngine.Start();

            category.Verify(
                m => m.RemoveProduct(It.IsAny<IProduct>()), Times.Exactly(1));
        }

        [Test]
        public void ShowCategory_WhenThePassedInputStringIsInTheCorrectFormat_ShouldResultInCallingThePrintMethod()
        {
            var factoryMocked = new Mock<ICosmeticsFactory>();
            var shoppingCartMocked = new Mock<IShoppingCart>();
            var commandParserMocked = new Mock<ICommandParser>();
            var commandMocked = new Mock<ICommand>();
            var commandsList = new List<ICommand> { commandMocked.Object };
            var categoryMocked = new Mock<ICategory>();

            commandParserMocked.Setup(m => m.ReadCommands()).Returns(commandsList);

            commandMocked.Setup(m => m.Name).Returns("ShowCategory");

            commandMocked.Setup(m => m.Parameters[0]).Returns("ForMale");

            var start = new CosmeticsEngineExtended(factoryMocked.Object, shoppingCartMocked.Object, commandParserMocked.Object);

            start.GetCategories.Add("ForMale", categoryMocked.Object);

            start.Start();

            categoryMocked.Verify(m => m.Print(), Times.Exactly(1));
        }

        [Test]
        public void CreateShampoo_WhenThePassedInputStringIsInTheCorrectFormat_ShouldResultInAddingTheNewlyCreatedShampoo()
        {
            var factoryMocked = new Mock<ICosmeticsFactory>();
            //var shoppingCartMocked = 

            //var start = new CosmeticsEngineExtended()
        }
    }
}
