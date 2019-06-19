using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CoreEMS.Migrations.EMS
{
    public partial class addingDepartmentSemesterRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "DateOfBirth", "GuardianId" },
                values: new object[] { new DateTime(2019, 6, 19, 22, 18, 33, 859, DateTimeKind.Local).AddTicks(6430), null });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "10",
                column: "DateOfBirth",
                value: new DateTime(2019, 6, 19, 22, 18, 33, 864, DateTimeKind.Local).AddTicks(3010));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "11",
                column: "DateOfBirth",
                value: new DateTime(2019, 6, 19, 22, 18, 33, 864, DateTimeKind.Local).AddTicks(3010));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "12",
                column: "DateOfBirth",
                value: new DateTime(2019, 6, 19, 22, 18, 33, 864, DateTimeKind.Local).AddTicks(3020));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "13",
                column: "DateOfBirth",
                value: new DateTime(2019, 6, 19, 22, 18, 33, 864, DateTimeKind.Local).AddTicks(3020));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "DateOfBirth", "GuardianId" },
                values: new object[] { new DateTime(2019, 6, 19, 22, 18, 33, 864, DateTimeKind.Local).AddTicks(2960), null });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "DateOfBirth", "GuardianId" },
                values: new object[] { new DateTime(2019, 6, 19, 22, 18, 33, 864, DateTimeKind.Local).AddTicks(2990), null });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "4",
                column: "DateOfBirth",
                value: new DateTime(2019, 6, 19, 22, 18, 33, 864, DateTimeKind.Local).AddTicks(3000));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "5",
                column: "DateOfBirth",
                value: new DateTime(2019, 6, 19, 22, 18, 33, 864, DateTimeKind.Local).AddTicks(3000));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "6",
                column: "DateOfBirth",
                value: new DateTime(2019, 6, 19, 22, 18, 33, 864, DateTimeKind.Local).AddTicks(3000));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "7",
                column: "DateOfBirth",
                value: new DateTime(2019, 6, 19, 22, 18, 33, 864, DateTimeKind.Local).AddTicks(3010));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "8",
                column: "DateOfBirth",
                value: new DateTime(2019, 6, 19, 22, 18, 33, 864, DateTimeKind.Local).AddTicks(3010));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "9",
                column: "DateOfBirth",
                value: new DateTime(2019, 6, 19, 22, 18, 33, 864, DateTimeKind.Local).AddTicks(3010));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "DateOfBirth", "GuardianId" },
                values: new object[] { new DateTime(2019, 6, 18, 22, 52, 39, 610, DateTimeKind.Local).AddTicks(3100), "1" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "10",
                column: "DateOfBirth",
                value: new DateTime(2019, 6, 18, 22, 52, 39, 616, DateTimeKind.Local).AddTicks(8610));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "11",
                column: "DateOfBirth",
                value: new DateTime(2019, 6, 18, 22, 52, 39, 616, DateTimeKind.Local).AddTicks(8620));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "12",
                column: "DateOfBirth",
                value: new DateTime(2019, 6, 18, 22, 52, 39, 616, DateTimeKind.Local).AddTicks(8620));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "13",
                column: "DateOfBirth",
                value: new DateTime(2019, 6, 18, 22, 52, 39, 616, DateTimeKind.Local).AddTicks(8620));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "DateOfBirth", "GuardianId" },
                values: new object[] { new DateTime(2019, 6, 18, 22, 52, 39, 616, DateTimeKind.Local).AddTicks(8550), "2" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "DateOfBirth", "GuardianId" },
                values: new object[] { new DateTime(2019, 6, 18, 22, 52, 39, 616, DateTimeKind.Local).AddTicks(8590), "3" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "4",
                column: "DateOfBirth",
                value: new DateTime(2019, 6, 18, 22, 52, 39, 616, DateTimeKind.Local).AddTicks(8590));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "5",
                column: "DateOfBirth",
                value: new DateTime(2019, 6, 18, 22, 52, 39, 616, DateTimeKind.Local).AddTicks(8590));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "6",
                column: "DateOfBirth",
                value: new DateTime(2019, 6, 18, 22, 52, 39, 616, DateTimeKind.Local).AddTicks(8600));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "7",
                column: "DateOfBirth",
                value: new DateTime(2019, 6, 18, 22, 52, 39, 616, DateTimeKind.Local).AddTicks(8600));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "8",
                column: "DateOfBirth",
                value: new DateTime(2019, 6, 18, 22, 52, 39, 616, DateTimeKind.Local).AddTicks(8610));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "9",
                column: "DateOfBirth",
                value: new DateTime(2019, 6, 18, 22, 52, 39, 616, DateTimeKind.Local).AddTicks(8610));
        }
    }
}
