using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ReceiveDate",
                table: "RentalContract",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 31, 0, 20, 11, 470, DateTimeKind.Local).AddTicks(7393),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 7, 30, 23, 42, 26, 907, DateTimeKind.Local).AddTicks(9252));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckOutDate",
                table: "RentalContract",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 31, 0, 20, 11, 470, DateTimeKind.Local).AddTicks(8467),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 7, 30, 23, 42, 26, 907, DateTimeKind.Local).AddTicks(9634));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Birthday",
                table: "People",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 31, 0, 20, 11, 465, DateTimeKind.Local).AddTicks(224),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 7, 30, 23, 42, 26, 907, DateTimeKind.Local).AddTicks(4712));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Days",
                table: "PaymentExtension",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 31, 0, 20, 11, 459, DateTimeKind.Local).AddTicks(5558),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 7, 30, 23, 42, 26, 907, DateTimeKind.Local).AddTicks(146));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ReceiveDate",
                table: "DepositsContract",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 31, 0, 20, 11, 458, DateTimeKind.Local).AddTicks(6775),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 7, 30, 23, 42, 26, 906, DateTimeKind.Local).AddTicks(5336));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DepositsDate",
                table: "DepositsContract",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 31, 0, 20, 11, 458, DateTimeKind.Local).AddTicks(6149),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 7, 30, 23, 42, 26, 906, DateTimeKind.Local).AddTicks(4970));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PayDate",
                table: "Bill",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 31, 0, 20, 11, 457, DateTimeKind.Local).AddTicks(6687),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 7, 30, 23, 42, 26, 906, DateTimeKind.Local).AddTicks(941));

            migrationBuilder.UpdateData(
                table: "Bill",
                keyColumn: "ID",
                keyValue: 1,
                column: "PayDate",
                value: new DateTime(2023, 7, 31, 0, 20, 11, 474, DateTimeKind.Local).AddTicks(7145));

            migrationBuilder.UpdateData(
                table: "DepositsContract",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CheckOutDate", "DepositsDate", "ReceiveDate" },
                values: new object[] { new DateTime(2023, 7, 31, 0, 20, 11, 474, DateTimeKind.Local).AddTicks(7206), new DateTime(2023, 7, 31, 0, 20, 11, 474, DateTimeKind.Local).AddTicks(7201), new DateTime(2023, 7, 31, 0, 20, 11, 474, DateTimeKind.Local).AddTicks(7204) });

            migrationBuilder.UpdateData(
                table: "PaymentExtension",
                keyColumn: "ID",
                keyValue: 1,
                column: "Days",
                value: new DateTime(2023, 7, 31, 0, 20, 11, 474, DateTimeKind.Local).AddTicks(7277));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "ID",
                keyValue: 1,
                column: "Birthday",
                value: new DateTime(2023, 7, 31, 0, 20, 11, 474, DateTimeKind.Local).AddTicks(7315));

            migrationBuilder.UpdateData(
                table: "RentalContract",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CheckOutDate", "ReceiveDate" },
                values: new object[] { new DateTime(2023, 7, 31, 0, 20, 11, 474, DateTimeKind.Local).AddTicks(7358), new DateTime(2023, 7, 31, 0, 20, 11, 474, DateTimeKind.Local).AddTicks(7357) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ReceiveDate",
                table: "RentalContract",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 30, 23, 42, 26, 907, DateTimeKind.Local).AddTicks(9252),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 7, 31, 0, 20, 11, 470, DateTimeKind.Local).AddTicks(7393));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckOutDate",
                table: "RentalContract",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 30, 23, 42, 26, 907, DateTimeKind.Local).AddTicks(9634),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 7, 31, 0, 20, 11, 470, DateTimeKind.Local).AddTicks(8467));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Birthday",
                table: "People",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 30, 23, 42, 26, 907, DateTimeKind.Local).AddTicks(4712),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 7, 31, 0, 20, 11, 465, DateTimeKind.Local).AddTicks(224));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Days",
                table: "PaymentExtension",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 30, 23, 42, 26, 907, DateTimeKind.Local).AddTicks(146),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 7, 31, 0, 20, 11, 459, DateTimeKind.Local).AddTicks(5558));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ReceiveDate",
                table: "DepositsContract",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 30, 23, 42, 26, 906, DateTimeKind.Local).AddTicks(5336),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 7, 31, 0, 20, 11, 458, DateTimeKind.Local).AddTicks(6775));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DepositsDate",
                table: "DepositsContract",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 30, 23, 42, 26, 906, DateTimeKind.Local).AddTicks(4970),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 7, 31, 0, 20, 11, 458, DateTimeKind.Local).AddTicks(6149));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PayDate",
                table: "Bill",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 30, 23, 42, 26, 906, DateTimeKind.Local).AddTicks(941),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 7, 31, 0, 20, 11, 457, DateTimeKind.Local).AddTicks(6687));

            migrationBuilder.UpdateData(
                table: "Bill",
                keyColumn: "ID",
                keyValue: 1,
                column: "PayDate",
                value: new DateTime(2023, 7, 30, 23, 42, 26, 909, DateTimeKind.Local).AddTicks(5749));

            migrationBuilder.UpdateData(
                table: "DepositsContract",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CheckOutDate", "DepositsDate", "ReceiveDate" },
                values: new object[] { new DateTime(2023, 7, 30, 23, 42, 26, 909, DateTimeKind.Local).AddTicks(5770), new DateTime(2023, 7, 30, 23, 42, 26, 909, DateTimeKind.Local).AddTicks(5768), new DateTime(2023, 7, 30, 23, 42, 26, 909, DateTimeKind.Local).AddTicks(5769) });

            migrationBuilder.UpdateData(
                table: "PaymentExtension",
                keyColumn: "ID",
                keyValue: 1,
                column: "Days",
                value: new DateTime(2023, 7, 30, 23, 42, 26, 909, DateTimeKind.Local).AddTicks(5798));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "ID",
                keyValue: 1,
                column: "Birthday",
                value: new DateTime(2023, 7, 30, 23, 42, 26, 909, DateTimeKind.Local).AddTicks(5814));

            migrationBuilder.UpdateData(
                table: "RentalContract",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CheckOutDate", "ReceiveDate" },
                values: new object[] { new DateTime(2023, 7, 30, 23, 42, 26, 909, DateTimeKind.Local).AddTicks(5832), new DateTime(2023, 7, 30, 23, 42, 26, 909, DateTimeKind.Local).AddTicks(5831) });
        }
    }
}
