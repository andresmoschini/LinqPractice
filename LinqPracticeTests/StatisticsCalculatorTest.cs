using LinqPractice.Statistics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LinqPractice.Domain;
using System.Collections.Generic;

namespace LinqPracticeTests
{
    
    
    /// <summary>
    ///This is a test class for StatisticsCalculatorTest and is intended
    ///to contain all StatisticsCalculatorTest Unit Tests
    ///</summary>
    [TestClass()]
    public class StatisticsCalculatorTest
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
        ///A test for BestBuyerByNetIncome
        ///</summary>
        [TestMethod()]
        public void BestBuyerByNetIncomeTest()
        {
            IEnumerable<Client> clients = null; // TODO: Initialize to an appropriate value
            IEnumerable<Product> products = null; // TODO: Initialize to an appropriate value
            IEnumerable<Invoice> invonces = null; // TODO: Initialize to an appropriate value
            StatisticsCalculator target = new StatisticsCalculator(clients, products, invonces); // TODO: Initialize to an appropriate value
            Client expected = null; // TODO: Initialize to an appropriate value
            Client actual;
            actual = target.BestBuyerByNetIncome();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for BestBuyerByTotal
        ///</summary>
        [TestMethod()]
        public void BestBuyerByTotalTest()
        {
            IEnumerable<Client> clients = null; // TODO: Initialize to an appropriate value
            IEnumerable<Product> products = null; // TODO: Initialize to an appropriate value
            IEnumerable<Invoice> invonces = null; // TODO: Initialize to an appropriate value
            StatisticsCalculator target = new StatisticsCalculator(clients, products, invonces); // TODO: Initialize to an appropriate value
            Client expected = null; // TODO: Initialize to an appropriate value
            Client actual;
            actual = target.BestBuyerByTotal();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ClientsWithNoInvoices
        ///</summary>
        [TestMethod()]
        public void ClientsWithNoInvoicesTest()
        {
            IEnumerable<Client> clients = null; // TODO: Initialize to an appropriate value
            IEnumerable<Product> products = null; // TODO: Initialize to an appropriate value
            IEnumerable<Invoice> invonces = null; // TODO: Initialize to an appropriate value
            StatisticsCalculator target = new StatisticsCalculator(clients, products, invonces); // TODO: Initialize to an appropriate value
            IEnumerable<Client> expected = null; // TODO: Initialize to an appropriate value
            IEnumerable<Client> actual;
            actual = target.ClientsWithNoInvoices();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for SalesByClient
        ///</summary>
        [TestMethod()]
        public void SalesByClientTest()
        {
            IEnumerable<Client> clients = null; // TODO: Initialize to an appropriate value
            IEnumerable<Product> products = null; // TODO: Initialize to an appropriate value
            IEnumerable<Invoice> invonces = null; // TODO: Initialize to an appropriate value
            StatisticsCalculator target = new StatisticsCalculator(clients, products, invonces); // TODO: Initialize to an appropriate value
            DateTime from = new DateTime(); // TODO: Initialize to an appropriate value
            DateTime to = new DateTime(); // TODO: Initialize to an appropriate value
            SalesByClientSummary expected = null; // TODO: Initialize to an appropriate value
            SalesByClientSummary actual;
            actual = target.SalesByClient(from, to);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for SalesByDate
        ///</summary>
        [TestMethod()]
        public void SalesByDateTest()
        {
            IEnumerable<Client> clients = null; // TODO: Initialize to an appropriate value
            IEnumerable<Product> products = null; // TODO: Initialize to an appropriate value
            IEnumerable<Invoice> invonces = null; // TODO: Initialize to an appropriate value
            StatisticsCalculator target = new StatisticsCalculator(clients, products, invonces); // TODO: Initialize to an appropriate value
            DateTime date = new DateTime(); // TODO: Initialize to an appropriate value
            IEnumerable<SalesByDateSummary> expected = null; // TODO: Initialize to an appropriate value
            IEnumerable<SalesByDateSummary> actual;
            actual = target.SalesByDate(date);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for SalesIn
        ///</summary>
        [TestMethod()]
        public void SalesInTest()
        {
            IEnumerable<Client> clients = null; // TODO: Initialize to an appropriate value
            IEnumerable<Product> products = null; // TODO: Initialize to an appropriate value
            IEnumerable<Invoice> invonces = null; // TODO: Initialize to an appropriate value
            StatisticsCalculator target = new StatisticsCalculator(clients, products, invonces); // TODO: Initialize to an appropriate value
            DateTime date = new DateTime(); // TODO: Initialize to an appropriate value
            SalesByDateSummary expected = null; // TODO: Initialize to an appropriate value
            SalesByDateSummary actual;
            actual = target.SalesIn(date);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for TotalCost
        ///</summary>
        [TestMethod()]
        public void TotalCostTest()
        {
            IEnumerable<Client> clients = null; // TODO: Initialize to an appropriate value
            IEnumerable<Product> products = null; // TODO: Initialize to an appropriate value
            IEnumerable<Invoice> invonces = null; // TODO: Initialize to an appropriate value
            StatisticsCalculator target = new StatisticsCalculator(clients, products, invonces); // TODO: Initialize to an appropriate value
            Decimal expected = new Decimal(); // TODO: Initialize to an appropriate value
            Decimal actual;
            actual = target.TotalCost();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for TotalNetIncome
        ///</summary>
        [TestMethod()]
        public void TotalNetIncomeTest()
        {
            IEnumerable<Client> clients = null; // TODO: Initialize to an appropriate value
            IEnumerable<Product> products = null; // TODO: Initialize to an appropriate value
            IEnumerable<Invoice> invonces = null; // TODO: Initialize to an appropriate value
            StatisticsCalculator target = new StatisticsCalculator(clients, products, invonces); // TODO: Initialize to an appropriate value
            Decimal expected = new Decimal(); // TODO: Initialize to an appropriate value
            Decimal actual;
            actual = target.TotalNetIncome();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for TotalTaxes
        ///</summary>
        [TestMethod()]
        public void TotalTaxesTest()
        {
            IEnumerable<Client> clients = null; // TODO: Initialize to an appropriate value
            IEnumerable<Product> products = null; // TODO: Initialize to an appropriate value
            IEnumerable<Invoice> invonces = null; // TODO: Initialize to an appropriate value
            StatisticsCalculator target = new StatisticsCalculator(clients, products, invonces); // TODO: Initialize to an appropriate value
            Decimal expected = new Decimal(); // TODO: Initialize to an appropriate value
            Decimal actual;
            actual = target.TotalTaxes();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
