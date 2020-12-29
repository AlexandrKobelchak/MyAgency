using Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace AppContext
{
    public partial class AppDbContext : IdentityDbContext
    {
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
    }
}
