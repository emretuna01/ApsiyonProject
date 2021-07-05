﻿// <auto-generated />
using System;
using ApsiyonProject.Persistance.App.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ApsiyonProject.Persistance.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20210705120647_Mig_3")]
    partial class Mig_3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ApsiyonProject.Domain.App.Entities.Building", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("AdministratorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("BlockName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("BuildingStatusId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("BuildingTypeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("AdministratorId");

                    b.HasIndex("BuildingStatusId");

                    b.HasIndex("BuildingTypeId");

                    b.ToTable("Buildings");
                });

            modelBuilder.Entity("ApsiyonProject.Domain.App.Entities.BuildingStatus", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("BuildingStatuses");
                });

            modelBuilder.Entity("ApsiyonProject.Domain.App.Entities.BuildingType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("BuildingTypes");
                });

            modelBuilder.Entity("ApsiyonProject.Domain.App.Entities.Car", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("HouseOwnerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Plates")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("HouseOwnerId");

                    b.ToTable("Cars");
                });

            modelBuilder.Entity("ApsiyonProject.Domain.App.Entities.Flat", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("FlatNumer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("FlatStatusId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("FlatTypeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("FloorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("HouseOwnerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("FlatStatusId");

                    b.HasIndex("FlatTypeId");

                    b.HasIndex("FloorId");

                    b.HasIndex("HouseOwnerId");

                    b.ToTable("Flats");
                });

            modelBuilder.Entity("ApsiyonProject.Domain.App.Entities.FlatStatus", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("FlatStatuses");
                });

            modelBuilder.Entity("ApsiyonProject.Domain.App.Entities.FlatType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("FlatTypes");
                });

            modelBuilder.Entity("ApsiyonProject.Domain.App.Entities.Floor", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("BuildingId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("FloorNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("BuildingId");

                    b.ToTable("Floors");
                });

            modelBuilder.Entity("ApsiyonProject.Domain.App.Entities.HouseOwner", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("AdministratorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SurName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TCNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AdministratorId");

                    b.ToTable("HouseOwners");
                });

            modelBuilder.Entity("ApsiyonProject.Domain.App.Entities.HouseOwnerRoleClaims", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("HouseOwnerRoleClaims");
                });

            modelBuilder.Entity("ApsiyonProject.Domain.App.Entities.HouseOwnerRoles", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("HouseOwnerRoles");
                });

            modelBuilder.Entity("HouseOwnerHouseOwnerRoles", b =>
                {
                    b.Property<Guid>("HouseOwnerRolesId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("HouseOwnersId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("HouseOwnerRolesId", "HouseOwnersId");

                    b.HasIndex("HouseOwnersId");

                    b.ToTable("HouseOwnerHouseOwnerRoles");
                });

            modelBuilder.Entity("HouseOwnerRoleClaimsHouseOwnerRoles", b =>
                {
                    b.Property<Guid>("HouseOwnerRoleClaimsId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("HouseOwnerRolesId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("HouseOwnerRoleClaimsId", "HouseOwnerRolesId");

                    b.HasIndex("HouseOwnerRolesId");

                    b.ToTable("HouseOwnerRoleClaimsHouseOwnerRoles");
                });

            modelBuilder.Entity("ApsiyonProject.Domain.App.Entities.Building", b =>
                {
                    b.HasOne("ApsiyonProject.Domain.App.Entities.HouseOwner", "Administrator")
                        .WithMany()
                        .HasForeignKey("AdministratorId");

                    b.HasOne("ApsiyonProject.Domain.App.Entities.BuildingStatus", "BuildingStatus")
                        .WithMany()
                        .HasForeignKey("BuildingStatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ApsiyonProject.Domain.App.Entities.BuildingType", "BuildingType")
                        .WithMany()
                        .HasForeignKey("BuildingTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Administrator");

                    b.Navigation("BuildingStatus");

                    b.Navigation("BuildingType");
                });

            modelBuilder.Entity("ApsiyonProject.Domain.App.Entities.Car", b =>
                {
                    b.HasOne("ApsiyonProject.Domain.App.Entities.HouseOwner", "HouseOwner")
                        .WithMany("Cars")
                        .HasForeignKey("HouseOwnerId");

                    b.Navigation("HouseOwner");
                });

            modelBuilder.Entity("ApsiyonProject.Domain.App.Entities.Flat", b =>
                {
                    b.HasOne("ApsiyonProject.Domain.App.Entities.FlatStatus", "FlatStatus")
                        .WithMany()
                        .HasForeignKey("FlatStatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ApsiyonProject.Domain.App.Entities.FlatType", "FlatType")
                        .WithMany()
                        .HasForeignKey("FlatTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ApsiyonProject.Domain.App.Entities.Floor", "Floor")
                        .WithMany("Flats")
                        .HasForeignKey("FloorId");

                    b.HasOne("ApsiyonProject.Domain.App.Entities.HouseOwner", "HouseOwner")
                        .WithMany("Flats")
                        .HasForeignKey("HouseOwnerId");

                    b.Navigation("FlatStatus");

                    b.Navigation("FlatType");

                    b.Navigation("Floor");

                    b.Navigation("HouseOwner");
                });

            modelBuilder.Entity("ApsiyonProject.Domain.App.Entities.Floor", b =>
                {
                    b.HasOne("ApsiyonProject.Domain.App.Entities.Building", "Building")
                        .WithMany("Floors")
                        .HasForeignKey("BuildingId");

                    b.Navigation("Building");
                });

            modelBuilder.Entity("ApsiyonProject.Domain.App.Entities.HouseOwner", b =>
                {
                    b.HasOne("ApsiyonProject.Domain.App.Entities.HouseOwner", "Administrator")
                        .WithMany()
                        .HasForeignKey("AdministratorId");

                    b.Navigation("Administrator");
                });

            modelBuilder.Entity("HouseOwnerHouseOwnerRoles", b =>
                {
                    b.HasOne("ApsiyonProject.Domain.App.Entities.HouseOwnerRoles", null)
                        .WithMany()
                        .HasForeignKey("HouseOwnerRolesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ApsiyonProject.Domain.App.Entities.HouseOwner", null)
                        .WithMany()
                        .HasForeignKey("HouseOwnersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HouseOwnerRoleClaimsHouseOwnerRoles", b =>
                {
                    b.HasOne("ApsiyonProject.Domain.App.Entities.HouseOwnerRoleClaims", null)
                        .WithMany()
                        .HasForeignKey("HouseOwnerRoleClaimsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ApsiyonProject.Domain.App.Entities.HouseOwnerRoles", null)
                        .WithMany()
                        .HasForeignKey("HouseOwnerRolesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ApsiyonProject.Domain.App.Entities.Building", b =>
                {
                    b.Navigation("Floors");
                });

            modelBuilder.Entity("ApsiyonProject.Domain.App.Entities.Floor", b =>
                {
                    b.Navigation("Flats");
                });

            modelBuilder.Entity("ApsiyonProject.Domain.App.Entities.HouseOwner", b =>
                {
                    b.Navigation("Cars");

                    b.Navigation("Flats");
                });
#pragma warning restore 612, 618
        }
    }
}
