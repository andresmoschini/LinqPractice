using LinqPractice.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace LinqPracticeTests
{
    
    
    /// <summary>
    ///This is a test class for InvoiceTest and is intended
    ///to contain all InvoiceTest Unit Tests
    ///</summary>
    [TestClass()]
    public class InvoiceTest
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
        ///A test for GetCost
        ///</summary>
        [TestMethod()]
        public void GetCostTest()
        {
            Invoice target = new Invoice(); // TODO: Initialize to an appropriate value
            Decimal expected = new Decimal(); // TODO: Initialize to an appropriate value
            Decimal actual;
            actual = target.GetCost();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetNetIncome
        ///</summary>
        [TestMethod()]
        public void GetNetIncomeTest()
        {
            Invoice target = new Invoice(); // TODO: Initialize to an appropriate value
            Decimal expected = new Decimal(); // TODO: Initialize to an appropriate value
            Decimal actual;
            actual = target.GetNetIncome();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetTaxes
        ///</summary>
        [TestMethod()]
        public void GetTaxesTest()
        {
            Invoice target = new Invoice(); // TODO: Initialize to an appropriate value
            Decimal expected = new Decimal(); // TODO: Initialize to an appropriate value
            Decimal actual;
            actual = target.GetTaxes();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetTotal
        ///</summary>
        [TestMethod()]
        public void GetTotalTest()
        {
            Invoice target = new Invoice(); // TODO: Initialize to an appropriate value
            Decimal expected = new Decimal(); // TODO: Initialize to an appropriate value
            Decimal actual;
            actual = target.GetTotal();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
