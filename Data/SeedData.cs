using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ContosoPets.Api.Models;
using CoreEMS.Models;
using System.Collections.Generic;

namespace Core.Data
{
    public class SeedData
    {
        public static readonly List<Department> departments = new List<Department>() {
            new Department() { Id = "1", Name = "CSE" },
            new Department() { Id = "2", Name = "ISE" },
            new Department() { Id = "3", Name = "ECE" },
        };

        public static readonly List<Semester> semesters = new List<Semester>() {
            new Semester() { Id = "1", Name = "1", DepartmentId = "1" },
            new Semester() { Id = "2", Name = "3", DepartmentId = "1" },
            new Semester() { Id = "3", Name = "5", DepartmentId = "1" },
            new Semester() { Id = "4", Name = "7", DepartmentId = "1" },

            new Semester() { Id = "5", Name = "1", DepartmentId = "2" },
            new Semester() { Id = "6", Name = "3", DepartmentId = "2" },
            new Semester() { Id = "7", Name = "5", DepartmentId = "2" },
            new Semester() { Id = "8", Name = "7", DepartmentId = "2" },

            new Semester() { Id = "9", Name = "1", DepartmentId = "3" },
            new Semester() { Id = "10", Name = "3", DepartmentId = "3" },
            new Semester() { Id = "11", Name = "5", DepartmentId = "3" },
            new Semester() { Id = "12", Name = "7", DepartmentId = "3" },
        };

        public static readonly List<Section> sections = new List<Section>() {
            new Section() { Id = "1", Name = "A", SemesterId = "1" },
            new Section() { Id = "2", Name = "B", SemesterId = "1" },
            new Section() { Id = "3", Name = "A", SemesterId = "2" },
            new Section() { Id = "4", Name = "B", SemesterId = "2" },

            new Section() { Id = "5", Name = "A", SemesterId = "3" },
            new Section() { Id = "6", Name = "B", SemesterId = "3" },
            new Section() { Id = "7", Name = "A", SemesterId = "4" },
            new Section() { Id = "8", Name = "B", SemesterId = "4" },

            new Section() { Id = "9", Name = "A", SemesterId = "5" },
            new Section() { Id = "10", Name = "B", SemesterId = "5" },
            new Section() { Id = "11", Name = "A", SemesterId = "6" },
            new Section() { Id = "12", Name = "B", SemesterId = "6" },

            new Section() { Id = "13", Name = "A", SemesterId = "7" },
            new Section() { Id = "14", Name = "B", SemesterId = "7" },
            new Section() { Id = "15", Name = "C", SemesterId = "7" },
            new Section() { Id = "16", Name = "B", SemesterId = "8" },

            new Section() { Id = "17", Name = "A", SemesterId = "8" },
            new Section() { Id = "18", Name = "B", SemesterId = "10" },
            new Section() { Id = "19", Name = "A", SemesterId = "10" },
            new Section() { Id = "20", Name = "C", SemesterId = "10" },
            new Section() { Id = "21", Name = "A", SemesterId = "11" },
            new Section() { Id = "22", Name = "A", SemesterId = "12" },
        };
        
        public static readonly List<Guardian> guardians = new List<Guardian>() {
            new Guardian() { Id = "1", Name = "Papa 1", Address = "Bangalore", Phone = "1234567891" },
            new Guardian() { Id = "2", Name = "Papa 2", Address = "Pune", Phone = "1234567891" },
            new Guardian() { Id = "3", Name = "Papa 3", Address = "Mumbai", Phone = "1234567891" },
            new Guardian() { Id = "4", Name = "Papa 4", Address = "Chennai", Phone = "1234567891" },
            new Guardian() { Id = "5", Name = "Papa 5", Address = "Vijaywada", Phone = "1234567891" },
            new Guardian() { Id = "6", Name = "Papa 6", Address = "Cochin", Phone = "1234567891" },
            new Guardian() { Id = "7", Name = "Papa 7", Address = "Delhi", Phone = "1234567891" },
            new Guardian() { Id = "8", Name = "Papa 8", Address = "Chandigarh", Phone = "1234567891" },
            new Guardian() { Id = "9", Name = "Papa 9", Address = "Calcutta", Phone = "1234567891" },
            new Guardian() { Id = "10", Name = "Papa 10", Address = "Manali", Phone = "1234567891" },
        };

