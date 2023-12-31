using System;
using System.Collections.Generic;
using System.Reflection;
using Microsoft.EntityFrameworkCore;

namespace Job_Portal_Project.Models;

public partial class JobportalDbContext : DbContext
{
    public JobportalDbContext()
    {
    }

    public JobportalDbContext(DbContextOptions<JobportalDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Admin> Admins { get; set; }

    public virtual DbSet<Application> Applications { get; set; }

    public virtual DbSet<Job> Jobs { get; set; }

    public virtual DbSet<JobApplicationsApproval> JobApplicationsApprovals { get; set; }

    public virtual DbSet<Message> Messages { get; set; }

    public virtual DbSet<Offer> Offers { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Server=TAHA\\MSSQLSERVER02;Database=Jobportal-Db;Trusted_Connection=True;TrustServerCertificate=true;MultipleActiveResultSets=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
