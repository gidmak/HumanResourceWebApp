using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HumanResourceWebApp.Models
{
    public class CompanyBranch
    {
        [Key]
        public int Id { get; set; }
        public string LocationName { get; set; }
        public int City { get; set; }
        [ForeignKey("Id")]
        public Country Country { get; set; }
        public string CountryId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string CreatedBy { get; set; }
    }
}
