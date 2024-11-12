﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SamAnDMBackEnd.Context;

#nullable disable

namespace SamAnDMBackEnd.Migrations
{
    [DbContext(typeof(DbContextDM))]
    [Migration("20241110202535_DocumentsFamily")]
    partial class DocumentsFamily
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SamAnDMBackEnd.Model.Documents", b =>
                {
                    b.Property<int>("DocumentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DocumentId"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("DocumentContent")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("DocumentName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("DocumentSize")
                        .HasColumnType("bigint");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsProtected")
                        .HasColumnType("bit");

                    b.Property<string>("TypeDocument")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DocumentId");

                    b.ToTable("Documents");
                });

            modelBuilder.Entity("SamAnDMBackEnd.Model.DocumentsHistorics", b =>
                {
                    b.Property<int>("DocumentId")
                        .HasColumnType("int");

                    b.Property<int>("HistoricId")
                        .HasColumnType("int");

                    b.HasKey("DocumentId", "HistoricId");

                    b.HasIndex("HistoricId");

                    b.ToTable("DocumentsHistorics");
                });

            modelBuilder.Entity("SamAnDMBackEnd.Model.FamilyGroup", b =>
                {
                    b.Property<int>("FamilyGroupId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FamilyGroupId"));

                    b.Property<int>("DocumentId")
                        .HasColumnType("int");

                    b.Property<int>("DocumentsDocumentId")
                        .HasColumnType("int");

                    b.Property<string>("Members")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("UsersUserId")
                        .HasColumnType("int");

                    b.HasKey("FamilyGroupId");

                    b.HasIndex("DocumentsDocumentId");

                    b.HasIndex("UsersUserId");

                    b.ToTable("FamilyGroups");
                });

            modelBuilder.Entity("SamAnDMBackEnd.Model.Historics", b =>
                {
                    b.Property<int>("HistoricId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HistoricId"));

                    b.Property<string>("Action")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateModification")
                        .HasColumnType("datetime2");

                    b.Property<string>("ReferenceId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserModification")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("HistoricId");

                    b.ToTable("Historics");
                });

            modelBuilder.Entity("SamAnDMBackEnd.Model.Permissions", b =>
                {
                    b.Property<int>("PermissionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PermissionId"));

                    b.Property<string>("PermissionName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PermissionId");

                    b.ToTable("Permissions");
                });

            modelBuilder.Entity("SamAnDMBackEnd.Model.Persons", b =>
                {
                    b.Property<int>("PersonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PersonId"));

                    b.Property<bool>("AccountStatus")
                        .HasColumnType("bit");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateRegistration")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("LastLogin")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Phone")
                        .HasColumnType("int");

                    b.Property<string>("ProfilePicture")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TokenRecovery")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("UsersUserId")
                        .HasColumnType("int");

                    b.HasKey("PersonId");

                    b.HasIndex("UsersUserId");

                    b.ToTable("Persons");
                });

            modelBuilder.Entity("SamAnDMBackEnd.Model.UserType", b =>
                {
                    b.Property<int>("UserTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserTypeId"));

                    b.Property<string>("TypeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserTypeId");

                    b.ToTable("UserTypes");
                });

            modelBuilder.Entity("SamAnDMBackEnd.Model.UserTypePermissions", b =>
                {
                    b.Property<int>("UserTypeId")
                        .HasColumnType("int");

                    b.Property<int>("PermissionId")
                        .HasColumnType("int");

                    b.HasKey("UserTypeId", "PermissionId");

                    b.HasIndex("PermissionId");

                    b.ToTable("UserTypePermissions");
                });

            modelBuilder.Entity("SamAnDMBackEnd.Model.Users", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserTypeId")
                        .HasColumnType("int");

                    b.HasKey("UserId");

                    b.HasIndex("UserTypeId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("SamAnDMBackEnd.Model.DocumentsHistorics", b =>
                {
                    b.HasOne("SamAnDMBackEnd.Model.Documents", "Documents")
                        .WithMany("DocumentsHistorics")
                        .HasForeignKey("DocumentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SamAnDMBackEnd.Model.Historics", "Historics")
                        .WithMany("DocumentsHistorics")
                        .HasForeignKey("HistoricId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Documents");

                    b.Navigation("Historics");
                });

            modelBuilder.Entity("SamAnDMBackEnd.Model.FamilyGroup", b =>
                {
                    b.HasOne("SamAnDMBackEnd.Model.Documents", "Documents")
                        .WithMany("FamilyGroups")
                        .HasForeignKey("DocumentsDocumentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SamAnDMBackEnd.Model.Users", "Users")
                        .WithMany("FamilyGroups")
                        .HasForeignKey("UsersUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Documents");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("SamAnDMBackEnd.Model.Persons", b =>
                {
                    b.HasOne("SamAnDMBackEnd.Model.Users", "Users")
                        .WithMany()
                        .HasForeignKey("UsersUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Users");
                });

            modelBuilder.Entity("SamAnDMBackEnd.Model.UserTypePermissions", b =>
                {
                    b.HasOne("SamAnDMBackEnd.Model.Permissions", "Permissions")
                        .WithMany("UserTypePermissions")
                        .HasForeignKey("PermissionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SamAnDMBackEnd.Model.UserType", "UserType")
                        .WithMany("UserTypePermissions")
                        .HasForeignKey("UserTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Permissions");

                    b.Navigation("UserType");
                });

            modelBuilder.Entity("SamAnDMBackEnd.Model.Users", b =>
                {
                    b.HasOne("SamAnDMBackEnd.Model.UserType", "UserType")
                        .WithMany("Users")
                        .HasForeignKey("UserTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserType");
                });

            modelBuilder.Entity("SamAnDMBackEnd.Model.Documents", b =>
                {
                    b.Navigation("DocumentsHistorics");

                    b.Navigation("FamilyGroups");
                });

            modelBuilder.Entity("SamAnDMBackEnd.Model.Historics", b =>
                {
                    b.Navigation("DocumentsHistorics");
                });

            modelBuilder.Entity("SamAnDMBackEnd.Model.Permissions", b =>
                {
                    b.Navigation("UserTypePermissions");
                });

            modelBuilder.Entity("SamAnDMBackEnd.Model.UserType", b =>
                {
                    b.Navigation("UserTypePermissions");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("SamAnDMBackEnd.Model.Users", b =>
                {
                    b.Navigation("FamilyGroups");
                });
#pragma warning restore 612, 618
        }
    }
}
