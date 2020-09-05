using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HumanResourceWebApp.Models
{
    public class ELicense
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Id")]
        public License Licenses { get; set; }
        public int LicenseId { get; set; }
        public string LicenceNumber { get; set; }
        public DateTime IssuedDate { get; set; }
        public DateTime ExpiryDate { get; set; }
        public string Comment { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string CreatedBy { get; set; }
    }
}
