using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyAppAvalonia.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 1,
                column: "OrderTime",
                value: new DateTime(2023, 12, 19, 5, 21, 39, 167, DateTimeKind.Utc).AddTicks(1374));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 2,
                column: "OrderTime",
                value: new DateTime(2023, 12, 19, 5, 21, 39, 167, DateTimeKind.Utc).AddTicks(1375));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 3,
                column: "OrderTime",
                value: new DateTime(2023, 12, 19, 5, 21, 39, 167, DateTimeKind.Utc).AddTicks(1376));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 4,
                column: "OrderTime",
                value: new DateTime(2023, 12, 19, 5, 21, 39, 167, DateTimeKind.Utc).AddTicks(1377));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 5,
                column: "OrderTime",
                value: new DateTime(2023, 12, 19, 5, 21, 39, 167, DateTimeKind.Utc).AddTicks(1378));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 6,
                column: "OrderTime",
                value: new DateTime(2023, 12, 19, 5, 21, 39, 167, DateTimeKind.Utc).AddTicks(1378));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 7,
                column: "OrderTime",
                value: new DateTime(2023, 12, 19, 5, 21, 39, 167, DateTimeKind.Utc).AddTicks(1379));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 8,
                column: "OrderTime",
                value: new DateTime(2023, 12, 19, 5, 21, 39, 167, DateTimeKind.Utc).AddTicks(1380));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 9,
                column: "OrderTime",
                value: new DateTime(2023, 12, 19, 5, 21, 39, 167, DateTimeKind.Utc).AddTicks(1381));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10,
                column: "OrderTime",
                value: new DateTime(2023, 12, 19, 5, 21, 39, 167, DateTimeKind.Utc).AddTicks(1382));

            migrationBuilder.UpdateData(
                table: "Shift",
                keyColumn: "ShiftId",
                keyValue: 1,
                columns: new[] { "ShiftDate", "ShiftTimeEnd", "ShiftTimeStart" },
                values: new object[] { new DateTime(2023, 12, 19, 5, 21, 39, 167, DateTimeKind.Utc).AddTicks(1319), new DateTime(2023, 12, 19, 15, 21, 39, 167, DateTimeKind.Utc).AddTicks(1326), new DateTime(2023, 12, 19, 9, 21, 39, 167, DateTimeKind.Utc).AddTicks(1320) });

            migrationBuilder.UpdateData(
                table: "Shift",
                keyColumn: "ShiftId",
                keyValue: 2,
                columns: new[] { "ShiftDate", "ShiftTimeEnd", "ShiftTimeStart" },
                values: new object[] { new DateTime(2023, 12, 19, 5, 21, 39, 167, DateTimeKind.Utc).AddTicks(1328), new DateTime(2023, 12, 19, 15, 21, 39, 167, DateTimeKind.Utc).AddTicks(1328), new DateTime(2023, 12, 19, 9, 21, 39, 167, DateTimeKind.Utc).AddTicks(1328) });

            migrationBuilder.UpdateData(
                table: "Shift",
                keyColumn: "ShiftId",
                keyValue: 3,
                columns: new[] { "ShiftDate", "ShiftTimeEnd", "ShiftTimeStart" },
                values: new object[] { new DateTime(2023, 12, 19, 5, 21, 39, 167, DateTimeKind.Utc).AddTicks(1329), new DateTime(2023, 12, 19, 15, 21, 39, 167, DateTimeKind.Utc).AddTicks(1330), new DateTime(2023, 12, 19, 9, 21, 39, 167, DateTimeKind.Utc).AddTicks(1330) });

            migrationBuilder.UpdateData(
                table: "Shift",
                keyColumn: "ShiftId",
                keyValue: 4,
                columns: new[] { "ShiftDate", "ShiftTimeEnd", "ShiftTimeStart" },
                values: new object[] { new DateTime(2023, 12, 19, 5, 21, 39, 167, DateTimeKind.Utc).AddTicks(1331), new DateTime(2023, 12, 19, 15, 21, 39, 167, DateTimeKind.Utc).AddTicks(1332), new DateTime(2023, 12, 19, 9, 21, 39, 167, DateTimeKind.Utc).AddTicks(1331) });

            migrationBuilder.UpdateData(
                table: "Shift",
                keyColumn: "ShiftId",
                keyValue: 5,
                columns: new[] { "ShiftDate", "ShiftTimeEnd", "ShiftTimeStart" },
                values: new object[] { new DateTime(2023, 12, 19, 5, 21, 39, 167, DateTimeKind.Utc).AddTicks(1333), new DateTime(2023, 12, 19, 15, 21, 39, 167, DateTimeKind.Utc).AddTicks(1333), new DateTime(2023, 12, 19, 9, 21, 39, 167, DateTimeKind.Utc).AddTicks(1333) });

            migrationBuilder.UpdateData(
                table: "Shift",
                keyColumn: "ShiftId",
                keyValue: 6,
                columns: new[] { "ShiftDate", "ShiftTimeEnd", "ShiftTimeStart" },
                values: new object[] { new DateTime(2023, 12, 19, 5, 21, 39, 167, DateTimeKind.Utc).AddTicks(1334), new DateTime(2023, 12, 19, 15, 21, 39, 167, DateTimeKind.Utc).AddTicks(1335), new DateTime(2023, 12, 19, 9, 21, 39, 167, DateTimeKind.Utc).AddTicks(1334) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 1,
                column: "OrderTime",
                value: new DateTime(2023, 12, 19, 5, 21, 12, 436, DateTimeKind.Utc).AddTicks(2579));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 2,
                column: "OrderTime",
                value: new DateTime(2023, 12, 19, 5, 21, 12, 436, DateTimeKind.Utc).AddTicks(2581));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 3,
                column: "OrderTime",
                value: new DateTime(2023, 12, 19, 5, 21, 12, 436, DateTimeKind.Utc).AddTicks(2582));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 4,
                column: "OrderTime",
                value: new DateTime(2023, 12, 19, 5, 21, 12, 436, DateTimeKind.Utc).AddTicks(2582));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 5,
                column: "OrderTime",
                value: new DateTime(2023, 12, 19, 5, 21, 12, 436, DateTimeKind.Utc).AddTicks(2583));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 6,
                column: "OrderTime",
                value: new DateTime(2023, 12, 19, 5, 21, 12, 436, DateTimeKind.Utc).AddTicks(2584));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 7,
                column: "OrderTime",
                value: new DateTime(2023, 12, 19, 5, 21, 12, 436, DateTimeKind.Utc).AddTicks(2585));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 8,
                column: "OrderTime",
                value: new DateTime(2023, 12, 19, 5, 21, 12, 436, DateTimeKind.Utc).AddTicks(2585));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 9,
                column: "OrderTime",
                value: new DateTime(2023, 12, 19, 5, 21, 12, 436, DateTimeKind.Utc).AddTicks(2586));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10,
                column: "OrderTime",
                value: new DateTime(2023, 12, 19, 5, 21, 12, 436, DateTimeKind.Utc).AddTicks(2587));

            migrationBuilder.UpdateData(
                table: "Shift",
                keyColumn: "ShiftId",
                keyValue: 1,
                columns: new[] { "ShiftDate", "ShiftTimeEnd", "ShiftTimeStart" },
                values: new object[] { new DateTime(2023, 12, 19, 5, 21, 12, 436, DateTimeKind.Utc).AddTicks(2514), new DateTime(2023, 12, 19, 15, 21, 12, 436, DateTimeKind.Utc).AddTicks(2523), new DateTime(2023, 12, 19, 9, 21, 12, 436, DateTimeKind.Utc).AddTicks(2515) });

            migrationBuilder.UpdateData(
                table: "Shift",
                keyColumn: "ShiftId",
                keyValue: 2,
                columns: new[] { "ShiftDate", "ShiftTimeEnd", "ShiftTimeStart" },
                values: new object[] { new DateTime(2023, 12, 19, 5, 21, 12, 436, DateTimeKind.Utc).AddTicks(2525), new DateTime(2023, 12, 19, 15, 21, 12, 436, DateTimeKind.Utc).AddTicks(2526), new DateTime(2023, 12, 19, 9, 21, 12, 436, DateTimeKind.Utc).AddTicks(2525) });

            migrationBuilder.UpdateData(
                table: "Shift",
                keyColumn: "ShiftId",
                keyValue: 3,
                columns: new[] { "ShiftDate", "ShiftTimeEnd", "ShiftTimeStart" },
                values: new object[] { new DateTime(2023, 12, 19, 5, 21, 12, 436, DateTimeKind.Utc).AddTicks(2526), new DateTime(2023, 12, 19, 15, 21, 12, 436, DateTimeKind.Utc).AddTicks(2527), new DateTime(2023, 12, 19, 9, 21, 12, 436, DateTimeKind.Utc).AddTicks(2527) });

            migrationBuilder.UpdateData(
                table: "Shift",
                keyColumn: "ShiftId",
                keyValue: 4,
                columns: new[] { "ShiftDate", "ShiftTimeEnd", "ShiftTimeStart" },
                values: new object[] { new DateTime(2023, 12, 19, 5, 21, 12, 436, DateTimeKind.Utc).AddTicks(2528), new DateTime(2023, 12, 19, 15, 21, 12, 436, DateTimeKind.Utc).AddTicks(2529), new DateTime(2023, 12, 19, 9, 21, 12, 436, DateTimeKind.Utc).AddTicks(2528) });

            migrationBuilder.UpdateData(
                table: "Shift",
                keyColumn: "ShiftId",
                keyValue: 5,
                columns: new[] { "ShiftDate", "ShiftTimeEnd", "ShiftTimeStart" },
                values: new object[] { new DateTime(2023, 12, 19, 5, 21, 12, 436, DateTimeKind.Utc).AddTicks(2530), new DateTime(2023, 12, 19, 15, 21, 12, 436, DateTimeKind.Utc).AddTicks(2531), new DateTime(2023, 12, 19, 9, 21, 12, 436, DateTimeKind.Utc).AddTicks(2530) });

            migrationBuilder.UpdateData(
                table: "Shift",
                keyColumn: "ShiftId",
                keyValue: 6,
                columns: new[] { "ShiftDate", "ShiftTimeEnd", "ShiftTimeStart" },
                values: new object[] { new DateTime(2023, 12, 19, 5, 21, 12, 436, DateTimeKind.Utc).AddTicks(2531), new DateTime(2023, 12, 19, 15, 21, 12, 436, DateTimeKind.Utc).AddTicks(2532), new DateTime(2023, 12, 19, 9, 21, 12, 436, DateTimeKind.Utc).AddTicks(2532) });
        }
    }
}
