using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HumanResourceWebApp.Models
{
    public class PayGrade
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Id")]
        public Currency Currency { get; set; }
        public int CurrencyId { get; set; }
        public string MinimumSalary{ get; set; }
        public string MaximumSalary { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string CreatedBy { get; set; }
    }
}
