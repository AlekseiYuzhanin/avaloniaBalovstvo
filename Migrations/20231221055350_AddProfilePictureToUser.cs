using System;
using Microsoft.EntityFrameworkCore.Migrations;

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
            migrationBuilder.DeleteData(
                table: "DishStatuses",
                keyColumn: "DishStatusId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "DishStatuses",
                keyColumn: "DishStatusId",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "DishStatuses",
                keyColumn: "DishStatusId",
                keyValue: 1,
                column: "StatusTitle",
                value: "Готовится");

            migrationBuilder.UpdateData(
                table: "DishStatuses",
                keyColumn: "DishStatusId",
                keyValue: 2,
                column: "StatusTitle",
                value: "Приготовлен");

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 1,
                column: "OrderTime",
                value: new DateTime(2023, 12, 21, 5, 53, 49, 220, DateTimeKind.Utc).AddTicks(8568));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 2,
                column: "OrderTime",
                value: new DateTime(2023, 12, 21, 5, 53, 49, 220, DateTimeKind.Utc).AddTicks(8570));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 3,
                column: "OrderTime",
                value: new DateTime(2023, 12, 21, 5, 53, 49, 220, DateTimeKind.Utc).AddTicks(8570));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 4,
                column: "OrderTime",
                value: new DateTime(2023, 12, 21, 5, 53, 49, 220, DateTimeKind.Utc).AddTicks(8571));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 5,
                column: "OrderTime",
                value: new DateTime(2023, 12, 21, 5, 53, 49, 220, DateTimeKind.Utc).AddTicks(8572));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 6,
                column: "OrderTime",
                value: new DateTime(2023, 12, 21, 5, 53, 49, 220, DateTimeKind.Utc).AddTicks(8573));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 7,
                column: "OrderTime",
                value: new DateTime(2023, 12, 21, 5, 53, 49, 220, DateTimeKind.Utc).AddTicks(8573));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 8,
                column: "OrderTime",
                value: new DateTime(2023, 12, 21, 5, 53, 49, 220, DateTimeKind.Utc).AddTicks(8574));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 9,
                column: "OrderTime",
                value: new DateTime(2023, 12, 21, 5, 53, 49, 220, DateTimeKind.Utc).AddTicks(8575));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10,
                column: "OrderTime",
                value: new DateTime(2023, 12, 21, 5, 53, 49, 220, DateTimeKind.Utc).AddTicks(8575));

            migrationBuilder.UpdateData(
                table: "Shift",
                keyColumn: "ShiftId",
                keyValue: 1,
                columns: new[] { "ShiftDate", "ShiftTimeEnd", "ShiftTimeStart" },
                values: new object[] { new DateTime(2023, 12, 21, 5, 53, 49, 220, DateTimeKind.Utc).AddTicks(8501), new DateTime(2023, 12, 21, 15, 53, 49, 220, DateTimeKind.Utc).AddTicks(8509), new DateTime(2023, 12, 21, 9, 53, 49, 220, DateTimeKind.Utc).AddTicks(8502) });

            migrationBuilder.UpdateData(
                table: "Shift",
                keyColumn: "ShiftId",
                keyValue: 2,
                columns: new[] { "ShiftDate", "ShiftTimeEnd", "ShiftTimeStart" },
                values: new object[] { new DateTime(2023, 12, 21, 5, 53, 49, 220, DateTimeKind.Utc).AddTicks(8511), new DateTime(2023, 12, 21, 15, 53, 49, 220, DateTimeKind.Utc).AddTicks(8511), new DateTime(2023, 12, 21, 9, 53, 49, 220, DateTimeKind.Utc).AddTicks(8511) });

            migrationBuilder.UpdateData(
                table: "Shift",
                keyColumn: "ShiftId",
                keyValue: 3,
                columns: new[] { "ShiftDate", "ShiftTimeEnd", "ShiftTimeStart" },
                values: new object[] { new DateTime(2023, 12, 21, 5, 53, 49, 220, DateTimeKind.Utc).AddTicks(8512), new DateTime(2023, 12, 21, 15, 53, 49, 220, DateTimeKind.Utc).AddTicks(8513), new DateTime(2023, 12, 21, 9, 53, 49, 220, DateTimeKind.Utc).AddTicks(8513) });

            migrationBuilder.UpdateData(
                table: "Shift",
                keyColumn: "ShiftId",
                keyValue: 4,
                columns: new[] { "ShiftDate", "ShiftTimeEnd", "ShiftTimeStart" },
                values: new object[] { new DateTime(2023, 12, 21, 5, 53, 49, 220, DateTimeKind.Utc).AddTicks(8514), new DateTime(2023, 12, 21, 15, 53, 49, 220, DateTimeKind.Utc).AddTicks(8515), new DateTime(2023, 12, 21, 9, 53, 49, 220, DateTimeKind.Utc).AddTicks(8514) });

            migrationBuilder.UpdateData(
                table: "Shift",
                keyColumn: "ShiftId",
                keyValue: 5,
                columns: new[] { "ShiftDate", "ShiftTimeEnd", "ShiftTimeStart" },
                values: new object[] { new DateTime(2023, 12, 21, 5, 53, 49, 220, DateTimeKind.Utc).AddTicks(8516), new DateTime(2023, 12, 21, 15, 53, 49, 220, DateTimeKind.Utc).AddTicks(8516), new DateTime(2023, 12, 21, 9, 53, 49, 220, DateTimeKind.Utc).AddTicks(8516) });

            migrationBuilder.UpdateData(
                table: "Shift",
                keyColumn: "ShiftId",
                keyValue: 6,
                columns: new[] { "ShiftDate", "ShiftTimeEnd", "ShiftTimeStart" },
                values: new object[] { new DateTime(2023, 12, 21, 5, 53, 49, 220, DateTimeKind.Utc).AddTicks(8517), new DateTime(2023, 12, 21, 15, 53, 49, 220, DateTimeKind.Utc).AddTicks(8518), new DateTime(2023, 12, 21, 9, 53, 49, 220, DateTimeKind.Utc).AddTicks(8518) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "DishStatuses",
                keyColumn: "DishStatusId",
                keyValue: 1,
                column: "StatusTitle",
                value: null);

            migrationBuilder.UpdateData(
                table: "DishStatuses",
                keyColumn: "DishStatusId",
                keyValue: 2,
                column: "StatusTitle",
                value: null);

            migrationBuilder.InsertData(
                table: "DishStatuses",
                columns: new[] { "DishStatusId", "StatusTitle" },
                values: new object[,]
                {
                    { 3, null },
                    { 4, null }
                });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 1,
                column: "OrderTime",
                value: new DateTime(2023, 12, 20, 23, 9, 40, 74, DateTimeKind.Utc).AddTicks(1150));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 2,
                column: "OrderTime",
                value: new DateTime(2023, 12, 20, 23, 9, 40, 74, DateTimeKind.Utc).AddTicks(1152));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 3,
                column: "OrderTime",
                value: new DateTime(2023, 12, 20, 23, 9, 40, 74, DateTimeKind.Utc).AddTicks(1153));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 4,
                column: "OrderTime",
                value: new DateTime(2023, 12, 20, 23, 9, 40, 74, DateTimeKind.Utc).AddTicks(1154));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 5,
                column: "OrderTime",
                value: new DateTime(2023, 12, 20, 23, 9, 40, 74, DateTimeKind.Utc).AddTicks(1155));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 6,
                column: "OrderTime",
                value: new DateTime(2023, 12, 20, 23, 9, 40, 74, DateTimeKind.Utc).AddTicks(1155));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 7,
                column: "OrderTime",
                value: new DateTime(2023, 12, 20, 23, 9, 40, 74, DateTimeKind.Utc).AddTicks(1156));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 8,
                column: "OrderTime",
                value: new DateTime(2023, 12, 20, 23, 9, 40, 74, DateTimeKind.Utc).AddTicks(1157));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 9,
                column: "OrderTime",
                value: new DateTime(2023, 12, 20, 23, 9, 40, 74, DateTimeKind.Utc).AddTicks(1158));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10,
                column: "OrderTime",
                value: new DateTime(2023, 12, 20, 23, 9, 40, 74, DateTimeKind.Utc).AddTicks(1158));

            migrationBuilder.UpdateData(
                table: "Shift",
                keyColumn: "ShiftId",
                keyValue: 1,
                columns: new[] { "ShiftDate", "ShiftTimeEnd", "ShiftTimeStart" },
                values: new object[] { new DateTime(2023, 12, 20, 23, 9, 40, 74, DateTimeKind.Utc).AddTicks(1085), new DateTime(2023, 12, 21, 9, 9, 40, 74, DateTimeKind.Utc).AddTicks(1091), new DateTime(2023, 12, 21, 3, 9, 40, 74, DateTimeKind.Utc).AddTicks(1086) });

            migrationBuilder.UpdateData(
                table: "Shift",
                keyColumn: "ShiftId",
                keyValue: 2,
                columns: new[] { "ShiftDate", "ShiftTimeEnd", "ShiftTimeStart" },
                values: new object[] { new DateTime(2023, 12, 20, 23, 9, 40, 74, DateTimeKind.Utc).AddTicks(1093), new DateTime(2023, 12, 21, 9, 9, 40, 74, DateTimeKind.Utc).AddTicks(1094), new DateTime(2023, 12, 21, 3, 9, 40, 74, DateTimeKind.Utc).AddTicks(1093) });

            migrationBuilder.UpdateData(
                table: "Shift",
                keyColumn: "ShiftId",
                keyValue: 3,
                columns: new[] { "ShiftDate", "ShiftTimeEnd", "ShiftTimeStart" },
                values: new object[] { new DateTime(2023, 12, 20, 23, 9, 40, 74, DateTimeKind.Utc).AddTicks(1095), new DateTime(2023, 12, 21, 9, 9, 40, 74, DateTimeKind.Utc).AddTicks(1096), new DateTime(2023, 12, 21, 3, 9, 40, 74, DateTimeKind.Utc).AddTicks(1095) });

            migrationBuilder.UpdateData(
                table: "Shift",
                keyColumn: "ShiftId",
                keyValue: 4,
                columns: new[] { "ShiftDate", "ShiftTimeEnd", "ShiftTimeStart" },
                values: new object[] { new DateTime(2023, 12, 20, 23, 9, 40, 74, DateTimeKind.Utc).AddTicks(1096), new DateTime(2023, 12, 21, 9, 9, 40, 74, DateTimeKind.Utc).AddTicks(1097), new DateTime(2023, 12, 21, 3, 9, 40, 74, DateTimeKind.Utc).AddTicks(1097) });

            migrationBuilder.UpdateData(
                table: "Shift",
                keyColumn: "ShiftId",
                keyValue: 5,
                columns: new[] { "ShiftDate", "ShiftTimeEnd", "ShiftTimeStart" },
                values: new object[] { new DateTime(2023, 12, 20, 23, 9, 40, 74, DateTimeKind.Utc).AddTicks(1098), new DateTime(2023, 12, 21, 9, 9, 40, 74, DateTimeKind.Utc).AddTicks(1099), new DateTime(2023, 12, 21, 3, 9, 40, 74, DateTimeKind.Utc).AddTicks(1098) });

            migrationBuilder.UpdateData(
                table: "Shift",
                keyColumn: "ShiftId",
                keyValue: 6,
                columns: new[] { "ShiftDate", "ShiftTimeEnd", "ShiftTimeStart" },
                values: new object[] { new DateTime(2023, 12, 20, 23, 9, 40, 74, DateTimeKind.Utc).AddTicks(1100), new DateTime(2023, 12, 21, 9, 9, 40, 74, DateTimeKind.Utc).AddTicks(1100), new DateTime(2023, 12, 21, 3, 9, 40, 74, DateTimeKind.Utc).AddTicks(1100) });
        }
    }
}
