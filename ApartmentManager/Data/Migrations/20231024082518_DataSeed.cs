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
                defaultValue: new DateTime(2023, 10, 24, 15, 25, 17, 961, DateTimeKind.Local).AddTicks(4253),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 24, 15, 25, 2, 789, DateTimeKind.Local).AddTicks(5992));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckOutDate",
                table: "RentalContract",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 24, 15, 25, 17, 961, DateTimeKind.Local).AddTicks(4570),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 24, 15, 25, 2, 789, DateTimeKind.Local).AddTicks(6382));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Birthday",
                table: "People",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 24, 15, 25, 17, 961, DateTimeKind.Local).AddTicks(561),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 24, 15, 25, 2, 789, DateTimeKind.Local).AddTicks(2013));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Days",
                table: "PaymentExtension",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 24, 15, 25, 17, 960, DateTimeKind.Local).AddTicks(9159),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 24, 15, 25, 2, 789, DateTimeKind.Local).AddTicks(600));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ReceiveDate",
                table: "DepositsContract",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 24, 15, 25, 17, 960, DateTimeKind.Local).AddTicks(4568),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 24, 15, 25, 2, 788, DateTimeKind.Local).AddTicks(5855));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DepositsDate",
                table: "DepositsContract",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 24, 15, 25, 17, 960, DateTimeKind.Local).AddTicks(4273),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 24, 15, 25, 2, 788, DateTimeKind.Local).AddTicks(5540));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PayDate",
                table: "Bill",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 24, 15, 25, 17, 960, DateTimeKind.Local).AddTicks(860),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 24, 15, 25, 2, 788, DateTimeKind.Local).AddTicks(1943));

            migrationBuilder.UpdateData(
                table: "Bill",
                keyColumn: "ID",
                keyValue: 1,
                column: "PayDate",
                value: new DateTime(2023, 10, 24, 15, 25, 17, 963, DateTimeKind.Local).AddTicks(6926));

            migrationBuilder.UpdateData(
                table: "DepositsContract",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CheckOutDate", "DepositsDate", "ReceiveDate" },
                values: new object[] { new DateTime(2023, 10, 24, 15, 25, 17, 963, DateTimeKind.Local).AddTicks(6946), new DateTime(2023, 10, 24, 15, 25, 17, 963, DateTimeKind.Local).AddTicks(6945), new DateTime(2023, 10, 24, 15, 25, 17, 963, DateTimeKind.Local).AddTicks(6946) });

            migrationBuilder.UpdateData(
                table: "PaymentExtension",
                keyColumn: "ID",
                keyValue: 1,
                column: "Days",
                value: new DateTime(2023, 10, 24, 15, 25, 17, 963, DateTimeKind.Local).AddTicks(6972));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "ID",
                keyValue: 1,
                column: "Birthday",
                value: new DateTime(2023, 10, 24, 15, 25, 17, 963, DateTimeKind.Local).AddTicks(6989));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "ID",
                keyValue: 2,
                column: "Birthday",
                value: new DateTime(1997, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "ID",
                keyValue: 3,
                column: "Birthday",
                value: new DateTime(1996, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "ID",
                keyValue: 4,
                column: "Birthday",
                value: new DateTime(1999, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "ID",
                keyValue: 5,
                column: "Birthday",
                value: new DateTime(1995, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RentalContract",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CheckOutDate", "ReceiveDate" },
                values: new object[] { new DateTime(2023, 10, 24, 15, 25, 17, 963, DateTimeKind.Local).AddTicks(7087), new DateTime(2023, 10, 24, 15, 25, 17, 963, DateTimeKind.Local).AddTicks(7087) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ReceiveDate",
                table: "RentalContract",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 24, 15, 25, 2, 789, DateTimeKind.Local).AddTicks(5992),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 24, 15, 25, 17, 961, DateTimeKind.Local).AddTicks(4253));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckOutDate",
                table: "RentalContract",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 24, 15, 25, 2, 789, DateTimeKind.Local).AddTicks(6382),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 24, 15, 25, 17, 961, DateTimeKind.Local).AddTicks(4570));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Birthday",
                table: "People",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 24, 15, 25, 2, 789, DateTimeKind.Local).AddTicks(2013),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 24, 15, 25, 17, 961, DateTimeKind.Local).AddTicks(561));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Days",
                table: "PaymentExtension",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 24, 15, 25, 2, 789, DateTimeKind.Local).AddTicks(600),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 24, 15, 25, 17, 960, DateTimeKind.Local).AddTicks(9159));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ReceiveDate",
                table: "DepositsContract",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 24, 15, 25, 2, 788, DateTimeKind.Local).AddTicks(5855),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 24, 15, 25, 17, 960, DateTimeKind.Local).AddTicks(4568));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DepositsDate",
                table: "DepositsContract",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 24, 15, 25, 2, 788, DateTimeKind.Local).AddTicks(5540),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 24, 15, 25, 17, 960, DateTimeKind.Local).AddTicks(4273));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PayDate",
                table: "Bill",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 24, 15, 25, 2, 788, DateTimeKind.Local).AddTicks(1943),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 24, 15, 25, 17, 960, DateTimeKind.Local).AddTicks(860));

            migrationBuilder.UpdateData(
                table: "Bill",
                keyColumn: "ID",
                keyValue: 1,
                column: "PayDate",
                value: new DateTime(2023, 10, 24, 15, 25, 2, 791, DateTimeKind.Local).AddTicks(9001));

            migrationBuilder.UpdateData(
                table: "DepositsContract",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CheckOutDate", "DepositsDate", "ReceiveDate" },
                values: new object[] { new DateTime(2023, 10, 24, 15, 25, 2, 791, DateTimeKind.Local).AddTicks(9021), new DateTime(2023, 10, 24, 15, 25, 2, 791, DateTimeKind.Local).AddTicks(9019), new DateTime(2023, 10, 24, 15, 25, 2, 791, DateTimeKind.Local).AddTicks(9021) });

            migrationBuilder.UpdateData(
                table: "PaymentExtension",
                keyColumn: "ID",
                keyValue: 1,
                column: "Days",
                value: new DateTime(2023, 10, 24, 15, 25, 2, 791, DateTimeKind.Local).AddTicks(9044));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "ID",
                keyValue: 1,
                column: "Birthday",
                value: new DateTime(2023, 10, 24, 15, 25, 2, 791, DateTimeKind.Local).AddTicks(9060));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "ID",
                keyValue: 2,
                column: "Birthday",
                value: new DateTime(1990, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "ID",
                keyValue: 3,
                column: "Birthday",
                value: new DateTime(2000, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "ID",
                keyValue: 4,
                column: "Birthday",
                value: new DateTime(1990, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "ID",
                keyValue: 5,
                column: "Birthday",
                value: new DateTime(2000, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RentalContract",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CheckOutDate", "ReceiveDate" },
                values: new object[] { new DateTime(2023, 10, 24, 15, 25, 2, 791, DateTimeKind.Local).AddTicks(9161), new DateTime(2023, 10, 24, 15, 25, 2, 791, DateTimeKind.Local).AddTicks(9160) });
        }
    }
}
