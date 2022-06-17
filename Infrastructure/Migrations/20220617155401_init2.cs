using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("9f887b32-2ffe-4a7e-9fd0-5da8e71ae901"));

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Address",
                type: "uniqueidentifier",
                nullable: false,
                defaultValueSql: "NEWID()",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.InsertData(
                table: "Owners",
                columns: new[] { "Id", "AddressId", "Avatar", "FullName", "Profile" },
                values: new object[] { new Guid("fb4d1f4b-a519-4f6b-b30a-2c00abaccd95"), null, "avatar1.jbeg", "Amr Atallah", "Software engineer | Machine learning engineer" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("fb4d1f4b-a519-4f6b-b30a-2c00abaccd95"));

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Address",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValueSql: "NEWID()");

            migrationBuilder.InsertData(
                table: "Owners",
                columns: new[] { "Id", "AddressId", "Avatar", "FullName", "Profile" },
                values: new object[] { new Guid("9f887b32-2ffe-4a7e-9fd0-5da8e71ae901"), null, "avatar1.jbeg", "Amr Atallah", "Software engineer | Machine learning engineer" });
        }
    }
}
