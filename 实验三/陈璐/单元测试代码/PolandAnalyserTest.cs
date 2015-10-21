using GrammarAnalysers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PolandAnalyserTest
{
    
    
    /// <summary>
    ///This is a test class for PolandAnalyserTest and is intended
    ///to contain all PolandAnalyserTest Unit Tests
    ///</summary>
    [TestClass()]
    public class PolandAnalyserTest
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
        ///A test for Analyse
        ///</summary>
        [TestMethod()]
        public void AnalyseTest()
        {
            PolandAnalyser target = new PolandAnalyser(); // TODO: Initialize to an appropriate value
            string[] Ins = { null, "4*(28+87*6-75)/8#", "#", "4*(28+87*6-75)/8", " 4*(28+87*6-75)/8# ", " 4 * (28+87*6-75)/8# " }; // TODO: Initialize to an appropriate value
            string[] expecteds = { "错误", "4&28&87&6*+75-*8/\r\n237.5", "\r\n0", "错误", "4&28&87&6*+75-*8/\r\n237.5", "Unknown Char" }; // TODO: Initialize to an appropriate value
            string actual;
            for (int i = 0; i < Ins.Length; i++)
            {
                actual = target.Analyse(Ins[i]);
                Assert.AreEqual(expecteds[i], actual);
            }
            //Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
