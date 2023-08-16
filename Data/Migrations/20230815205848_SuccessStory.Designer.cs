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
    [Migration("20230815205848_SuccessStory")]
    partial class SuccessStory
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

                    b.Property<string>("BlogDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BlogImage")
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

                    b.Property<string>("OurPersonImage")
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

                    b.Property<string>("SuccessStoryImage")
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
                            ConcurrencyStamp = "c45a921a-0bf0-4a53-a17e-5fc1c78f2e00",
                            Name = "Manager",
                            NormalizedName = "MANAGER"
                        },
                        new
                        {
                            Id = "2",
                            ConcurrencyStamp = "da854685-aa38-4518-8cf0-b5087976ca52",
                            Name = "Employee",
                            NormalizedName = "EMPLOYEE"
                        },
                        new
                        {
                            Id = "3",
                            ConcurrencyStamp = "54b2f243-1b42-432e-9e47-33b6e7eb66d2",
                            Name = "Volunteer",
                            NormalizedName = "VOLUNTEER"
                        },
                        new
                        {
                            Id = "4",
                            ConcurrencyStamp = "d6f40c82-6a91-4712-99e9-bf8c3a0e3528",
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
                            ConcurrencyStamp = "ab6f4e32-b815-4af3-bacd-2224c21885e1",
                            Email = "Manager1@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "MANAGER1@GMAIL.COM",
                            NormalizedUserName = "MANAGER1",
                            PasswordHash = "AQAAAAEAACcQAAAAEI+EsfYpgEkra/GIB3AzGhZJaIfHkgXS2lHXMTivz4ncYxUxNgvwBlKW7yOgjaUtBg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "f2d77ca2-bf2e-4120-b6ce-4029ab7c4044",
                            TwoFactorEnabled = false,
                            UserName = "Manager1"
                        },
                        new
                        {
                            Id = "2",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "da6e99a5-413f-4b3a-9a68-6e14c3b0769f",
                            Email = "Employee1@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "EMPLOYEE1@GMAIL.COM",
                            NormalizedUserName = "EMPLOYEE1",
                            PasswordHash = "AQAAAAEAACcQAAAAEL090ry09UETCOwMCn9uNHpc9EaiJjeD5gQNMG2N1kWQ5WvtPJFCnIc8OgTrvuzdkg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "bbd3a4b8-de29-46bd-b3ff-ea0e6ab69fc4",
                            TwoFactorEnabled = false,
                            UserName = "Employee1"
                        },
                        new
                        {
                            Id = "3",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "615db859-255d-4d3e-9e70-1901a2397d97",
                            Email = "Volunteer1@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "VOLUNTEER1@GMAIL.COM",
                            NormalizedUserName = "VOLUNTEER1",
                            PasswordHash = "AQAAAAEAACcQAAAAELmGHearTqlqy9AiMVZFPmdoR0Hpez1ejld7HgyLFSExP1/Jn3Z0gPJKpc06NtX1BQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "2352c80c-e668-4af2-a5bd-00cd0bd10070",
                            TwoFactorEnabled = false,
                            UserName = "Volunteer1"
                        },
                        new
                        {
                            Id = "4",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "8b5d1ffc-f16f-42db-ae6c-601efb64601f",
                            Email = "User1@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "USER1@GMAIL.COM",
                            NormalizedUserName = "USER1",
                            PasswordHash = "AQAAAAEAACcQAAAAEKBOtHd/F/TEeDDwfvv/wvmbhdjY3jCNFBDJsN1qpaT0MpxrKK57j2h7T7QpUOJJcw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "e6d51e10-153d-42a4-8dfb-a5e7cb84b54d",
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
