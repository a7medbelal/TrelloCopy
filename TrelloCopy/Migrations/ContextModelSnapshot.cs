﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TrelloCopy.Data;

#nullable disable

namespace TrelloCopy.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TrelloCopy.Models.Project", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("CreatorID")
                        .HasColumnType("int");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UpdatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.HasIndex("CreatorID");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("TrelloCopy.Models.Role", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UpdatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            CreatedBy = 0,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Deleted = false,
                            Description = "Administrator Role",
                            Name = "Admin",
                            UpdatedBy = 0
                        },
                        new
                        {
                            ID = 2,
                            CreatedBy = 0,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Deleted = false,
                            Description = "Standard User Role",
                            Name = "User",
                            UpdatedBy = 0
                        });
                });

            modelBuilder.Entity("TrelloCopy.Models.SprintItem", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProjectID")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UpdatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("ProjectID");

                    b.HasIndex("UserID");

                    b.ToTable("SprintItems");
                });

            modelBuilder.Entity("TrelloCopy.Models.User", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("ConfirmationToken")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsEmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleID")
                        .HasColumnType("int");

                    b.Property<bool>("TwoFactorAuthEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("TwoFactorAuthsecretKey")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UpdatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.HasIndex("RoleID");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Country = "CountryName",
                            CreatedBy = 0,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Deleted = false,
                            Email = "upskillingfinalproject@gmail.com",
                            IsActive = true,
                            IsEmailConfirmed = true,
                            Name = "Admin User",
<<<<<<< HEAD
<<<<<<< HEAD
                            Password = "AQAAAAIAAYagAAAAEKzYSHWib8JKYlQsSksieRbO49qYk+DGt+k7D7V7Mv69ObmD/Ffe7RNjJsHV35prlw==",
=======
>>>>>>> 6ae4654236e5e9e904278da2fb2c0a3c45575212
=======
>>>>>>> 6ae4654236e5e9e904278da2fb2c0a3c45575212
                            PhoneNo = "1234567890",
                            RoleID = 1,
                            TwoFactorAuthEnabled = false,
                            UpdatedBy = 0
                        });
                });

            modelBuilder.Entity("TrelloCopy.Models.UserAssignedProject", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<DateTime>("AssignDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ProjectID")
                        .HasColumnType("int");

                    b.Property<int>("UpdatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("ProjectID");

                    b.HasIndex("UserID");

                    b.ToTable("UserAssignedProjects");
                });

            modelBuilder.Entity("TrelloCopy.Models.UserFeature", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<int>("Feature")
                        .HasColumnType("int");

                    b.Property<int>("UpdatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("UserID");

                    b.ToTable("UserFeatures");
<<<<<<< HEAD
=======
                });

            modelBuilder.Entity("TrelloCopy.Models.UserSprintItem", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<int>("SprintItemID")
                        .HasColumnType("int");

                    b.Property<int>("UpdatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("SprintItemID");

                    b.HasIndex("UserID");

                    b.ToTable("UserSprintItems");
>>>>>>> 6ae4654236e5e9e904278da2fb2c0a3c45575212
                });

            modelBuilder.Entity("TrelloCopy.Models.Project", b =>
                {
                    b.HasOne("TrelloCopy.Models.User", "Creator")
                        .WithMany("CreatedProjects")
                        .HasForeignKey("CreatorID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Creator");
                });

            modelBuilder.Entity("TrelloCopy.Models.SprintItem", b =>
                {
                    b.HasOne("TrelloCopy.Models.Project", "Project")
                        .WithMany("SprintItems")
                        .HasForeignKey("ProjectID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TrelloCopy.Models.User", "User")
                        .WithMany("UserSprintItems")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Project");

                    b.Navigation("User");
                });

            modelBuilder.Entity("TrelloCopy.Models.User", b =>
                {
                    b.HasOne("TrelloCopy.Models.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("TrelloCopy.Models.UserAssignedProject", b =>
                {
                    b.HasOne("TrelloCopy.Models.Project", "Project")
                        .WithMany("UserAssignedProjects")
                        .HasForeignKey("ProjectID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("TrelloCopy.Models.User", "User")
                        .WithMany("UserAssignedProjects")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Project");

                    b.Navigation("User");
                });

            modelBuilder.Entity("TrelloCopy.Models.UserFeature", b =>
                {
                    b.HasOne("TrelloCopy.Models.User", "user")
                        .WithMany("UserFeatures")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("user");
                });

            modelBuilder.Entity("TrelloCopy.Models.Project", b =>
                {
                    b.Navigation("SprintItems");

                    b.Navigation("UserAssignedProjects");
                });

            modelBuilder.Entity("TrelloCopy.Models.Role", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("TrelloCopy.Models.User", b =>
                {
                    b.Navigation("CreatedProjects");

                    b.Navigation("UserAssignedProjects");

                    b.Navigation("UserFeatures");

                    b.Navigation("UserSprintItems");
                });
#pragma warning restore 612, 618
        }
    }
}
