using Job_Portal_Project.Models;
using Job_Portal_Project.Repositories;
using Job_Portal_Project.Services;
using Microsoft.EntityFrameworkCore;

namespace Job_Portal_Project.Infrastructure.Extensions
{
    public static class ServiceExtension
    {
        public static void ConfigureDbContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<JobportalDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            });
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