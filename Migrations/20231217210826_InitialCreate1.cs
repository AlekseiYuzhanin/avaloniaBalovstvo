using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MyAppAvalonia.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ShiftTimeStart",
                table: "Shift",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(TimeSpan),
                oldType: "interval");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ShiftTimeEnd",
                table: "Shift",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(TimeSpan),
                oldType: "interval");

            migrationBuilder.AddColumn<int>(
                name: "DishStatusId",
                table: "OrderDishes",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<double>(
                name: "DishPrice",
                table: "Dishes",
                type: "double precision",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric");

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
                table: "Shift",
                columns: new[] { "ShiftId", "ShiftDate", "ShiftTimeEnd", "ShiftTimeStart" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 12, 17, 21, 8, 26, 244, DateTimeKind.Utc).AddTicks(3173), new DateTime(2023, 12, 18, 7, 8, 26, 244, DateTimeKind.Utc).AddTicks(3179), new DateTime(2023, 12, 18, 1, 8, 26, 244, DateTimeKind.Utc).AddTicks(3174) },
                    { 2, new DateTime(2023, 12, 17, 21, 8, 26, 244, DateTimeKind.Utc).AddTicks(3181), new DateTime(2023, 12, 18, 7, 8, 26, 244, DateTimeKind.Utc).AddTicks(3181), new DateTime(2023, 12, 18, 1, 8, 26, 244, DateTimeKind.Utc).AddTicks(3181) },
                    { 3, new DateTime(2023, 12, 17, 21, 8, 26, 244, DateTimeKind.Utc).AddTicks(3182), new DateTime(2023, 12, 18, 7, 8, 26, 244, DateTimeKind.Utc).AddTicks(3183), new DateTime(2023, 12, 18, 1, 8, 26, 244, DateTimeKind.Utc).AddTicks(3182) },
                    { 4, new DateTime(2023, 12, 17, 21, 8, 26, 244, DateTimeKind.Utc).AddTicks(3184), new DateTime(2023, 12, 18, 7, 8, 26, 244, DateTimeKind.Utc).AddTicks(3184), new DateTime(2023, 12, 18, 1, 8, 26, 244, DateTimeKind.Utc).AddTicks(3184) },
                    { 5, new DateTime(2023, 12, 17, 21, 8, 26, 244, DateTimeKind.Utc).AddTicks(3185), new DateTime(2023, 12, 18, 7, 8, 26, 244, DateTimeKind.Utc).AddTicks(3186), new DateTime(2023, 12, 18, 1, 8, 26, 244, DateTimeKind.Utc).AddTicks(3185) },
                    { 6, new DateTime(2023, 12, 17, 21, 8, 26, 244, DateTimeKind.Utc).AddTicks(3187), new DateTime(2023, 12, 18, 7, 8, 26, 244, DateTimeKind.Utc).AddTicks(3187), new DateTime(2023, 12, 18, 1, 8, 26, 244, DateTimeKind.Utc).AddTicks(3187) }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderId", "ClientName", "OrderTime", "Payed", "ShiftId" },
                values: new object[,]
                {
                    { 1, "Client 1", new DateTime(2023, 12, 17, 21, 8, 26, 244, DateTimeKind.Utc).AddTicks(3224), false, 1 },
                    { 2, "Client 2", new DateTime(2023, 12, 17, 21, 8, 26, 244, DateTimeKind.Utc).AddTicks(3226), true, 2 },
                    { 3, "Client 3", new DateTime(2023, 12, 17, 21, 8, 26, 244, DateTimeKind.Utc).AddTicks(3227), true, 3 },
                    { 4, "Client 4", new DateTime(2023, 12, 17, 21, 8, 26, 244, DateTimeKind.Utc).AddTicks(3228), true, 4 },
                    { 5, "Client 5", new DateTime(2023, 12, 17, 21, 8, 26, 244, DateTimeKind.Utc).AddTicks(3228), true, 1 },
                    { 6, "Client 6", new DateTime(2023, 12, 17, 21, 8, 26, 244, DateTimeKind.Utc).AddTicks(3229), true, 2 },
                    { 7, "Client 7", new DateTime(2023, 12, 17, 21, 8, 26, 244, DateTimeKind.Utc).AddTicks(3230), true, 3 },
                    { 8, "Client 8", new DateTime(2023, 12, 17, 21, 8, 26, 244, DateTimeKind.Utc).AddTicks(3230), true, 4 },
                    { 9, "Client 9", new DateTime(2023, 12, 17, 21, 8, 26, 244, DateTimeKind.Utc).AddTicks(3231), false, 5 },
                    { 10, "Client 10", new DateTime(2023, 12, 17, 21, 8, 26, 244, DateTimeKind.Utc).AddTicks(3232), false, 6 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderDishes_DishStatusId",
                table: "OrderDishes",
                column: "DishStatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDishes_DishStatuses_DishStatusId",
                table: "OrderDishes",
                column: "DishStatusId",
                principalTable: "DishStatuses",
                principalColumn: "DishStatusId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDishes_DishStatuses_DishStatusId",
                table: "OrderDishes");

            migrationBuilder.DropTable(
                name: "DishStatuses");

            migrationBuilder.DropIndex(
                name: "IX_OrderDishes_DishStatusId",
                table: "OrderDishes");

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Shift",
                keyColumn: "ShiftId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Shift",
                keyColumn: "ShiftId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Shift",
                keyColumn: "ShiftId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Shift",
                keyColumn: "ShiftId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Shift",
                keyColumn: "ShiftId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Shift",
                keyColumn: "ShiftId",
                keyValue: 6);

            migrationBuilder.DropColumn(
                name: "DishStatusId",
                table: "OrderDishes");

            migrationBuilder.AlterColumn<TimeSpan>(
                name: "ShiftTimeStart",
                table: "Shift",
                type: "interval",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<TimeSpan>(
                name: "ShiftTimeEnd",
                table: "Shift",
                type: "interval",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<decimal>(
                name: "DishPrice",
                table: "Dishes",
                type: "numeric",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "double precision");
        }
    }
}
