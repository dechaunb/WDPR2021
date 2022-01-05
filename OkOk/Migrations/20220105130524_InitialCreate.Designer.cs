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
    [Migration("20220105130524_InitialCreate")]
    partial class InitialCreate
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
                            Id = "2db6cc93-83ed-4198-bbb4-6925cdbc9683",
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
                            UserId = "cba67af6-a922-4228-b97b-5373d412b69d",
                            RoleId = "2db6cc93-83ed-4198-bbb4-6925cdbc9683"
                        },
                        new
                        {
                            UserId = "2d7895f7-bae6-401b-81ae-ab9cd3797f8d",
                            RoleId = "2db6cc93-83ed-4198-bbb4-6925cdbc9683"
                        },
                        new
                        {
                            UserId = "e3395df1-d82c-4dba-81d0-73f9a7a64a4b",
                            RoleId = "2db6cc93-83ed-4198-bbb4-6925cdbc9683"
                        },
                        new
                        {
                            UserId = "cd08560b-d0f2-4f26-a4ef-3a537b50c4ce",
                            RoleId = "2db6cc93-83ed-4198-bbb4-6925cdbc9683"
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
                            Id = "cba67af6-a922-4228-b97b-5373d412b69d",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "aff9d907-589c-479c-a843-a56191d897be",
                            Email = "angelo@okokapp.nl",
                            EmailConfirmed = true,
                            FirstName = "Angelo",
                            LastName = "OkOk",
                            LockoutEnabled = false,
                            NormalizedEmail = "ANGELO@OKOKAPP.NL",
                            NormalizedUserName = "ANGELO@OKOKAPP.NL",
                            PasswordHash = "AQAAAAEAACcQAAAAEJ2YYKHOIPFlvP7ydl90hi6cxIR1lmdYgexBXW8J7BYvao85JUvK5nVspg6EdLDFJg==",
                            PhoneNumber = "1234567890",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "efd93414-0570-4018-8fe8-108a0acf199f",
                            TwoFactorEnabled = false,
                            UserName = "angelo@okokapp.nl"
                        },
                        new
                        {
                            Id = "2d7895f7-bae6-401b-81ae-ab9cd3797f8d",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "8b566023-b6b4-4805-a84d-29c77395f5f0",
                            Email = "dechaun@okokapp.nl",
                            EmailConfirmed = true,
                            FirstName = "Dechaun",
                            LastName = "OkOk",
                            LockoutEnabled = false,
                            NormalizedEmail = "DECHAUN@OKOKAPP.NL",
                            NormalizedUserName = "DECHAUN@OKOKAPP.NL",
                            PasswordHash = "AQAAAAEAACcQAAAAELlC0YDW0NmvchvxttJQ5x/+QsxEfCeZ0Rw8l4V0XufAxcWEx0gnzEE4yEc3cQN83g==",
                            PhoneNumber = "1234567890",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "aeac89ef-ba0e-4c81-9d04-d71b82a0584b",
                            TwoFactorEnabled = false,
                            UserName = "dechaun@okokapp.nl"
                        },
                        new
                        {
                            Id = "e3395df1-d82c-4dba-81d0-73f9a7a64a4b",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "41d16618-89cc-41b2-8ffb-8e50cd95af7f",
                            Email = "timothy@okokapp.nl",
                            EmailConfirmed = true,
                            FirstName = "Timothy",
                            LastName = "OkOk",
                            LockoutEnabled = false,
                            NormalizedEmail = "TIMOTHY@OKOKAPP.NL",
                            NormalizedUserName = "TIMOTHY@OKOKAPP.NL",
                            PasswordHash = "AQAAAAEAACcQAAAAEI9uHac9of8g3uimN8NZ99I2AH6jsbQA7xmn6c8ZyniD76vwvvf51mpKmMxoD0NjKQ==",
                            PhoneNumber = "1234567890",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "53aa99f3-fe8a-45ef-a5a2-d54c69231b12",
                            TwoFactorEnabled = false,
                            UserName = "timothy@okokapp.nl"
                        },
                        new
                        {
                            Id = "cd08560b-d0f2-4f26-a4ef-3a537b50c4ce",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "4be22ee2-6d9f-4962-8d47-9ccce1113862",
                            Email = "yash@okokapp.nl",
                            EmailConfirmed = true,
                            FirstName = "Yash",
                            LastName = "OkOk",
                            LockoutEnabled = false,
                            NormalizedEmail = "YASH@OKOKAPP.NL",
                            NormalizedUserName = "YASH@OKOKAPP.NL",
                            PasswordHash = "AQAAAAEAACcQAAAAEJspJ0R9h1lsKSZTOJ0osQ+nRuuxP8pinASuY44JS3BrVB52I+dvwGzLCI4A7DBSGQ==",
                            PhoneNumber = "1234567890",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "973ba1b0-f342-407c-ae19-e03ba6158268",
                            TwoFactorEnabled = false,
                            UserName = "yash@okokapp.nl"
                        });
                });

            modelBuilder.Entity("OkOk.Models.Message", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("ChatUserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("GroupId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ChatUserId");

                    b.HasIndex("GroupId");

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

                    b.Property<Guid>("ChatUserId")
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
                    b.HasOne("OkOk.Models.Identity.ChatApplicationUser", "ChatApplicationUser")
                        .WithMany("Messages")
                        .HasForeignKey("ChatUserId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("OkOk.Models.SupportGroup", "SupportGroup")
                        .WithMany("Messages")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.SetNull)
                        .IsRequired();

                    b.Navigation("ChatApplicationUser");

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
                    b.Navigation("Messages");
                });

            modelBuilder.Entity("OkOk.Models.Identity.ChatApplicationUser", b =>
                {
                    b.Navigation("Messages");
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
