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
            migrationBuilder.AddColumn<byte[]>(
                name: "ContractPicture",
                table: "Users",
                type: "bytea",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "ProfilePicture",
                table: "Users",
                type: "bytea",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 1,
                column: "OrderTime",
                value: new DateTime(2023, 12, 19, 10, 42, 26, 737, DateTimeKind.Utc).AddTicks(2055));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 2,
                column: "OrderTime",
                value: new DateTime(2023, 12, 19, 10, 42, 26, 737, DateTimeKind.Utc).AddTicks(2057));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 3,
                column: "OrderTime",
                value: new DateTime(2023, 12, 19, 10, 42, 26, 737, DateTimeKind.Utc).AddTicks(2058));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 4,
                column: "OrderTime",
                value: new DateTime(2023, 12, 19, 10, 42, 26, 737, DateTimeKind.Utc).AddTicks(2059));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 5,
                column: "OrderTime",
                value: new DateTime(2023, 12, 19, 10, 42, 26, 737, DateTimeKind.Utc).AddTicks(2059));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 6,
                column: "OrderTime",
                value: new DateTime(2023, 12, 19, 10, 42, 26, 737, DateTimeKind.Utc).AddTicks(2060));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 7,
                column: "OrderTime",
                value: new DateTime(2023, 12, 19, 10, 42, 26, 737, DateTimeKind.Utc).AddTicks(2061));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 8,
                column: "OrderTime",
                value: new DateTime(2023, 12, 19, 10, 42, 26, 737, DateTimeKind.Utc).AddTicks(2062));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 9,
                column: "OrderTime",
                value: new DateTime(2023, 12, 19, 10, 42, 26, 737, DateTimeKind.Utc).AddTicks(2063));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10,
                column: "OrderTime",
                value: new DateTime(2023, 12, 19, 10, 42, 26, 737, DateTimeKind.Utc).AddTicks(2063));

            migrationBuilder.UpdateData(
                table: "Shift",
                keyColumn: "ShiftId",
                keyValue: 1,
                columns: new[] { "ShiftDate", "ShiftTimeEnd", "ShiftTimeStart" },
                values: new object[] { new DateTime(2023, 12, 19, 10, 42, 26, 737, DateTimeKind.Utc).AddTicks(1994), new DateTime(2023, 12, 19, 20, 42, 26, 737, DateTimeKind.Utc).AddTicks(2002), new DateTime(2023, 12, 19, 14, 42, 26, 737, DateTimeKind.Utc).AddTicks(1995) });

            migrationBuilder.UpdateData(
                table: "Shift",
                keyColumn: "ShiftId",
                keyValue: 2,
                columns: new[] { "ShiftDate", "ShiftTimeEnd", "ShiftTimeStart" },
                values: new object[] { new DateTime(2023, 12, 19, 10, 42, 26, 737, DateTimeKind.Utc).AddTicks(2003), new DateTime(2023, 12, 19, 20, 42, 26, 737, DateTimeKind.Utc).AddTicks(2004), new DateTime(2023, 12, 19, 14, 42, 26, 737, DateTimeKind.Utc).AddTicks(2004) });

            migrationBuilder.UpdateData(
                table: "Shift",
                keyColumn: "ShiftId",
                keyValue: 3,
                columns: new[] { "ShiftDate", "ShiftTimeEnd", "ShiftTimeStart" },
                values: new object[] { new DateTime(2023, 12, 19, 10, 42, 26, 737, DateTimeKind.Utc).AddTicks(2005), new DateTime(2023, 12, 19, 20, 42, 26, 737, DateTimeKind.Utc).AddTicks(2006), new DateTime(2023, 12, 19, 14, 42, 26, 737, DateTimeKind.Utc).AddTicks(2005) });

            migrationBuilder.UpdateData(
                table: "Shift",
                keyColumn: "ShiftId",
                keyValue: 4,
                columns: new[] { "ShiftDate", "ShiftTimeEnd", "ShiftTimeStart" },
                values: new object[] { new DateTime(2023, 12, 19, 10, 42, 26, 737, DateTimeKind.Utc).AddTicks(2007), new DateTime(2023, 12, 19, 20, 42, 26, 737, DateTimeKind.Utc).AddTicks(2007), new DateTime(2023, 12, 19, 14, 42, 26, 737, DateTimeKind.Utc).AddTicks(2007) });

            migrationBuilder.UpdateData(
                table: "Shift",
                keyColumn: "ShiftId",
                keyValue: 5,
                columns: new[] { "ShiftDate", "ShiftTimeEnd", "ShiftTimeStart" },
                values: new object[] { new DateTime(2023, 12, 19, 10, 42, 26, 737, DateTimeKind.Utc).AddTicks(2008), new DateTime(2023, 12, 19, 20, 42, 26, 737, DateTimeKind.Utc).AddTicks(2009), new DateTime(2023, 12, 19, 14, 42, 26, 737, DateTimeKind.Utc).AddTicks(2009) });

            migrationBuilder.UpdateData(
                table: "Shift",
                keyColumn: "ShiftId",
                keyValue: 6,
                columns: new[] { "ShiftDate", "ShiftTimeEnd", "ShiftTimeStart" },
                values: new object[] { new DateTime(2023, 12, 19, 10, 42, 26, 737, DateTimeKind.Utc).AddTicks(2010), new DateTime(2023, 12, 19, 20, 42, 26, 737, DateTimeKind.Utc).AddTicks(2011), new DateTime(2023, 12, 19, 14, 42, 26, 737, DateTimeKind.Utc).AddTicks(2010) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "ContractPicture", "ProfilePicture" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "ContractPicture", "ProfilePicture" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "ContractPicture", "ProfilePicture" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "ContractPicture", "ProfilePicture" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5,
                columns: new[] { "ContractPicture", "ProfilePicture" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6,
                columns: new[] { "ContractPicture", "ProfilePicture" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 7,
                columns: new[] { "ContractPicture", "ProfilePicture" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 8,
                columns: new[] { "ContractPicture", "ProfilePicture" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 9,
                columns: new[] { "ContractPicture", "ProfilePicture" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 10,
                columns: new[] { "ContractPicture", "ProfilePicture" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 11,
                columns: new[] { "ContractPicture", "ProfilePicture" },
                values: new object[] { null, null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ContractPicture",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "ProfilePicture",
                table: "Users");

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
    }
}
