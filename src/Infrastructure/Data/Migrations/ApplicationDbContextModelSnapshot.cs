﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebhelpChallengeBackend.Infrastructure.Data;

#nullable disable

namespace WebhelpChallengeBackend.Infrastructure.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

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

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
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

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
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

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("WebhelpChallengeBackend.Domain.Entities.Area", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Areas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Finanzas"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Talento Humano"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Mercadeo"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Operaciones"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Informática"
                        });
                });

            modelBuilder.Entity("WebhelpChallengeBackend.Domain.Entities.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Countries");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Canadá"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Estados Unidos"
                        },
                        new
                        {
                            Id = 3,
                            Name = "México"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Guatemala"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Belice"
                        },
                        new
                        {
                            Id = 6,
                            Name = "El Salvador"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Honduras"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Nicaragua"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Costa Rica"
                        },
                        new
                        {
                            Id = 10,
                            Name = "Panamá"
                        });
                });

            modelBuilder.Entity("WebhelpChallengeBackend.Domain.Entities.DocumentType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("DocumentTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "DUI"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Pasaporte"
                        });
                });

            modelBuilder.Entity("WebhelpChallengeBackend.Domain.Entities.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AreaId")
                        .HasColumnType("int");

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("DocumentNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DocumentTypeId")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateOnly>("HiringDate")
                        .HasColumnType("date");

                    b.Property<string>("LastNames")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SubAreaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AreaId");

                    b.HasIndex("CountryId");

                    b.HasIndex("DocumentTypeId");

                    b.HasIndex("SubAreaId");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AreaId = 5,
                            CountryId = 6,
                            DocumentNumber = "062094829",
                            DocumentTypeId = 1,
                            FirstName = "Fabio Ernesto",
                            HiringDate = new DateOnly(2024, 1, 7),
                            LastNames = "Guardado Gil",
                            SubAreaId = 11
                        },
                        new
                        {
                            Id = 2,
                            AreaId = 5,
                            CountryId = 6,
                            DocumentNumber = "062359236",
                            DocumentTypeId = 1,
                            FirstName = "Kevin Armando",
                            HiringDate = new DateOnly(2024, 1, 7),
                            LastNames = "Grande Chávez",
                            SubAreaId = 10
                        },
                        new
                        {
                            Id = 3,
                            AreaId = 4,
                            CountryId = 6,
                            DocumentNumber = "123658522",
                            DocumentTypeId = 1,
                            FirstName = "Kimberly Aronet",
                            HiringDate = new DateOnly(2024, 1, 7),
                            LastNames = "Vásquez Rodriguez",
                            SubAreaId = 9
                        },
                        new
                        {
                            Id = 4,
                            AreaId = 1,
                            CountryId = 7,
                            DocumentNumber = "0623598456",
                            DocumentTypeId = 2,
                            FirstName = "Nelson Alberto",
                            HiringDate = new DateOnly(2024, 1, 7),
                            LastNames = "Serrano López",
                            SubAreaId = 1
                        },
                        new
                        {
                            Id = 5,
                            AreaId = 1,
                            CountryId = 6,
                            DocumentNumber = "555141659",
                            DocumentTypeId = 1,
                            FirstName = "Mónica Alejandra",
                            HiringDate = new DateOnly(2024, 1, 7),
                            LastNames = "Reyes Ramos",
                            SubAreaId = 2
                        },
                        new
                        {
                            Id = 6,
                            AreaId = 1,
                            CountryId = 3,
                            DocumentNumber = "654658987",
                            DocumentTypeId = 2,
                            FirstName = "Alejandro Andrés",
                            HiringDate = new DateOnly(2024, 1, 7),
                            LastNames = "Nuila Santos",
                            SubAreaId = 2
                        });
                });

            modelBuilder.Entity("WebhelpChallengeBackend.Domain.Entities.SubArea", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SubAreas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Financiamiento"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Auditoría"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Contrataciones"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Capacitación y Desarrollo"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Ventas"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Publicidad"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Gestión de Proveedores"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Inventario"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Planificación"
                        },
                        new
                        {
                            Id = 10,
                            Name = "Soporte Técnico"
                        },
                        new
                        {
                            Id = 11,
                            Name = "Desarrollo de Software y Bases de Datos"
                        },
                        new
                        {
                            Id = 12,
                            Name = "Redes e Infraestructura"
                        });
                });

            modelBuilder.Entity("WebhelpChallengeBackend.Infrastructure.Identity.ApplicationUser", b =>
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

                    b.ToTable("AspNetUsers", (string)null);
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
                    b.HasOne("WebhelpChallengeBackend.Infrastructure.Identity.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("WebhelpChallengeBackend.Infrastructure.Identity.ApplicationUser", null)
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

                    b.HasOne("WebhelpChallengeBackend.Infrastructure.Identity.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("WebhelpChallengeBackend.Infrastructure.Identity.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WebhelpChallengeBackend.Domain.Entities.Employee", b =>
                {
                    b.HasOne("WebhelpChallengeBackend.Domain.Entities.Area", "Area")
                        .WithMany()
                        .HasForeignKey("AreaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebhelpChallengeBackend.Domain.Entities.Country", "Country")
                        .WithMany()
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebhelpChallengeBackend.Domain.Entities.DocumentType", "DocumentType")
                        .WithMany()
                        .HasForeignKey("DocumentTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebhelpChallengeBackend.Domain.Entities.SubArea", "SubArea")
                        .WithMany()
                        .HasForeignKey("SubAreaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Area");

                    b.Navigation("Country");

                    b.Navigation("DocumentType");

                    b.Navigation("SubArea");
                });
#pragma warning restore 612, 618
        }
    }
}
