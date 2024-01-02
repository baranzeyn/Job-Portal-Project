using Job_Portal_Project.Models;
using Job_Portal_Project.Repositories;
using Job_Portal_Project.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Job_Portal_Project.Infrastructure.Extensions
{
    public static class ServiceExtension
    {
        public static void ConfigureDbContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<JobportalDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"),
                b => b.MigrationsAssembly("Job-Portal-Project"));
                
                options.EnableSensitiveDataLogging(true);
            });
        }

        public static void ConfigureIdentity(this IServiceCollection services)
        {
            services.AddIdentity<IdentityUser, IdentityRole>(options =>
            {
                options.SignIn.RequireConfirmedAccount = false;
                options.SignIn.RequireConfirmedEmail = false;
                options.Password.RequireLowercase  = false;
                options.Password.RequireUppercase = false;
                options.Password.RequireDigit = false;
                options.Password.RequiredLength = 6;

            }).AddEntityFrameworkStores<JobportalDbContext>();
        }

        public static void ConfigureRepositoryRegistration(this IServiceCollection services)
        {
            // Add services to the container.
            services.AddScoped<IRepositoryManager, RepositoryManager>();
            services.AddScoped<IAdminRepository, AdminRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IJobsRepository, JobsRepository>();
            services.AddScoped<IContactRepository, ContactRepository>();
        }
        public static void ConfigureServicesRegistration(this IServiceCollection services)
        {
            // Add services to the container.

            services.AddScoped<IServiceManager, ServiceManager>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IAdminService, AdminService>();
            services.AddScoped<IJobsService, JobsService>();
            services.AddScoped<IContactService, ContactService>();
        }
    }
}