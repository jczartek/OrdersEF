using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataLayer.Entities
{
    public class Category
    {
        public int CategoryId { get; set; }
        
        [Required]
        [MaxLength(15)]
        public string CategoryName { get; set; }

        [Required]
        [MaxLength(200)]
        public string Description { get; set; }

        // RelationShip
        public ICollection<Product> Products { get; set; }
    }
}
