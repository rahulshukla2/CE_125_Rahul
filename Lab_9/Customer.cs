using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace core_lab9_3.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public long Mobile_no { get; set; }
        public string Email_id { get; set; }
        public string City { get; set; }

        public string State { get; set; }

        public List<Order> Orders { get; set; }
    }
}
