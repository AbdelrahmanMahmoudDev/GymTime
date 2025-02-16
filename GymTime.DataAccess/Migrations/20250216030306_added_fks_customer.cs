using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GymTime.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class added_fks_customer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_SubscriptionPackages_SubPackSubscriptionPackageId",
                table: "Customers");

            migrationBuilder.DropIndex(
                name: "IX_Customers_SubPackSubscriptionPackageId",
                table: "Customers");

            migrationBuilder.RenameColumn(
                name: "SubPackSubscriptionPackageId",
                table: "Customers",
                newName: "TrainingScheduleId");

            migrationBuilder.AddColumn<int>(
                name: "CustomerPasswordId",
                table: "Customers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SubscriptionPackageId",
                table: "Customers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Customers_SubscriptionPackageId",
                table: "Customers",
                column: "SubscriptionPackageId");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_SubscriptionPackages_SubscriptionPackageId",
                table: "Customers",
                column: "SubscriptionPackageId",
                principalTable: "SubscriptionPackages",
                principalColumn: "SubscriptionPackageId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_SubscriptionPackages_SubscriptionPackageId",
                table: "Customers");

            migrationBuilder.DropIndex(
                name: "IX_Customers_SubscriptionPackageId",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "CustomerPasswordId",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "SubscriptionPackageId",
                table: "Customers");

            migrationBuilder.RenameColumn(
                name: "TrainingScheduleId",
                table: "Customers",
                newName: "SubPackSubscriptionPackageId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_SubPackSubscriptionPackageId",
                table: "Customers",
                column: "SubPackSubscriptionPackageId");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_SubscriptionPackages_SubPackSubscriptionPackageId",
                table: "Customers",
                column: "SubPackSubscriptionPackageId",
                principalTable: "SubscriptionPackages",
                principalColumn: "SubscriptionPackageId");
        }
    }
}
