using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataLayer.Entities
{
    public class Product
    {
        public int ProductId { get; set; }

        [Required]
        [MaxLength(40)]
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public bool Discontinued { get; set; }

        // Relationship
        public int SupplierId { get; set; }
        public Supplier Supplier { get; set; }
        public int CategoryId { get; set; }
        public Category Category {get; set; }
        public ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
