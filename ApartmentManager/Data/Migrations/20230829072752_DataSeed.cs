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
                defaultValue: new DateTime(2023, 8, 29, 14, 27, 51, 969, DateTimeKind.Local).AddTicks(3937),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 14, 27, 41, 570, DateTimeKind.Local).AddTicks(6173));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckOutDate",
                table: "RentalContract",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 14, 27, 51, 969, DateTimeKind.Local).AddTicks(4524),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 14, 27, 41, 570, DateTimeKind.Local).AddTicks(6506));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Birthday",
                table: "People",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 14, 27, 51, 968, DateTimeKind.Local).AddTicks(5675),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 14, 27, 41, 570, DateTimeKind.Local).AddTicks(2217));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Days",
                table: "PaymentExtension",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 14, 27, 51, 966, DateTimeKind.Local).AddTicks(9762),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 14, 27, 41, 569, DateTimeKind.Local).AddTicks(8198));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ReceiveDate",
                table: "DepositsContract",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 14, 27, 51, 963, DateTimeKind.Local).AddTicks(6063),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 14, 27, 41, 569, DateTimeKind.Local).AddTicks(4225));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DepositsDate",
                table: "DepositsContract",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 14, 27, 51, 963, DateTimeKind.Local).AddTicks(5267),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 14, 27, 41, 569, DateTimeKind.Local).AddTicks(3913));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PayDate",
                table: "Bill",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 14, 27, 51, 962, DateTimeKind.Local).AddTicks(8566),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 14, 27, 41, 569, DateTimeKind.Local).AddTicks(540));

            migrationBuilder.UpdateData(
                table: "Bill",
                keyColumn: "ID",
                keyValue: 1,
                column: "PayDate",
                value: new DateTime(2023, 8, 29, 14, 27, 51, 972, DateTimeKind.Local).AddTicks(7173));

            migrationBuilder.UpdateData(
                table: "DepositsContract",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CheckOutDate", "DepositsDate", "ReceiveDate" },
                values: new object[] { new DateTime(2023, 8, 29, 14, 27, 51, 972, DateTimeKind.Local).AddTicks(7222), new DateTime(2023, 8, 29, 14, 27, 51, 972, DateTimeKind.Local).AddTicks(7219), new DateTime(2023, 8, 29, 14, 27, 51, 972, DateTimeKind.Local).AddTicks(7221) });

            migrationBuilder.UpdateData(
                table: "PaymentExtension",
                keyColumn: "ID",
                keyValue: 1,
                column: "Days",
                value: new DateTime(2023, 8, 29, 14, 27, 51, 972, DateTimeKind.Local).AddTicks(7276));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "ID",
                keyValue: 1,
                column: "Birthday",
                value: new DateTime(2023, 8, 29, 14, 27, 51, 972, DateTimeKind.Local).AddTicks(7306));

            migrationBuilder.UpdateData(
                table: "RentalContract",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CheckOutDate", "ReceiveDate" },
                values: new object[] { new DateTime(2023, 8, 29, 14, 27, 51, 972, DateTimeKind.Local).AddTicks(7341), new DateTime(2023, 8, 29, 14, 27, 51, 972, DateTimeKind.Local).AddTicks(7340) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ReceiveDate",
                table: "RentalContract",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 14, 27, 41, 570, DateTimeKind.Local).AddTicks(6173),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 14, 27, 51, 969, DateTimeKind.Local).AddTicks(3937));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckOutDate",
                table: "RentalContract",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 14, 27, 41, 570, DateTimeKind.Local).AddTicks(6506),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 14, 27, 51, 969, DateTimeKind.Local).AddTicks(4524));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Birthday",
                table: "People",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 14, 27, 41, 570, DateTimeKind.Local).AddTicks(2217),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 14, 27, 51, 968, DateTimeKind.Local).AddTicks(5675));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Days",
                table: "PaymentExtension",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 14, 27, 41, 569, DateTimeKind.Local).AddTicks(8198),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 14, 27, 51, 966, DateTimeKind.Local).AddTicks(9762));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ReceiveDate",
                table: "DepositsContract",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 14, 27, 41, 569, DateTimeKind.Local).AddTicks(4225),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 14, 27, 51, 963, DateTimeKind.Local).AddTicks(6063));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DepositsDate",
                table: "DepositsContract",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 14, 27, 41, 569, DateTimeKind.Local).AddTicks(3913),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 14, 27, 51, 963, DateTimeKind.Local).AddTicks(5267));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PayDate",
                table: "Bill",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 29, 14, 27, 41, 569, DateTimeKind.Local).AddTicks(540),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 29, 14, 27, 51, 962, DateTimeKind.Local).AddTicks(8566));

            migrationBuilder.UpdateData(
                table: "Bill",
                keyColumn: "ID",
                keyValue: 1,
                column: "PayDate",
                value: new DateTime(2023, 8, 29, 14, 27, 41, 572, DateTimeKind.Local).AddTicks(771));

            migrationBuilder.UpdateData(
                table: "DepositsContract",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CheckOutDate", "DepositsDate", "ReceiveDate" },
                values: new object[] { new DateTime(2023, 8, 29, 14, 27, 41, 572, DateTimeKind.Local).AddTicks(792), new DateTime(2023, 8, 29, 14, 27, 41, 572, DateTimeKind.Local).AddTicks(791), new DateTime(2023, 8, 29, 14, 27, 41, 572, DateTimeKind.Local).AddTicks(791) });

            migrationBuilder.UpdateData(
                table: "PaymentExtension",
                keyColumn: "ID",
                keyValue: 1,
                column: "Days",
                value: new DateTime(2023, 8, 29, 14, 27, 41, 572, DateTimeKind.Local).AddTicks(817));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "ID",
                keyValue: 1,
                column: "Birthday",
                value: new DateTime(2023, 8, 29, 14, 27, 41, 572, DateTimeKind.Local).AddTicks(830));

            migrationBuilder.UpdateData(
                table: "RentalContract",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CheckOutDate", "ReceiveDate" },
                values: new object[] { new DateTime(2023, 8, 29, 14, 27, 41, 572, DateTimeKind.Local).AddTicks(845), new DateTime(2023, 8, 29, 14, 27, 41, 572, DateTimeKind.Local).AddTicks(845) });
        }
    }
}
