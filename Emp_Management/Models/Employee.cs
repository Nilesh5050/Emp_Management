using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Emp_Management.Models
{
    public class Employee
    {
        [Key]
        public string Id { get; set; }
        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "First Name")]
        public String FirstName { get; set; }
        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "First Name")]
        public String LastName { get; set; }
        [Required]
        [EmailAddress]
        [Display(Name = "First Name")]
        public String Email { get; set; }
        [Required]
        [Display(Name = "Enter a Mobile Nuber")]
        public String Mobile { get; set; }
        [Required]
        [Display(Name = "Enter a Gender")]
        public String Gender { get; set; }
        [Required]
        [Display(Name = "Write a Experience")]
        public int Experience { get; set; }
        [Required]
        public DateTime created_ON { get; set; }
    }
}
