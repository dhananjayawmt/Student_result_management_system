﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Login_Screen.Migrations
{
    /// <inheritdoc />
    public partial class Mala : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "password",
                table: "Teachers",
                newName: "TeacherPass");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TeacherPass",
                table: "Teachers",
                newName: "password");
        }
    }
}
