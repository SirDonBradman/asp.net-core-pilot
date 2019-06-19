﻿// <auto-generated />
using System;
using Core.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace CoreEMS.Migrations.EMS
{
    [DbContext(typeof(EMSContext))]
    [Migration("20190619164834_addingDepartmentSemesterRelation")]
    partial class addingDepartmentSemesterRelation
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("ContosoPets.Api.Models.Product", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<decimal>("Price");

                    b.HasKey("Id");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("CoreEMS.Models.Book", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Author");

                    b.Property<string>("ISBN");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("SubjectId");

                    b.HasKey("Id");

                    b.HasIndex("SubjectId");

                    b.ToTable("Book");
                });

            modelBuilder.Entity("CoreEMS.Models.Department", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Departments");

                    b.HasData(
                        new
                        {
                            Id = "1",
                            Name = "CSE"
                        },
                        new
                        {
                            Id = "2",
                            Name = "ISE"
                        },
                        new
                        {
                            Id = "3",
                            Name = "ECE"
                        });
                });

            modelBuilder.Entity("CoreEMS.Models.Guardian", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address")
                        .IsRequired();

                    b.Property<string>("Email");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("Password");

                    b.Property<string>("Phone")
                        .IsRequired();

                    b.Property<string>("Photo");

                    b.Property<string>("Role");

                    b.Property<string>("Username");

                    b.HasKey("Id");

                    b.ToTable("Guardians");

                    b.HasData(
                        new
                        {
                            Id = "1",
                            Address = "Bangalore",
                            Name = "Papa 1",
                            Phone = "1234567891"
                        },
                        new
                        {
                            Id = "2",
                            Address = "Pune",
                            Name = "Papa 2",
                            Phone = "1234567891"
                        },
                        new
                        {
                            Id = "3",
                            Address = "Mumbai",
                            Name = "Papa 3",
                            Phone = "1234567891"
                        },
                        new
                        {
                            Id = "4",
                            Address = "Chennai",
                            Name = "Papa 4",
                            Phone = "1234567891"
                        },
                        new
                        {
                            Id = "5",
                            Address = "Vijaywada",
                            Name = "Papa 5",
                            Phone = "1234567891"
                        },
                        new
                        {
                            Id = "6",
                            Address = "Cochin",
                            Name = "Papa 6",
                            Phone = "1234567891"
                        },
                        new
                        {
                            Id = "7",
                            Address = "Delhi",
                            Name = "Papa 7",
                            Phone = "1234567891"
                        },
                        new
                        {
                            Id = "8",
                            Address = "Chandigarh",
                            Name = "Papa 8",
                            Phone = "1234567891"
                        },
                        new
                        {
                            Id = "9",
                            Address = "Calcutta",
                            Name = "Papa 9",
                            Phone = "1234567891"
                        },
                        new
                        {
                            Id = "10",
                            Address = "Manali",
                            Name = "Papa 10",
                            Phone = "1234567891"
                        });
                });

            modelBuilder.Entity("CoreEMS.Models.Lecture", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("NumberOfClasses");

                    b.Property<string>("RoomNumber");

                    b.Property<string>("SectionId")
                        .IsRequired();

                    b.Property<string>("SubjectId")
                        .IsRequired();

                    b.Property<string>("TeacherId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("SectionId");

                    b.HasIndex("SubjectId");

                    b.HasIndex("TeacherId");

                    b.ToTable("Lectures");
                });

            modelBuilder.Entity("CoreEMS.Models.Section", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("SemesterId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("SemesterId");

                    b.ToTable("Sections");

                    b.HasData(
                        new
                        {
                            Id = "1",
                            Name = "A",
                            SemesterId = "1"
                        },
                        new
                        {
                            Id = "2",
                            Name = "B",
                            SemesterId = "1"
                        },
                        new
                        {
                            Id = "3",
                            Name = "A",
                            SemesterId = "2"
                        },
                        new
                        {
                            Id = "4",
                            Name = "B",
                            SemesterId = "2"
                        },
                        new
                        {
                            Id = "5",
                            Name = "A",
                            SemesterId = "3"
                        },
                        new
                        {
                            Id = "6",
                            Name = "B",
                            SemesterId = "3"
                        },
                        new
                        {
                            Id = "7",
                            Name = "A",
                            SemesterId = "4"
                        },
                        new
                        {
                            Id = "8",
                            Name = "B",
                            SemesterId = "4"
                        },
                        new
                        {
                            Id = "9",
                            Name = "A",
                            SemesterId = "5"
                        },
                        new
                        {
                            Id = "10",
                            Name = "B",
                            SemesterId = "5"
                        },
                        new
                        {
                            Id = "11",
                            Name = "A",
                            SemesterId = "6"
                        },
                        new
                        {
                            Id = "12",
                            Name = "B",
                            SemesterId = "6"
                        },
                        new
                        {
                            Id = "13",
                            Name = "A",
                            SemesterId = "7"
                        },
                        new
                        {
                            Id = "14",
                            Name = "B",
                            SemesterId = "7"
                        },
                        new
                        {
                            Id = "15",
                            Name = "C",
                            SemesterId = "7"
                        },
                        new
                        {
                            Id = "16",
                            Name = "B",
                            SemesterId = "8"
                        },
                        new
                        {
                            Id = "17",
                            Name = "A",
                            SemesterId = "8"
                        },
                        new
                        {
                            Id = "18",
                            Name = "B",
                            SemesterId = "10"
                        },
                        new
                        {
                            Id = "19",
                            Name = "A",
                            SemesterId = "10"
                        },
                        new
                        {
                            Id = "20",
                            Name = "C",
                            SemesterId = "10"
                        },
                        new
                        {
                            Id = "21",
                            Name = "A",
                            SemesterId = "11"
                        },
                        new
                        {
                            Id = "22",
                            Name = "A",
                            SemesterId = "12"
                        });
                });

            modelBuilder.Entity("CoreEMS.Models.Semester", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DepartmentId");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Semesters");

                    b.HasData(
                        new
                        {
                            Id = "1",
                            DepartmentId = "1",
                            Name = "1"
                        },
                        new
                        {
                            Id = "2",
                            DepartmentId = "1",
                            Name = "3"
                        },
                        new
                        {
                            Id = "3",
                            DepartmentId = "1",
                            Name = "5"
                        },
                        new
                        {
                            Id = "4",
                            DepartmentId = "1",
                            Name = "7"
                        },
                        new
                        {
                            Id = "5",
                            DepartmentId = "2",
                            Name = "1"
                        },
                        new
                        {
                            Id = "6",
                            DepartmentId = "2",
                            Name = "3"
                        },
                        new
                        {
                            Id = "7",
                            DepartmentId = "2",
                            Name = "5"
                        },
                        new
                        {
                            Id = "8",
                            DepartmentId = "2",
                            Name = "7"
                        },
                        new
                        {
                            Id = "9",
                            DepartmentId = "3",
                            Name = "1"
                        },
                        new
                        {
                            Id = "10",
                            DepartmentId = "3",
                            Name = "3"
                        },
                        new
                        {
                            Id = "11",
                            DepartmentId = "3",
                            Name = "5"
                        },
                        new
                        {
                            Id = "12",
                            DepartmentId = "3",
                            Name = "7"
                        });
                });

            modelBuilder.Entity("CoreEMS.Models.Student", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address")
                        .IsRequired();

                    b.Property<string>("BloodGroup");

                    b.Property<DateTime>("DateOfBirth");

                    b.Property<string>("Email");

                    b.Property<int>("Gender");

                    b.Property<string>("GuardianId");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("Password");

                    b.Property<string>("Phone")
                        .IsRequired();

                    b.Property<string>("Photo");

                    b.Property<string>("RegistrationNumber");

                    b.Property<string>("Role");

                    b.Property<string>("RollNumber");

                    b.Property<string>("SectionId");

                    b.Property<string>("Username");

                    b.HasKey("Id");

                    b.HasIndex("GuardianId")
                        .IsUnique();

                    b.HasIndex("SectionId");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            Id = "1",
                            Address = "Bangalore",
                            BloodGroup = "A+",
                            DateOfBirth = new DateTime(2019, 6, 19, 22, 18, 33, 859, DateTimeKind.Local).AddTicks(6430),
                            Gender = 0,
                            GuardianId = "1",
                            Name = "Shivam",
                            Phone = "1234567891",
                            RegistrationNumber = "1",
                            RollNumber = "1",
                            SectionId = "1"
                        },
                        new
                        {
                            Id = "2",
                            Address = "Bangalore",
                            BloodGroup = "B+",
                            DateOfBirth = new DateTime(2019, 6, 19, 22, 18, 33, 864, DateTimeKind.Local).AddTicks(2960),
                            Gender = 0,
                            GuardianId = "2",
                            Name = "Manish",
                            Phone = "1234567891",
                            RegistrationNumber = "2",
                            RollNumber = "2",
                            SectionId = "1"
                        },
                        new
                        {
                            Id = "3",
                            Address = "Bangalore",
                            BloodGroup = "AB+",
                            DateOfBirth = new DateTime(2019, 6, 19, 22, 18, 33, 864, DateTimeKind.Local).AddTicks(2990),
                            Gender = 0,
                            GuardianId = "3",
                            Name = "Ankur",
                            Phone = "1234567891",
                            RegistrationNumber = "3",
                            RollNumber = "3",
                            SectionId = "1"
                        },
                        new
                        {
                            Id = "4",
                            Address = "Bangalore",
                            BloodGroup = "O+",
                            DateOfBirth = new DateTime(2019, 6, 19, 22, 18, 33, 864, DateTimeKind.Local).AddTicks(3000),
                            Gender = 1,
                            GuardianId = "4",
                            Name = "Priti",
                            Phone = "1234567891",
                            RegistrationNumber = "4",
                            RollNumber = "4",
                            SectionId = "1"
                        },
                        new
                        {
                            Id = "5",
                            Address = "Bangalore",
                            BloodGroup = "A+",
                            DateOfBirth = new DateTime(2019, 6, 19, 22, 18, 33, 864, DateTimeKind.Local).AddTicks(3000),
                            Gender = 0,
                            GuardianId = "5",
                            Name = "Ishan",
                            Phone = "1234567891",
                            RegistrationNumber = "5",
                            RollNumber = "5",
                            SectionId = "2"
                        },
                        new
                        {
                            Id = "6",
                            Address = "Bangalore",
                            BloodGroup = "B+",
                            DateOfBirth = new DateTime(2019, 6, 19, 22, 18, 33, 864, DateTimeKind.Local).AddTicks(3000),
                            Gender = 0,
                            GuardianId = "6",
                            Name = "Satyam",
                            Phone = "1234567891",
                            RegistrationNumber = "6",
                            RollNumber = "6",
                            SectionId = "2"
                        },
                        new
                        {
                            Id = "7",
                            Address = "Bangalore",
                            BloodGroup = "AB+",
                            DateOfBirth = new DateTime(2019, 6, 19, 22, 18, 33, 864, DateTimeKind.Local).AddTicks(3010),
                            Gender = 1,
                            GuardianId = "7",
                            Name = "Madhu",
                            Phone = "1234567891",
                            RegistrationNumber = "7",
                            RollNumber = "7",
                            SectionId = "2"
                        },
                        new
                        {
                            Id = "8",
                            Address = "Bangalore",
                            BloodGroup = "A+",
                            DateOfBirth = new DateTime(2019, 6, 19, 22, 18, 33, 864, DateTimeKind.Local).AddTicks(3010),
                            Gender = 1,
                            GuardianId = "8",
                            Name = "Chikku",
                            Phone = "1234567891",
                            RegistrationNumber = "8",
                            RollNumber = "8",
                            SectionId = "2"
                        },
                        new
                        {
                            Id = "9",
                            Address = "Bangalore",
                            BloodGroup = "AB+",
                            DateOfBirth = new DateTime(2019, 6, 19, 22, 18, 33, 864, DateTimeKind.Local).AddTicks(3010),
                            Gender = 0,
                            GuardianId = "9",
                            Name = "Liyan",
                            Phone = "1234567891",
                            RegistrationNumber = "9",
                            RollNumber = "9",
                            SectionId = "3"
                        },
                        new
                        {
                            Id = "10",
                            Address = "Bangalore",
                            BloodGroup = "O+",
                            DateOfBirth = new DateTime(2019, 6, 19, 22, 18, 33, 864, DateTimeKind.Local).AddTicks(3010),
                            Gender = 0,
                            GuardianId = "10",
                            Name = "Raju",
                            Phone = "1234567891",
                            RegistrationNumber = "10",
                            RollNumber = "10",
                            SectionId = "3"
                        },
                        new
                        {
                            Id = "11",
                            Address = "Bangalore",
                            BloodGroup = "A+",
                            DateOfBirth = new DateTime(2019, 6, 19, 22, 18, 33, 864, DateTimeKind.Local).AddTicks(3010),
                            Gender = 0,
                            GuardianId = "1",
                            Name = "Rohan",
                            Phone = "1234567891",
                            RegistrationNumber = "11",
                            RollNumber = "11",
                            SectionId = "3"
                        },
                        new
                        {
                            Id = "12",
                            Address = "Bangalore",
                            BloodGroup = "AB+",
                            DateOfBirth = new DateTime(2019, 6, 19, 22, 18, 33, 864, DateTimeKind.Local).AddTicks(3020),
                            Gender = 0,
                            GuardianId = "2",
                            Name = "Ramesh",
                            Phone = "1234567891",
                            RegistrationNumber = "12",
                            RollNumber = "12",
                            SectionId = "3"
                        },
                        new
                        {
                            Id = "13",
                            Address = "Bangalore",
                            BloodGroup = "B+",
                            DateOfBirth = new DateTime(2019, 6, 19, 22, 18, 33, 864, DateTimeKind.Local).AddTicks(3020),
                            Gender = 0,
                            GuardianId = "3",
                            Name = "Suresh",
                            Phone = "1234567891",
                            RegistrationNumber = "13",
                            RollNumber = "13",
                            SectionId = "3"
                        });
                });

            modelBuilder.Entity("CoreEMS.Models.Subject", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("SemesterId")
                        .IsRequired();

                    b.Property<string>("SubjectCode")
                        .IsRequired();

                    b.Property<int>("SubjectType");

                    b.HasKey("Id");

                    b.HasIndex("SemesterId");

                    b.ToTable("Subjects");
                });

            modelBuilder.Entity("CoreEMS.Models.Teacher", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address")
                        .IsRequired();

                    b.Property<DateTime>("DateOfBirth");

                    b.Property<string>("Designation")
                        .IsRequired();

                    b.Property<string>("Email");

                    b.Property<int>("Gender");

                    b.Property<DateTime>("JoiningDate");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("Password");

                    b.Property<string>("Phone")
                        .IsRequired();

                    b.Property<string>("Photo");

                    b.Property<string>("Role");

                    b.Property<string>("Username");

                    b.HasKey("Id");

                    b.ToTable("Teachers");
                });

            modelBuilder.Entity("CoreEMS.Models.Book", b =>
                {
                    b.HasOne("CoreEMS.Models.Subject")
                        .WithMany("ReferenceBooks")
                        .HasForeignKey("SubjectId");
                });

            modelBuilder.Entity("CoreEMS.Models.Lecture", b =>
                {
                    b.HasOne("CoreEMS.Models.Section", "Section")
                        .WithMany("Lectures")
                        .HasForeignKey("SectionId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CoreEMS.Models.Subject", "Subject")
                        .WithMany()
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CoreEMS.Models.Teacher", "Teacher")
                        .WithMany()
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CoreEMS.Models.Section", b =>
                {
                    b.HasOne("CoreEMS.Models.Semester", "Semester")
                        .WithMany("Sections")
                        .HasForeignKey("SemesterId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CoreEMS.Models.Semester", b =>
                {
                    b.HasOne("CoreEMS.Models.Department", "Department")
                        .WithMany("Semesters")
                        .HasForeignKey("DepartmentId");
                });

            modelBuilder.Entity("CoreEMS.Models.Student", b =>
                {
                    b.HasOne("CoreEMS.Models.Guardian", "Guardian")
                        .WithOne("Student")
                        .HasForeignKey("CoreEMS.Models.Student", "GuardianId");

                    b.HasOne("CoreEMS.Models.Section", "Section")
                        .WithMany()
                        .HasForeignKey("SectionId");
                });

            modelBuilder.Entity("CoreEMS.Models.Subject", b =>
                {
                    b.HasOne("CoreEMS.Models.Semester", "Semester")
                        .WithMany()
                        .HasForeignKey("SemesterId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}