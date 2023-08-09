using LoveNottiesV2.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace LoveNottiesV2.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {
        }

        public DbSet<Volunteer> Volunteers { get; set; }
        public DbSet<BlogItem> BlogItems { get; set; }
        public DbSet<OurPeople> OurPeoples { get; set; }


        //Seeding --> 2 tables --categories --> onModelCreating
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Volunteer>().HasKey(volunteers => new { volunteers.VolunteerID, volunteers.VolunteerName });
            modelBuilder.Entity<BlogItem>().HasKey(blogItems => new { blogItems.BlogID });
            modelBuilder.Entity<OurPeople>().HasKey(ourPeople => new { ourPeople.OurPersonID });

            //Farmer Seed Data 
            modelBuilder.Entity<Volunteer>().HasData(new Volunteer { VolunteerID = "1", VolunteerName = "Sivan Moodley", VolunteerCell = "0815750712" , VolunteerEmail = "sivan.moodley02@gmail.com"});

            //Seeding roles to AspNetRoles table
            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole { Id = "1", Name = "Manager", NormalizedName = "Manager".ToUpper() });
            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole { Id = "2", Name = "Employee", NormalizedName = "Employee".ToUpper() });
            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole { Id = "3", Name = "Volunteer", NormalizedName = "Volunteer".ToUpper() });
            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole { Id = "4", Name = "User", NormalizedName = "User".ToUpper() });


            //a hasher to hash the password before seeding the user to the db
            var hasher = new PasswordHasher<IdentityUser>();

            //Seed a Manager Account
            //Seeding the Manager User to AspNetUsers table
            modelBuilder.Entity<IdentityUser>().HasData(
                new IdentityUser
                {
                    Id = "1", // primary key
                    Email = "Manager1@gmail.com",
                    NormalizedEmail = "Manager1@gmail.com".ToUpper(),
                    UserName = "Manager1",
                    NormalizedUserName = "MANAGER1",
                    PasswordHash = hasher.HashPassword(null, "Test@123")
                }
            ) ;


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
                    Email = "Employee1@gmail.com",
                    NormalizedEmail = "Employee1@gmail.com".ToUpper(),
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
                    Email = "Volunteer1@gmail.com",
                    NormalizedEmail = "Volunteer1@gmail.com".ToUpper(),
                    UserName = "Volunteer1",
                    NormalizedUserName = "Volunteer1".ToUpper(),
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
                    Email = "User1@gmail.com",
                    NormalizedEmail = "User1@gmail.com".ToUpper(),
                    UserName = "User1",
                    NormalizedUserName = "User1".ToUpper(),
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
