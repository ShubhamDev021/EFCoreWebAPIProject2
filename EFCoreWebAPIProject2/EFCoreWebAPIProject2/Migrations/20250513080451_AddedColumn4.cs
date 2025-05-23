﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreWebAPIProject2.Migrations
{
    /// <inheritdoc />
    public partial class AddedColumn4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Column4",
                table: "Books",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Column4",
                table: "Books");
        }
    }
}
