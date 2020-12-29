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
    }
}
