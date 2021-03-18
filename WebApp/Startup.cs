using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.SpaServices.AngularCli;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Context;
using Entities.Identity;
using System;
using Repositories;

namespace WebApp
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection"),
                optionsBuilder=>optionsBuilder.MigrationsAssembly("WebApp")));

            services.AddTransient<DbContext, AppDbContext>();

            services.AddTransient<IBankRepository, BankRepository>();
            services.AddTransient<ICompanyRepository, CompanyRepository>();
            services.AddTransient<ICountryRepository, CountryRepository>();
            services.AddTransient<IEmployeeRepository, EmployeeRepository>();
            services.AddTransient<IIndividualPersonRepository,IndividualPersonRepository>();
            services.AddTransient<ILegalPersonRepository, LegalPersonRepository>();
            services.AddTransient<ISaleRepository, SaleRepository>();
            services.AddTransient<ITouristPhoneRepository, TouristPhoneRepository>();
            services.AddTransient<ITouristProfileRepository, TouristProfileRepository>();
            services.AddTransient<ITourRepository, TourRepository>();
            services.AddTransient<ITourTypeRepository, TourTypeRepository>();
            services.AddTransient<ITouristTagRepository, TouristTagRepository>();
            services.AddTransient<ISocialNetworkRepository, SocialNetworkRepository>();

            services.AddDatabaseDeveloperPageExceptionFilter();

            services.AddDefaultIdentity<ApplicationUser>()
           .AddRoles<ApplicationRole>()
           .AddEntityFrameworkStores<AppDbContext>();

            services.Configure<IdentityOptions>(options =>
            {
                options.SignIn.RequireConfirmedAccount = true;

                options.Password.RequireDigit = true;
                options.Password.RequireLowercase = true;
                options.Password.RequireNonAlphanumeric = true;
                options.Password.RequireUppercase = true;
                options.Password.RequiredLength = 6;
                options.Password.RequiredUniqueChars = 1;

                // Lockout settings.
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
                options.Lockout.MaxFailedAccessAttempts = 5;
                options.Lockout.AllowedForNewUsers = true;

            });


            services.AddIdentityServer(options =>
            {
                //options.Events.RaiseSuccessEvents = true;
                //options.Events.RaiseFailureEvents = true;
                //options.Events.RaiseErrorEvents = true;
            })
            .AddApiAuthorization<ApplicationUser, AppDbContext>();


           
            services.AddAuthentication()
                .AddIdentityServerJwt();

            services.AddAuthorization(options => {
                options.AddPolicy("RequireModerator",
                    policy => policy.RequireRole("Administrator", "Moderator").RequireAuthenticatedUser());

                options.AddPolicy("RequireAdministrator",
                    policy => policy.RequireRole("Administrator").RequireAuthenticatedUser());
            });


            services.AddControllersWithViews();
            services.AddRazorPages();
            // In production, the Angular files will be served from this directory
            services.AddSpaStaticFiles(configuration =>
            {
                configuration.RootPath = "ClientApp/dist";
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseMigrationsEndPoint();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            if (!env.IsDevelopment())
            {
                app.UseSpaStaticFiles();
            }

            app.UseRouting();

            app.UseAuthentication();
            app.UseIdentityServer();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
            });

            app.UseSpa(spa =>
            {
                // To learn more about options for serving an Angular SPA from ASP.NET Core,
                // see https://go.microsoft.com/fwlink/?linkid=864501

                spa.Options.SourcePath = "ClientApp";

                if (env.IsDevelopment())
                {
                    spa.UseAngularCliServer(npmScript: "start");
                }
            });
        }
    }
}
