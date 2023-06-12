using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiDotNet.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class baseEntities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "usuario",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 12, 23, 27, 42, 182, DateTimeKind.Utc).AddTicks(862));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "usuario",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "usuario",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "usuario",
                type: "timestamp with time zone",
                nullable: true,
                defaultValue: new DateTime(2023, 6, 12, 23, 27, 42, 182, DateTimeKind.Utc).AddTicks(1270));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "produto",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 12, 23, 27, 42, 181, DateTimeKind.Utc).AddTicks(2532));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "produto",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "produto",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "produto",
                type: "timestamp with time zone",
                nullable: true,
                defaultValue: new DateTime(2023, 6, 12, 23, 27, 42, 181, DateTimeKind.Utc).AddTicks(2874));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "pessoa",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 12, 23, 27, 42, 179, DateTimeKind.Utc).AddTicks(6804));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "pessoa",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "pessoa",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "pessoa",
                type: "timestamp with time zone",
                nullable: true,
                defaultValue: new DateTime(2023, 6, 12, 23, 27, 42, 179, DateTimeKind.Utc).AddTicks(7386));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "permissaousuario",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 12, 23, 27, 42, 183, DateTimeKind.Utc).AddTicks(5438));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "permissaousuario",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "permissaousuario",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "permissaousuario",
                type: "timestamp with time zone",
                nullable: true,
                defaultValue: new DateTime(2023, 6, 12, 23, 27, 42, 183, DateTimeKind.Utc).AddTicks(5878));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "permissao",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 12, 23, 27, 42, 179, DateTimeKind.Utc).AddTicks(2237));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "permissao",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "permissao",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "permissao",
                type: "timestamp with time zone",
                nullable: true,
                defaultValue: new DateTime(2023, 6, 12, 23, 27, 42, 179, DateTimeKind.Utc).AddTicks(2642));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "compra",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 12, 23, 27, 42, 181, DateTimeKind.Utc).AddTicks(6535));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "compra",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "compra",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "compra",
                type: "timestamp with time zone",
                nullable: true,
                defaultValue: new DateTime(2023, 6, 12, 23, 27, 42, 181, DateTimeKind.Utc).AddTicks(6971));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "usuario");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "usuario");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "usuario");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "usuario");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "produto");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "produto");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "produto");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "produto");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "pessoa");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "pessoa");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "pessoa");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "pessoa");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "permissaousuario");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "permissaousuario");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "permissaousuario");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "permissaousuario");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "permissao");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "permissao");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "permissao");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "permissao");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "compra");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "compra");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "compra");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "compra");
        }
    }
}
