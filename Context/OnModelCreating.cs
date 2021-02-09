using Entities;
using Entities.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Context
{
    public partial class AppDbContext 
        :ApiAuthorizationDbContext<ApplicationUser, ApplicationRole, Guid>
    {
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Tour>(tour =>
            {
                tour.HasMany(t => t.Countries)
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

                   tcr => tcr.HasKey(pk => new { pk.TourId, pk.CountryId }));

                tour.HasMany(tour => tour.TourTypes)
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
                    tt => tt.HasKey(ttt => new { ttt.TourId, ttt.TourTypeId }));
            });


            builder.Entity<TouristPhone>(phone =>
            {
                phone.HasOne(p => p.Tourist)
                 .WithMany(t => t.Phones)
                 .HasForeignKey(p => p.TouristProfileId);

                phone.HasMany(p => p.SocialNetworks)
                .WithMany(sn => sn.TouristPhones)
                .UsingEntity<TouristPhoneSocial>(

                    tps => tps.HasOne(ps => ps.SocialNetwork)
                        .WithMany(sn => sn.TPS)
                        .HasForeignKey(ps => ps.SocialId),
                    
                    tps => tps.HasOne(ps => ps.TouristPhone)
                        .WithMany(ph => ph.TPS)
                        .HasForeignKey(ps => ps.PhoneId),
                    
                    tps => tps.HasKey(ps => new { ps.PhoneId, ps.SocialId }));
            });

            builder.Entity<TouristProfile>(profile =>
            {

                profile.HasMany(tp => tp.TouristTags)
                .WithMany(tt => tt.TouristProfiles)
                .UsingEntity<TouristProfileTag>(
                     tpt => tpt
                        .HasOne(p => p.TouristTag)
                        .WithMany(p => p.ProfileTouristTag)
                        .HasForeignKey(p => p.TagId),

                     tpt => tpt
                        .HasOne(p => p.TouristProfile)
                        .WithMany(p => p.ProfileTouristTag)
                        .HasForeignKey(p => p.TouristId),

                     tpt => tpt.HasKey(k => new { k.TagId, k.TouristId }));
            });


            builder.Entity<IndividualPerson>()
                .HasOne(ip => ip.Profile)
                .WithOne(p => p.IndividualPersonData)
                .HasForeignKey<IndividualPerson>(ip => ip.Id)
                .HasPrincipalKey<TouristProfile>(tp => tp.Id);

            builder.Entity<LegalPerson>()
               .HasOne(ip => ip.Profile)
               .WithOne(p => p.LegalPersonData)
               .HasForeignKey<LegalPerson>(ip => ip.Id)
               .HasPrincipalKey<TouristProfile>(tp => tp.Id);

            builder.Entity<LegalPerson>()
                .HasOne(lp => lp.Bank)
                .WithMany(b => b.LegalPersons)
                .HasForeignKey(lp => lp.BankId);


            builder.Entity<Employee>()
                .HasOne(e => e.Company)
                .WithMany(c => c.Emploiees)
                .HasForeignKey(e => e.CompanyId);


            builder.Entity<Sale>(sale =>
            {
                sale.HasOne(s => s.Agent)
                .WithMany(e => e.Sales)
                .HasForeignKey(s => s.AgentId);

                sale.HasOne(s => s.Tour)
               .WithMany(e => e.Sales)
               .HasForeignKey(s => s.TourId);

                sale.HasOne(s => s.Tourist)
               .WithMany(e => e.Sales)
               .HasForeignKey(s => s.TouristId);
            });

           

            base.OnModelCreating(builder);


            builder.Entity<TouristTag>().HasData(
                new TouristTag { Id = Guid.NewGuid(), TagName = "VIP" },
                new TouristTag { Id = Guid.NewGuid(), TagName = "Горнолыжный отдых" },
                new TouristTag { Id = Guid.NewGuid(), TagName = "Постоянный клиент" },
                new TouristTag { Id = Guid.NewGuid(), TagName = "Эконом" },
                new TouristTag { Id = Guid.NewGuid(), TagName = "Активный отдых" },
                new TouristTag { Id = Guid.NewGuid(), TagName = "Ездит один" },
                new TouristTag { Id = Guid.NewGuid(), TagName = "Семья" },
                new TouristTag { Id = Guid.NewGuid(), TagName = "Экскурсионный отдых" }
            );

            builder.Entity<TouristProfile>().HasData(
                  new TouristProfile
                  {
                      Id = Guid.NewGuid(),
                      FirstName = "Иван",
                      MiddleName = "Иванович",
                      LastName = "Тестовый",
                      Comment = "Просто хороший человек",
                      Address = "Живет где-то в Днепре",
                      City="Днепр",
                      Birthday = new DateTime(1978, 11, 20)
                  },
                  new TouristProfile
                  {
                      Id = Guid.NewGuid(),
                      FirstName = "Владимир",
                      MiddleName = "Иванович",
                      LastName = "Тестовый",
                      Comment = "Очень хороший человек",
                      Address = "Живет где-то в Киеве",
                      City = "Киев",
                      Birthday = new DateTime(1988, 2, 13)
                  },
                  new TouristProfile
                  {
                      Id = Guid.NewGuid(),
                      FirstName = "Тест",
                      MiddleName = "Тестович",
                      LastName = "Иванов",
                      Comment = "Просто хороший человек",
                      Address = "Живет где-то в Сухачевке",
                      City = "Сухачевка",
                      Birthday = new DateTime(1973, 6, 22)

                  }
            );

            builder.Entity<SocialNetwork>().HasData(
                new SocialNetwork
                {
                    Id = Guid.NewGuid(),
                    Name = "Viber"
                },
                new SocialNetwork
                {
                    Id = Guid.NewGuid(),
                    Name = "Telegram"
                });



        }
    }
}
