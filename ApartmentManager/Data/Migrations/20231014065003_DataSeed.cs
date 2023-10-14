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
                defaultValue: new DateTime(2023, 10, 14, 13, 50, 3, 375, DateTimeKind.Local).AddTicks(1144),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 14, 13, 49, 19, 987, DateTimeKind.Local).AddTicks(5776));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckOutDate",
                table: "RentalContract",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 14, 13, 50, 3, 375, DateTimeKind.Local).AddTicks(2127),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 14, 13, 49, 19, 987, DateTimeKind.Local).AddTicks(6085));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Birthday",
                table: "People",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 14, 13, 50, 3, 373, DateTimeKind.Local).AddTicks(1982),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 14, 13, 49, 19, 987, DateTimeKind.Local).AddTicks(1905));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Days",
                table: "PaymentExtension",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 14, 13, 50, 3, 366, DateTimeKind.Local).AddTicks(7760),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 14, 13, 49, 19, 987, DateTimeKind.Local).AddTicks(540));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ReceiveDate",
                table: "DepositsContract",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 14, 13, 50, 3, 351, DateTimeKind.Local).AddTicks(1026),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 14, 13, 49, 19, 986, DateTimeKind.Local).AddTicks(5699));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DepositsDate",
                table: "DepositsContract",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 14, 13, 50, 3, 351, DateTimeKind.Local).AddTicks(688),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 14, 13, 49, 19, 986, DateTimeKind.Local).AddTicks(5398));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PayDate",
                table: "Bill",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 14, 13, 50, 3, 350, DateTimeKind.Local).AddTicks(5590),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 14, 13, 49, 19, 986, DateTimeKind.Local).AddTicks(1950));

            migrationBuilder.UpdateData(
                table: "Bill",
                keyColumn: "ID",
                keyValue: 1,
                column: "PayDate",
                value: new DateTime(2023, 10, 14, 13, 50, 3, 378, DateTimeKind.Local).AddTicks(4843));

            migrationBuilder.UpdateData(
                table: "DepositsContract",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CheckOutDate", "DepositsDate", "ReceiveDate" },
                values: new object[] { new DateTime(2023, 10, 14, 13, 50, 3, 378, DateTimeKind.Local).AddTicks(4878), new DateTime(2023, 10, 14, 13, 50, 3, 378, DateTimeKind.Local).AddTicks(4876), new DateTime(2023, 10, 14, 13, 50, 3, 378, DateTimeKind.Local).AddTicks(4877) });

            migrationBuilder.UpdateData(
                table: "PaymentExtension",
                keyColumn: "ID",
                keyValue: 1,
                column: "Days",
                value: new DateTime(2023, 10, 14, 13, 50, 3, 378, DateTimeKind.Local).AddTicks(4911));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "ID",
                keyValue: 1,
                column: "Birthday",
                value: new DateTime(2023, 10, 14, 13, 50, 3, 378, DateTimeKind.Local).AddTicks(4930));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "ID",
                keyValue: 2,
                column: "Birthday",
                value: new DateTime(1994, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "ID",
                keyValue: 3,
                column: "Birthday",
                value: new DateTime(1997, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "ID",
                keyValue: 4,
                column: "Birthday",
                value: new DateTime(1996, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "ID",
                keyValue: 5,
                column: "Birthday",
                value: new DateTime(1998, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RentalContract",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CheckOutDate", "ReceiveDate" },
                values: new object[] { new DateTime(2023, 10, 14, 13, 50, 3, 378, DateTimeKind.Local).AddTicks(5037), new DateTime(2023, 10, 14, 13, 50, 3, 378, DateTimeKind.Local).AddTicks(5036) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ReceiveDate",
                table: "RentalContract",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 14, 13, 49, 19, 987, DateTimeKind.Local).AddTicks(5776),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 14, 13, 50, 3, 375, DateTimeKind.Local).AddTicks(1144));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckOutDate",
                table: "RentalContract",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 14, 13, 49, 19, 987, DateTimeKind.Local).AddTicks(6085),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 14, 13, 50, 3, 375, DateTimeKind.Local).AddTicks(2127));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Birthday",
                table: "People",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 14, 13, 49, 19, 987, DateTimeKind.Local).AddTicks(1905),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 14, 13, 50, 3, 373, DateTimeKind.Local).AddTicks(1982));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Days",
                table: "PaymentExtension",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 14, 13, 49, 19, 987, DateTimeKind.Local).AddTicks(540),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 14, 13, 50, 3, 366, DateTimeKind.Local).AddTicks(7760));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ReceiveDate",
                table: "DepositsContract",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 14, 13, 49, 19, 986, DateTimeKind.Local).AddTicks(5699),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 14, 13, 50, 3, 351, DateTimeKind.Local).AddTicks(1026));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DepositsDate",
                table: "DepositsContract",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 14, 13, 49, 19, 986, DateTimeKind.Local).AddTicks(5398),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 14, 13, 50, 3, 351, DateTimeKind.Local).AddTicks(688));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PayDate",
                table: "Bill",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 14, 13, 49, 19, 986, DateTimeKind.Local).AddTicks(1950),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 14, 13, 50, 3, 350, DateTimeKind.Local).AddTicks(5590));

            migrationBuilder.UpdateData(
                table: "Bill",
                keyColumn: "ID",
                keyValue: 1,
                column: "PayDate",
                value: new DateTime(2023, 10, 14, 13, 49, 19, 990, DateTimeKind.Local).AddTicks(2077));

            migrationBuilder.UpdateData(
                table: "DepositsContract",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CheckOutDate", "DepositsDate", "ReceiveDate" },
                values: new object[] { new DateTime(2023, 10, 14, 13, 49, 19, 990, DateTimeKind.Local).AddTicks(2129), new DateTime(2023, 10, 14, 13, 49, 19, 990, DateTimeKind.Local).AddTicks(2126), new DateTime(2023, 10, 14, 13, 49, 19, 990, DateTimeKind.Local).AddTicks(2127) });

            migrationBuilder.UpdateData(
                table: "PaymentExtension",
                keyColumn: "ID",
                keyValue: 1,
                column: "Days",
                value: new DateTime(2023, 10, 14, 13, 49, 19, 990, DateTimeKind.Local).AddTicks(2169));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "ID",
                keyValue: 1,
                column: "Birthday",
                value: new DateTime(2023, 10, 14, 13, 49, 19, 990, DateTimeKind.Local).AddTicks(2251));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "ID",
                keyValue: 2,
                column: "Birthday",
                value: new DateTime(1991, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "ID",
                keyValue: 3,
                column: "Birthday",
                value: new DateTime(1996, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "ID",
                keyValue: 4,
                column: "Birthday",
                value: new DateTime(1999, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "ID",
                keyValue: 5,
                column: "Birthday",
                value: new DateTime(1995, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RentalContract",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CheckOutDate", "ReceiveDate" },
                values: new object[] { new DateTime(2023, 10, 14, 13, 49, 19, 990, DateTimeKind.Local).AddTicks(2657), new DateTime(2023, 10, 14, 13, 49, 19, 990, DateTimeKind.Local).AddTicks(2656) });
        }
    }
}
