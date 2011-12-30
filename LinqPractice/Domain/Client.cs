using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqPractice.Domain
{
    public class Client
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LatsName { get; set; }
        public DateTime IsClientSince { get; set; }
    }
}
