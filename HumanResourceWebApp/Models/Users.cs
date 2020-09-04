using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HumanResourceWebApp.Models
{
    public class Users
    {
        [Key]
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Designation { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        [ForeignKey("RoleId")]
        public Role Role { get; set; }
        public int RoleId { get; set; }
        [ForeignKey("DeptId")]
        public Department Department { get; set; }
        public int DeptId { get; set; }
    }
}
