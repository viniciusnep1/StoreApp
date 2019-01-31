using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class AddingBaseEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Products",
                table: "Products");

            migrationBuilder.RenameTable(
                name: "Products",
                newName: "BaseEntities");

            migrationBuilder.RenameIndex(
                name: "IX_Products_CategoryId",
                table: "BaseEntities",
                newName: "IX_BaseEntities_CategoryId");

            migrationBuilder.AddColumn<DateTime>(
                name: "AddedDate",
                table: "BaseEntities",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "Ativo",
                table: "BaseEntities",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "BaseEntities",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "BaseEntities",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Product_Name",
                table: "BaseEntities",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_BaseEntities",
                table: "BaseEntities",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BaseEntities_BaseEntities_CategoryId",
                table: "BaseEntities",
                column: "CategoryId",
                principalTable: "BaseEntities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BaseEntities_BaseEntities_CategoryId",
                table: "BaseEntities");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BaseEntities",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "AddedDate",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "Ativo",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "Product_Name",
                table: "BaseEntities");

            migrationBuilder.RenameTable(
                name: "BaseEntities",
                newName: "Products");

            migrationBuilder.RenameIndex(
                name: "IX_BaseEntities_CategoryId",
                table: "Products",
                newName: "IX_Products_CategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Products",
                table: "Products",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
