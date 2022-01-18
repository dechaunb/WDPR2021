﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OkOk.Data;

#nullable disable

namespace OkOk.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

            modelBuilder.Entity("MessageChatapplicationUser", b =>
                {
                    b.Property<string>("ChatUserId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("MessageId")
                        .HasColumnType("TEXT");

                    b.HasKey("ChatUserId", "MessageId");

                    b.HasIndex("MessageId");

                    b.ToTable("MessageChatapplicationUser");
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
                            Id = "7fc5c0d9-7c58-4542-a1f9-b9b5d16e6255",
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
                            UserId = "d2625ac3-b544-434d-81b0-b1e267504ea7",
                            RoleId = "7fc5c0d9-7c58-4542-a1f9-b9b5d16e6255"
                        },
                        new
                        {
                            UserId = "53f62527-7337-4ba7-aea1-190f03808d9d",
                            RoleId = "7fc5c0d9-7c58-4542-a1f9-b9b5d16e6255"
                        },
                        new
                        {
                            UserId = "f1bbc63e-b551-4792-84c2-e02f43cca68f",
                            RoleId = "7fc5c0d9-7c58-4542-a1f9-b9b5d16e6255"
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
                            Id = "d2625ac3-b544-434d-81b0-b1e267504ea7",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "5f51ba52-4ead-459f-b64b-07d5dcbb7450",
                            Email = "angelo@okokapp.nl",
                            EmailConfirmed = true,
                            FirstName = "Angelo",
                            LastName = "OkOk",
                            LockoutEnabled = false,
                            NormalizedEmail = "ANGELO@OKOKAPP.NL",
                            NormalizedUserName = "ANGELO@OKOKAPP.NL",
                            PasswordHash = "AQAAAAEAACcQAAAAEDO0KoQX3geOUVyPCjxFr5zIa0x36Sa9GWNDfF0ZYcn8vwkEOxtFkqqGJCOX1+Pl0g==",
                            PhoneNumber = "1234567890",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "99f94423-02ab-44fc-83e5-ea37e3810fc0",
                            TwoFactorEnabled = false,
                            UserName = "angelo@okokapp.nl"
                        },
                        new
                        {
                            Id = "53f62527-7337-4ba7-aea1-190f03808d9d",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "8db079dc-7bbb-4175-bc84-a589d03f91fc",
                            Email = "dechaun@okokapp.nl",
                            EmailConfirmed = true,
                            FirstName = "Dechaun",
                            LastName = "OkOk",
                            LockoutEnabled = false,
                            NormalizedEmail = "DECHAUN@OKOKAPP.NL",
                            NormalizedUserName = "DECHAUN@OKOKAPP.NL",
                            PasswordHash = "AQAAAAEAACcQAAAAEKMltFh3o/ZO/pX8zcK9J6BqMMjjpq0+vuO2/LP8/hGY3+qctYomy4X5mjPE1uo1rA==",
                            PhoneNumber = "1234567890",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "8949840a-3c52-4262-be4e-07143a3f74a5",
                            TwoFactorEnabled = false,
                            UserName = "dechaun@okokapp.nl"
                        },
                        new
                        {
                            Id = "f1bbc63e-b551-4792-84c2-e02f43cca68f",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "3649ba95-4d6f-4485-bcef-ada4290f0765",
                            Email = "timothy@okokapp.nl",
                            EmailConfirmed = true,
                            FirstName = "Timothy",
                            LastName = "OkOk",
                            LockoutEnabled = false,
                            NormalizedEmail = "TIMOTHY@OKOKAPP.NL",
                            NormalizedUserName = "TIMOTHY@OKOKAPP.NL",
                            PasswordHash = "AQAAAAEAACcQAAAAEIKkHp2u6GMlOHykrVySqlIOAo9DK0y+MbMMn4mJy3gRe6HnTM0HLHRAvbMitteZIQ==",
                            PhoneNumber = "1234567890",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "c0ef3f07-4aa6-4b35-964f-3a087ac6750c",
                            TwoFactorEnabled = false,
                            UserName = "timothy@okokapp.nl"
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

                    b.Property<Guid?>("GroupId")
                        .HasColumnType("TEXT");

                    b.Property<string>("SenderId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("GroupId");

                    b.HasIndex("SenderId");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("OkOk.Models.MessageReport", b =>
                {
                    b.Property<Guid?>("MessageId")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("ReportId")
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

                    b.Property<bool>("Handled")
                        .HasColumnType("INTEGER");

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
                        .IsRequired()
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
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("DoctorId")
                        .IsRequired()
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

                    b.Property<Guid?>("AddressId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("ChatToken")
                        .HasColumnType("TEXT");

                    b.Property<bool>("OldEnough")
                        .HasColumnType("INTEGER");

                    b.HasIndex("AddressId")
                        .IsUnique();

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

            modelBuilder.Entity("MessageChatapplicationUser", b =>
                {
                    b.HasOne("OkOk.Models.Identity.ChatApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("ChatUserId")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.HasOne("OkOk.Models.Message", null)
                        .WithMany()
                        .HasForeignKey("MessageId")
                        .OnDelete(DeleteBehavior.Cascade)
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
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("OkOk.Models.Identity.ChatApplicationUser", "Sender")
                        .WithMany("Sent")
                        .HasForeignKey("SenderId")
                        .OnDelete(DeleteBehavior.SetNull)
                        .IsRequired();

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
                        .OnDelete(DeleteBehavior.SetNull)
                        .IsRequired();

                    b.Navigation("ClientApplicationUser");

                    b.Navigation("DoctorApplicationUser");
                });

            modelBuilder.Entity("OkOk.Models.Treatment", b =>
                {
                    b.HasOne("OkOk.Models.Identity.ClientApplicationUser", "ClientApplicationUser")
                        .WithMany("Treatments")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.SetNull)
                        .IsRequired();

                    b.HasOne("OkOk.Models.Identity.DoctorApplicationUser", "DoctorApplicationUser")
                        .WithMany("Treatments")
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.SetNull)
                        .IsRequired();

                    b.Navigation("ClientApplicationUser");

                    b.Navigation("DoctorApplicationUser");
                });

            modelBuilder.Entity("OkOk.Models.Identity.ClientApplicationUser", b =>
                {
                    b.HasOne("OkOk.Models.Address", "Address")
                        .WithOne("ClientApplicationUser")
                        .HasForeignKey("OkOk.Models.Identity.ClientApplicationUser", "AddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Address");
                });

            modelBuilder.Entity("OkOk.Models.Address", b =>
                {
                    b.Navigation("ClientApplicationUser")
                        .IsRequired();
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
                    b.Navigation("Sent");
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
