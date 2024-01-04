﻿// <auto-generated />
using System;
using Job_Portal_Project.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace JobPortalProject.Migrations
{
    [DbContext(typeof(JobportalDbContext))]
    partial class JobportalDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Job_Portal_Project.Models.Application", b =>
                {
                    b.Property<int>("ApplicationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ApplicationID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ApplicationId"));

                    b.Property<string>("ApplicantId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("ApplicantID");

                    b.Property<int?>("ApplicantUserId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ApplicationDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<int?>("JobId")
                        .IsRequired()
                        .HasColumnType("int")
                        .HasColumnName("JobID");

                    b.Property<string>("Status")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasDefaultValueSql("('pending')");

                    b.HasKey("ApplicationId")
                        .HasName("PK__Applicat__C93A4F7903670DAE");

                    b.HasIndex("ApplicantUserId");

                    b.HasIndex(new[] { "JobId", "ApplicantId" }, "UC_ApplicantJob")
                        .IsUnique();

                    b.ToTable("Applications");
                });

            modelBuilder.Entity("Job_Portal_Project.Models.Job", b =>
                {
                    b.Property<int>("JobId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("JobID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("JobId"));

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime?>("DatePosted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<string>("Deadline")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Education")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Experience")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("JobTitle")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("NumberOfVacancies")
                        .HasColumnType("int");

                    b.Property<string>("Requirements")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("SalaryRange")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("ShiftType")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Skills")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("JobId")
                        .HasName("PK__Jobs__056690E26D982F9B");

                    b.ToTable("Jobs");
                });

            modelBuilder.Entity("Job_Portal_Project.Models.JobApplicationsApproval", b =>
                {
                    b.Property<int>("ApplicationApprovalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ApplicationApprovalID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ApplicationApprovalId"));

                    b.Property<string>("ApplicantId")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("ApplicantID");

                    b.Property<DateTime?>("ApplicationDate")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("ApprovalDate")
                        .HasColumnType("datetime");

                    b.Property<int?>("JobId")
                        .HasColumnType("int")
                        .HasColumnName("JobID");

                    b.Property<string>("Status")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasDefaultValueSql("('pending')");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("UserID");

                    b.Property<int?>("UserId1")
                        .HasColumnType("int");

                    b.HasKey("ApplicationApprovalId")
                        .HasName("PK__JobAppli__A45A7F911BBA87C6");

                    b.HasIndex("UserId1");

                    b.HasIndex(new[] { "JobId", "ApplicantId" }, "UC_JobApplication")
                        .IsUnique()
                        .HasFilter("[JobID] IS NOT NULL AND [ApplicantID] IS NOT NULL");

                    b.ToTable("JobApplicationsApproval", (string)null);
                });

            modelBuilder.Entity("Job_Portal_Project.Models.Message", b =>
                {
                    b.Property<int>("MessageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("MessageID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MessageId"));

                    b.Property<string>("MessageText")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("SenderEmail")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("SenderName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("SenderNum")
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<string>("SenderRole")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<DateTime?>("Timestamp")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.HasKey("MessageId")
                        .HasName("PK__Messages__C87C037CACD743BF");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("Job_Portal_Project.Models.Offer", b =>
                {
                    b.Property<int>("OfferId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("OfferID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OfferId"));

                    b.Property<string>("ApplicantId")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("ApplicantID");

                    b.Property<int?>("JobId")
                        .HasColumnType("int")
                        .HasColumnName("JobID");

                    b.Property<decimal>("OfferAmount")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<DateTime?>("OfferDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<int>("OfferDuration")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasDefaultValueSql("('pending')");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("OfferId")
                        .HasName("PK__Offers__8EBCF0B1F0D44759");

                    b.HasIndex("UserId");

                    b.HasIndex(new[] { "JobId", "ApplicantId" }, "UC_JobApplicantOffer")
                        .IsUnique()
                        .HasFilter("[JobID] IS NOT NULL AND [ApplicantID] IS NOT NULL");

                    b.ToTable("Offers");
                });

            modelBuilder.Entity("Job_Portal_Project.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("UserID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<string>("Email")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("FirstName")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("LastName")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Password")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("UserType")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar(5)")
                        .HasDefaultValueSql("('user')");

                    b.HasKey("UserId")
                        .HasName("PK__Users__1788CCACC69786D4");

                    b.HasIndex(new[] { "Email" }, "UQ__Users__A9D10534898CBC33")
                        .IsUnique()
                        .HasFilter("[Email] IS NOT NULL");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "cad2e0aa-2824-4d39-a886-ef344919908b",
                            Name = "User",
                            NormalizedName = "USER"
                        },
                        new
                        {
                            Id = "5438d5eb-7dea-4b9a-b3a8-26955a8f981a",
                            Name = "Employer",
                            NormalizedName = "EMPLOYER"
                        },
                        new
                        {
                            Id = "2f7db78c-ee78-473a-8220-e3215bacb263",
                            ConcurrencyStamp = "988d409a-75dc-45fc-91b2-8b60f2483a32",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Job_Portal_Project.Models.Application", b =>
                {
                    b.HasOne("Job_Portal_Project.Models.User", "Applicant")
                        .WithMany("Applications")
                        .HasForeignKey("ApplicantUserId");

                    b.HasOne("Job_Portal_Project.Models.Job", "Job")
                        .WithMany("Applications")
                        .HasForeignKey("JobId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK__Applicati__JobID__48CFD27E");

                    b.Navigation("Applicant");

                    b.Navigation("Job");
                });

            modelBuilder.Entity("Job_Portal_Project.Models.JobApplicationsApproval", b =>
                {
                    b.HasOne("Job_Portal_Project.Models.Job", "Job")
                        .WithMany("JobApplicationsApprovals")
                        .HasForeignKey("JobId")
                        .HasConstraintName("FK__JobApplic__JobID__5070F446");

                    b.HasOne("Job_Portal_Project.Models.User", null)
                        .WithMany("JobApplicationsApprovals")
                        .HasForeignKey("UserId1");

                    b.HasOne("Job_Portal_Project.Models.Application", "Application")
                        .WithOne("JobApplicationsApproval")
                        .HasForeignKey("Job_Portal_Project.Models.JobApplicationsApproval", "JobId", "ApplicantId")
                        .HasPrincipalKey("Job_Portal_Project.Models.Application", "JobId", "ApplicantId")
                        .HasConstraintName("FK__JobApplicationsA__5535A963");

                    b.Navigation("Application");

                    b.Navigation("Job");
                });

            modelBuilder.Entity("Job_Portal_Project.Models.Offer", b =>
                {
                    b.HasOne("Job_Portal_Project.Models.Job", "Job")
                        .WithMany("Offers")
                        .HasForeignKey("JobId")
                        .HasConstraintName("FK__Offers__JobID__59063A47");

                    b.HasOne("Job_Portal_Project.Models.User", null)
                        .WithMany("Offers")
                        .HasForeignKey("UserId");

                    b.HasOne("Job_Portal_Project.Models.Application", "Application")
                        .WithOne("Offer")
                        .HasForeignKey("Job_Portal_Project.Models.Offer", "JobId", "ApplicantId")
                        .HasPrincipalKey("Job_Portal_Project.Models.Application", "JobId", "ApplicantId")
                        .HasConstraintName("FK__Offers__5DCAEF64");

                    b.Navigation("Application");

                    b.Navigation("Job");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Job_Portal_Project.Models.Application", b =>
                {
                    b.Navigation("JobApplicationsApproval");

                    b.Navigation("Offer");
                });

            modelBuilder.Entity("Job_Portal_Project.Models.Job", b =>
                {
                    b.Navigation("Applications");

                    b.Navigation("JobApplicationsApprovals");

                    b.Navigation("Offers");
                });

            modelBuilder.Entity("Job_Portal_Project.Models.User", b =>
                {
                    b.Navigation("Applications");

                    b.Navigation("JobApplicationsApprovals");

                    b.Navigation("Offers");
                });
#pragma warning restore 612, 618
        }
    }
}