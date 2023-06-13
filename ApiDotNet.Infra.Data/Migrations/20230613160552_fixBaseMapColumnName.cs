using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiDotNet.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class fixBaseMapColumnName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                table: "usuario",
                newName: "updatedat");

            migrationBuilder.RenameColumn(
                name: "IsDeleted",
                table: "usuario",
                newName: "isdeleted");

            migrationBuilder.RenameColumn(
                name: "DeletedAt",
                table: "usuario",
                newName: "deletedat");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "usuario",
                newName: "createdat");

            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                table: "produto",
                newName: "updatedat");

            migrationBuilder.RenameColumn(
                name: "IsDeleted",
                table: "produto",
                newName: "isdeleted");

            migrationBuilder.RenameColumn(
                name: "DeletedAt",
                table: "produto",
                newName: "deletedat");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "produto",
                newName: "createdat");

            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                table: "pessoa",
                newName: "updatedat");

            migrationBuilder.RenameColumn(
                name: "IsDeleted",
                table: "pessoa",
                newName: "isdeleted");

            migrationBuilder.RenameColumn(
                name: "DeletedAt",
                table: "pessoa",
                newName: "deletedat");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "pessoa",
                newName: "createdat");

            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                table: "permissaousuario",
                newName: "updatedat");

            migrationBuilder.RenameColumn(
                name: "IsDeleted",
                table: "permissaousuario",
                newName: "isdeleted");

            migrationBuilder.RenameColumn(
                name: "DeletedAt",
                table: "permissaousuario",
                newName: "deletedat");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "permissaousuario",
                newName: "createdat");

            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                table: "permissao",
                newName: "updatedat");

            migrationBuilder.RenameColumn(
                name: "IsDeleted",
                table: "permissao",
                newName: "isdeleted");

            migrationBuilder.RenameColumn(
                name: "DeletedAt",
                table: "permissao",
                newName: "deletedat");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "permissao",
                newName: "createdat");

            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                table: "compra",
                newName: "updatedat");

            migrationBuilder.RenameColumn(
                name: "IsDeleted",
                table: "compra",
                newName: "isdeleted");

            migrationBuilder.RenameColumn(
                name: "DeletedAt",
                table: "compra",
                newName: "deletedat");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "compra",
                newName: "createdat");

            migrationBuilder.AlterColumn<DateTime>(
                name: "updatedat",
                table: "usuario",
                type: "timestamp with time zone",
                nullable: true,
                defaultValue: new DateTime(2023, 6, 13, 16, 5, 52, 700, DateTimeKind.Utc).AddTicks(224),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 6, 12, 23, 27, 42, 182, DateTimeKind.Utc).AddTicks(1270));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdat",
                table: "usuario",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 13, 16, 5, 52, 699, DateTimeKind.Utc).AddTicks(9848),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 6, 12, 23, 27, 42, 182, DateTimeKind.Utc).AddTicks(862));

            migrationBuilder.AlterColumn<DateTime>(
                name: "updatedat",
                table: "produto",
                type: "timestamp with time zone",
                nullable: true,
                defaultValue: new DateTime(2023, 6, 13, 16, 5, 52, 698, DateTimeKind.Utc).AddTicks(9797),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 6, 12, 23, 27, 42, 181, DateTimeKind.Utc).AddTicks(2874));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdat",
                table: "produto",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 13, 16, 5, 52, 698, DateTimeKind.Utc).AddTicks(9310),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 6, 12, 23, 27, 42, 181, DateTimeKind.Utc).AddTicks(2532));

            migrationBuilder.AlterColumn<DateTime>(
                name: "updatedat",
                table: "pessoa",
                type: "timestamp with time zone",
                nullable: true,
                defaultValue: new DateTime(2023, 6, 13, 16, 5, 52, 697, DateTimeKind.Utc).AddTicks(2750),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 6, 12, 23, 27, 42, 179, DateTimeKind.Utc).AddTicks(7386));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdat",
                table: "pessoa",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 13, 16, 5, 52, 697, DateTimeKind.Utc).AddTicks(2211),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 6, 12, 23, 27, 42, 179, DateTimeKind.Utc).AddTicks(6804));

            migrationBuilder.AlterColumn<DateTime>(
                name: "updatedat",
                table: "permissaousuario",
                type: "timestamp with time zone",
                nullable: true,
                defaultValue: new DateTime(2023, 6, 13, 16, 5, 52, 702, DateTimeKind.Utc).AddTicks(2866),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 6, 12, 23, 27, 42, 183, DateTimeKind.Utc).AddTicks(5878));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdat",
                table: "permissaousuario",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 13, 16, 5, 52, 702, DateTimeKind.Utc).AddTicks(2220),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 6, 12, 23, 27, 42, 183, DateTimeKind.Utc).AddTicks(5438));

            migrationBuilder.AlterColumn<DateTime>(
                name: "updatedat",
                table: "permissao",
                type: "timestamp with time zone",
                nullable: true,
                defaultValue: new DateTime(2023, 6, 13, 16, 5, 52, 696, DateTimeKind.Utc).AddTicks(7707),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 6, 12, 23, 27, 42, 179, DateTimeKind.Utc).AddTicks(2642));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdat",
                table: "permissao",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 13, 16, 5, 52, 696, DateTimeKind.Utc).AddTicks(7231),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 6, 12, 23, 27, 42, 179, DateTimeKind.Utc).AddTicks(2237));

            migrationBuilder.AlterColumn<DateTime>(
                name: "updatedat",
                table: "compra",
                type: "timestamp with time zone",
                nullable: true,
                defaultValue: new DateTime(2023, 6, 13, 16, 5, 52, 699, DateTimeKind.Utc).AddTicks(4397),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 6, 12, 23, 27, 42, 181, DateTimeKind.Utc).AddTicks(6971));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdat",
                table: "compra",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 13, 16, 5, 52, 699, DateTimeKind.Utc).AddTicks(3869),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 6, 12, 23, 27, 42, 181, DateTimeKind.Utc).AddTicks(6535));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "updatedat",
                table: "usuario",
                newName: "UpdatedAt");

            migrationBuilder.RenameColumn(
                name: "isdeleted",
                table: "usuario",
                newName: "IsDeleted");

            migrationBuilder.RenameColumn(
                name: "deletedat",
                table: "usuario",
                newName: "DeletedAt");

            migrationBuilder.RenameColumn(
                name: "createdat",
                table: "usuario",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "updatedat",
                table: "produto",
                newName: "UpdatedAt");

            migrationBuilder.RenameColumn(
                name: "isdeleted",
                table: "produto",
                newName: "IsDeleted");

            migrationBuilder.RenameColumn(
                name: "deletedat",
                table: "produto",
                newName: "DeletedAt");

            migrationBuilder.RenameColumn(
                name: "createdat",
                table: "produto",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "updatedat",
                table: "pessoa",
                newName: "UpdatedAt");

            migrationBuilder.RenameColumn(
                name: "isdeleted",
                table: "pessoa",
                newName: "IsDeleted");

            migrationBuilder.RenameColumn(
                name: "deletedat",
                table: "pessoa",
                newName: "DeletedAt");

            migrationBuilder.RenameColumn(
                name: "createdat",
                table: "pessoa",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "updatedat",
                table: "permissaousuario",
                newName: "UpdatedAt");

            migrationBuilder.RenameColumn(
                name: "isdeleted",
                table: "permissaousuario",
                newName: "IsDeleted");

            migrationBuilder.RenameColumn(
                name: "deletedat",
                table: "permissaousuario",
                newName: "DeletedAt");

            migrationBuilder.RenameColumn(
                name: "createdat",
                table: "permissaousuario",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "updatedat",
                table: "permissao",
                newName: "UpdatedAt");

            migrationBuilder.RenameColumn(
                name: "isdeleted",
                table: "permissao",
                newName: "IsDeleted");

            migrationBuilder.RenameColumn(
                name: "deletedat",
                table: "permissao",
                newName: "DeletedAt");

            migrationBuilder.RenameColumn(
                name: "createdat",
                table: "permissao",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "updatedat",
                table: "compra",
                newName: "UpdatedAt");

            migrationBuilder.RenameColumn(
                name: "isdeleted",
                table: "compra",
                newName: "IsDeleted");

            migrationBuilder.RenameColumn(
                name: "deletedat",
                table: "compra",
                newName: "DeletedAt");

            migrationBuilder.RenameColumn(
                name: "createdat",
                table: "compra",
                newName: "CreatedAt");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "usuario",
                type: "timestamp with time zone",
                nullable: true,
                defaultValue: new DateTime(2023, 6, 12, 23, 27, 42, 182, DateTimeKind.Utc).AddTicks(1270),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 6, 13, 16, 5, 52, 700, DateTimeKind.Utc).AddTicks(224));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "usuario",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 12, 23, 27, 42, 182, DateTimeKind.Utc).AddTicks(862),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 6, 13, 16, 5, 52, 699, DateTimeKind.Utc).AddTicks(9848));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "produto",
                type: "timestamp with time zone",
                nullable: true,
                defaultValue: new DateTime(2023, 6, 12, 23, 27, 42, 181, DateTimeKind.Utc).AddTicks(2874),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 6, 13, 16, 5, 52, 698, DateTimeKind.Utc).AddTicks(9797));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "produto",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 12, 23, 27, 42, 181, DateTimeKind.Utc).AddTicks(2532),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 6, 13, 16, 5, 52, 698, DateTimeKind.Utc).AddTicks(9310));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "pessoa",
                type: "timestamp with time zone",
                nullable: true,
                defaultValue: new DateTime(2023, 6, 12, 23, 27, 42, 179, DateTimeKind.Utc).AddTicks(7386),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 6, 13, 16, 5, 52, 697, DateTimeKind.Utc).AddTicks(2750));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "pessoa",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 12, 23, 27, 42, 179, DateTimeKind.Utc).AddTicks(6804),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 6, 13, 16, 5, 52, 697, DateTimeKind.Utc).AddTicks(2211));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "permissaousuario",
                type: "timestamp with time zone",
                nullable: true,
                defaultValue: new DateTime(2023, 6, 12, 23, 27, 42, 183, DateTimeKind.Utc).AddTicks(5878),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 6, 13, 16, 5, 52, 702, DateTimeKind.Utc).AddTicks(2866));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "permissaousuario",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 12, 23, 27, 42, 183, DateTimeKind.Utc).AddTicks(5438),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 6, 13, 16, 5, 52, 702, DateTimeKind.Utc).AddTicks(2220));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "permissao",
                type: "timestamp with time zone",
                nullable: true,
                defaultValue: new DateTime(2023, 6, 12, 23, 27, 42, 179, DateTimeKind.Utc).AddTicks(2642),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 6, 13, 16, 5, 52, 696, DateTimeKind.Utc).AddTicks(7707));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "permissao",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 12, 23, 27, 42, 179, DateTimeKind.Utc).AddTicks(2237),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 6, 13, 16, 5, 52, 696, DateTimeKind.Utc).AddTicks(7231));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "compra",
                type: "timestamp with time zone",
                nullable: true,
                defaultValue: new DateTime(2023, 6, 12, 23, 27, 42, 181, DateTimeKind.Utc).AddTicks(6971),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 6, 13, 16, 5, 52, 699, DateTimeKind.Utc).AddTicks(4397));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "compra",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 12, 23, 27, 42, 181, DateTimeKind.Utc).AddTicks(6535),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 6, 13, 16, 5, 52, 699, DateTimeKind.Utc).AddTicks(3869));
        }
    }
}
