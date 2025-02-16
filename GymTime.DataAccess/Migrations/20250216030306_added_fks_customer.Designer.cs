﻿// <auto-generated />
using System;
using GymTime.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GymTime.DataAccess.Migrations
{
    [DbContext(typeof(GymTimeContext))]
    [Migration("20250216030306_added_fks_customer")]
    partial class added_fks_customer
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("GymTime.DataAccess.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerId"));

                    b.Property<int?>("CustomerPasswordId")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SubscriptionPackageId")
                        .HasColumnType("int");

                    b.Property<int?>("TrainerId")
                        .HasColumnType("int");

                    b.Property<int?>("TrainingScheduleId")
                        .HasColumnType("int");

                    b.HasKey("CustomerId");

                    b.HasIndex("SubscriptionPackageId");

                    b.HasIndex("TrainerId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("GymTime.DataAccess.CustomerPassword", b =>
                {
                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<string>("CustomerUsername")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerId");

                    b.ToTable("CustomerPasswords");
                });

            modelBuilder.Entity("GymTime.DataAccess.Manager", b =>
                {
                    b.Property<int>("ManagerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ManagerId"));

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ManagerId");

                    b.ToTable("Managers");
                });

            modelBuilder.Entity("GymTime.DataAccess.ManagerPassword", b =>
                {
                    b.Property<int>("ManagerPasswordId")
                        .HasColumnType("int");

                    b.Property<string>("ManagerUsername")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ManagerPasswordId");

                    b.ToTable("ManagerPasswords");
                });

            modelBuilder.Entity("GymTime.DataAccess.SubscriptionPackage", b =>
                {
                    b.Property<int>("SubscriptionPackageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SubscriptionPackageId"));

                    b.Property<decimal>("BasePrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<float>("DiscountPercent")
                        .HasColumnType("real");

                    b.HasKey("SubscriptionPackageId");

                    b.ToTable("SubscriptionPackages");
                });

            modelBuilder.Entity("GymTime.DataAccess.Trainer", b =>
                {
                    b.Property<int>("TrainerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TrainerId"));

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("KPI")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ManagerId")
                        .HasColumnType("int");

                    b.Property<decimal>("Salary")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("TrainerId");

                    b.HasIndex("ManagerId");

                    b.ToTable("Trainers");
                });

            modelBuilder.Entity("GymTime.DataAccess.TrainerPassword", b =>
                {
                    b.Property<int>("TrainerPasswordId")
                        .HasColumnType("int");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TrainerUsername")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TrainerPasswordId");

                    b.ToTable("TrainerPasswords");
                });

            modelBuilder.Entity("GymTime.DataAccess.TrainingSchedule", b =>
                {
                    b.Property<int>("TrainingScheduleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TrainingScheduleId"));

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("FirstDay")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FourthDay")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("SecondDay")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ThirdDay")
                        .HasColumnType("datetime2");

                    b.Property<int>("TrainerId")
                        .HasColumnType("int");

                    b.HasKey("TrainingScheduleId");

                    b.HasIndex("CustomerId")
                        .IsUnique();

                    b.HasIndex("TrainerId");

                    b.ToTable("TrainingSchedules");
                });

            modelBuilder.Entity("GymTime.DataAccess.Customer", b =>
                {
                    b.HasOne("GymTime.DataAccess.SubscriptionPackage", "SubPack")
                        .WithMany("Customers")
                        .HasForeignKey("SubscriptionPackageId");

                    b.HasOne("GymTime.DataAccess.Trainer", "Trainer")
                        .WithMany("Customers")
                        .HasForeignKey("TrainerId");

                    b.Navigation("SubPack");

                    b.Navigation("Trainer");
                });

            modelBuilder.Entity("GymTime.DataAccess.CustomerPassword", b =>
                {
                    b.HasOne("GymTime.DataAccess.Customer", "Customer")
                        .WithOne("CustomerPassword")
                        .HasForeignKey("GymTime.DataAccess.CustomerPassword", "CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("GymTime.DataAccess.ManagerPassword", b =>
                {
                    b.HasOne("GymTime.DataAccess.Manager", "Manager")
                        .WithOne("ManagerPassword")
                        .HasForeignKey("GymTime.DataAccess.ManagerPassword", "ManagerPasswordId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Manager");
                });

            modelBuilder.Entity("GymTime.DataAccess.Trainer", b =>
                {
                    b.HasOne("GymTime.DataAccess.Manager", "Manager")
                        .WithMany("Trainers")
                        .HasForeignKey("ManagerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Manager");
                });

            modelBuilder.Entity("GymTime.DataAccess.TrainerPassword", b =>
                {
                    b.HasOne("GymTime.DataAccess.Trainer", "Trainer")
                        .WithOne("TrainerPassword")
                        .HasForeignKey("GymTime.DataAccess.TrainerPassword", "TrainerPasswordId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Trainer");
                });

            modelBuilder.Entity("GymTime.DataAccess.TrainingSchedule", b =>
                {
                    b.HasOne("GymTime.DataAccess.Customer", "Customer")
                        .WithOne("Schedule")
                        .HasForeignKey("GymTime.DataAccess.TrainingSchedule", "CustomerId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("GymTime.DataAccess.Trainer", "Trainer")
                        .WithMany("Schedules")
                        .HasForeignKey("TrainerId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Trainer");
                });

            modelBuilder.Entity("GymTime.DataAccess.Customer", b =>
                {
                    b.Navigation("CustomerPassword")
                        .IsRequired();

                    b.Navigation("Schedule")
                        .IsRequired();
                });

            modelBuilder.Entity("GymTime.DataAccess.Manager", b =>
                {
                    b.Navigation("ManagerPassword")
                        .IsRequired();

                    b.Navigation("Trainers");
                });

            modelBuilder.Entity("GymTime.DataAccess.SubscriptionPackage", b =>
                {
                    b.Navigation("Customers");
                });

            modelBuilder.Entity("GymTime.DataAccess.Trainer", b =>
                {
                    b.Navigation("Customers");

                    b.Navigation("Schedules");

                    b.Navigation("TrainerPassword")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
