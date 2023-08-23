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
    [Migration("20230529093216_FinalMig2")]
    partial class FinalMig2
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
                            ConcurrencyStamp = "b619741d-88d1-44c9-9994-3b95037e2422",
                            Name = "Manager",
                            NormalizedName = "MANAGER"
                        },
                        new
                        {
                            Id = "2",
                            ConcurrencyStamp = "72201b32-c13f-47dc-bbdc-3ce2af92a28f",
                            Name = "Employee",
                            NormalizedName = "EMPLOYEE"
                        },
                        new
                        {
                            Id = "3",
                            ConcurrencyStamp = "efc51c77-6cfd-45b9-bf23-b226d7a0a847",
                            Name = "Farmer",
                            NormalizedName = "FARMER"
                        },
                        new
                        {
                            Id = "4",
                            ConcurrencyStamp = "e58d8337-e6e5-44fa-9022-1f793ef556ce",
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
                            ConcurrencyStamp = "89d5b962-4a3c-4763-9ef3-b1adcdc27dfe",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedUserName = "MANAGER1",
                            PasswordHash = "AQAAAAEAACcQAAAAEDJfOpMseV+o74LKpZ+u5GV2uW2e0xKrh7dcF/sYheWUp0/mGwaXuQsbsg25ZH6+JA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "33773478-6a9f-4292-bcae-83cb1a07b823",
                            TwoFactorEnabled = false,
                            UserName = "Manager1"
                        },
                        new
                        {
                            Id = "2",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "cc4f1cae-c74b-4bb5-8325-1a397d0796c8",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedUserName = "EMPLOYEE1",
                            PasswordHash = "AQAAAAEAACcQAAAAEHAlruhQZb1Q8iWrHj89fAqK+WIPAbvA1oYmi6Y6dSWHU6Tk7vQw4Owa16G1r/cdmg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "89d8934d-d91a-496f-b1d6-f6e5e5011e10",
                            TwoFactorEnabled = false,
                            UserName = "Employee1"
                        },
                        new
                        {
                            Id = "3",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "8dc5acc5-25f7-43ea-8e57-a36586c0d09b",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedUserName = "FARMER1",
                            PasswordHash = "AQAAAAEAACcQAAAAEE+ZfA3aiggMsZr+FcGLTyEefmqNvWI6ASYtV9m3PZSUPJnX/KObIFD/ZZDb8g8I7Q==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "9e6e14ec-6f71-4be5-9271-beebe97ed999",
                            TwoFactorEnabled = false,
                            UserName = "Farmer1"
                        },
                        new
                        {
                            Id = "4",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "6d0373a8-f1a9-45a1-b96f-32cbcd5a189e",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedUserName = "CUSTOMER1",
                            PasswordHash = "AQAAAAEAACcQAAAAEKTQ8M0W3W8OU7l0D8FPoJvetnt/+ks31OQa29J4D94qINH+1Utoa7wynu9rnePBdQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "138a687e-ba5f-461b-872b-e69d96939f81",
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
                            Category = "Fruit",
                            Date = new DateTime(2023, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Fresh Oranges",
                            ImageID = "Oranges.jpg",
                            Name = "Oranges",
                            Price = 24.99m
                        },
                        new
                        {
                            ProductID = 2,
                            FarmerID = "1",
                            Category = "Vegetable",
                            Date = new DateTime(2023, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Fresh Butter Lettuce",
                            ImageID = "Lettuce.jpg",
                            Name = "lettuce",
                            Price = 34.99m
                        },
                        new
                        {
                            ProductID = 3,
                            FarmerID = "1",
                            Category = "Fruit",
                            Date = new DateTime(2023, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Fresh Strawberries",
                            ImageID = "Strawberries.jpg",
                            Name = "Strawberries",
                            Price = 32.99m
                        },
                        new
                        {
                            ProductID = 4,
                            FarmerID = "1",
                            Category = "Vegetable",
                            Date = new DateTime(2023, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Fresh Leeks",
                            ImageID = "Leeks.jpg",
                            Name = "leeks",
                            Price = 29.99m
                        },
                        new
                        {
                            ProductID = 5,
                            FarmerID = "2",
                            Category = "Fruit",
                            Date = new DateTime(2023, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Fresh Oranges",
                            ImageID = "Apple.jpg",
                            Name = "Apples",
                            Price = 18.99m
                        },
                        new
                        {
                            ProductID = 6,
                            FarmerID = "2",
                            Category = "Vegetable",
                            Date = new DateTime(2023, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Fresh Butter Lettuce",
                            ImageID = "Aparagus.jpg",
                            Name = "Asparagus",
                            Price = 32.99m
                        },
                        new
                        {
                            ProductID = 7,
                            FarmerID = "2",
                            Category = "Fruit",
                            Date = new DateTime(2023, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Freshly stolen from farmer Shivani",
                            ImageID = "Avocado.jpg",
                            Name = "Avocado",
                            Price = 27.99m
                        },
                        new
                        {
                            ProductID = 8,
                            FarmerID = "2",
                            Category = "Vegetable",
                            Date = new DateTime(2023, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Fresh Leeks",
                            ImageID = "Chilli.jpg",
                            Name = "Chillis",
                            Price = 31.99m
                        },
                        new
                        {
                            ProductID = 9,
                            FarmerID = "3",
                            Category = "Vegetable",
                            Date = new DateTime(2023, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Fresh Oranges",
                            ImageID = "pepper.jpg",
                            Name = "Peppers",
                            Price = 24.99m
                        },
                        new
                        {
                            ProductID = 10,
                            FarmerID = "3",
                            Category = "Vegetable",
                            Date = new DateTime(2023, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Fresh Butter Lettuce",
                            ImageID = "Tomato.jpg",
                            Name = "Tomato",
                            Price = 34.99m
                        },
                        new
                        {
                            ProductID = 11,
                            FarmerID = "3",
                            Category = "Fruit",
                            Date = new DateTime(2023, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Fresh Strawberries",
                            ImageID = "Grapes.jpg",
                            Name = "Grapes",
                            Price = 32.99m
                        },
                        new
                        {
                            ProductID = 12,
                            FarmerID = "3",
                            Category = "Vegetable",
                            Date = new DateTime(2023, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Fresh Leeks",
                            ImageID = "Broccoli.jpg",
                            Name = "Broccoli",
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
