using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class DataSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ReceiveDate",
                table: "RentalContract",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 18, 21, 46, 2, 867, DateTimeKind.Local).AddTicks(9837),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 18, 21, 45, 50, 288, DateTimeKind.Local).AddTicks(9134));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckOutDate",
                table: "RentalContract",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 18, 21, 46, 2, 868, DateTimeKind.Local).AddTicks(359),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 18, 21, 45, 50, 288, DateTimeKind.Local).AddTicks(9496));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Birthday",
                table: "People",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 18, 21, 46, 2, 867, DateTimeKind.Local).AddTicks(3910),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 18, 21, 45, 50, 288, DateTimeKind.Local).AddTicks(4802));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Days",
                table: "PaymentExtension",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 18, 21, 46, 2, 867, DateTimeKind.Local).AddTicks(1560),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 18, 21, 45, 50, 288, DateTimeKind.Local).AddTicks(2752));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ReceiveDate",
                table: "DepositsContract",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 18, 21, 46, 2, 866, DateTimeKind.Local).AddTicks(4982),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 18, 21, 45, 50, 287, DateTimeKind.Local).AddTicks(8406));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DepositsDate",
                table: "DepositsContract",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 18, 21, 46, 2, 866, DateTimeKind.Local).AddTicks(4457),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 18, 21, 45, 50, 287, DateTimeKind.Local).AddTicks(8067));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PayDate",
                table: "Bill",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 18, 21, 46, 2, 865, DateTimeKind.Local).AddTicks(8502),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 18, 21, 45, 50, 287, DateTimeKind.Local).AddTicks(3993));

            migrationBuilder.UpdateData(
                table: "Bill",
                keyColumn: "ID",
                keyValue: 1,
                column: "PayDate",
                value: new DateTime(2023, 10, 18, 21, 46, 2, 872, DateTimeKind.Local).AddTicks(4960));

            migrationBuilder.UpdateData(
                table: "DepositsContract",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CheckOutDate", "DepositsDate", "ReceiveDate" },
                values: new object[] { new DateTime(2023, 10, 18, 21, 46, 2, 872, DateTimeKind.Local).AddTicks(5002), new DateTime(2023, 10, 18, 21, 46, 2, 872, DateTimeKind.Local).AddTicks(4999), new DateTime(2023, 10, 18, 21, 46, 2, 872, DateTimeKind.Local).AddTicks(5000) });

            migrationBuilder.UpdateData(
                table: "PaymentExtension",
                keyColumn: "ID",
                keyValue: 1,
                column: "Days",
                value: new DateTime(2023, 10, 18, 21, 46, 2, 872, DateTimeKind.Local).AddTicks(5044));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "ID",
                keyValue: 1,
                column: "Birthday",
                value: new DateTime(2023, 10, 18, 21, 46, 2, 872, DateTimeKind.Local).AddTicks(5067));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "ID",
                keyValue: 2,
                column: "Birthday",
                value: new DateTime(2000, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "ID",
                keyValue: 3,
                column: "Birthday",
                value: new DateTime(1992, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "ID",
                keyValue: 4,
                column: "Birthday",
                value: new DateTime(1994, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "ID",
                keyValue: 5,
                column: "Birthday",
                value: new DateTime(1999, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RentalContract",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CheckOutDate", "ReceiveDate" },
                values: new object[] { new DateTime(2023, 10, 18, 21, 46, 2, 872, DateTimeKind.Local).AddTicks(5207), new DateTime(2023, 10, 18, 21, 46, 2, 872, DateTimeKind.Local).AddTicks(5205) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ReceiveDate",
                table: "RentalContract",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 18, 21, 45, 50, 288, DateTimeKind.Local).AddTicks(9134),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 18, 21, 46, 2, 867, DateTimeKind.Local).AddTicks(9837));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckOutDate",
                table: "RentalContract",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 18, 21, 45, 50, 288, DateTimeKind.Local).AddTicks(9496),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 18, 21, 46, 2, 868, DateTimeKind.Local).AddTicks(359));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Birthday",
                table: "People",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 18, 21, 45, 50, 288, DateTimeKind.Local).AddTicks(4802),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 18, 21, 46, 2, 867, DateTimeKind.Local).AddTicks(3910));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Days",
                table: "PaymentExtension",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 18, 21, 45, 50, 288, DateTimeKind.Local).AddTicks(2752),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 18, 21, 46, 2, 867, DateTimeKind.Local).AddTicks(1560));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ReceiveDate",
                table: "DepositsContract",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 18, 21, 45, 50, 287, DateTimeKind.Local).AddTicks(8406),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 18, 21, 46, 2, 866, DateTimeKind.Local).AddTicks(4982));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DepositsDate",
                table: "DepositsContract",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 18, 21, 45, 50, 287, DateTimeKind.Local).AddTicks(8067),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 18, 21, 46, 2, 866, DateTimeKind.Local).AddTicks(4457));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PayDate",
                table: "Bill",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 18, 21, 45, 50, 287, DateTimeKind.Local).AddTicks(3993),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 18, 21, 46, 2, 865, DateTimeKind.Local).AddTicks(8502));

            migrationBuilder.UpdateData(
                table: "Bill",
                keyColumn: "ID",
                keyValue: 1,
                column: "PayDate",
                value: new DateTime(2023, 10, 18, 21, 45, 50, 291, DateTimeKind.Local).AddTicks(5026));

            migrationBuilder.UpdateData(
                table: "DepositsContract",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CheckOutDate", "DepositsDate", "ReceiveDate" },
                values: new object[] { new DateTime(2023, 10, 18, 21, 45, 50, 291, DateTimeKind.Local).AddTicks(5051), new DateTime(2023, 10, 18, 21, 45, 50, 291, DateTimeKind.Local).AddTicks(5049), new DateTime(2023, 10, 18, 21, 45, 50, 291, DateTimeKind.Local).AddTicks(5050) });

            migrationBuilder.UpdateData(
                table: "PaymentExtension",
                keyColumn: "ID",
                keyValue: 1,
                column: "Days",
                value: new DateTime(2023, 10, 18, 21, 45, 50, 291, DateTimeKind.Local).AddTicks(5083));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "ID",
                keyValue: 1,
                column: "Birthday",
                value: new DateTime(2023, 10, 18, 21, 45, 50, 291, DateTimeKind.Local).AddTicks(5099));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "ID",
                keyValue: 2,
                column: "Birthday",
                value: new DateTime(1990, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "ID",
                keyValue: 3,
                column: "Birthday",
                value: new DateTime(1990, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "ID",
                keyValue: 4,
                column: "Birthday",
                value: new DateTime(1996, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "ID",
                keyValue: 5,
                column: "Birthday",
                value: new DateTime(1998, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RentalContract",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CheckOutDate", "ReceiveDate" },
                values: new object[] { new DateTime(2023, 10, 18, 21, 45, 50, 291, DateTimeKind.Local).AddTicks(5199), new DateTime(2023, 10, 18, 21, 45, 50, 291, DateTimeKind.Local).AddTicks(5197) });
        }
    }
}
