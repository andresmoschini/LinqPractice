using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqPractice.Domain
{
    public class Invoice
    {
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public Client Client { get; set; }
        public IEnumerable<InvoiceItem> Items  { get; set; }

        /// <summary>
        /// Sum of total of each invoice item
        /// </summary>
        public decimal GetTotal()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Sum of the cost of each product of each item
        /// </summary>
        public decimal GetCost()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Sum of the taxes applied to each item
        /// </summary>
        public decimal GetTaxes()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Sum of net income of each item (total - cost - applied tax)
        /// </summary>
        public decimal GetNetIncome()
        {
            throw new NotImplementedException();
        }
    }
}
