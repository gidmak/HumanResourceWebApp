using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HumanResourceWebApp.Models
{
    public class CompanyInformation
    {
        [Key]
        public int Id { get; set; }
        public string OrganizationName { get; set; }
        public string TaxId { get; set; }
        public int NumberOfEmployees { get; set; }
        public string RegistrationNumber { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string StateOrProvince { get; set; }
        public string ZipOrPostalCode { get; set; }
        [ForeignKey("Id")]
        public Country Country { get; set; }
        public string CountryId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string CreatedBy { get; set; }

    }
}
