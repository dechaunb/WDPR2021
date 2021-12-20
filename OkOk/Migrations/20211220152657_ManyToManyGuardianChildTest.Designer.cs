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
    [Migration("20211220152657_ManyToManyGuardianChildTest")]
    partial class ManyToManyGuardianChildTest
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
                            Id = "056937bb-1d6c-488a-a629-0212959e8834",
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
                            Id = "610b0cc0-6f19-46e2-b033-e290ddd6c0b1",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "88a2b8c2-0a30-4209-a7b2-4b9565c3be75",
                            Email = "angelo@okokapp.nl",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "ANGELO@OKOKAPP.NL",
                            NormalizedUserName = "ANGELO@OKOKAPP.NL",
                            PasswordHash = "AQAAAAEAACcQAAAAEDrdhXIQ9lvtVrVmyvGkuE4JXxZpgo5LCVIo33kPZ1V3+H3hfKCJPFjI8I0BX1CbTw==",
                            PhoneNumber = "1234567890",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "c66f49f3-d35d-46db-abd7-721c9bebffe8",
                            TwoFactorEnabled = false,
                            UserName = "angelo@okokapp.nl"
                        },
                        new
                        {
                            Id = "c266a7fe-6e83-4275-a09e-d48956cb9a2d",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "fa74d86f-2a64-4120-a192-2a7f5a8b08f4",
                            Email = "dechaun@okokapp.nl",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "DECHAUN@OKOKAPP.NL",
                            NormalizedUserName = "DECHAUN@OKOKAPP.NL",
                            PasswordHash = "AQAAAAEAACcQAAAAELOLhERSwZ2Ym9HEYE8mwKmX+ge7IYzK1Fpz8C/K3AQf8XaBEkF/AUaadhAM/q5RuA==",
                            PhoneNumber = "1234567890",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "524907d0-88d6-4ab1-9697-a4fdab0522f3",
                            TwoFactorEnabled = false,
                            UserName = "dechaun@okokapp.nl"
                        },
                        new
                        {
                            Id = "24ead0cf-877e-4ec2-b325-ce67c4236b7f",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "a0b96649-ff70-4ee2-b5fe-9efe4da86fad",
                            Email = "timothy@okokapp.nl",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "TIMOTHY@OKOKAPP.NL",
                            NormalizedUserName = "TIMOTHY@OKOKAPP.NL",
                            PasswordHash = "AQAAAAEAACcQAAAAEBMcmlHrTP9DxVhSnlXgJ+WScZ7GYn0WrTl4whc04NBhOIkuUYAz0GlOOl5UXMhCnw==",
                            PhoneNumber = "1234567890",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "716abd7a-3372-47a5-9e3d-59a743c38417",
                            TwoFactorEnabled = false,
                            UserName = "timothy@okokapp.nl"
                        },
                        new
                        {
                            Id = "7b824801-f924-462d-aae0-49d1656c6a9f",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "d13b34b1-7a1e-44cd-acfc-0ee01ffbe2c3",
                            Email = "yash@okokapp.nl",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "YASH@OKOKAPP.NL",
                            NormalizedUserName = "YASH@OKOKAPP.NL",
                            PasswordHash = "AQAAAAEAACcQAAAAEO7GrH0oL9JuPOJgiuPvBTULHM5DdvM2TU/oj9ZFqAzSH2TlajyapKRKORkkTae4CA==",
                            PhoneNumber = "1234567890",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "4ada1396-b106-4aa4-8ede-96d9832f8820",
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
                            UserId = "610b0cc0-6f19-46e2-b033-e290ddd6c0b1",
                            RoleId = "056937bb-1d6c-488a-a629-0212959e8834"
                        },
                        new
                        {
                            UserId = "c266a7fe-6e83-4275-a09e-d48956cb9a2d",
                            RoleId = "056937bb-1d6c-488a-a629-0212959e8834"
                        },
                        new
                        {
                            UserId = "24ead0cf-877e-4ec2-b325-ce67c4236b7f",
                            RoleId = "056937bb-1d6c-488a-a629-0212959e8834"
                        },
                        new
                        {
                            UserId = "7b824801-f924-462d-aae0-49d1656c6a9f",
                            RoleId = "056937bb-1d6c-488a-a629-0212959e8834"
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

            modelBuilder.Entity("OkOk.Models.Treatment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("ClientApplicationUserId")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ClientApplicationUserId");

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

            modelBuilder.Entity("OkOk.Models.Treatment", b =>
                {
                    b.HasOne("OkOk.Models.Identity.ClientApplicationUser", null)
                        .WithMany("Treatments")
                        .HasForeignKey("ClientApplicationUserId");
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
#pragma warning restore 612, 618
        }
    }
}
