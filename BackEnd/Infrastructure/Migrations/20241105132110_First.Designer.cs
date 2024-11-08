﻿// <auto-generated />
using System;
using Infrastructure.Databases.Relational.MsSql;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(CmsMssqlDbContext))]
    [Migration("20241105132110_First")]
    partial class First
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Application.Databases.Relational.Models.Users.Admin", b =>
                {
                    b.Property<Guid>("AdminId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("AdminId")
                        .HasName("Application.Databases.Relational.Models.Users.Admin_pk");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("Application.Databases.Relational.Models.Users.RefreshToken", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Expired")
                        .HasColumnType("datetime2");

                    b.Property<string>("RefreshTokenString")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id")
                        .HasName("Application.Databases.Relational.Models.Users.RefreshToken_pk");

                    b.HasIndex("UserId");

                    b.ToTable("RefreshTokens");
                });

            modelBuilder.Entity("Application.Databases.Relational.Models.Users.Student", b =>
                {
                    b.Property<Guid>("StudentId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("StudentId")
                        .HasName("Application.Databases.Relational.Models.Users.Student_pk");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("Application.Databases.Relational.Models.Users.Teacher", b =>
                {
                    b.Property<Guid>("TeacherId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("TeacherId")
                        .HasName("Application.Databases.Relational.Models.Users.Teacher_pk");

                    b.ToTable("Teachers");
                });

            modelBuilder.Entity("Application.Databases.Relational.Models.Users.User", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("NEWID()");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId")
                        .HasName("Application.Databases.Relational.Models.Users.User_pk");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Application.Databases.Relational.Models.Users.Admin", b =>
                {
                    b.HasOne("Application.Databases.Relational.Models.Users.User", "User")
                        .WithOne("Admin")
                        .HasForeignKey("Application.Databases.Relational.Models.Users.Admin", "AdminId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired()
                        .HasConstraintName("Application.Databases.Relational.Models.Users.User_Application.Databases.Relational.Models.Users.Admin");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Application.Databases.Relational.Models.Users.RefreshToken", b =>
                {
                    b.HasOne("Application.Databases.Relational.Models.Users.User", "User")
                        .WithMany("RefreshTokens")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired()
                        .HasConstraintName("Application.Databases.Relational.Models.Users.User_Application.Databases.Relational.Models.Users.RefreshToken");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Application.Databases.Relational.Models.Users.Student", b =>
                {
                    b.HasOne("Application.Databases.Relational.Models.Users.User", "User")
                        .WithOne("Student")
                        .HasForeignKey("Application.Databases.Relational.Models.Users.Student", "StudentId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired()
                        .HasConstraintName("Application.Databases.Relational.Models.Users.User_Application.Databases.Relational.Models.Users.Student");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Application.Databases.Relational.Models.Users.Teacher", b =>
                {
                    b.HasOne("Application.Databases.Relational.Models.Users.User", "User")
                        .WithOne("Teacher")
                        .HasForeignKey("Application.Databases.Relational.Models.Users.Teacher", "TeacherId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired()
                        .HasConstraintName("Application.Databases.Relational.Models.Users.User_Application.Databases.Relational.Models.Users.Teacher");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Application.Databases.Relational.Models.Users.User", b =>
                {
                    b.Navigation("Admin");

                    b.Navigation("RefreshTokens");

                    b.Navigation("Student");

                    b.Navigation("Teacher");
                });
#pragma warning restore 612, 618
        }
    }
}
