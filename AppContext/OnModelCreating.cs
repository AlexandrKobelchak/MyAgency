﻿using Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppContext
{
    public partial class AppDbContext : IdentityDbContext
    {
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Country>()
                .Property(p => p.Id)
                .HasDefaultValueSql("NEWID()")
                .HasDefaultValue(Guid.NewGuid());

            builder.Entity<TourType>()
               .Property(p => p.Id)
               .HasDefaultValueSql("NEWID()")
               .HasDefaultValue(Guid.NewGuid());

            builder.Entity<Tour>()
                .HasMany(t => t.Countries)
                .WithMany(c => c.Tours)
                .UsingEntity<TourCountry>(
                    tcr => tcr
                        .HasOne(tc => tc.Country)
                        .WithMany(c => c.CountryTour)
                        .HasForeignKey(tc => tc.CountryId),
                    tcr => tcr
                        .HasOne(tc => tc.Tour)
                        .WithMany(t => t.CountryTour)
                        .HasForeignKey(tc => tc.TourId),

                   tcr => tcr.HasKey(pk => new { pk.TourId, pk.CountryId }))

                .HasMany(tour => tour.TourTypes)
                .WithMany(type => type.Tours)
                .UsingEntity<TourTourType>(
                    tt => tt
                        .HasOne(ttt => ttt.TourType)
                        .WithMany(t => t.TourTourType)
                        .HasForeignKey(ttt => ttt.TourTypeId),
                    tt => tt
                        .HasOne(ttt => ttt.Tour)
                        .WithMany(t => t.TourTourType)
                        .HasForeignKey(ttt => ttt.TourId),
                    tt => tt.HasKey(ttt => new { ttt.TourId, ttt.TourTypeId }))

                 .Property(p => p.Id)
                 .HasDefaultValueSql("NEWID()");

            builder.Entity<TouristTag>()
                .Property(p => p.Id)
                .HasDefaultValueSql("NEWID()")
                .HasDefaultValue(Guid.NewGuid());

            builder.Entity<TouristPhone>()
                .Property(p => p.Id)
                .HasDefaultValueSql("NEWID()")
                .HasDefaultValue(Guid.NewGuid());

            builder.Entity<TouristPhone>()
               .HasOne(p => p.Tourist)
                .WithMany(t => t.Phones)
                .HasForeignKey(p => p.TouristProfileId);

            builder.Entity<TouristProfile>()

                .HasMany(tp => tp.TouristTags)
                .WithMany(tt => tt.TouristProfiles)
                .UsingEntity<TouristProfileTag>(
                     tpt => tpt
                        .HasOne(p => p.TouristTag)
                        .WithMany(p => p.ProfileTouristTag)
                        .HasForeignKey(p => p.TagId),
                     
                     tpt => tpt
                        .HasOne(p=>p.TouristProfile)
                        .WithMany(p => p.ProfileTouristTag)
                        .HasForeignKey(p => p.TouristId),
                     
                     tpt => tpt.HasKey(k => new { k.TagId, k.TouristId}))

               .Property(p => p.Id)
               .HasDefaultValueSql("NEWID()")
               .HasDefaultValue<Guid>(Guid.NewGuid());

            builder.Entity


            base.OnModelCreating(builder);
        }
    }
}