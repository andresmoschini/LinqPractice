using LinqPractice.Statistics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using LinqPractice.Domain;
using System.Collections.Generic;

namespace LinqPractice.Tests
{
    [TestClass()]
    public class InvoiceTest
    {
        readonly ExampleData1 _exampleData = new ExampleData1();

        /// <summary>
        ///A test for GetCost
        ///</summary>
        [TestMethod()]
        public void GetCostTest()
        {
            var target = _exampleData.GetInvoice(3);
            var expected = 7.4M;
            var actual = target.GetCost();
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for GetNetIncome
        ///</summary>
        [TestMethod()]
        public void GetNetIncomeTest()
        {
            var target = _exampleData.GetInvoice(3);
            var expected = 2.415M;
            var actual = target.GetNetIncome();
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for GetTaxes
        ///</summary>
        [TestMethod()]
        public void GetTaxesTest()
        {
            var target = _exampleData.GetInvoice(3);
            var expected = 1.885M;
            var actual = target.GetTaxes();
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for GetTotal
        ///</summary>
        [TestMethod()]
        public void GetTotalTest()
        {
            var target = _exampleData.GetInvoice(3);
            var expected = 11.7M;
            var actual = target.GetTotal();
            Assert.AreEqual(expected, actual);
        }
    }
}
