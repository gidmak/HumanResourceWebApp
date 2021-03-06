﻿using Microsoft.EntityFrameworkCore;
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
        public DbSet<License> Licenses{ get; set; }
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
        public DbSet<EEmergencyContact> EEmergencyContacts { get; set; }
        public DbSet<EDependant> EDependants { get; set; }
        public DbSet<EImmigration> EImmigrations{ get; set; }
        public DbSet<EJob> EJobs { get; set; }
        public DbSet<ESalary> ESalaries { get; set; }
        public DbSet<EMembership> EMemberships { get; set; }
        public DbSet<EWorkExperience> EWorkExperiences { get; set; }
        public DbSet<EEducation> EEducations { get; set; }
        public DbSet<ESkill> ESkills { get; set; }
        public DbSet<ELanguage> ELanguages { get; set; }
        public DbSet<ELicense> ELicenses { get; set; }
    }
}
