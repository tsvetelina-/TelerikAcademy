using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using ArmyOfCreatures.Console.Extended.Specialties;

namespace ArmyOfCreatures.Tests
{
    /// <summary>
    /// Summary description for CreaturesFactoryTests
    /// </summary>
    [TestFixture]
    public class CreaturesFactoryTests
    {
        [TestCase("Angel", typeof(Angel))]
        public CreaturesFactoryTests()
        {
            public void CreaturesFactory_WhenValidNameIsPassed_ShouldReturnExpectedType(string name, Type expectedCreature)
             {
                var factory = new CreaturesFactoryExtended();

                var creature = new CreateCreature(name);

                Assert.Throws<ArgumentException>
        }
    }

    private TestContext testContextInstance;

    /// <summary>
    ///Gets or sets the test context which provides
    ///information about and functionality for the current test run.
    ///</summary>
    public TestContext TestContext
    {
        get
        {
            return testContextInstance;
        }
        set
        {
            testContextInstance = value;
        }
    }

    #region Additional test attributes
    //
    // You can use the following additional attributes as you write your tests:
    //
    // Use ClassInitialize to run code before running the first test in the class
    // [ClassInitialize()]
    // public static void MyClassInitialize(TestContext testContext) { }
    //
    // Use ClassCleanup to run code after all tests in a class have run
    // [ClassCleanup()]
    // public static void MyClassCleanup() { }
    //
    // Use TestInitialize to run code before running each test 
    // [TestInitialize()]
    // public void MyTestInitialize() { }
    //
    // Use TestCleanup to run code after each test has run
    // [TestCleanup()]
    // public void MyTestCleanup() { }
    //
    #endregion

    [TestMethod]
    public void TestMethod1()
    {
        //
        // TODO: Add test logic here
        //
    }
}
}
