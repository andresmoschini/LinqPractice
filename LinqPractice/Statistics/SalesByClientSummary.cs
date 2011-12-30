using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LinqPractice.Domain;

namespace LinqPractice.Statistics
{
    public class SalesByClientSummary
    {
        public Client Client { get; set; }

        public IEnumerable<int> InvoiceNumbers { get; set; }

        /// <summary>
        /// List of items grouped by product
        /// </summary>
        public IEnumerable<InvoiceItem> Items  { get; set; }
    }
}
