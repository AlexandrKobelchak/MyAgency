using Entities;
using Entities.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace Context
{
    public partial class AppDbContext
        :ApiAuthorizationDbContext<ApplicationUser, ApplicationRole, Guid>
    {
        public DbSet<Asset> Assets { get; set; }
        public DbSet<Tour> Tours { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<TourCountry> ToursCountries { get; set; }
        public DbSet<TourType> TourTypes { get; set; }
        public DbSet<TourTourType> TourTourTypes { get; set; }
        public DbSet<TouristTag> TouristTags { get; set; }
        public DbSet<TouristProfileTag>  TouristProfileTags {get; set;}
        public DbSet<LegalPerson> LegalPerson { get; set; }
        public DbSet<Bank> Bank { get; set; }
        public DbSet<IndividualPerson> IndividualPeople { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<TouristPhoneSocial> TPS { get; set; }
        public DbSet<SocialNetwork> SocialNetworks { get; set; }
    }
}
