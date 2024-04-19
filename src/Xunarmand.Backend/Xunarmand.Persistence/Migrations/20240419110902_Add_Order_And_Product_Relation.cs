using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Xunarmand.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Add_Order_And_Product_Relation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddForeignKey(
                name: "FK_Products_Orders_Id",
                table: "Products",
                column: "Id",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Orders_Id",
                table: "Products");
        }
    }
}
