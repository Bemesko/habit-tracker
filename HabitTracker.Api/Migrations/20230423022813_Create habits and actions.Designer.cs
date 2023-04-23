﻿// <auto-generated />
using System;
using HabitTracker.Api.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace HabitTracker.Api.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230423022813_Create habits and actions")]
    partial class Createhabitsandactions
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("HabitTracker.Api.Models.Habit", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Habits");
                });

            modelBuilder.Entity("HabitTracker.Api.Models.HabitAction", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("ActionTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid?>("HabitId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("HabitId");

                    b.ToTable("HabitActions");
                });

            modelBuilder.Entity("HabitTracker.Api.Models.HabitAction", b =>
                {
                    b.HasOne("HabitTracker.Api.Models.Habit", null)
                        .WithMany("Actions")
                        .HasForeignKey("HabitId");
                });

            modelBuilder.Entity("HabitTracker.Api.Models.Habit", b =>
                {
                    b.Navigation("Actions");
                });
#pragma warning restore 612, 618
        }
    }
}
