using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CoreEMS.Migrations.EMS
{
    public partial class seedstudentsfinal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Guardians",
                columns: new[] { "Id", "Address", "Email", "Name", "Password", "Phone", "Photo", "Role", "Username" },
                values: new object[,]
                {
                    { "1", "Bangalore", null, "Papa 1", null, "1234567891", null, null, null },
                    { "2", "Pune", null, "Papa 2", null, "1234567891", null, null, null },
                    { "3", "Mumbai", null, "Papa 3", null, "1234567891", null, null, null },
                    { "4", "Chennai", null, "Papa 4", null, "1234567891", null, null, null },
                    { "5", "Vijaywada", null, "Papa 5", null, "1234567891", null, null, null },
                    { "6", "Cochin", null, "Papa 6", null, "1234567891", null, null, null },
                    { "7", "Delhi", null, "Papa 7", null, "1234567891", null, null, null },
                    { "8", "Chandigarh", null, "Papa 8", null, "1234567891", null, null, null },
                    { "9", "Calcutta", null, "Papa 9", null, "1234567891", null, null, null },
                    { "10", "Manali", null, "Papa 10", null, "1234567891", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Semesters",
                columns: new[] { "Id", "DepartmentId", "Name" },
                values: new object[,]
                {
                    { "10", "3", "3" },
                    { "9", "3", "1" },
                    { "8", "2", "7" },
                    { "7", "2", "5" },
                    { "6", "2", "3" },
                    { "1", "1", "1" },
                    { "4", "1", "7" },
                    { "3", "1", "5" },
                    { "2", "1", "3" },
                    { "11", "3", "5" },
                    { "5", "2", "1" },
                    { "12", "3", "7" }
                });

            migrationBuilder.InsertData(
                table: "Sections",
                columns: new[] { "Id", "Name", "SemesterId" },
                values: new object[,]
                {
                    { "1", "A", "1" },
                    { "20", "C", "10" },
                    { "19", "A", "10" },
                    { "18", "B", "10" },
                    { "17", "A", "8" },
                    { "16", "B", "8" },
                    { "15", "C", "7" },
                    { "14", "B", "7" },
                    { "13", "A", "7" },
                    { "12", "B", "6" },
                    { "11", "A", "6" },
                    { "10", "B", "5" },
                    { "9", "A", "5" },
                    { "8", "B", "4" },
                    { "7", "A", "4" },
                    { "6", "B", "3" },
                    { "5", "A", "3" },
                    { "4", "B", "2" },
                    { "3", "A", "2" },
                    { "2", "B", "1" },
                    { "21", "A", "11" },
                    { "22", "A", "12" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Address", "BloodGroup", "DateOfBirth", "Email", "Gender", "GuardianId", "Name", "Password", "Phone", "Photo", "RegistrationNumber", "Role", "RollNumber", "SectionId", "Username" },
                values: new object[,]
                {
                    { "1", "Bangalore", "A+", new DateTime(2019, 6, 18, 22, 52, 39, 610, DateTimeKind.Local).AddTicks(3100), null, 0, null, "Shivam", null, "1234567891", null, "1", null, "1", "1", null },
                    { "2", "Bangalore", "B+", new DateTime(2019, 6, 18, 22, 52, 39, 616, DateTimeKind.Local).AddTicks(8550), null, 0, null, "Manish", null, "1234567891", null, "2", null, "2", "1", null },
                    { "3", "Bangalore", "AB+", new DateTime(2019, 6, 18, 22, 52, 39, 616, DateTimeKind.Local).AddTicks(8590), null, 0, null, "Ankur", null, "1234567891", null, "3", null, "3", "1", null },
                    { "4", "Bangalore", "O+", new DateTime(2019, 6, 18, 22, 52, 39, 616, DateTimeKind.Local).AddTicks(8590), null, 1, "4", "Priti", null, "1234567891", null, "4", null, "4", "1", null },
                    { "5", "Bangalore", "A+", new DateTime(2019, 6, 18, 22, 52, 39, 616, DateTimeKind.Local).AddTicks(8590), null, 0, "5", "Ishan", null, "1234567891", null, "5", null, "5", "2", null },
                    { "6", "Bangalore", "B+", new DateTime(2019, 6, 18, 22, 52, 39, 616, DateTimeKind.Local).AddTicks(8600), null, 0, "6", "Satyam", null, "1234567891", null, "6", null, "6", "2", null },
                    { "7", "Bangalore", "AB+", new DateTime(2019, 6, 18, 22, 52, 39, 616, DateTimeKind.Local).AddTicks(8600), null, 1, "7", "Madhu", null, "1234567891", null, "7", null, "7", "2", null },
                    { "8", "Bangalore", "A+", new DateTime(2019, 6, 18, 22, 52, 39, 616, DateTimeKind.Local).AddTicks(8610), null, 1, "8", "Chikku", null, "1234567891", null, "8", null, "8", "2", null },
                    { "9", "Bangalore", "AB+", new DateTime(2019, 6, 18, 22, 52, 39, 616, DateTimeKind.Local).AddTicks(8610), null, 0, "9", "Liyan", null, "1234567891", null, "9", null, "9", "3", null },
                    { "10", "Bangalore", "O+", new DateTime(2019, 6, 18, 22, 52, 39, 616, DateTimeKind.Local).AddTicks(8610), null, 0, "10", "Raju", null, "1234567891", null, "10", null, "10", "3", null },
                    { "11", "Bangalore", "A+", new DateTime(2019, 6, 18, 22, 52, 39, 616, DateTimeKind.Local).AddTicks(8620), null, 0, "1", "Rohan", null, "1234567891", null, "11", null, "11", "3", null },
                    { "12", "Bangalore", "AB+", new DateTime(2019, 6, 18, 22, 52, 39, 616, DateTimeKind.Local).AddTicks(8620), null, 0, "2", "Ramesh", null, "1234567891", null, "12", null, "12", "3", null },
                    { "13", "Bangalore", "B+", new DateTime(2019, 6, 18, 22, 52, 39, 616, DateTimeKind.Local).AddTicks(8620), null, 0, "3", "Suresh", null, "1234567891", null, "13", null, "13", "3", null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: "10");

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: "11");

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: "12");

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: "13");

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: "14");

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: "15");

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: "16");

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: "17");

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: "18");

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: "19");

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: "20");

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: "21");

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: "22");

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: "4");

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: "5");

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: "6");

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: "7");

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: "8");

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: "9");

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: "9");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "10");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "11");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "12");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "13");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "3");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "4");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "5");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "6");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "7");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "8");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "9");

            migrationBuilder.DeleteData(
                table: "Guardians",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "Guardians",
                keyColumn: "Id",
                keyValue: "10");

            migrationBuilder.DeleteData(
                table: "Guardians",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "Guardians",
                keyColumn: "Id",
                keyValue: "3");

            migrationBuilder.DeleteData(
                table: "Guardians",
                keyColumn: "Id",
                keyValue: "4");

            migrationBuilder.DeleteData(
                table: "Guardians",
                keyColumn: "Id",
                keyValue: "5");

            migrationBuilder.DeleteData(
                table: "Guardians",
                keyColumn: "Id",
                keyValue: "6");

            migrationBuilder.DeleteData(
                table: "Guardians",
                keyColumn: "Id",
                keyValue: "7");

            migrationBuilder.DeleteData(
                table: "Guardians",
                keyColumn: "Id",
                keyValue: "8");

            migrationBuilder.DeleteData(
                table: "Guardians",
                keyColumn: "Id",
                keyValue: "9");

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: "3");

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: "10");

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: "11");

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: "12");

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: "3");

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: "4");

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: "5");

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: "6");

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: "7");

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: "8");

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: "2");
        }
    }
}
