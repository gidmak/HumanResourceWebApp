using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HumanResourceWebApp.Models
{
    public class ESalary
    {
        [Key]
        public int Id { get; set; }
        public int PayGradeId { get; set; }
        public string PayFrequency { get; set; }
        [ForeignKey("Id")]
        public Currency Currency { get; set; }
        public int CurrencyId { get; set; }
        public string Amount { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string CreatedBy { get; set; }
    }
}
