using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MyAppAvalonia.Migrations
{
    /// <inheritdoc />
    public partial class AddProfilePictureToUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Dishes",
                columns: table => new
                {
                    DishId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DishTitle = table.Column<string>(type: "text", nullable: true),
                    DishPrice = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dishes", x => x.DishId);
                });

            migrationBuilder.CreateTable(
                name: "DishStatuses",
                columns: table => new
                {
                    DishStatusId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StatusTitle = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DishStatuses", x => x.DishStatusId);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    RoleId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RoleTitle = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.RoleId);
                });

            migrationBuilder.CreateTable(
                name: "Shift",
                columns: table => new
                {
                    ShiftId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ShiftDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ShiftTimeStart = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ShiftTimeEnd = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shift", x => x.ShiftId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserName = table.Column<string>(type: "text", nullable: true),
                    UserLogin = table.Column<string>(type: "text", nullable: true),
                    UserPassword = table.Column<string>(type: "text", nullable: true),
                    Fired = table.Column<bool>(type: "boolean", nullable: false),
                    ProfilePicture = table.Column<byte[]>(type: "bytea", nullable: true),
                    ContractPicture = table.Column<byte[]>(type: "bytea", nullable: true),
                    RoleId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_Users_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "RoleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ClientName = table.Column<string>(type: "text", nullable: true),
                    ShiftId = table.Column<int>(type: "integer", nullable: false),
                    OrderTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Payed = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
                    table.ForeignKey(
                        name: "FK_Orders_Shift_ShiftId",
                        column: x => x.ShiftId,
                        principalTable: "Shift",
                        principalColumn: "ShiftId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ShiftAssignments",
                columns: table => new
                {
                    ShiftAssignmentId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    ShiftId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShiftAssignments", x => x.ShiftAssignmentId);
                    table.ForeignKey(
                        name: "FK_ShiftAssignments_Shift_ShiftId",
                        column: x => x.ShiftId,
                        principalTable: "Shift",
                        principalColumn: "ShiftId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ShiftAssignments_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderDishes",
                columns: table => new
                {
                    OrderDishId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    OrderId = table.Column<int>(type: "integer", nullable: false),
                    DishId = table.Column<int>(type: "integer", nullable: false),
                    DishStatusId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDishes", x => x.OrderDishId);
                    table.ForeignKey(
                        name: "FK_OrderDishes_DishStatuses_DishStatusId",
                        column: x => x.DishStatusId,
                        principalTable: "DishStatuses",
                        principalColumn: "DishStatusId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDishes_Dishes_DishId",
                        column: x => x.DishId,
                        principalTable: "Dishes",
                        principalColumn: "DishId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDishes_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "DishStatuses",
                columns: new[] { "DishStatusId", "StatusTitle" },
                values: new object[,]
                {
                    { 1, null },
                    { 2, null },
                    { 3, null },
                    { 4, null }
                });

            migrationBuilder.InsertData(
                table: "Dishes",
                columns: new[] { "DishId", "DishPrice", "DishTitle" },
                values: new object[,]
                {
                    { 1, 200.0, "Картошка" },
                    { 2, 200.0, "Котлета" },
                    { 3, 200.0, "Кола" },
                    { 4, 200.0, "Квас" },
                    { 5, 200.0, "Морс" },
                    { 6, 200.0, "Плов" },
                    { 7, 200.0, "Пицца" },
                    { 8, 200.0, "Доширак" },
                    { 9, 200.0, "Ролтон" },
                    { 10, 200.0, "Пепси" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RoleId", "RoleTitle" },
                values: new object[,]
                {
                    { 1, "Admin" },
                    { 2, "Cooker" },
                    { 3, "Waiter" }
                });

            migrationBuilder.InsertData(
                table: "Shift",
                columns: new[] { "ShiftId", "ShiftDate", "ShiftTimeEnd", "ShiftTimeStart" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 12, 20, 23, 9, 40, 74, DateTimeKind.Utc).AddTicks(1085), new DateTime(2023, 12, 21, 9, 9, 40, 74, DateTimeKind.Utc).AddTicks(1091), new DateTime(2023, 12, 21, 3, 9, 40, 74, DateTimeKind.Utc).AddTicks(1086) },
                    { 2, new DateTime(2023, 12, 20, 23, 9, 40, 74, DateTimeKind.Utc).AddTicks(1093), new DateTime(2023, 12, 21, 9, 9, 40, 74, DateTimeKind.Utc).AddTicks(1094), new DateTime(2023, 12, 21, 3, 9, 40, 74, DateTimeKind.Utc).AddTicks(1093) },
                    { 3, new DateTime(2023, 12, 20, 23, 9, 40, 74, DateTimeKind.Utc).AddTicks(1095), new DateTime(2023, 12, 21, 9, 9, 40, 74, DateTimeKind.Utc).AddTicks(1096), new DateTime(2023, 12, 21, 3, 9, 40, 74, DateTimeKind.Utc).AddTicks(1095) },
                    { 4, new DateTime(2023, 12, 20, 23, 9, 40, 74, DateTimeKind.Utc).AddTicks(1096), new DateTime(2023, 12, 21, 9, 9, 40, 74, DateTimeKind.Utc).AddTicks(1097), new DateTime(2023, 12, 21, 3, 9, 40, 74, DateTimeKind.Utc).AddTicks(1097) },
                    { 5, new DateTime(2023, 12, 20, 23, 9, 40, 74, DateTimeKind.Utc).AddTicks(1098), new DateTime(2023, 12, 21, 9, 9, 40, 74, DateTimeKind.Utc).AddTicks(1099), new DateTime(2023, 12, 21, 3, 9, 40, 74, DateTimeKind.Utc).AddTicks(1098) },
                    { 6, new DateTime(2023, 12, 20, 23, 9, 40, 74, DateTimeKind.Utc).AddTicks(1100), new DateTime(2023, 12, 21, 9, 9, 40, 74, DateTimeKind.Utc).AddTicks(1100), new DateTime(2023, 12, 21, 3, 9, 40, 74, DateTimeKind.Utc).AddTicks(1100) }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderId", "ClientName", "OrderTime", "Payed", "ShiftId" },
                values: new object[,]
                {
                    { 1, "Client 1", new DateTime(2023, 12, 20, 23, 9, 40, 74, DateTimeKind.Utc).AddTicks(1150), false, 1 },
                    { 2, "Client 2", new DateTime(2023, 12, 20, 23, 9, 40, 74, DateTimeKind.Utc).AddTicks(1152), true, 2 },
                    { 3, "Client 3", new DateTime(2023, 12, 20, 23, 9, 40, 74, DateTimeKind.Utc).AddTicks(1153), true, 3 },
                    { 4, "Client 4", new DateTime(2023, 12, 20, 23, 9, 40, 74, DateTimeKind.Utc).AddTicks(1154), true, 4 },
                    { 5, "Client 5", new DateTime(2023, 12, 20, 23, 9, 40, 74, DateTimeKind.Utc).AddTicks(1155), true, 1 },
                    { 6, "Client 6", new DateTime(2023, 12, 20, 23, 9, 40, 74, DateTimeKind.Utc).AddTicks(1155), true, 2 },
                    { 7, "Client 7", new DateTime(2023, 12, 20, 23, 9, 40, 74, DateTimeKind.Utc).AddTicks(1156), true, 3 },
                    { 8, "Client 8", new DateTime(2023, 12, 20, 23, 9, 40, 74, DateTimeKind.Utc).AddTicks(1157), true, 4 },
                    { 9, "Client 9", new DateTime(2023, 12, 20, 23, 9, 40, 74, DateTimeKind.Utc).AddTicks(1158), false, 5 },
                    { 10, "Client 10", new DateTime(2023, 12, 20, 23, 9, 40, 74, DateTimeKind.Utc).AddTicks(1158), false, 6 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "ContractPicture", "Fired", "ProfilePicture", "RoleId", "UserLogin", "UserName", "UserPassword" },
                values: new object[,]
                {
                    { 1, null, false, null, 1, "LoginTom", "Tom", "PasswordTom" },
                    { 2, null, false, null, 2, "JohnTom", "John", "PasswordJohn" },
                    { 3, null, false, null, 2, "LoginPeter", "Peter", "PasswordPeter" },
                    { 4, null, false, null, 2, "LoginSam", "Sam", "PasswordSam" },
                    { 5, null, false, null, 2, "LoginMarry", "Marry", "PasswordMarry" },
                    { 6, null, false, null, 2, "LoginSue", "Sue", "PasswordSue" },
                    { 7, null, false, null, 3, "LoginJessy", "Jessy", "PasswordJessy" },
                    { 8, null, false, null, 3, "LoginDominic", "Dominic", "PasswordDominic" },
                    { 9, null, false, null, 3, "LoginKennedy", "Kennedy", "PasswordKennedy" },
                    { 10, null, false, null, 3, "LoginVitya", "Vitya", "PasswordVitya" },
                    { 11, null, true, null, 3, "LoginDaniel", "Daniel", "PasswordDaniel" }
                });

            migrationBuilder.InsertData(
                table: "OrderDishes",
                columns: new[] { "OrderDishId", "DishId", "DishStatusId", "OrderId" },
                values: new object[,]
                {
                    { 1, 1, 1, 1 },
                    { 2, 2, 1, 2 },
                    { 3, 3, 1, 3 },
                    { 4, 4, 1, 4 },
                    { 5, 5, 1, 5 },
                    { 6, 6, 1, 6 },
                    { 7, 7, 1, 7 },
                    { 8, 8, 1, 8 },
                    { 9, 9, 1, 9 },
                    { 10, 10, 1, 10 },
                    { 11, 1, 1, 1 },
                    { 12, 2, 1, 2 },
                    { 13, 3, 1, 3 },
                    { 14, 4, 1, 4 },
                    { 15, 5, 1, 5 },
                    { 16, 6, 1, 6 },
                    { 17, 7, 1, 7 },
                    { 18, 8, 1, 8 },
                    { 19, 9, 1, 9 },
                    { 20, 10, 1, 10 },
                    { 21, 1, 1, 1 },
                    { 22, 2, 1, 2 },
                    { 23, 3, 1, 3 },
                    { 24, 4, 1, 4 },
                    { 25, 5, 1, 5 },
                    { 26, 6, 1, 6 },
                    { 27, 7, 1, 7 },
                    { 28, 8, 1, 8 },
                    { 29, 9, 1, 9 },
                    { 30, 10, 1, 10 }
                });

            migrationBuilder.InsertData(
                table: "ShiftAssignments",
                columns: new[] { "ShiftAssignmentId", "ShiftId", "UserId" },
                values: new object[,]
                {
                    { 1, 1, 2 },
                    { 2, 2, 3 },
                    { 3, 1, 4 },
                    { 4, 2, 5 },
                    { 5, 1, 6 },
                    { 6, 2, 7 },
                    { 7, 1, 2 },
                    { 8, 2, 3 },
                    { 9, 2, 4 },
                    { 10, 1, 5 },
                    { 11, 2, 6 },
                    { 12, 1, 7 },
                    { 13, 2, 8 },
                    { 14, 1, 9 },
                    { 15, 2, 10 },
                    { 16, 1, 11 },
                    { 17, 2, 6 },
                    { 18, 1, 7 },
                    { 19, 2, 8 },
                    { 20, 1, 9 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderDishes_DishId",
                table: "OrderDishes",
                column: "DishId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDishes_DishStatusId",
                table: "OrderDishes",
                column: "DishStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDishes_OrderId",
                table: "OrderDishes",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ShiftId",
                table: "Orders",
                column: "ShiftId");

            migrationBuilder.CreateIndex(
                name: "IX_ShiftAssignments_ShiftId",
                table: "ShiftAssignments",
                column: "ShiftId");

            migrationBuilder.CreateIndex(
                name: "IX_ShiftAssignments_UserId",
                table: "ShiftAssignments",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_RoleId",
                table: "Users",
                column: "RoleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderDishes");

            migrationBuilder.DropTable(
                name: "ShiftAssignments");

            migrationBuilder.DropTable(
                name: "DishStatuses");

            migrationBuilder.DropTable(
                name: "Dishes");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Shift");

            migrationBuilder.DropTable(
                name: "Roles");
        }
    }
}
