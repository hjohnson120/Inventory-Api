using Microsoft.EntityFrameworkCore.Migrations;

namespace inventory_api.Migrations
{
    public partial class AddedFK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Location",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "LocationId",
                table: "Item",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Item_LocationId",
                table: "Item",
                column: "LocationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Item_Location_LocationId",
                table: "Item",
                column: "LocationId",
                principalTable: "Location",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Item_Location_LocationId",
                table: "Item");

            migrationBuilder.DropIndex(
                name: "IX_Item_LocationId",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "LocationId",
                table: "Item");

            migrationBuilder.AlterColumn<int>(
                name: "PhoneNumber",
                table: "Location",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
