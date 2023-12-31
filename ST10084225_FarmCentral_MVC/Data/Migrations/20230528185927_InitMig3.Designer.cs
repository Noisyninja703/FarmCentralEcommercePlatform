﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ST10084225_FarmCentral_MVC.Data;

namespace ST10084225_FarmCentral_MVC.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230528185927_InitMig3")]
    partial class InitMig3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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

                    b.ToTable("AspNetRoles");

                    b.HasData(
                        new
                        {
                            Id = "1",
                            ConcurrencyStamp = "1af19f3d-3090-425c-b83c-ba3a05861063",
                            Name = "Manager",
                            NormalizedName = "MANAGER"
                        },
                        new
                        {
                            Id = "2",
                            ConcurrencyStamp = "28935aa2-5fba-44ba-ada2-835bc3230864",
                            Name = "Employee",
                            NormalizedName = "EMPLOYEE"
                        },
                        new
                        {
                            Id = "3",
                            ConcurrencyStamp = "0f7a972a-500c-4e41-92ca-9bf882d7d932",
                            Name = "Farmer",
                            NormalizedName = "FARMER"
                        },
                        new
                        {
                            Id = "4",
                            ConcurrencyStamp = "bef8d7db-e0cc-4679-b715-e8201f31a42b",
                            Name = "Customer",
                            NormalizedName = "CUSTOMER"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
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

                    b.ToTable("AspNetUsers");

                    b.HasData(
                        new
                        {
                            Id = "1",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "f5cfb616-6f5a-494b-b7f9-83b8d0673bbb",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedUserName = "MANAGER1",
                            PasswordHash = "AQAAAAEAACcQAAAAEMeP+vwdz1jQckofUoZ75bR75juaFxULlBNrNRQdYNkWou4pRIHrRBXyxsrNgGtJiw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "596fbbcd-39f9-46b2-881c-80225bacb9d0",
                            TwoFactorEnabled = false,
                            UserName = "Manager1"
                        },
                        new
                        {
                            Id = "2",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "f14c61e6-6c84-4852-82b9-7c5525860022",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedUserName = "EMPLOYEE1",
                            PasswordHash = "AQAAAAEAACcQAAAAEMwjJsKIEuAlNwJeIeCbw+y+o6dc8r4TmBe3HhTFqslEGPrJxzDbJprCobiE7TlUwQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "f201511c-18cb-418c-a6bd-9b2714c6a215",
                            TwoFactorEnabled = false,
                            UserName = "Employee1"
                        },
                        new
                        {
                            Id = "3",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "b7076442-04ab-4a4b-8c9d-1150db97c4c0",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedUserName = "FARMER1",
                            PasswordHash = "AQAAAAEAACcQAAAAEDwKWc3/+f2i8dFyWPc2MZAHAYtX7cht1Z41tsmpZoYxxIXNZqhnqeUg4MhX2vv+ZA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "c1f75c6c-cd50-4fc5-91d4-78734173a10b",
                            TwoFactorEnabled = false,
                            UserName = "Farmer1"
                        },
                        new
                        {
                            Id = "4",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "f4c01717-47e5-4437-9747-9a3f965326e4",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedUserName = "CUSTOMER1",
                            PasswordHash = "AQAAAAEAACcQAAAAEBPcO66V25Wa33yCE4LccCZu6K55mT8RDIVnEGpcu77cMAbUpRKf9laQxurbIDQmbw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "f0968551-3762-4f6e-8037-5d87b2dcacec",
                            TwoFactorEnabled = false,
                            UserName = "Customer1"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
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

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");

                    b.HasData(
                        new
                        {
                            UserId = "1",
                            RoleId = "1"
                        },
                        new
                        {
                            UserId = "2",
                            RoleId = "2"
                        },
                        new
                        {
                            UserId = "3",
                            RoleId = "3"
                        },
                        new
                        {
                            UserId = "4",
                            RoleId = "4"
                        });
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

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("ST10084225_FarmCentral_MVC.Models.Farmer", b =>
                {
                    b.Property<string>("FarmerID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("FarmerName")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("FarmerID", "FarmerName");

                    b.ToTable("Farmers");

                    b.HasData(
                        new
                        {
                            FarmerID = "1",
                            FarmerName = "Mike Wozoski"
                        },
                        new
                        {
                            FarmerID = "2",
                            FarmerName = "Dave Davidson"
                        },
                        new
                        {
                            FarmerID = "3",
                            FarmerName = "Jakko Marakko"
                        },
                        new
                        {
                            FarmerID = "4",
                            FarmerName = "Carol Canoli"
                        });
                });

            modelBuilder.Entity("ST10084225_FarmCentral_MVC.Models.Product", b =>
                {
                    b.Property<int>("ProductID")
                        .HasColumnType("int");

                    b.Property<string>("FarmerID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Category")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ProductID", "FarmerID");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductID = 1,
                            FarmerID = "1",
                            Category = "Fruits",
                            Date = new DateTime(2023, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Fresh Oranges",
                            ImageID = "Oranges.jpg",
                            Name = "Oranges",
                            Price = 24.99m
                        },
                        new
                        {
                            ProductID = 2,
                            FarmerID = "2",
                            Category = "Vegetables",
                            Date = new DateTime(2023, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Fresh Butter Lettuce",
                            ImageID = "Lettuce.jpg",
                            Name = "lettuce",
                            Price = 34.99m
                        },
                        new
                        {
                            ProductID = 3,
                            FarmerID = "3",
                            Category = "Fruits",
                            Date = new DateTime(2023, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Fresh Strawberries",
                            ImageID = "Strawberries.jpg",
                            Name = "Strawberries",
                            Price = 32.99m
                        },
                        new
                        {
                            ProductID = 4,
                            FarmerID = "4",
                            Category = "Vegetables",
                            Date = new DateTime(2023, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Fresh Leeks",
                            ImageID = "Leeks.jpg",
                            Name = "leeks",
                            Price = 29.99m
                        });
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
#pragma warning restore 612, 618
        }
    }
}
