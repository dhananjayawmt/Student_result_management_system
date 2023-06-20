﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Login_Screen.Migrations
{
    /// <inheritdoc />
    public partial class addresult : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ModuleCode",
                table: "Results",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "StudentId",
                table: "Results",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "grade",
                table: "Results",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ModuleCode",
                table: "Results");

            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "Results");

            migrationBuilder.DropColumn(
                name: "grade",
                table: "Results");
        }
    }
}
