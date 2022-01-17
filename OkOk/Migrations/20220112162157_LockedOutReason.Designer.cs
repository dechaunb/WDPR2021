﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OkOk.Data;

#nullable disable

namespace OkOk.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220112162157_LockedOutReason")]
    partial class LockedOutReason
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.1");

            modelBuilder.Entity("ChatApplicationUserSupportGroup", b =>
                {
                    b.Property<string>("ChatUserId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("GroupId")
                        .HasColumnType("TEXT");

                    b.HasKey("ChatUserId", "GroupId");

                    b.HasIndex("GroupId");

                    b.ToTable("ChatApplicationUserSupportGroup");
                });

            modelBuilder.Entity("GuardianChild", b =>
                {
                    b.Property<string>("ChildId")
                        .HasColumnType("TEXT");

                    b.Property<string>("GuardianId")
                        .HasColumnType("TEXT");

                    b.HasKey("ChildId", "GuardianId");

                    b.HasIndex("GuardianId");

                    b.ToTable("GuardianChild");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "af19af82-a608-462a-92b5-dae351070f22",
                            ConcurrencyStamp = "1",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "fd73af46-b9b1-43db-94c8-505b5cc7c31f",
                            RoleId = "af19af82-a608-462a-92b5-dae351070f22"
                        },
                        new
                        {
                            UserId = "5874f7ed-e3b2-487a-823f-df7fe8d1d81a",
                            RoleId = "af19af82-a608-462a-92b5-dae351070f22"
                        },
                        new
                        {
                            UserId = "63fda3aa-cf2d-4ad6-91cf-8bf1073ade7e",
                            RoleId = "af19af82-a608-462a-92b5-dae351070f22"
                        },
                        new
                        {
                            UserId = "0048e49d-7be3-4642-8058-8e78c2fd406d",
                            RoleId = "af19af82-a608-462a-92b5-dae351070f22"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("OkOk.Models.Address", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("HouseNumber")
                        .HasColumnType("INTEGER");

                    b.Property<string>("HouseNumberAddition")
                        .HasColumnType("TEXT");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("OkOk.Models.Identity.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LockedOutReason")
                        .HasColumnType("TEXT");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("TEXT");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasDiscriminator<string>("Discriminator").HasValue("ApplicationUser");

                    b.HasData(
                        new
                        {
                            Id = "fd73af46-b9b1-43db-94c8-505b5cc7c31f",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "9dee6739-03c5-400b-a42e-5e2ad96e9df1",
                            Email = "angelo@okokapp.nl",
                            EmailConfirmed = true,
                            FirstName = "Angelo",
                            LastName = "OkOk",
                            LockoutEnabled = false,
                            NormalizedEmail = "ANGELO@OKOKAPP.NL",
                            NormalizedUserName = "ANGELO@OKOKAPP.NL",
                            PasswordHash = "AQAAAAEAACcQAAAAEBqw7zfhdGhqo5S/WW604SDyW1/WOZq/rph83c3Vj3ug5fsD2HKXI7ZZr/GipG6AgA==",
                            PhoneNumber = "1234567890",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "14cc3885-85d5-4a6d-ab8c-d716917bacda",
                            TwoFactorEnabled = false,
                            UserName = "angelo@okokapp.nl"
                        },
                        new
                        {
                            Id = "5874f7ed-e3b2-487a-823f-df7fe8d1d81a",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "3208d057-a254-4b6b-9911-ea90e03c78bd",
                            Email = "dechaun@okokapp.nl",
                            EmailConfirmed = true,
                            FirstName = "Dechaun",
                            LastName = "OkOk",
                            LockoutEnabled = false,
                            NormalizedEmail = "DECHAUN@OKOKAPP.NL",
                            NormalizedUserName = "DECHAUN@OKOKAPP.NL",
                            PasswordHash = "AQAAAAEAACcQAAAAEIYvhXHNQ68n1ZDZJF5PGgOwtj2bPKuP5Q28rBljyTNjn2AqMy/HgV9vaeqjMLxpXA==",
                            PhoneNumber = "1234567890",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "cfe43a04-0917-4aae-9d44-e36d1be468e2",
                            TwoFactorEnabled = false,
                            UserName = "dechaun@okokapp.nl"
                        },
                        new
                        {
                            Id = "63fda3aa-cf2d-4ad6-91cf-8bf1073ade7e",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "1af2d5d3-7480-436a-817f-7bfc87a860c6",
                            Email = "timothy@okokapp.nl",
                            EmailConfirmed = true,
                            FirstName = "Timothy",
                            LastName = "OkOk",
                            LockoutEnabled = false,
                            NormalizedEmail = "TIMOTHY@OKOKAPP.NL",
                            NormalizedUserName = "TIMOTHY@OKOKAPP.NL",
                            PasswordHash = "AQAAAAEAACcQAAAAEDiuCKXNRw0k0dGNFNDVA2SOwmt1u8aPghc0y2rhB9Zp0XyDp8d6fNcsrQcfxIqT4w==",
                            PhoneNumber = "1234567890",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "4badbb5a-56f6-4767-aa56-5ea3ebcb9ba8",
                            TwoFactorEnabled = false,
                            UserName = "timothy@okokapp.nl"
                        },
                        new
                        {
                            Id = "0048e49d-7be3-4642-8058-8e78c2fd406d",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "3fd02b1f-8084-4817-b8c7-9ef4cc37948c",
                            Email = "yash@okokapp.nl",
                            EmailConfirmed = true,
                            FirstName = "Yash",
                            LastName = "OkOk",
                            LockoutEnabled = false,
                            NormalizedEmail = "YASH@OKOKAPP.NL",
                            NormalizedUserName = "YASH@OKOKAPP.NL",
                            PasswordHash = "AQAAAAEAACcQAAAAEKNosDRJ3kwSwse0dAAWUiiwEX86vC0u4KiEzIBXRKzz2x1jlInHt7gpx9xzZPSygQ==",
                            PhoneNumber = "1234567890",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "13165b1b-b253-4b9a-8804-9ddfc903ad66",
                            TwoFactorEnabled = false,
                            UserName = "yash@okokapp.nl"
                        });
                });

            modelBuilder.Entity("OkOk.Models.Message", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("GroupId")
                        .HasColumnType("TEXT");

                    b.Property<string>("SenderId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("GroupId");

                    b.HasIndex("SenderId");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("OkOk.Models.MessageReport", b =>
                {
                    b.Property<Guid>("MessageId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("ReportId")
                        .HasColumnType("TEXT");

                    b.HasKey("MessageId", "ReportId");

                    b.HasIndex("ReportId")
                        .IsUnique();

                    b.ToTable("MessageReports");
                });

            modelBuilder.Entity("OkOk.Models.Report", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Reports");
                });

            modelBuilder.Entity("OkOk.Models.SignUpRequest", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("ClientId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("DoctorId")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Handled")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ClientId")
                        .IsUnique();

                    b.HasIndex("DoctorId");

                    b.ToTable("SignUpRequests");
                });

            modelBuilder.Entity("OkOk.Models.SupportGroup", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("SupportGroups");
                });

            modelBuilder.Entity("OkOk.Models.Treatment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("ClientId")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("DoctorId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.HasIndex("DoctorId");

                    b.ToTable("Treatments");
                });

            modelBuilder.Entity("OkOk.Models.Identity.ChatApplicationUser", b =>
                {
                    b.HasBaseType("OkOk.Models.Identity.ApplicationUser");

                    b.HasDiscriminator().HasValue("ChatApplicationUser");
                });

            modelBuilder.Entity("OkOk.Models.Identity.GuardianApplicationUser", b =>
                {
                    b.HasBaseType("OkOk.Models.Identity.ApplicationUser");

                    b.HasDiscriminator().HasValue("GuardianApplicationUser");
                });

            modelBuilder.Entity("OkOk.Models.Identity.ClientApplicationUser", b =>
                {
                    b.HasBaseType("OkOk.Models.Identity.ChatApplicationUser");

                    b.Property<Guid>("AddressId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("ChatToken")
                        .HasColumnType("TEXT");

                    b.Property<bool>("OldEnough")
                        .HasColumnType("INTEGER");

                    b.HasIndex("AddressId");

                    b.HasDiscriminator().HasValue("ClientApplicationUser");
                });

            modelBuilder.Entity("OkOk.Models.Identity.DoctorApplicationUser", b =>
                {
                    b.HasBaseType("OkOk.Models.Identity.ChatApplicationUser");

                    b.Property<string>("Specialism")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasDiscriminator().HasValue("DoctorApplicationUser");
                });

            modelBuilder.Entity("ChatApplicationUserSupportGroup", b =>
                {
                    b.HasOne("OkOk.Models.Identity.ChatApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("ChatUserId")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.HasOne("OkOk.Models.SupportGroup", null)
                        .WithMany()
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GuardianChild", b =>
                {
                    b.HasOne("OkOk.Models.Identity.ClientApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("ChildId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OkOk.Models.Identity.GuardianApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("GuardianId")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
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
                    b.HasOne("OkOk.Models.Identity.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("OkOk.Models.Identity.ApplicationUser", null)
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

                    b.HasOne("OkOk.Models.Identity.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("OkOk.Models.Identity.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OkOk.Models.Message", b =>
                {
                    b.HasOne("OkOk.Models.SupportGroup", "SupportGroup")
                        .WithMany("Received")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.SetNull)
                        .IsRequired();

                    b.HasOne("OkOk.Models.Identity.ChatApplicationUser", "Sender")
                        .WithMany("Received")
                        .HasForeignKey("SenderId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("Sender");

                    b.Navigation("SupportGroup");
                });

            modelBuilder.Entity("OkOk.Models.MessageReport", b =>
                {
                    b.HasOne("OkOk.Models.Message", "Message")
                        .WithMany("MessageReports")
                        .HasForeignKey("MessageId")
                        .OnDelete(DeleteBehavior.SetNull)
                        .IsRequired();

                    b.HasOne("OkOk.Models.Report", "Report")
                        .WithOne("MessageReport")
                        .HasForeignKey("OkOk.Models.MessageReport", "ReportId")
                        .OnDelete(DeleteBehavior.SetNull)
                        .IsRequired();

                    b.Navigation("Message");

                    b.Navigation("Report");
                });

            modelBuilder.Entity("OkOk.Models.SignUpRequest", b =>
                {
                    b.HasOne("OkOk.Models.Identity.ClientApplicationUser", "ClientApplicationUser")
                        .WithOne("SignUpRequest")
                        .HasForeignKey("OkOk.Models.SignUpRequest", "ClientId")
                        .OnDelete(DeleteBehavior.SetNull)
                        .IsRequired();

                    b.HasOne("OkOk.Models.Identity.DoctorApplicationUser", "DoctorApplicationUser")
                        .WithMany("SignUpRequests")
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("ClientApplicationUser");

                    b.Navigation("DoctorApplicationUser");
                });

            modelBuilder.Entity("OkOk.Models.Treatment", b =>
                {
                    b.HasOne("OkOk.Models.Identity.ClientApplicationUser", "ClientApplicationUser")
                        .WithMany("Treatments")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("OkOk.Models.Identity.DoctorApplicationUser", "DoctorApplicationUser")
                        .WithMany("Treatments")
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("ClientApplicationUser");

                    b.Navigation("DoctorApplicationUser");
                });

            modelBuilder.Entity("OkOk.Models.Identity.ClientApplicationUser", b =>
                {
                    b.HasOne("OkOk.Models.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Address");
                });

            modelBuilder.Entity("OkOk.Models.Message", b =>
                {
                    b.Navigation("MessageReports");
                });

            modelBuilder.Entity("OkOk.Models.Report", b =>
                {
                    b.Navigation("MessageReport");
                });

            modelBuilder.Entity("OkOk.Models.SupportGroup", b =>
                {
                    b.Navigation("Received");
                });

            modelBuilder.Entity("OkOk.Models.Identity.ChatApplicationUser", b =>
                {
                    b.Navigation("Received");
                });

            modelBuilder.Entity("OkOk.Models.Identity.ClientApplicationUser", b =>
                {
                    b.Navigation("SignUpRequest");

                    b.Navigation("Treatments");
                });

            modelBuilder.Entity("OkOk.Models.Identity.DoctorApplicationUser", b =>
                {
                    b.Navigation("SignUpRequests");

                    b.Navigation("Treatments");
                });
#pragma warning restore 612, 618
        }
    }
}