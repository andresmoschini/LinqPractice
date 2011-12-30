using LinqPractice.Statistics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using LinqPractice.Domain;
using System.Collections.Generic;

namespace LinqPractice.Tests
{
    [TestClass()]
    public class StatisticsCalculatorTest
    {
        readonly ExampleData1 _exampleData = new ExampleData1();

        /// <summary>
        ///A test for SalesByClient
        ///</summary>
        [TestMethod()]
        public void SalesByClientTest()
        {
            var target = new StatisticsCalculator(_exampleData.Clients, _exampleData.Products, _exampleData.Invoices);
            var from = DateTime.Parse("2011-12-05");
            var to = DateTime.Parse("2011-12-08");
            var client = _exampleData.IcazaClient;

            var expectedClient = _exampleData.IcazaClient;
            var expectedInvoiceNumbers = new[] { 7, 8, 10, 15 }; 

            var actual = target.SalesByClient(client, from, to);
            
            Assert.AreEqual(expectedClient, actual.Client);
            Assert.IsTrue(actual.InvoiceNumbers.SequenceEqual(expectedInvoiceNumbers));
            Assert.Inconclusive("test actual.Items");
        }

        /// <summary>
        ///A test for ClientsWithNoInvoices
        ///</summary>
        [TestMethod()]
        public void ClientsWithNoInvoicesTest()
        {
            var target = new StatisticsCalculator(_exampleData.Clients, _exampleData.Products, _exampleData.Invoices); 
            IEnumerable<Client> expected = null; // TODO: Initialize to an appropriate value
            IEnumerable<Client> actual;
            actual = target.ClientsWithNoInvoices();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for BestBuyerByTotal
        ///</summary>
        [TestMethod()]
        public void BestBuyerByTotalTest()
        {
            var target = new StatisticsCalculator(_exampleData.Clients, _exampleData.Products, _exampleData.Invoices); 
            Client expected = null; // TODO: Initialize to an appropriate value
            Client actual;
            actual = target.BestBuyerByTotal();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for BestBuyerByNetIncome
        ///</summary>
        [TestMethod()]
        public void BestBuyerByNetIncomeTest()
        {
            var target = new StatisticsCalculator(_exampleData.Clients, _exampleData.Products, _exampleData.Invoices); 
            Client expected = null; // TODO: Initialize to an appropriate value
            Client actual;
            actual = target.BestBuyerByNetIncome();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for SalesByDate
        ///</summary>
        [TestMethod()]
        public void SalesByDateTest()
        {
            var target = new StatisticsCalculator(_exampleData.Clients, _exampleData.Products, _exampleData.Invoices); 
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
            var target = new StatisticsCalculator(_exampleData.Clients, _exampleData.Products, _exampleData.Invoices); 
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
            var target = new StatisticsCalculator(_exampleData.Clients, _exampleData.Products, _exampleData.Invoices); 
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
            var target = new StatisticsCalculator(_exampleData.Clients, _exampleData.Products, _exampleData.Invoices); 
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
            var target = new StatisticsCalculator(_exampleData.Clients, _exampleData.Products, _exampleData.Invoices); 
            Decimal expected = new Decimal(); // TODO: Initialize to an appropriate value
            Decimal actual;
            actual = target.TotalTaxes();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
