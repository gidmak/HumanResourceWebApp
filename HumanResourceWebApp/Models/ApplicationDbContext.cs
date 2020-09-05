using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HumanResourceWebApp.Models 
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base (options)
        {

        }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<Licenses> Licenses{ get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Membership> Memberships{ get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Nationality> Nationalities{ get; set; }
        public DbSet<JobTitle> JobTitles { get; set; }
        public DbSet<Currency> Currencies{ get; set; }
        public DbSet<PayGrade> PayGrades { get; set; }
        public DbSet<EmploymentStatus> EmploymentStatuses{ get; set; }
        public DbSet<JobCategory> JobCategories { get; set; }
        public DbSet<CompanyInformation> CompanyInformation { get; set; }
        public DbSet<CompanyBranch> CompanyBranches { get; set; }
        public DbSet<EContactDetail> EContactDetails { get; set; }
    }
}
