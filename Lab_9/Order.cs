using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace core_lab9_3.Models
{
    public class Order
    {
        public int OrderId { get; set; }

        public string Amount { get; set; }

        public DateTime Order_date_time { get; set; }

        public int CustomerId { get; set; }

        public int ProductId { get; set; }


        public Customer Customer { get; set; }
        public Product Product { get; set; }

    }
}
