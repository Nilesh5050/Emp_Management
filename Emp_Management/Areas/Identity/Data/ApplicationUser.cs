using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Emp_Management.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        [PersonalData]
        [Column(TypeName = "nvarchar(100)")]
        public string FirstName { get; set; }
        [PersonalData]
        [Column(TypeName = "nvarchar(100)")]
        public string LastName { get; set; }
        [PersonalData]
        [Column(TypeName = "nvarchar(20)")]
        public String Mobile { get; set; }
        [PersonalData]
        [Column(TypeName = "nvarchar(20)")]
        public String Gender { get; set; }
        [PersonalData]
        [Column(TypeName = "nvarchar(20)")]
        public String Image { get; set; }
        [PersonalData]
        public int Experience { get; set; }
        [PersonalData]
        public bool IsVerified { get; set; }
        [PersonalData]
        public DateTime created_ON { get; set; }
    }
}
