using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Entities
{
    public class OrderDetail
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public decimal UnitPrice { get; set; }
        public short Qty { get; set; }
        public decimal Discount { get; set; }

        // Relationships
        public Order Order { get; set; }
        public Product Product { get; set; }
    }
}
