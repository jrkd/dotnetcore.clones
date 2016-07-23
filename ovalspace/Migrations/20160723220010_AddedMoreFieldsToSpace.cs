using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ovalspace.Migrations
{
    public partial class AddedMoreFieldsToSpace : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Spaces",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageURL",
                table: "Spaces",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Spaces",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Spaces");

            migrationBuilder.DropColumn(
                name: "ImageURL",
                table: "Spaces");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Spaces");
        }
    }
}
