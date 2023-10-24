using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class DataSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ReceiveDate",
                table: "RentalContract",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 15, 18, 29, 42, 805, DateTimeKind.Local).AddTicks(2295),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 15, 18, 29, 28, 37, DateTimeKind.Local).AddTicks(2994));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckOutDate",
                table: "RentalContract",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 15, 18, 29, 42, 805, DateTimeKind.Local).AddTicks(2668),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 15, 18, 29, 28, 37, DateTimeKind.Local).AddTicks(3357));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Birthday",
                table: "People",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 15, 18, 29, 42, 804, DateTimeKind.Local).AddTicks(6739),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 15, 18, 29, 28, 36, DateTimeKind.Local).AddTicks(7922));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Days",
                table: "PaymentExtension",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 15, 18, 29, 42, 804, DateTimeKind.Local).AddTicks(4755),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 15, 18, 29, 28, 36, DateTimeKind.Local).AddTicks(5904));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ReceiveDate",
                table: "DepositsContract",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 15, 18, 29, 42, 803, DateTimeKind.Local).AddTicks(8570),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 15, 18, 29, 28, 36, DateTimeKind.Local).AddTicks(220));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DepositsDate",
                table: "DepositsContract",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 15, 18, 29, 42, 803, DateTimeKind.Local).AddTicks(8109),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 15, 18, 29, 28, 35, DateTimeKind.Local).AddTicks(9656));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PayDate",
                table: "Bill",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 15, 18, 29, 42, 803, DateTimeKind.Local).AddTicks(2630),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 15, 18, 29, 28, 35, DateTimeKind.Local).AddTicks(5432));

            migrationBuilder.UpdateData(
                table: "Bill",
                keyColumn: "ID",
                keyValue: 1,
                column: "PayDate",
                value: new DateTime(2023, 10, 15, 18, 29, 42, 811, DateTimeKind.Local).AddTicks(8561));

            migrationBuilder.UpdateData(
                table: "DepositsContract",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CheckOutDate", "DepositsDate", "ReceiveDate" },
                values: new object[] { new DateTime(2023, 10, 15, 18, 29, 42, 811, DateTimeKind.Local).AddTicks(8607), new DateTime(2023, 10, 15, 18, 29, 42, 811, DateTimeKind.Local).AddTicks(8605), new DateTime(2023, 10, 15, 18, 29, 42, 811, DateTimeKind.Local).AddTicks(8606) });

            migrationBuilder.UpdateData(
                table: "PaymentExtension",
                keyColumn: "ID",
                keyValue: 1,
                column: "Days",
                value: new DateTime(2023, 10, 15, 18, 29, 42, 811, DateTimeKind.Local).AddTicks(8665));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "ID",
                keyValue: 1,
                column: "Birthday",
                value: new DateTime(2023, 10, 15, 18, 29, 42, 811, DateTimeKind.Local).AddTicks(8695));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "ID",
                keyValue: 2,
                column: "Birthday",
                value: new DateTime(1992, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "ID",
                keyValue: 3,
                column: "Birthday",
                value: new DateTime(1998, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "ID",
                keyValue: 4,
                column: "Birthday",
                value: new DateTime(1996, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "ID",
                keyValue: 5,
                column: "Birthday",
                value: new DateTime(1995, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RentalContract",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CheckOutDate", "ReceiveDate" },
                values: new object[] { new DateTime(2023, 10, 15, 18, 29, 42, 811, DateTimeKind.Local).AddTicks(8823), new DateTime(2023, 10, 15, 18, 29, 42, 811, DateTimeKind.Local).AddTicks(8822) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ReceiveDate",
                table: "RentalContract",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 15, 18, 29, 28, 37, DateTimeKind.Local).AddTicks(2994),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 15, 18, 29, 42, 805, DateTimeKind.Local).AddTicks(2295));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckOutDate",
                table: "RentalContract",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 15, 18, 29, 28, 37, DateTimeKind.Local).AddTicks(3357),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 15, 18, 29, 42, 805, DateTimeKind.Local).AddTicks(2668));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Birthday",
                table: "People",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 15, 18, 29, 28, 36, DateTimeKind.Local).AddTicks(7922),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 15, 18, 29, 42, 804, DateTimeKind.Local).AddTicks(6739));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Days",
                table: "PaymentExtension",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 15, 18, 29, 28, 36, DateTimeKind.Local).AddTicks(5904),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 15, 18, 29, 42, 804, DateTimeKind.Local).AddTicks(4755));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ReceiveDate",
                table: "DepositsContract",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 15, 18, 29, 28, 36, DateTimeKind.Local).AddTicks(220),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 15, 18, 29, 42, 803, DateTimeKind.Local).AddTicks(8570));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DepositsDate",
                table: "DepositsContract",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 15, 18, 29, 28, 35, DateTimeKind.Local).AddTicks(9656),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 15, 18, 29, 42, 803, DateTimeKind.Local).AddTicks(8109));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PayDate",
                table: "Bill",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 15, 18, 29, 28, 35, DateTimeKind.Local).AddTicks(5432),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 15, 18, 29, 42, 803, DateTimeKind.Local).AddTicks(2630));

            migrationBuilder.UpdateData(
                table: "Bill",
                keyColumn: "ID",
                keyValue: 1,
                column: "PayDate",
                value: new DateTime(2023, 10, 15, 18, 29, 28, 40, DateTimeKind.Local).AddTicks(1057));

            migrationBuilder.UpdateData(
                table: "DepositsContract",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CheckOutDate", "DepositsDate", "ReceiveDate" },
                values: new object[] { new DateTime(2023, 10, 15, 18, 29, 28, 40, DateTimeKind.Local).AddTicks(1081), new DateTime(2023, 10, 15, 18, 29, 28, 40, DateTimeKind.Local).AddTicks(1079), new DateTime(2023, 10, 15, 18, 29, 28, 40, DateTimeKind.Local).AddTicks(1080) });

            migrationBuilder.UpdateData(
                table: "PaymentExtension",
                keyColumn: "ID",
                keyValue: 1,
                column: "Days",
                value: new DateTime(2023, 10, 15, 18, 29, 28, 40, DateTimeKind.Local).AddTicks(1108));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "ID",
                keyValue: 1,
                column: "Birthday",
                value: new DateTime(2023, 10, 15, 18, 29, 28, 40, DateTimeKind.Local).AddTicks(1123));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "ID",
                keyValue: 2,
                column: "Birthday",
                value: new DateTime(1994, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "ID",
                keyValue: 3,
                column: "Birthday",
                value: new DateTime(2000, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "ID",
                keyValue: 4,
                column: "Birthday",
                value: new DateTime(2000, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "ID",
                keyValue: 5,
                column: "Birthday",
                value: new DateTime(1999, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RentalContract",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CheckOutDate", "ReceiveDate" },
                values: new object[] { new DateTime(2023, 10, 15, 18, 29, 28, 40, DateTimeKind.Local).AddTicks(1219), new DateTime(2023, 10, 15, 18, 29, 28, 40, DateTimeKind.Local).AddTicks(1217) });
        }
    }
}
