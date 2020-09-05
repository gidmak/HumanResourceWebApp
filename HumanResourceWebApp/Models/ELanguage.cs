using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HumanResourceWebApp.Models
{
    public class ELanguage
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Id")]
        public Language Language { get; set; }
        public int LanguageId { get; set; }
        public string Fluency { get; set; }
        public string Competency { get; set; }
        public string Comment { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string CreatedBy { get; set; }
    }
}
