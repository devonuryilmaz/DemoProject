﻿// <auto-generated />
using System;
using BackendDemoProject.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace BackendDemoProject.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210706225632_firstMig")]
    partial class firstMig
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("BackendDemoProject.Core.Entities.ActionType", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<int?>("ModifiedBy")
                        .HasColumnType("integer");

                    b.Property<DateTime>("ModifyDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.HasKey("ID");

                    b.HasIndex("CreatedBy");

                    b.HasIndex("ModifiedBy");

                    b.ToTable("ActionType");
                });

            modelBuilder.Entity("BackendDemoProject.Core.Entities.Maintenance", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<DateTime>("ExpectedTimeToFix")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("LocationLatitude")
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)");

                    b.Property<string>("LocationLongitude")
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)");

                    b.Property<int?>("ModifiedBy")
                        .HasColumnType("integer");

                    b.Property<DateTime>("ModifyDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("PictureGroupID")
                        .HasColumnType("integer");

                    b.Property<int>("ResponsibleUserID")
                        .HasColumnType("integer");

                    b.Property<int>("StatusID")
                        .HasColumnType("integer");

                    b.Property<int>("UserID")
                        .HasColumnType("integer");

                    b.Property<int>("VehicleID")
                        .HasColumnType("integer");

                    b.HasKey("ID");

                    b.HasIndex("CreatedBy");

                    b.HasIndex("ModifiedBy");

                    b.HasIndex("PictureGroupID");

                    b.HasIndex("ResponsibleUserID");

                    b.HasIndex("StatusID");

                    b.HasIndex("UserID");

                    b.HasIndex("VehicleID");

                    b.ToTable("Maintenance");
                });

            modelBuilder.Entity("BackendDemoProject.Core.Entities.MaintenanceHistory", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("ActionTypeID")
                        .HasColumnType("integer");

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<int>("MaintenanceID")
                        .HasColumnType("integer");

                    b.Property<int?>("ModifiedBy")
                        .HasColumnType("integer");

                    b.Property<DateTime>("ModifyDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("text")
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.HasIndex("ActionTypeID");

                    b.HasIndex("CreatedBy");

                    b.HasIndex("MaintenanceID");

                    b.HasIndex("ModifiedBy");

                    b.ToTable("MaintenanceHistory");
                });

            modelBuilder.Entity("BackendDemoProject.Core.Entities.PictureGroup", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<int?>("ModifiedBy")
                        .HasColumnType("integer");

                    b.Property<DateTime>("ModifyDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("PictureImage")
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.HasIndex("CreatedBy");

                    b.HasIndex("ModifiedBy");

                    b.ToTable("PictureGroup");
                });

            modelBuilder.Entity("BackendDemoProject.Core.Entities.Status", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<int?>("ModifiedBy")
                        .HasColumnType("integer");

                    b.Property<DateTime>("ModifyDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Name")
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.HasKey("ID");

                    b.HasIndex("CreatedBy");

                    b.HasIndex("ModifiedBy");

                    b.ToTable("Status");
                });

            modelBuilder.Entity("BackendDemoProject.Core.Entities.User", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Adress")
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("FirstName")
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("LastName")
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<int?>("ModifiedBy")
                        .HasColumnType("integer");

                    b.Property<DateTime>("ModifyDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("profilePicture")
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.HasIndex("CreatedBy");

                    b.HasIndex("ModifiedBy");

                    b.ToTable("User");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Admin",
                            IsDeleted = false,
                            LastName = "User",
                            ModifyDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("BackendDemoProject.Core.Entities.Vehicle", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<int?>("ModifiedBy")
                        .HasColumnType("integer");

                    b.Property<DateTime>("ModifyDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("PlateNo")
                        .HasMaxLength(60)
                        .HasColumnType("character varying(60)");

                    b.Property<int>("UserID")
                        .HasColumnType("integer");

                    b.Property<int>("VehicleTypeID")
                        .HasColumnType("integer");

                    b.HasKey("ID");

                    b.HasIndex("CreatedBy");

                    b.HasIndex("ModifiedBy");

                    b.HasIndex("UserID");

                    b.HasIndex("VehicleTypeID");

                    b.ToTable("Vehicle");
                });

            modelBuilder.Entity("BackendDemoProject.Core.Entities.VehicleType", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<int?>("ModifiedBy")
                        .HasColumnType("integer");

                    b.Property<DateTime>("ModifyDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Name")
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.HasKey("ID");

                    b.HasIndex("CreatedBy");

                    b.HasIndex("ModifiedBy");

                    b.ToTable("VehicleType");
                });

            modelBuilder.Entity("BackendDemoProject.Core.Entities.ActionType", b =>
                {
                    b.HasOne("BackendDemoProject.Core.Entities.User", "CreatedByUser")
                        .WithMany()
                        .HasForeignKey("CreatedBy");

                    b.HasOne("BackendDemoProject.Core.Entities.User", "ModifiedByUser")
                        .WithMany()
                        .HasForeignKey("ModifiedBy");

                    b.Navigation("CreatedByUser");

                    b.Navigation("ModifiedByUser");
                });

            modelBuilder.Entity("BackendDemoProject.Core.Entities.Maintenance", b =>
                {
                    b.HasOne("BackendDemoProject.Core.Entities.User", "CreatedByUser")
                        .WithMany()
                        .HasForeignKey("CreatedBy");

                    b.HasOne("BackendDemoProject.Core.Entities.User", "ModifiedByUser")
                        .WithMany()
                        .HasForeignKey("ModifiedBy");

                    b.HasOne("BackendDemoProject.Core.Entities.PictureGroup", "PictureGroup")
                        .WithMany()
                        .HasForeignKey("PictureGroupID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BackendDemoProject.Core.Entities.User", "ResponsibleUser")
                        .WithMany()
                        .HasForeignKey("ResponsibleUserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BackendDemoProject.Core.Entities.Status", "Status")
                        .WithMany()
                        .HasForeignKey("StatusID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BackendDemoProject.Core.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BackendDemoProject.Core.Entities.Vehicle", "Vehicle")
                        .WithMany()
                        .HasForeignKey("VehicleID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CreatedByUser");

                    b.Navigation("ModifiedByUser");

                    b.Navigation("PictureGroup");

                    b.Navigation("ResponsibleUser");

                    b.Navigation("Status");

                    b.Navigation("User");

                    b.Navigation("Vehicle");
                });

            modelBuilder.Entity("BackendDemoProject.Core.Entities.MaintenanceHistory", b =>
                {
                    b.HasOne("BackendDemoProject.Core.Entities.ActionType", "ActionType")
                        .WithMany()
                        .HasForeignKey("ActionTypeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BackendDemoProject.Core.Entities.User", "CreatedByUser")
                        .WithMany()
                        .HasForeignKey("CreatedBy");

                    b.HasOne("BackendDemoProject.Core.Entities.Maintenance", "Maintenance")
                        .WithMany("MaintenanceHistories")
                        .HasForeignKey("MaintenanceID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BackendDemoProject.Core.Entities.User", "ModifiedByUser")
                        .WithMany()
                        .HasForeignKey("ModifiedBy");

                    b.Navigation("ActionType");

                    b.Navigation("CreatedByUser");

                    b.Navigation("Maintenance");

                    b.Navigation("ModifiedByUser");
                });

            modelBuilder.Entity("BackendDemoProject.Core.Entities.PictureGroup", b =>
                {
                    b.HasOne("BackendDemoProject.Core.Entities.User", "CreatedByUser")
                        .WithMany()
                        .HasForeignKey("CreatedBy");

                    b.HasOne("BackendDemoProject.Core.Entities.User", "ModifiedByUser")
                        .WithMany()
                        .HasForeignKey("ModifiedBy");

                    b.Navigation("CreatedByUser");

                    b.Navigation("ModifiedByUser");
                });

            modelBuilder.Entity("BackendDemoProject.Core.Entities.Status", b =>
                {
                    b.HasOne("BackendDemoProject.Core.Entities.User", "CreatedByUser")
                        .WithMany()
                        .HasForeignKey("CreatedBy");

                    b.HasOne("BackendDemoProject.Core.Entities.User", "ModifiedByUser")
                        .WithMany()
                        .HasForeignKey("ModifiedBy");

                    b.Navigation("CreatedByUser");

                    b.Navigation("ModifiedByUser");
                });

            modelBuilder.Entity("BackendDemoProject.Core.Entities.User", b =>
                {
                    b.HasOne("BackendDemoProject.Core.Entities.User", "CreatedByUser")
                        .WithMany()
                        .HasForeignKey("CreatedBy");

                    b.HasOne("BackendDemoProject.Core.Entities.User", "ModifiedByUser")
                        .WithMany()
                        .HasForeignKey("ModifiedBy");

                    b.Navigation("CreatedByUser");

                    b.Navigation("ModifiedByUser");
                });

            modelBuilder.Entity("BackendDemoProject.Core.Entities.Vehicle", b =>
                {
                    b.HasOne("BackendDemoProject.Core.Entities.User", "CreatedByUser")
                        .WithMany()
                        .HasForeignKey("CreatedBy");

                    b.HasOne("BackendDemoProject.Core.Entities.User", "ModifiedByUser")
                        .WithMany()
                        .HasForeignKey("ModifiedBy");

                    b.HasOne("BackendDemoProject.Core.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BackendDemoProject.Core.Entities.VehicleType", "VehicleType")
                        .WithMany()
                        .HasForeignKey("VehicleTypeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CreatedByUser");

                    b.Navigation("ModifiedByUser");

                    b.Navigation("User");

                    b.Navigation("VehicleType");
                });

            modelBuilder.Entity("BackendDemoProject.Core.Entities.VehicleType", b =>
                {
                    b.HasOne("BackendDemoProject.Core.Entities.User", "CreatedByUser")
                        .WithMany()
                        .HasForeignKey("CreatedBy");

                    b.HasOne("BackendDemoProject.Core.Entities.User", "ModifiedByUser")
                        .WithMany()
                        .HasForeignKey("ModifiedBy");

                    b.Navigation("CreatedByUser");

                    b.Navigation("ModifiedByUser");
                });

            modelBuilder.Entity("BackendDemoProject.Core.Entities.Maintenance", b =>
                {
                    b.Navigation("MaintenanceHistories");
                });
#pragma warning restore 612, 618
        }
    }
}
