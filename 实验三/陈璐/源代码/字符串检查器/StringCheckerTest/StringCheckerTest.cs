using Homework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace StringCheckerTest
{
    
    
    /// <summary>
    ///This is a test class for StringCheckerTest and is intended
    ///to contain all StringCheckerTest Unit Tests
    ///</summary>
    [TestClass()]
    public class StringCheckerTest
    {


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
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for StringChecker Constructor
        ///</summary>
        [TestMethod()]
        public void StringCheckerConstructorTest()
        {
            StringChecker target = new StringChecker();
            string[] sList = { "1.22", "1.22.1", "12", ".12", null, "", " 1.22 " };
            bool[] expList = { true, false, true, false, false, false, false };
            bool actual;
            for (int i = 0; i < sList.Length; i++)
            {
                actual = target.IsDouble(sList[i]);
                Assert.AreEqual(expList[i], actual);
            }
            
            //Assert.Inconclusive("TODO: Implement code to verify target");
        }
    }
}
