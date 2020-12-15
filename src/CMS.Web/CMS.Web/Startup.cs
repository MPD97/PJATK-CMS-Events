using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using CMS.Infrastructure.MsSQL;
using CMS.Core.Entites;
using CMS.Web.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Razor;
using System.Linq;
using System.Security.Claims;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;
using System;

namespace CMS.Web
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }


        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddIdentity<ApplicationUser, ApplicationRole>(options =>
                {
                    options.User.RequireUniqueEmail = false;
                    
                })
                .AddEntityFrameworkStores<ApplicationContext>()
                .AddDefaultTokenProviders();

            services.AddLocalization(options => options.ResourcesPath = "Resources");

            services.AddControllersWithViews()
                .AddViewLocalization(LanguageViewLocationExpanderFormat.Suffix)
                .AddDataAnnotationsLocalization();

            services.AddScoped<IEventService, EventService>();

            services.AddRazorPages();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ApplicationContext context, UserManager<ApplicationUser> userManager)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            var supportedCultures = new[] { "en-US", "pl-PL" };
            var localizationOptions = new RequestLocalizationOptions().SetDefaultCulture(supportedCultures[0])
                .AddSupportedCultures(supportedCultures)
                .AddSupportedUICultures(supportedCultures);

            app.UseRequestLocalization(localizationOptions);


            context.Database.EnsureCreated();

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();


            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
            });

            seedUsers(userManager).Wait();
        }
        private async Task seedUsers( UserManager<ApplicationUser> userManager)
        {

            var adminEmail = "Admin@wp.pl";
            var adminPassword = "1qaz@WSX";

            var userEmail = "User@wp.pl";
            var userPassword = "1qaz@WSX";

            var admin = await userManager.FindByEmailAsync(adminEmail);
            if (admin == null)
            {
                var adminToCrete = new ApplicationUser { UserName = adminEmail, Email = adminEmail, Role = "Admin" };
                var result = await userManager.CreateAsync(adminToCrete, adminPassword);
                if (!result.Succeeded)
                {
                    throw new Exception("CANNOT CREATE ADMIN ACCOUNT!");
                }
            }


            var user = await userManager.FindByEmailAsync(userEmail);
            if (user == null)
            {
                var userToCreate = new ApplicationUser { UserName = userEmail, Email = userEmail };
                var result = await userManager.CreateAsync(userToCreate, userPassword);
                if (!result.Succeeded)
                {
                    throw new Exception("CANNOT CREATE USER ACCOUNT!");
                }
            }
        }
    }
}
