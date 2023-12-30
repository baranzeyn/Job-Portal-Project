using Job_Portal_Project.Controllers;
using Job_Portal_Project.Models;
using Job_Portal_Project.Repositories;
using Job_Portal_Project.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IRepositoryManager,RepositoryManager>();
builder.Services.AddScoped<IAdminRepository,AdminRepository>();
builder.Services.AddScoped<IUserRepository,UserRepository>();
builder.Services.AddScoped<IServiceManager,ServiceManager>();
builder.Services.AddScoped<IUserService,UserService>();
builder.Services.AddScoped<IAdminService,AdminService>();
builder.Services.AddScoped<IJobsRepository,JobsRepository>();
builder.Services.AddScoped<IJobsService,JobsService>();
builder.Services.AddScoped<IContactRepository,ContactRepository>();
builder.Services.AddScoped<IContactService,ContactService>();

builder.Services.AddDbContext<JobportalDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")
    );
});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
