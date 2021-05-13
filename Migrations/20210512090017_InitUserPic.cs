using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CloudStorage.Migrations
{
    public partial class InitUserPic : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "UserPic",
                table: "AspNetUsers",
                type: "varbinary(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserPic",
                table: "AspNetUsers");
        }
    }
}
