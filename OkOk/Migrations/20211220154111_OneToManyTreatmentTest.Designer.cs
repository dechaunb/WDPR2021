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
    [Migration("20211220154111_OneToManyTreatmentTest")]
    partial class OneToManyTreatmentTest
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.0");

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
                            Id = "ca60e46e-f45a-4acf-ba6a-31731b64c6d9",
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

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
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

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUser");

                    b.HasData(
                        new
                        {
                            Id = "8a80fefa-44c6-435c-a438-6b87dc70e2ae",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "78135484-e3b6-40d7-8775-444c99610f96",
                            Email = "angelo@okokapp.nl",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "ANGELO@OKOKAPP.NL",
                            NormalizedUserName = "ANGELO@OKOKAPP.NL",
                            PasswordHash = "AQAAAAEAACcQAAAAEA0qxEkY+ITTlaheBhY2eJV9K6LOA/eghr4mBZQKxb7J9PLj0V5zMZe7VPH+IoIAUQ==",
                            PhoneNumber = "1234567890",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "529830ac-a0fa-4420-8425-be2f2f7f4ba4",
                            TwoFactorEnabled = false,
                            UserName = "angelo@okokapp.nl"
                        },
                        new
                        {
                            Id = "54dc975b-4075-4937-b530-a184b92c142e",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "7cfc72d2-9f7f-4943-83fc-2d826b61cd81",
                            Email = "dechaun@okokapp.nl",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "DECHAUN@OKOKAPP.NL",
                            NormalizedUserName = "DECHAUN@OKOKAPP.NL",
                            PasswordHash = "AQAAAAEAACcQAAAAEF1JEHaN6STP48qjWKpuP3vt31GIRoQrd+k8ic3+3g5wOLJO347sN7Lo6W7XyMjWrg==",
                            PhoneNumber = "1234567890",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "41e4840b-77b3-4898-9364-09f1ec80fab7",
                            TwoFactorEnabled = false,
                            UserName = "dechaun@okokapp.nl"
                        },
                        new
                        {
                            Id = "5fc5eee9-60fd-4e0e-9a46-ffee3ef1b314",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "0d3f137c-f247-43f5-b6a5-31e5c949e7bd",
                            Email = "timothy@okokapp.nl",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "TIMOTHY@OKOKAPP.NL",
                            NormalizedUserName = "TIMOTHY@OKOKAPP.NL",
                            PasswordHash = "AQAAAAEAACcQAAAAENmhaQvO/SoETTqHll43VstHAeX6R98M2IoFbZfPkP70gZGw8DI5GzGjTpcUe+vCIQ==",
                            PhoneNumber = "1234567890",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "53c3c84f-35b7-424a-be5e-719f8b9d6af8",
                            TwoFactorEnabled = false,
                            UserName = "timothy@okokapp.nl"
                        },
                        new
                        {
                            Id = "b062a111-d60f-434b-9477-cbd06023d0a4",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "295e3392-c3a9-420b-a7e7-c1a4c55747f7",
                            Email = "yash@okokapp.nl",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "YASH@OKOKAPP.NL",
                            NormalizedUserName = "YASH@OKOKAPP.NL",
                            PasswordHash = "AQAAAAEAACcQAAAAEL4MKPSd5yVAOAkrWBcCR4egyUDYqQun5NEHZPIbJYOlS7p3rW9dAzdTC2ujvmmB3g==",
                            PhoneNumber = "1234567890",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "9d98efa2-80fc-45b4-b63c-f2432dd9cf80",
                            TwoFactorEnabled = false,
                            UserName = "yash@okokapp.nl"
                        });
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
                            UserId = "8a80fefa-44c6-435c-a438-6b87dc70e2ae",
                            RoleId = "ca60e46e-f45a-4acf-ba6a-31731b64c6d9"
                        },
                        new
                        {
                            UserId = "54dc975b-4075-4937-b530-a184b92c142e",
                            RoleId = "ca60e46e-f45a-4acf-ba6a-31731b64c6d9"
                        },
                        new
                        {
                            UserId = "5fc5eee9-60fd-4e0e-9a46-ffee3ef1b314",
                            RoleId = "ca60e46e-f45a-4acf-ba6a-31731b64c6d9"
                        },
                        new
                        {
                            UserId = "b062a111-d60f-434b-9477-cbd06023d0a4",
                            RoleId = "ca60e46e-f45a-4acf-ba6a-31731b64c6d9"
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

                    b.ToTable("Address");
                });

            modelBuilder.Entity("OkOk.Models.SignUpRequest", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("DoctorApplicationUserId")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Handled")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("DoctorApplicationUserId");

                    b.ToTable("SignUpRequest");
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

                    b.ToTable("Treatment");
                });

            modelBuilder.Entity("OkOk.Models.Identity.ClientApplicationUser", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<Guid>("AddressId")
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .ValueGeneratedOnUpdateSometimes()
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .ValueGeneratedOnUpdateSometimes()
                        .HasColumnType("TEXT");

                    b.Property<bool>("OldEnough")
                        .HasColumnType("INTEGER");

                    b.HasIndex("AddressId");

                    b.HasDiscriminator().HasValue("ClientApplicationUser");
                });

            modelBuilder.Entity("OkOk.Models.Identity.DoctorApplicationUser", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .ValueGeneratedOnUpdateSometimes()
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .ValueGeneratedOnUpdateSometimes()
                        .HasColumnType("TEXT");

                    b.Property<string>("Specialism")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasDiscriminator().HasValue("DoctorApplicationUser");
                });

            modelBuilder.Entity("OkOk.Models.Identity.GuardianApplicationUser", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .ValueGeneratedOnUpdateSometimes()
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .ValueGeneratedOnUpdateSometimes()
                        .HasColumnType("TEXT");

                    b.HasDiscriminator().HasValue("GuardianApplicationUser");
                });

            modelBuilder.Entity("GuardianChild", b =>
                {
                    b.HasOne("OkOk.Models.Identity.ClientApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("ChildId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_GuardianChild_Children_ChildId");

                    b.HasOne("OkOk.Models.Identity.GuardianApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("GuardianId")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired()
                        .HasConstraintName("FK_GuardianChild_Guardians_GuardianId");
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

            modelBuilder.Entity("OkOk.Models.SignUpRequest", b =>
                {
                    b.HasOne("OkOk.Models.Identity.DoctorApplicationUser", null)
                        .WithMany("SignUpRequests")
                        .HasForeignKey("DoctorApplicationUserId");
                });

            modelBuilder.Entity("OkOk.Models.Treatment", b =>
                {
                    b.HasOne("OkOk.Models.Identity.ClientApplicationUser", "ClientApplicationUser")
                        .WithMany("Treatments")
                        .HasForeignKey("ClientId");

                    b.HasOne("OkOk.Models.Identity.DoctorApplicationUser", "DoctorApplicationUser")
                        .WithMany("Treatments")
                        .HasForeignKey("DoctorId");

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

            modelBuilder.Entity("OkOk.Models.Identity.ClientApplicationUser", b =>
                {
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
