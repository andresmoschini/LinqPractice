using System;
using System.Collections.Generic;
using LinqPractice.Domain;

namespace LinqPractice.Statistics
{
    public class StatisticsCalculator
    {
        private readonly IEnumerable<Client> _clients;
        private readonly IEnumerable<Product> _products;
        private readonly IEnumerable<Invoice> _invonces;

        public StatisticsCalculator(IEnumerable<Client> clients, IEnumerable<Product> products, IEnumerable<Invoice> invonces)
        {
            _clients = clients;
            _products = products;
            _invonces = invonces;
        }

        /// <summary>
        /// Calculate the total of taxes in invoices
        /// </summary>
        public decimal TotalTaxes()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Calculate the total of income discounting costs and taxes
        /// </summary>
        public decimal TotalNetIncome()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Calculate the sum of costs of each invoice
        /// </summary>
        public decimal TotalCost()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Identify the client who spend more money
        /// </summary>
        public Client BestBuyerByTotal()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Identify the client who generate more net income
        /// </summary>
        public Client BestBuyerByNetIncome()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Calculate a summary of sales in a day
        /// </summary>
        public SalesByDateSummary SalesIn(DateTime date)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Calculate a summary of sales in each day
        /// </summary>
        public IEnumerable<SalesByDateSummary> SalesByDate(DateTime date)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Calculate a summary of sales to a client within a range of dates
        /// </summary>
        public SalesByClientSummary SalesByClient(Client client, DateTime from, DateTime to)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Identify clients that have not done any purchase
        /// </summary>
        public IEnumerable<Client> ClientsWithNoInvoices()
        {
            throw new NotImplementedException();
        }
    }
}
