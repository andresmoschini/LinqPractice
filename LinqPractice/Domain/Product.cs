using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqPractice.Domain
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public decimal Tax { get; set; }
        public decimal CurrentCost { get; set; }
        public decimal SugestedPrice { get; set; }
    }
}
