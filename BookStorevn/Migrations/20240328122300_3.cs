using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookStorevn.Migrations
{
    /// <inheritdoc />
    public partial class _3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetail_OrderMaster_OrderMasterId",
                table: "OrderDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetail_Stationeries_StationeryId",
                table: "OrderDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderMaster_Customer_CustomerId",
                table: "OrderMaster");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderMaster",
                table: "OrderMaster");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderDetail",
                table: "OrderDetail");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Customer",
                table: "Customer");

            migrationBuilder.RenameTable(
                name: "OrderMaster",
                newName: "OrderMasters");

            migrationBuilder.RenameTable(
                name: "OrderDetail",
                newName: "OrderDetails");

            migrationBuilder.RenameTable(
                name: "Customer",
                newName: "Customers");

            migrationBuilder.RenameIndex(
                name: "IX_OrderMaster_CustomerId",
                table: "OrderMasters",
                newName: "IX_OrderMasters_CustomerId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderDetail_StationeryId",
                table: "OrderDetails",
                newName: "IX_OrderDetails_StationeryId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderDetail_OrderMasterId",
                table: "OrderDetails",
                newName: "IX_OrderDetails_OrderMasterId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderMasters",
                table: "OrderMasters",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderDetails",
                table: "OrderDetails",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Customers",
                table: "Customers",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_OrderMasters_OrderMasterId",
                table: "OrderDetails",
                column: "OrderMasterId",
                principalTable: "OrderMasters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_Stationeries_StationeryId",
                table: "OrderDetails",
                column: "StationeryId",
                principalTable: "Stationeries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderMasters_Customers_CustomerId",
                table: "OrderMasters",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_OrderMasters_OrderMasterId",
                table: "OrderDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_Stationeries_StationeryId",
                table: "OrderDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderMasters_Customers_CustomerId",
                table: "OrderMasters");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderMasters",
                table: "OrderMasters");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderDetails",
                table: "OrderDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Customers",
                table: "Customers");

            migrationBuilder.RenameTable(
                name: "OrderMasters",
                newName: "OrderMaster");

            migrationBuilder.RenameTable(
                name: "OrderDetails",
                newName: "OrderDetail");

            migrationBuilder.RenameTable(
                name: "Customers",
                newName: "Customer");

            migrationBuilder.RenameIndex(
                name: "IX_OrderMasters_CustomerId",
                table: "OrderMaster",
                newName: "IX_OrderMaster_CustomerId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderDetails_StationeryId",
                table: "OrderDetail",
                newName: "IX_OrderDetail_StationeryId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderDetails_OrderMasterId",
                table: "OrderDetail",
                newName: "IX_OrderDetail_OrderMasterId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderMaster",
                table: "OrderMaster",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderDetail",
                table: "OrderDetail",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Customer",
                table: "Customer",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetail_OrderMaster_OrderMasterId",
                table: "OrderDetail",
                column: "OrderMasterId",
                principalTable: "OrderMaster",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetail_Stationeries_StationeryId",
                table: "OrderDetail",
                column: "StationeryId",
                principalTable: "Stationeries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderMaster_Customer_CustomerId",
                table: "OrderMaster",
                column: "CustomerId",
                principalTable: "Customer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
