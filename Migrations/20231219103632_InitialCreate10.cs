﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyAppAvalonia.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate10 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 1,
                column: "OrderTime",
                value: new DateTime(2023, 12, 19, 10, 36, 32, 151, DateTimeKind.Utc).AddTicks(3461));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 2,
                column: "OrderTime",
                value: new DateTime(2023, 12, 19, 10, 36, 32, 151, DateTimeKind.Utc).AddTicks(3462));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 3,
                column: "OrderTime",
                value: new DateTime(2023, 12, 19, 10, 36, 32, 151, DateTimeKind.Utc).AddTicks(3463));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 4,
                column: "OrderTime",
                value: new DateTime(2023, 12, 19, 10, 36, 32, 151, DateTimeKind.Utc).AddTicks(3464));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 5,
                column: "OrderTime",
                value: new DateTime(2023, 12, 19, 10, 36, 32, 151, DateTimeKind.Utc).AddTicks(3465));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 6,
                column: "OrderTime",
                value: new DateTime(2023, 12, 19, 10, 36, 32, 151, DateTimeKind.Utc).AddTicks(3466));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 7,
                column: "OrderTime",
                value: new DateTime(2023, 12, 19, 10, 36, 32, 151, DateTimeKind.Utc).AddTicks(3467));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 8,
                column: "OrderTime",
                value: new DateTime(2023, 12, 19, 10, 36, 32, 151, DateTimeKind.Utc).AddTicks(3468));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 9,
                column: "OrderTime",
                value: new DateTime(2023, 12, 19, 10, 36, 32, 151, DateTimeKind.Utc).AddTicks(3469));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10,
                column: "OrderTime",
                value: new DateTime(2023, 12, 19, 10, 36, 32, 151, DateTimeKind.Utc).AddTicks(3469));

            migrationBuilder.UpdateData(
                table: "Shift",
                keyColumn: "ShiftId",
                keyValue: 1,
                columns: new[] { "ShiftDate", "ShiftTimeEnd", "ShiftTimeStart" },
                values: new object[] { new DateTime(2023, 12, 19, 10, 36, 32, 151, DateTimeKind.Utc).AddTicks(3412), new DateTime(2023, 12, 19, 20, 36, 32, 151, DateTimeKind.Utc).AddTicks(3418), new DateTime(2023, 12, 19, 14, 36, 32, 151, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "Shift",
                keyColumn: "ShiftId",
                keyValue: 2,
                columns: new[] { "ShiftDate", "ShiftTimeEnd", "ShiftTimeStart" },
                values: new object[] { new DateTime(2023, 12, 19, 10, 36, 32, 151, DateTimeKind.Utc).AddTicks(3420), new DateTime(2023, 12, 19, 20, 36, 32, 151, DateTimeKind.Utc).AddTicks(3420), new DateTime(2023, 12, 19, 14, 36, 32, 151, DateTimeKind.Utc).AddTicks(3420) });

            migrationBuilder.UpdateData(
                table: "Shift",
                keyColumn: "ShiftId",
                keyValue: 3,
                columns: new[] { "ShiftDate", "ShiftTimeEnd", "ShiftTimeStart" },
                values: new object[] { new DateTime(2023, 12, 19, 10, 36, 32, 151, DateTimeKind.Utc).AddTicks(3421), new DateTime(2023, 12, 19, 20, 36, 32, 151, DateTimeKind.Utc).AddTicks(3422), new DateTime(2023, 12, 19, 14, 36, 32, 151, DateTimeKind.Utc).AddTicks(3422) });

            migrationBuilder.UpdateData(
                table: "Shift",
                keyColumn: "ShiftId",
                keyValue: 4,
                columns: new[] { "ShiftDate", "ShiftTimeEnd", "ShiftTimeStart" },
                values: new object[] { new DateTime(2023, 12, 19, 10, 36, 32, 151, DateTimeKind.Utc).AddTicks(3423), new DateTime(2023, 12, 19, 20, 36, 32, 151, DateTimeKind.Utc).AddTicks(3424), new DateTime(2023, 12, 19, 14, 36, 32, 151, DateTimeKind.Utc).AddTicks(3423) });

            migrationBuilder.UpdateData(
                table: "Shift",
                keyColumn: "ShiftId",
                keyValue: 5,
                columns: new[] { "ShiftDate", "ShiftTimeEnd", "ShiftTimeStart" },
                values: new object[] { new DateTime(2023, 12, 19, 10, 36, 32, 151, DateTimeKind.Utc).AddTicks(3425), new DateTime(2023, 12, 19, 20, 36, 32, 151, DateTimeKind.Utc).AddTicks(3425), new DateTime(2023, 12, 19, 14, 36, 32, 151, DateTimeKind.Utc).AddTicks(3425) });

            migrationBuilder.UpdateData(
                table: "Shift",
                keyColumn: "ShiftId",
                keyValue: 6,
                columns: new[] { "ShiftDate", "ShiftTimeEnd", "ShiftTimeStart" },
                values: new object[] { new DateTime(2023, 12, 19, 10, 36, 32, 151, DateTimeKind.Utc).AddTicks(3426), new DateTime(2023, 12, 19, 20, 36, 32, 151, DateTimeKind.Utc).AddTicks(3427), new DateTime(2023, 12, 19, 14, 36, 32, 151, DateTimeKind.Utc).AddTicks(3426) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}