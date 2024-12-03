﻿// <auto-generated />
using System;
using ClassAssignmentApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ClassAssignmentApp.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0-preview.7.24405.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ClassAssignmentApp.Models.Building", b =>
                {
                    b.Property<int>("BuildingID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BuildingID"));

                    b.Property<string>("Address1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Address2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BuildingID");

                    b.ToTable("Buildings");
                });

            modelBuilder.Entity("ClassAssignmentApp.Models.ClassRoom", b =>
                {
                    b.Property<int>("ClassRoomID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ClassRoomID"));

                    b.Property<int?>("BuildingNumber")
                        .HasColumnType("int");

                    b.Property<int?>("Capacity")
                        .HasColumnType("int");

                    b.Property<int?>("RoomNumber")
                        .HasColumnType("int");

                    b.Property<string>("Unavailable")
                        .HasMaxLength(1)
                        .HasColumnType("nvarchar(1)");

                    b.HasKey("ClassRoomID");

                    b.ToTable("ClassRooms");
                });

            modelBuilder.Entity("ClassAssignmentApp.Models.ClassSession", b =>
                {
                    b.Property<int>("ClassSessionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ClassSessionID"));

                    b.Property<int>("ClassRoomID")
                        .HasColumnType("int");

                    b.Property<int>("CourseID")
                        .HasColumnType("int");

                    b.Property<TimeOnly>("EndTime")
                        .HasColumnType("time");

                    b.Property<int>("InstructorID")
                        .HasColumnType("int");

                    b.Property<TimeOnly>("StartTime")
                        .HasColumnType("time");

                    b.Property<string>("WeekDay")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("ClassSessionID");

                    b.ToTable("ClassSessions");
                });

            modelBuilder.Entity("ClassAssignmentApp.Models.Course", b =>
                {
                    b.Property<int>("CourseID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CourseID"));

                    b.Property<int>("CreditHours")
                        .HasColumnType("int");

                    b.Property<string>("Department")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("PrerequisiteCourseID")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("CourseID");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("ClassAssignmentApp.Models.Instructor", b =>
                {
                    b.Property<int>("InstructorID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("InstructorID"));

                    b.Property<string>("AddressLine1")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("AddressLine2")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("City")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("MiddleName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("State")
                        .HasMaxLength(2)
                        .HasColumnType("nvarchar(2)");

                    b.Property<string>("Title")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ZipCode")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("InstructorID");

                    b.ToTable("Instructors");
                });

            modelBuilder.Entity("ClassAssignmentApp.Models.Student", b =>
                {
                    b.Property<int>("StudentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StudentID"));

                    b.Property<string>("AddressLine1")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("AddressLine2")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("City")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("ClassRank")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("MiddleName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("State")
                        .HasMaxLength(2)
                        .HasColumnType("nvarchar(2)");

                    b.Property<string>("ZipCode")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("StudentID");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("ClassAssignmentApp.Models.StudentClassSession", b =>
                {
                    b.Property<int>("StudentClassSessionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StudentClassSessionID"));

                    b.Property<int>("ClassSessionID")
                        .HasColumnType("int");

                    b.Property<int>("StudentID")
                        .HasColumnType("int");

                    b.Property<int?>("TimesAbsent")
                        .HasColumnType("int");

                    b.HasKey("StudentClassSessionID");

                    b.ToTable("StudentClassSessions");
                });

            modelBuilder.Entity("ClassAssignmentApp.Models.UnitedState", b =>
                {
                    b.Property<int>("StateID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StateID"));

                    b.Property<string>("StateAbbreviation")
                        .IsRequired()
                        .HasMaxLength(2)
                        .HasColumnType("nvarchar(2)");

                    b.Property<string>("StateName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("StateID");

                    b.ToTable("UnitedStates");
                });
#pragma warning restore 612, 618
        }
    }
}
