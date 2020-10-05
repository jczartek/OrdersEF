using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DataLayer.Entities
{
    public class Shipper
    {
        public int ShipperId { get; set; }

        [Required]
        [MaxLength(40)]
        public string CompanyName { get; set; }

        [Required]
        [MaxLength(24)]
        public string Phone { get; set; }

        //Relationship
        public ICollection<Order> Orders { get; set; }
    }
}
