using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HumanResourceWebApp.Models
{
    public class EJob
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Id")]
        public JobTitle JobTitle { get; set; }
        public int JobTitleId { get; set; }
        [ForeignKey("Id")]
        public EmploymentStatus EmploymentStatus { get; set; }
        [ForeignKey("Id")]
        public JobCategory JobCategory { get; set; }
        public DateTime DateJoined { get; set; }
        [ForeignKey("DeptId")]
        public Department Department { get; set; }
        public int DeptId { get; set; }
        [ForeignKey("Id")]
        public CompanyBranch CompanyBranch { get; set; }
        public int CompanyBranchId { get; set; }
        public DateTime ContractStartDate { get; set; }
        public DateTime ContractEndDate { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string CreatedBy { get; set; }
    }
}
