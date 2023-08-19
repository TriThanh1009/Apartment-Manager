using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ReceiveDate",
                table: "RentalContract",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 17, 23, 15, 40, 375, DateTimeKind.Local).AddTicks(1966),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 7, 11, 12, 13, 45, 91, DateTimeKind.Local).AddTicks(2882));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckOutDate",
                table: "RentalContract",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 17, 23, 15, 40, 375, DateTimeKind.Local).AddTicks(2459),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 7, 11, 12, 13, 45, 91, DateTimeKind.Local).AddTicks(3254));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Birthday",
                table: "People",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 17, 23, 15, 40, 374, DateTimeKind.Local).AddTicks(6372),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 7, 11, 12, 13, 45, 90, DateTimeKind.Local).AddTicks(8428));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Days",
                table: "PaymentExtension",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 17, 23, 15, 40, 374, DateTimeKind.Local).AddTicks(1175),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 7, 11, 12, 13, 45, 90, DateTimeKind.Local).AddTicks(3939));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ReceiveDate",
                table: "DepositsContract",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 17, 23, 15, 40, 373, DateTimeKind.Local).AddTicks(5540),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 7, 11, 12, 13, 45, 89, DateTimeKind.Local).AddTicks(9236));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DepositsDate",
                table: "DepositsContract",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 17, 23, 15, 40, 373, DateTimeKind.Local).AddTicks(5097),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 7, 11, 12, 13, 45, 89, DateTimeKind.Local).AddTicks(8875));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PayDate",
                table: "Bill",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 17, 23, 15, 40, 373, DateTimeKind.Local).AddTicks(128),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 7, 11, 12, 13, 45, 89, DateTimeKind.Local).AddTicks(4586));

            migrationBuilder.UpdateData(
                table: "Bill",
                keyColumn: "ID",
                keyValue: 1,
                column: "PayDate",
                value: new DateTime(2023, 8, 17, 23, 15, 40, 377, DateTimeKind.Local).AddTicks(2525));

            migrationBuilder.UpdateData(
                table: "DepositsContract",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CheckOutDate", "DepositsDate", "ReceiveDate" },
                values: new object[] { new DateTime(2023, 8, 17, 23, 15, 40, 377, DateTimeKind.Local).AddTicks(2558), new DateTime(2023, 8, 17, 23, 15, 40, 377, DateTimeKind.Local).AddTicks(2556), new DateTime(2023, 8, 17, 23, 15, 40, 377, DateTimeKind.Local).AddTicks(2558) });

            migrationBuilder.UpdateData(
                table: "PaymentExtension",
                keyColumn: "ID",
                keyValue: 1,
                column: "Days",
                value: new DateTime(2023, 8, 17, 23, 15, 40, 377, DateTimeKind.Local).AddTicks(2601));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "ID",
                keyValue: 1,
                column: "Birthday",
                value: new DateTime(2023, 8, 17, 23, 15, 40, 377, DateTimeKind.Local).AddTicks(2622));

            migrationBuilder.UpdateData(
                table: "RentalContract",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CheckOutDate", "ReceiveDate" },
                values: new object[] { new DateTime(2023, 8, 17, 23, 15, 40, 377, DateTimeKind.Local).AddTicks(2646), new DateTime(2023, 8, 17, 23, 15, 40, 377, DateTimeKind.Local).AddTicks(2644) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ReceiveDate",
                table: "RentalContract",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 11, 12, 13, 45, 91, DateTimeKind.Local).AddTicks(2882),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 17, 23, 15, 40, 375, DateTimeKind.Local).AddTicks(1966));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckOutDate",
                table: "RentalContract",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 11, 12, 13, 45, 91, DateTimeKind.Local).AddTicks(3254),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 17, 23, 15, 40, 375, DateTimeKind.Local).AddTicks(2459));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Birthday",
                table: "People",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 11, 12, 13, 45, 90, DateTimeKind.Local).AddTicks(8428),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 17, 23, 15, 40, 374, DateTimeKind.Local).AddTicks(6372));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Days",
                table: "PaymentExtension",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 11, 12, 13, 45, 90, DateTimeKind.Local).AddTicks(3939),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 17, 23, 15, 40, 374, DateTimeKind.Local).AddTicks(1175));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ReceiveDate",
                table: "DepositsContract",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 11, 12, 13, 45, 89, DateTimeKind.Local).AddTicks(9236),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 17, 23, 15, 40, 373, DateTimeKind.Local).AddTicks(5540));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DepositsDate",
                table: "DepositsContract",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 11, 12, 13, 45, 89, DateTimeKind.Local).AddTicks(8875),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 17, 23, 15, 40, 373, DateTimeKind.Local).AddTicks(5097));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PayDate",
                table: "Bill",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 11, 12, 13, 45, 89, DateTimeKind.Local).AddTicks(4586),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 17, 23, 15, 40, 373, DateTimeKind.Local).AddTicks(128));

            migrationBuilder.UpdateData(
                table: "Bill",
                keyColumn: "ID",
                keyValue: 1,
                column: "PayDate",
                value: new DateTime(2023, 7, 11, 12, 13, 45, 92, DateTimeKind.Local).AddTicks(9500));

            migrationBuilder.UpdateData(
                table: "DepositsContract",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CheckOutDate", "DepositsDate", "ReceiveDate" },
                values: new object[] { new DateTime(2023, 7, 11, 12, 13, 45, 92, DateTimeKind.Local).AddTicks(9531), new DateTime(2023, 7, 11, 12, 13, 45, 92, DateTimeKind.Local).AddTicks(9529), new DateTime(2023, 7, 11, 12, 13, 45, 92, DateTimeKind.Local).AddTicks(9530) });

            migrationBuilder.UpdateData(
                table: "PaymentExtension",
                keyColumn: "ID",
                keyValue: 1,
                column: "Days",
                value: new DateTime(2023, 7, 11, 12, 13, 45, 92, DateTimeKind.Local).AddTicks(9568));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "ID",
                keyValue: 1,
                column: "Birthday",
                value: new DateTime(2023, 7, 11, 12, 13, 45, 92, DateTimeKind.Local).AddTicks(9582));

            migrationBuilder.UpdateData(
                table: "RentalContract",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CheckOutDate", "ReceiveDate" },
                values: new object[] { new DateTime(2023, 7, 11, 12, 13, 45, 92, DateTimeKind.Local).AddTicks(9607), new DateTime(2023, 7, 11, 12, 13, 45, 92, DateTimeKind.Local).AddTicks(9606) });
        }
    }
}
