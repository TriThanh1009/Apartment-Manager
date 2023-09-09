using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Account",
                columns: table => new
                {
                    Acc = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Pass = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Account", x => x.Acc);
                });

            migrationBuilder.CreateTable(
                name: "Furniture",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Furniture", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Room",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDLeader = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Room", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "DepositsContract",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDRoom = table.Column<int>(type: "int", nullable: false),
                    DepositsDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 8, 25, 22, 37, 41, 580, DateTimeKind.Local).AddTicks(8910)),
                    ReceiveDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 8, 25, 22, 37, 41, 580, DateTimeKind.Local).AddTicks(9217)),
                    CheckOutDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Money = table.Column<int>(type: "int", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepositsContract", x => x.ID);
                    table.ForeignKey(
                        name: "FK_DepositsContract_Room_IDRoom",
                        column: x => x.IDRoom,
                        principalTable: "Room",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "People",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDroom = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Sex = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    Birthday = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 8, 25, 22, 37, 41, 581, DateTimeKind.Local).AddTicks(6971)),
                    PhoneNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IDCard = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_People", x => x.ID);
                    table.ForeignKey(
                        name: "FK_People_Room_IDroom",
                        column: x => x.IDroom,
                        principalTable: "Room",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RoomDetails",
                columns: table => new
                {
                    IDFur = table.Column<int>(type: "int", nullable: false),
                    IDRoom = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomDetails", x => new { x.IDFur, x.IDRoom });
                    table.ForeignKey(
                        name: "FK_RoomDetails_Furniture_IDFur",
                        column: x => x.IDFur,
                        principalTable: "Furniture",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RoomDetails_Room_IDRoom",
                        column: x => x.IDRoom,
                        principalTable: "Room",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RoomImage",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDroom = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Url = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomImage", x => x.ID);
                    table.ForeignKey(
                        name: "FK_RoomImage_Room_IDroom",
                        column: x => x.IDroom,
                        principalTable: "Room",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RentalContract",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDroom = table.Column<int>(type: "int", nullable: false),
                    IDLeader = table.Column<int>(type: "int", nullable: false),
                    ReceiveDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 8, 25, 22, 37, 41, 582, DateTimeKind.Local).AddTicks(851)),
                    CheckOutDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 8, 25, 22, 37, 41, 582, DateTimeKind.Local).AddTicks(1164)),
                    RoomMoney = table.Column<int>(type: "int", maxLength: 50, nullable: false),
                    ElectricMoney = table.Column<int>(type: "int", maxLength: 50, nullable: false),
                    WaterMoney = table.Column<int>(type: "int", maxLength: 50, nullable: false),
                    ServiceMoney = table.Column<int>(type: "int", maxLength: 50, nullable: false),
                    PeopleID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RentalContract", x => x.ID);
                    table.ForeignKey(
                        name: "FK_RentalContract_People_PeopleID",
                        column: x => x.PeopleID,
                        principalTable: "People",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_RentalContract_Room_IDroom",
                        column: x => x.IDroom,
                        principalTable: "Room",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Bill",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDRTC = table.Column<int>(type: "int", nullable: false),
                    ElectricQuantity = table.Column<int>(type: "int", maxLength: 50, nullable: false),
                    Active = table.Column<int>(type: "int", maxLength: 50, nullable: false),
                    PayDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 8, 25, 22, 37, 41, 580, DateTimeKind.Local).AddTicks(5718)),
                    TotalMoney = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bill", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Bill_RentalContract_IDRTC",
                        column: x => x.IDRTC,
                        principalTable: "RentalContract",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PaymentExtension",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDBill = table.Column<int>(type: "int", nullable: false),
                    Days = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 8, 25, 22, 37, 41, 581, DateTimeKind.Local).AddTicks(3219))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentExtension", x => x.ID);
                    table.ForeignKey(
                        name: "FK_PaymentExtension_Bill_IDBill",
                        column: x => x.IDBill,
                        principalTable: "Bill",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Account",
                columns: new[] { "Acc", "Pass" },
                values: new object[] { "admin", "admin" });

            migrationBuilder.InsertData(
                table: "Furniture",
                columns: new[] { "ID", "Name" },
                values: new object[] { 1, "Chair" });

            migrationBuilder.InsertData(
                table: "Room",
                columns: new[] { "ID", "IDLeader", "Name", "Quantity" },
                values: new object[,]
                {
                    { 1, 0, "A201", 4 },
                    { 2, 0, "A202", 5 },
                    { 3, 0, "A203", 3 },
                    { 4, 0, "A204", 3 },
                    { 5, 0, "A205", 4 },
                    { 6, 0, "A206", 4 },
                    { 7, 0, "A207", 3 },
                    { 8, 0, "A208", 5 },
                    { 9, 0, "A209", 5 },
                    { 10, 0, "A210", 3 },
                    { 11, 0, "A211", 5 },
                    { 12, 0, "A212", 3 },
                    { 13, 0, "A213", 4 },
                    { 14, 0, "A214", 4 },
                    { 15, 0, "A215", 3 },
                    { 16, 0, "A216", 4 },
                    { 17, 0, "A217", 3 },
                    { 18, 0, "A218", 3 },
                    { 19, 0, "A219", 5 },
                    { 20, 0, "A220", 4 },
                    { 21, 0, "A221", 4 },
                    { 22, 0, "A222", 5 },
                    { 23, 0, "A223", 5 },
                    { 24, 0, "A224", 3 },
                    { 25, 0, "A225", 4 },
                    { 26, 0, "A226", 3 },
                    { 27, 0, "A227", 5 },
                    { 28, 0, "A228", 3 },
                    { 29, 0, "A229", 4 },
                    { 30, 0, "A230", 5 },
                    { 31, 0, "A231", 4 },
                    { 32, 0, "A232", 5 },
                    { 33, 0, "A233", 4 },
                    { 34, 0, "A234", 3 },
                    { 35, 0, "A235", 4 },
                    { 36, 0, "A236", 5 },
                    { 37, 0, "A237", 4 },
                    { 38, 0, "A238", 3 },
                    { 39, 0, "A239", 5 },
                    { 40, 0, "A240", 3 }
                });

            migrationBuilder.InsertData(
                table: "DepositsContract",
                columns: new[] { "ID", "CheckOutDate", "DepositsDate", "IDRoom", "Money", "ReceiveDate" },
                values: new object[] { 1, new DateTime(2023, 8, 25, 22, 37, 41, 583, DateTimeKind.Local).AddTicks(5481), new DateTime(2023, 8, 25, 22, 37, 41, 583, DateTimeKind.Local).AddTicks(5479), 1, 10000, new DateTime(2023, 8, 25, 22, 37, 41, 583, DateTimeKind.Local).AddTicks(5480) });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "ID", "Address", "Birthday", "Email", "IDCard", "IDroom", "Name", "PhoneNumber" },
                values: new object[] { 1, "Vietnam", new DateTime(2023, 8, 25, 22, 37, 41, 583, DateTimeKind.Local).AddTicks(5517), "thanh@gmail.com", "1234123", 1, "Jonhny Deep", "1234" });

            migrationBuilder.InsertData(
                table: "RentalContract",
                columns: new[] { "ID", "CheckOutDate", "ElectricMoney", "IDLeader", "IDroom", "PeopleID", "ReceiveDate", "RoomMoney", "ServiceMoney", "WaterMoney" },
                values: new object[] { 1, new DateTime(2023, 8, 25, 22, 37, 41, 583, DateTimeKind.Local).AddTicks(5542), 100, 1, 1, null, new DateTime(2023, 8, 25, 22, 37, 41, 583, DateTimeKind.Local).AddTicks(5542), 100, 100, 100 });

            migrationBuilder.InsertData(
                table: "RoomDetails",
                columns: new[] { "IDFur", "IDRoom" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 1, 3 },
                    { 1, 4 },
                    { 1, 5 },
                    { 1, 6 },
                    { 1, 7 }
                });

            migrationBuilder.InsertData(
                table: "RoomImage",
                columns: new[] { "ID", "IDroom", "Name", "Url" },
                values: new object[,]
                {
                    { 1, 1, "A1 Image", "D:jett.png" },
                    { 2, 1, "A2 Image", "D:home.png" }
                });

            migrationBuilder.InsertData(
                table: "Bill",
                columns: new[] { "ID", "Active", "ElectricQuantity", "IDRTC", "PayDate", "TotalMoney" },
                values: new object[] { 1, 0, 150, 1, new DateTime(2023, 8, 25, 22, 37, 41, 583, DateTimeKind.Local).AddTicks(5460), 1000000 });

            migrationBuilder.InsertData(
                table: "PaymentExtension",
                columns: new[] { "ID", "Days", "IDBill" },
                values: new object[] { 1, new DateTime(2023, 8, 25, 22, 37, 41, 583, DateTimeKind.Local).AddTicks(5503), 1 });

            migrationBuilder.CreateIndex(
                name: "IX_Bill_IDRTC",
                table: "Bill",
                column: "IDRTC");

            migrationBuilder.CreateIndex(
                name: "IX_DepositsContract_IDRoom",
                table: "DepositsContract",
                column: "IDRoom");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentExtension_IDBill",
                table: "PaymentExtension",
                column: "IDBill");

            migrationBuilder.CreateIndex(
                name: "IX_People_IDroom",
                table: "People",
                column: "IDroom");

            migrationBuilder.CreateIndex(
                name: "IX_RentalContract_IDroom",
                table: "RentalContract",
                column: "IDroom");

            migrationBuilder.CreateIndex(
                name: "IX_RentalContract_PeopleID",
                table: "RentalContract",
                column: "PeopleID");

            migrationBuilder.CreateIndex(
                name: "IX_RoomDetails_IDRoom",
                table: "RoomDetails",
                column: "IDRoom");

            migrationBuilder.CreateIndex(
                name: "IX_RoomImage_IDroom",
                table: "RoomImage",
                column: "IDroom");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Account");

            migrationBuilder.DropTable(
                name: "DepositsContract");

            migrationBuilder.DropTable(
                name: "PaymentExtension");

            migrationBuilder.DropTable(
                name: "RoomDetails");

            migrationBuilder.DropTable(
                name: "RoomImage");

            migrationBuilder.DropTable(
                name: "Bill");

            migrationBuilder.DropTable(
                name: "Furniture");

            migrationBuilder.DropTable(
                name: "RentalContract");

            migrationBuilder.DropTable(
                name: "People");

            migrationBuilder.DropTable(
                name: "Room");
        }
    }
}
