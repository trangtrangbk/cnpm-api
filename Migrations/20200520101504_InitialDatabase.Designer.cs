﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using timtro.Models;

namespace timtro.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20200520101504_InitialDatabase")]
    partial class InitialDatabase
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("timtro.Models.Admin", b =>
                {
                    b.Property<int>("AdminId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Password")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Username")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("AdminId");

                    b.ToTable("Admin");
                });

            modelBuilder.Entity("timtro.Models.AdminPermission", b =>
                {
                    b.Property<int>("AdminPermissionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("AdminId")
                        .HasColumnType("int");

                    b.Property<int>("PermissionId")
                        .HasColumnType("int");

                    b.Property<bool>("license")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("AdminPermissionId");

                    b.HasIndex("AdminId");

                    b.HasIndex("PermissionId");

                    b.ToTable("AdminPermission");
                });

            modelBuilder.Entity("timtro.Models.Comment", b =>
                {
                    b.Property<int>("CommentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("CommentDetail")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("NewId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("CommentId");

                    b.HasIndex("NewId");

                    b.HasIndex("UserId");

                    b.ToTable("Comment");
                });

            modelBuilder.Entity("timtro.Models.New", b =>
                {
                    b.Property<int>("NewId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<float>("Area")
                        .HasColumnType("float");

                    b.Property<string>("Description")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Picture")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<bool>("Status")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("Time")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Title")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("price")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("NewId");

                    b.HasIndex("UserId");

                    b.ToTable("New");
                });

            modelBuilder.Entity("timtro.Models.Permission", b =>
                {
                    b.Property<int>("PermissionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("PermissionName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("PermissionId");

                    b.ToTable("Permission");
                });

            modelBuilder.Entity("timtro.Models.PermissionDetail", b =>
                {
                    b.Property<int>("PermissionDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ActionName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<bool>("CheckAction")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("PermissionId")
                        .HasColumnType("int");

                    b.HasKey("PermissionDetailId");

                    b.HasIndex("PermissionId");

                    b.ToTable("PermissionDetail");
                });

            modelBuilder.Entity("timtro.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime>("Birthday")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Email")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<bool>("Gender")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Password")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Phone")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("UserName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("UserId");

                    b.ToTable("User");
                });

            modelBuilder.Entity("timtro.Models.AdminPermission", b =>
                {
                    b.HasOne("timtro.Models.Admin", "Admins")
                        .WithMany("AdminPermissions")
                        .HasForeignKey("AdminId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("timtro.Models.Permission", "Permissions")
                        .WithMany("AdminPermissions")
                        .HasForeignKey("PermissionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("timtro.Models.Comment", b =>
                {
                    b.HasOne("timtro.Models.New", "News")
                        .WithMany("Comments")
                        .HasForeignKey("NewId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("timtro.Models.User", "Users")
                        .WithMany("Comments")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("timtro.Models.New", b =>
                {
                    b.HasOne("timtro.Models.User", "Users")
                        .WithMany("News")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("timtro.Models.PermissionDetail", b =>
                {
                    b.HasOne("timtro.Models.Permission", "Permissions")
                        .WithMany("PermissionDetails")
                        .HasForeignKey("PermissionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}