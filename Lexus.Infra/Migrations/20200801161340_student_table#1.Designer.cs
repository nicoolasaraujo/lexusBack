﻿// <auto-generated />
using System;
using Lexus.Infra.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Lexus.Infra.Migrations
{
    [DbContext(typeof(LexusContext))]
    [Migration("20200801161340_student_table#1")]
    partial class student_table1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Lexus.Core.Models.Student", b =>
                {
                    b.Property<string>("StudentId")
                        .HasColumnType("VARCHAR(36)");

                    b.Property<DateTime>("BirthDay")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.HasKey("StudentId");

                    b.ToTable("Student");
                });

            modelBuilder.Entity("Lexus.Core.Models.Teacher", b =>
                {
                    b.Property<string>("TeacherId")
                        .HasColumnType("VARCHAR(36)");

                    b.Property<string>("EmailAddres")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("PhotoPath")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("TeacherId");

                    b.ToTable("Teacher");
                });

            modelBuilder.Entity("Lexus.Core.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("VARCHAR(36)")
                        .HasMaxLength(36);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("VARCHAR(20)")
                        .HasMaxLength(20);

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("Username")
                        .IsUnique()
                        .HasName("User_Unique");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = "f731ba96-9966-4d23-a611-55e8f34d5781",
                            Password = "secretpass",
                            Username = "nicoolas"
                        });
                });

            modelBuilder.Entity("Lexus.Core.Models.Student", b =>
                {
                    b.HasOne("Lexus.Core.Models.User", "User")
                        .WithOne("Student")
                        .HasForeignKey("Lexus.Core.Models.Student", "StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Lexus.Core.Models.Teacher", b =>
                {
                    b.HasOne("Lexus.Core.Models.User", "User")
                        .WithOne("Teacher")
                        .HasForeignKey("Lexus.Core.Models.Teacher", "TeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
