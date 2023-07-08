using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

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
                    DepositsDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 7, 8, 19, 12, 20, 964, DateTimeKind.Local).AddTicks(8169)),
                    ReceiveDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 7, 8, 19, 12, 20, 964, DateTimeKind.Local).AddTicks(8713)),
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
                    Birthday = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 7, 8, 19, 12, 20, 965, DateTimeKind.Local).AddTicks(6713)),
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
                    ReceiveDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 7, 8, 19, 12, 20, 966, DateTimeKind.Local).AddTicks(565)),
                    CheckOutDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 7, 8, 19, 12, 20, 966, DateTimeKind.Local).AddTicks(873)),
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
                    PayDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 7, 8, 19, 12, 20, 964, DateTimeKind.Local).AddTicks(4203)),
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
                    Days = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 7, 8, 19, 12, 20, 965, DateTimeKind.Local).AddTicks(2915))
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
