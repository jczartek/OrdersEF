using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataLayer.Entities
{
    public class Employee
    {
        public int EmployeeId { get; set; }

        [Required]
        [MaxLength(20)]
        public string LastName { get; set; }

        [Required]
        [MaxLength(10)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(30)]
        public string Title { get; set; }

        [Required]
        [MaxLength(25)]
        public string TitleOfCourtesy { get; set; }

        public DateTime BirthDate { get; set; }

        public DateTime HireDate { get; set; }

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
        // Relationship
        public int MgrId { get; set; }
        public Employee Manager { get; set; }
        public ICollection<Employee> Subordinates { get; set; }
    }
}
