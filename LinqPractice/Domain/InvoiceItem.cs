using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqPractice.Domain
{
    public class InvoiceItem
    {
        public decimal Quantity { get; set; }
        public Product Product { get; set; }
        public decimal Total { get; set; }
    }
}
