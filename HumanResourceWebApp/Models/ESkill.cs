using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HumanResourceWebApp.Models
{
    public class ESkill
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Id")]
        public Skill Skill { get; set; }
        public int SkillId { get; set; }
        public int YearsOfExperience { get; set; }
        public string Comment { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string CreatedBy { get; set; }
    }
}