        public static readonly List<Student> students = new List<Student>() {
            new Student() { Id = "1", Name = "Shivam", GuardianId = "1", SectionId = "1", DateOfBirth = DateTime.Now, Gender = Gender.MALE, BloodGroup = "A+", Phone = "1234567891", Address = "Bangalore", RegistrationNumber = "1", RollNumber = "1" },
            new Student() { Id = "2", Name = "Manish", GuardianId = "2", SectionId = "1", DateOfBirth = DateTime.Now, Gender = Gender.MALE, BloodGroup = "B+", Phone = "1234567891", Address = "Bangalore", RegistrationNumber = "2", RollNumber = "2" },
            new Student() { Id = "3", Name = "Ankur", GuardianId = "3", SectionId = "1", DateOfBirth = DateTime.Now, Gender = Gender.MALE, BloodGroup = "AB+", Phone = "1234567891", Address = "Bangalore", RegistrationNumber = "3", RollNumber = "3" },
            new Student() { Id = "4", Name = "Priti", GuardianId = "4", SectionId = "1", DateOfBirth = DateTime.Now, Gender = Gender.FEMALE, BloodGroup = "O+", Phone = "1234567891", Address = "Bangalore", RegistrationNumber = "4", RollNumber = "4" },

            new Student() { Id = "5", Name = "Ishan", GuardianId = "5", SectionId = "2", DateOfBirth = DateTime.Now, Gender = Gender.MALE, BloodGroup = "A+", Phone = "1234567891", Address = "Bangalore", RegistrationNumber = "5", RollNumber = "5" },
            new Student() { Id = "6", Name = "Satyam", GuardianId = "6", SectionId = "2", DateOfBirth = DateTime.Now, Gender = Gender.MALE, BloodGroup = "B+", Phone = "1234567891", Address = "Bangalore", RegistrationNumber = "6", RollNumber = "6" },
            new Student() { Id = "7", Name = "Madhu", GuardianId = "7", SectionId = "2", DateOfBirth = DateTime.Now, Gender = Gender.FEMALE, BloodGroup = "AB+", Phone = "1234567891", Address = "Bangalore", RegistrationNumber = "7", RollNumber = "7" },
            new Student() { Id = "8", Name = "Chikku", GuardianId = "8", SectionId = "2", DateOfBirth = DateTime.Now, Gender = Gender.FEMALE, BloodGroup = "A+", Phone = "1234567891", Address = "Bangalore", RegistrationNumber = "8", RollNumber = "8" },

            new Student() { Id = "9", Name = "Liyan", GuardianId = "9", SectionId = "3", DateOfBirth = DateTime.Now, Gender = Gender.MALE, BloodGroup = "AB+", Phone = "1234567891", Address = "Bangalore", RegistrationNumber = "9", RollNumber = "9" },
            new Student() { Id = "10", Name = "Raju", GuardianId = "10", SectionId = "3", DateOfBirth = DateTime.Now, Gender = Gender.MALE, BloodGroup = "O+", Phone = "1234567891", Address = "Bangalore", RegistrationNumber = "10", RollNumber = "10" },
            new Student() { Id = "11", Name = "Rohan", GuardianId = "1", SectionId = "3", DateOfBirth = DateTime.Now, Gender = Gender.MALE, BloodGroup = "A+", Phone = "1234567891", Address = "Bangalore", RegistrationNumber = "11", RollNumber = "11" },
            new Student() { Id = "12", Name = "Ramesh", GuardianId = "2", SectionId = "3", DateOfBirth = DateTime.Now, Gender = Gender.MALE, BloodGroup = "AB+", Phone = "1234567891", Address = "Bangalore", RegistrationNumber = "12", RollNumber = "12" },
            new Student() { Id = "13", Name = "Suresh", GuardianId = "3", SectionId = "3", DateOfBirth = DateTime.Now, Gender = Gender.MALE, BloodGroup = "B+", Phone = "1234567891", Address = "Bangalore", RegistrationNumber = "13", RollNumber = "13" },

        };
        
        
        public static void Initialize(EMSContext context)
        {
            if (!context.Products.Any())
            {
                context.Products.AddRange(
                    new Product
                    {
                        Id = "1",
                        Name = "Squeaky Bone",
                        Price = 20.99m
                    },
                    new Product
                    {
                        Id = "2",
                        Name = "Knotted Rope",
                        Price = 12.99m
                    },
                    new Product
                    {
                        Id = "3",
                        Name = "Bats",
                        Price = 12.99m
                    },
                    new Product
                    {
                        Id = "4",
                        Name = "Balls",
                        Price = 12.99m
                    },
                    new Product
                    {
                        Id = "5",
                        Name = "Leg Guards",
                        Price = 12.99m
                    }
                );

                context.SaveChanges();
            }
        }
    }
}