using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HumanResourceWebApp.Models
{
    public class EEducation
    {
        [Key]
        public int Id { get; set; }
        public string Level { get; set; }
        public string Institute { get; set; }
        public string MajorOrSpecialization { get; set; }
        public string Year { get; set; }
        public string ScoreOrGPA { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string Comment { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string CreatedBy { get; set; }
    }
}
