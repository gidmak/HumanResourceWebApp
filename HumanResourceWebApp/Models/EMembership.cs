using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HumanResourceWebApp.Models
{
    public class EMembership
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Id")]
        public Membership Membership { get; set; }
        public int MembershipId { get; set; }
        public string ReportingMethod { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string CreatedBy { get; set; }
    }
}
