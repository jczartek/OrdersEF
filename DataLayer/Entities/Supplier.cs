using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataLayer.Entities
{
    public class Supplier
    {
        public int SupplierId { get; set; }
        
        [Required]
        [MaxLength(40)]
        public string CompanyName { get; set; }
        
        [Required]
        [MaxLength(30)]
        public string ContactName { get; set; }

        [Required]
        [MaxLength(30)]
        public string ContactTitle { get; set; }

        [Required]
        [MaxLength(60)]
        public string Address { get; set; }

        [Required]
        [MaxLength(15)]
        public string City { get; set; }

        [MaxLength(15)]
        public string Region { get; set; }

        [MaxLength(10)]
        public string PostalCode { get; set; }
        
        [Required]
        [MaxLength(15)]
        public string Country { get; set; }

        [Required]
        [MaxLength(24)]
        public string Phone { get; set; }

        [MaxLength(24)]
        public string Fax { get; set; }

        // Relationship
        public ICollection<Product> Products { get; set; }
    }
}
