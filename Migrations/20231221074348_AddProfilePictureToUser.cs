using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyAppAvalonia.Migrations
{
    /// <inheritdoc />
    public partial class AddProfilePictureToUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 1,
                column: "OrderTime",
                value: new DateTime(2023, 12, 21, 7, 43, 47, 588, DateTimeKind.Utc).AddTicks(5169));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 2,
                column: "OrderTime",
                value: new DateTime(2023, 12, 21, 7, 43, 47, 588, DateTimeKind.Utc).AddTicks(5171));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 3,
                column: "OrderTime",
                value: new DateTime(2023, 12, 21, 7, 43, 47, 588, DateTimeKind.Utc).AddTicks(5172));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 4,
                column: "OrderTime",
                value: new DateTime(2023, 12, 21, 7, 43, 47, 588, DateTimeKind.Utc).AddTicks(5173));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 5,
                column: "OrderTime",
                value: new DateTime(2023, 12, 21, 7, 43, 47, 588, DateTimeKind.Utc).AddTicks(5173));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 6,
                column: "OrderTime",
                value: new DateTime(2023, 12, 21, 7, 43, 47, 588, DateTimeKind.Utc).AddTicks(5174));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 7,
                column: "OrderTime",
                value: new DateTime(2023, 12, 21, 7, 43, 47, 588, DateTimeKind.Utc).AddTicks(5175));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 8,
                column: "OrderTime",
                value: new DateTime(2023, 12, 21, 7, 43, 47, 588, DateTimeKind.Utc).AddTicks(5176));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 9,
                column: "OrderTime",
                value: new DateTime(2023, 12, 21, 7, 43, 47, 588, DateTimeKind.Utc).AddTicks(5177));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10,
                column: "OrderTime",
                value: new DateTime(2023, 12, 21, 7, 43, 47, 588, DateTimeKind.Utc).AddTicks(5177));

            migrationBuilder.UpdateData(
                table: "Shift",
                keyColumn: "ShiftId",
                keyValue: 1,
                columns: new[] { "ShiftDate", "ShiftTimeEnd", "ShiftTimeStart" },
                values: new object[] { new DateTime(2023, 12, 21, 7, 43, 47, 588, DateTimeKind.Utc).AddTicks(5113), new DateTime(2023, 12, 21, 17, 43, 47, 588, DateTimeKind.Utc).AddTicks(5120), new DateTime(2023, 12, 21, 11, 43, 47, 588, DateTimeKind.Utc).AddTicks(5114) });

            migrationBuilder.UpdateData(
                table: "Shift",
                keyColumn: "ShiftId",
                keyValue: 2,
                columns: new[] { "ShiftDate", "ShiftTimeEnd", "ShiftTimeStart" },
                values: new object[] { new DateTime(2023, 12, 21, 7, 43, 47, 588, DateTimeKind.Utc).AddTicks(5121), new DateTime(2023, 12, 21, 17, 43, 47, 588, DateTimeKind.Utc).AddTicks(5122), new DateTime(2023, 12, 21, 11, 43, 47, 588, DateTimeKind.Utc).AddTicks(5122) });

            migrationBuilder.UpdateData(
                table: "Shift",
                keyColumn: "ShiftId",
                keyValue: 3,
                columns: new[] { "ShiftDate", "ShiftTimeEnd", "ShiftTimeStart" },
                values: new object[] { new DateTime(2023, 12, 21, 7, 43, 47, 588, DateTimeKind.Utc).AddTicks(5123), new DateTime(2023, 12, 21, 17, 43, 47, 588, DateTimeKind.Utc).AddTicks(5124), new DateTime(2023, 12, 21, 11, 43, 47, 588, DateTimeKind.Utc).AddTicks(5123) });

            migrationBuilder.UpdateData(
                table: "Shift",
                keyColumn: "ShiftId",
                keyValue: 4,
                columns: new[] { "ShiftDate", "ShiftTimeEnd", "ShiftTimeStart" },
                values: new object[] { new DateTime(2023, 12, 21, 7, 43, 47, 588, DateTimeKind.Utc).AddTicks(5124), new DateTime(2023, 12, 21, 17, 43, 47, 588, DateTimeKind.Utc).AddTicks(5125), new DateTime(2023, 12, 21, 11, 43, 47, 588, DateTimeKind.Utc).AddTicks(5125) });

            migrationBuilder.UpdateData(
                table: "Shift",
                keyColumn: "ShiftId",
                keyValue: 5,
                columns: new[] { "ShiftDate", "ShiftTimeEnd", "ShiftTimeStart" },
                values: new object[] { new DateTime(2023, 12, 21, 7, 43, 47, 588, DateTimeKind.Utc).AddTicks(5126), new DateTime(2023, 12, 21, 17, 43, 47, 588, DateTimeKind.Utc).AddTicks(5127), new DateTime(2023, 12, 21, 11, 43, 47, 588, DateTimeKind.Utc).AddTicks(5126) });

            migrationBuilder.UpdateData(
                table: "Shift",
                keyColumn: "ShiftId",
                keyValue: 6,
                columns: new[] { "ShiftDate", "ShiftTimeEnd", "ShiftTimeStart" },
                values: new object[] { new DateTime(2023, 12, 21, 7, 43, 47, 588, DateTimeKind.Utc).AddTicks(5128), new DateTime(2023, 12, 21, 17, 43, 47, 588, DateTimeKind.Utc).AddTicks(5128), new DateTime(2023, 12, 21, 11, 43, 47, 588, DateTimeKind.Utc).AddTicks(5128) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
