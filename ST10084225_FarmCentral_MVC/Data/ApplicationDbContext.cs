using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ST10084225_FarmCentral_MVC.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ST10084225_FarmCentral_MVC.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }

        public DbSet<Farmer> Farmers { get; set; }


        //Seeding --> 2 tables --categories --> onModelCreating
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>().HasKey(products => new { products.ProductID, products.FarmerID });
            modelBuilder.Entity<Farmer>().HasKey(farmers => new { farmers.FarmerID, farmers.FarmerName });

            //Product Seed Data 
            //Seed Farmer 1 Products
            modelBuilder.Entity<Product>().HasData(new Product { ProductID = 1, FarmerID = "1", Name = "Oranges", Date = new DateTime(2023, 05, 10), Category = "Fruit", Description = "Fresh Oranges", Price = 24.99M, ImageID = "Oranges.jpg" });
            modelBuilder.Entity<Product>().HasData(new Product { ProductID = 2, FarmerID = "1", Name = "lettuce", Date = new DateTime(2023, 05, 11), Category = "Vegetable", Description = "Fresh Butter Lettuce", Price = 34.99M, ImageID = "Lettuce.jpg" });
            modelBuilder.Entity<Product>().HasData(new Product { ProductID = 3, FarmerID = "1", Name = "Strawberries", Date = new DateTime(2023, 05, 12), Category = "Fruit", Description = "Fresh Strawberries", Price = 32.99M, ImageID = "Strawberries.jpg" });
            modelBuilder.Entity<Product>().HasData(new Product { ProductID = 4, FarmerID = "1", Name = "leeks", Date = new DateTime(2023, 05, 13), Category = "Vegetable", Description = "Fresh Leeks", Price = 29.99M, ImageID = "Leeks.jpg" }); 

            //Seed Farmer 2 Products
            modelBuilder.Entity<Product>().HasData(new Product { ProductID = 5, FarmerID = "2", Name = "Apples", Date = new DateTime(2023, 05, 14), Category = "Fruit", Description = "Fresh Apples", Price = 18.99M, ImageID = "Apple.jpg" });
            modelBuilder.Entity<Product>().HasData(new Product { ProductID = 6, FarmerID = "2", Name = "Asparagus", Date = new DateTime(2023, 05, 15), Category = "Vegetable", Description = "Fresh Asparagus", Price = 32.99M, ImageID = "Aparagus.jpg" });
            modelBuilder.Entity<Product>().HasData(new Product { ProductID = 7, FarmerID = "2", Name = "Avocado", Date = new DateTime(2023, 05, 16), Category = "Fruit", Description = "Freshly stolen from farmer Shivani", Price = 27.99M, ImageID = "Avocado.jpg" });
            modelBuilder.Entity<Product>().HasData(new Product { ProductID = 8, FarmerID = "2", Name = "Chillis", Date = new DateTime(2023, 05, 17), Category = "Vegetable", Description = "Fresh Chillis", Price = 31.99M, ImageID = "Chilli.jpg" });

            //Seed Farmer 3 Products
            modelBuilder.Entity<Product>().HasData(new Product { ProductID = 9, FarmerID = "3", Name = "Peppers", Date = new DateTime(2023, 05, 18), Category = "Vegetable", Description = "Fresh Peppers", Price = 24.99M, ImageID = "pepper.jpg" });
            modelBuilder.Entity<Product>().HasData(new Product { ProductID = 10, FarmerID = "3", Name = "Tomato", Date = new DateTime(2023, 05, 19), Category = "Vegetable", Description = "Fresh Tomato", Price = 34.99M, ImageID = "Tomato.jpg" });
            modelBuilder.Entity<Product>().HasData(new Product { ProductID = 11, FarmerID = "3", Name = "Grapes", Date = new DateTime(2023, 05, 20), Category = "Fruit", Description = "Fresh Grapes", Price = 32.99M, ImageID = "Grapes.jpg" });
            modelBuilder.Entity<Product>().HasData(new Product { ProductID = 12, FarmerID = "3", Name = "Broccoli", Date = new DateTime(2023, 05, 21), Category = "Vegetable", Description = "Fresh Broccoli", Price = 29.99M, ImageID = "Broccoli.jpg" });

            //Farmer Seed Data 
            modelBuilder.Entity<Farmer>().HasData(new Farmer { FarmerID = "1", FarmerName = "Mike Wozoski" });
            modelBuilder.Entity<Farmer>().HasData(new Farmer { FarmerID = "2", FarmerName = "Dave Davidson" });
            modelBuilder.Entity<Farmer>().HasData(new Farmer { FarmerID = "3", FarmerName = "Jakko Marakko" });

            //Seeding roles to AspNetRoles table
            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole { Id = "1", Name = "Manager", NormalizedName = "Manager".ToUpper() });
            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole { Id = "2", Name = "Employee", NormalizedName = "Employee".ToUpper() });
            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole { Id = "3", Name = "Farmer", NormalizedName = "Farmer".ToUpper() });
            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole { Id = "4", Name = "Customer", NormalizedName = "Customer".ToUpper() });


            //a hasher to hash the password before seeding the user to the db
            var hasher = new PasswordHasher<IdentityUser>();

            //Seed a Manager Account
            //Seeding the Manager User to AspNetUsers table
            modelBuilder.Entity<IdentityUser>().HasData(
                new IdentityUser
                {
                    Id = "1", // primary key
                    UserName = "Manager1",
                    NormalizedUserName = "MANAGER1",
                    PasswordHash = hasher.HashPassword(null, "Test@123")
                }
            );


            //Seeding the relation between our user and role to AspNetUserRoles table
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "1",
                    UserId = "1"
                }
            );

            //Seed the employee account
            //Seeding the Employee User to AspNetUsers table
            modelBuilder.Entity<IdentityUser>().HasData(
                new IdentityUser
                {
                    Id = "2", // primary key
                    UserName = "Employee1",
                    NormalizedUserName = "EMPLOYEE1",
                    PasswordHash = hasher.HashPassword(null, "Test@123")
                }
            );


            //Seeding the relation between our user and role to AspNetUserRoles table
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "2",
                    UserId = "2"
                }
            );

            //Seed the farmer account
            //Seeding the farmer User to AspNetUsers table
            modelBuilder.Entity<IdentityUser>().HasData(
                new IdentityUser
                {
                    Id = "3", // primary key
                    UserName = "Farmer1",
                    NormalizedUserName = "FARMER1",
                    PasswordHash = hasher.HashPassword(null, "Test@123")
                }
            );


            //Seeding the relation between our user and role to AspNetUserRoles table
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "3",
                    UserId = "3"
                }
            );

            //Seed the customer account
            //Seeding the customer User to AspNetUsers table
            modelBuilder.Entity<IdentityUser>().HasData(
                new IdentityUser
                {
                    Id = "4", // primary key
                    UserName = "Customer1",
                    NormalizedUserName = "CUSTOMER1",
                    PasswordHash = hasher.HashPassword(null, "Test@123")
                }
            );


            //Seeding the relation between our user and role to AspNetUserRoles table
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "4",
                    UserId = "4"
                }
            );
        }

    }
}
