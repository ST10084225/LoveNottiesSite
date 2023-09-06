﻿// <auto-generated />
using System;
using LoveNottiesV2.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LoveNottiesV2.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230831104504_ModelUpdate")]
    partial class ModelUpdate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LoveNottiesV2.Models.BlogItem", b =>
                {
                    b.Property<string>("BlogID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("BlogDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BlogDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BlogImageID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BlogTag")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BlogTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BlogViews")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BlogID");

                    b.ToTable("BlogItems");
                });

            modelBuilder.Entity("LoveNottiesV2.Models.OurPeople", b =>
                {
                    b.Property<string>("OurPersonID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("OurPersonDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OurPersonFirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OurPersonImageID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OurPersonLastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OurPersonTitle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("OurPersonID");

                    b.ToTable("OurPeoples");
                });

            modelBuilder.Entity("LoveNottiesV2.Models.SuccessStory", b =>
                {
                    b.Property<string>("SuccessStoryID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("SuccessStoryDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SuccessStoryImageID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SuccessStoryTitle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SuccessStoryID");

                    b.ToTable("successStories");
                });

            modelBuilder.Entity("LoveNottiesV2.Models.Volunteer", b =>
                {
                    b.Property<string>("VolunteerID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("VolunteerName")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("VolunteerCell")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VolunteerEmail")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("VolunteerID", "VolunteerName");

                    b.ToTable("Volunteers");

                    b.HasData(
                        new
                        {
                            VolunteerID = "1",
                            VolunteerName = "Sivan Moodley",
                            VolunteerCell = "0815750712",
                            VolunteerEmail = "sivan.moodley02@gmail.com"
                        });
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

                    b.ToTable("AspNetRoles");

                    b.HasData(
                        new
                        {
                            Id = "1",
                            ConcurrencyStamp = "6657240c-bd5c-4f59-b39d-1ae78b21c677",
                            Name = "Manager",
                            NormalizedName = "MANAGER"
                        },
                        new
                        {
                            Id = "2",
                            ConcurrencyStamp = "ed890465-1e6c-4287-98d4-9d376c250bee",
                            Name = "Employee",
                            NormalizedName = "EMPLOYEE"
                        },
                        new
                        {
                            Id = "3",
                            ConcurrencyStamp = "6d63a861-d9ef-48cc-9225-07aa64bc34f5",
                            Name = "Volunteer",
                            NormalizedName = "VOLUNTEER"
                        },
                        new
                        {
                            Id = "4",
                            ConcurrencyStamp = "9af34114-b501-4cb1-82d3-0b93cf40c230",
                            Name = "User",
                            NormalizedName = "USER"
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
                            ConcurrencyStamp = "f30cbdd4-f388-4e2f-bd50-de340a64532f",
                            Email = "Manager1@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "MANAGER1@GMAIL.COM",
                            NormalizedUserName = "MANAGER1",
                            PasswordHash = "AQAAAAEAACcQAAAAEGL6O8UBgYeTyXmrtAvVAbRVEar1SXZeJpYcQdKoJhrn1O1ZX4K59NqLSqzkZy11Rg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "cc8e3d36-d9d7-4bc7-a9af-bcaba159cb13",
                            TwoFactorEnabled = false,
                            UserName = "Manager1"
                        },
                        new
                        {
                            Id = "2",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "f589b741-776e-4918-9b85-77407d470dd8",
                            Email = "Employee1@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "EMPLOYEE1@GMAIL.COM",
                            NormalizedUserName = "EMPLOYEE1",
                            PasswordHash = "AQAAAAEAACcQAAAAEHr95RK9W+FlypCBsC96+qTKohXSvByzkNH5JGvBee11nGZL9zMQPgQdhSIc5Piy0Q==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "fff0e89b-2c86-43ae-9fa1-8fa0d0018611",
                            TwoFactorEnabled = false,
                            UserName = "Employee1"
                        },
                        new
                        {
                            Id = "3",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "28de2208-e60f-4ac9-84a9-f707f4f2bf8b",
                            Email = "Volunteer1@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "VOLUNTEER1@GMAIL.COM",
                            NormalizedUserName = "VOLUNTEER1",
                            PasswordHash = "AQAAAAEAACcQAAAAENY9Fd1z9bzJMLpq95B3xIzcwpURlRBL/PhoAJD18dQKW2x+Ll06I68wDOSrS07glA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "eb03522d-61ee-4f22-92dc-b8cbc6222fc2",
                            TwoFactorEnabled = false,
                            UserName = "Volunteer1"
                        },
                        new
                        {
                            Id = "4",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "cc019cb9-3925-4e03-b367-21c9569f0e9f",
                            Email = "User1@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "USER1@GMAIL.COM",
                            NormalizedUserName = "USER1",
                            PasswordHash = "AQAAAAEAACcQAAAAEG8DnRKE95Z9b1EGIdsQ1NZhUMQKvQpOrfcWLAldEBLRHxRJ5cuSCMWq54D6R3C+Tg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "b056f5bb-70c6-4169-b888-b2f235e75149",
                            TwoFactorEnabled = false,
                            UserName = "User1"
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
