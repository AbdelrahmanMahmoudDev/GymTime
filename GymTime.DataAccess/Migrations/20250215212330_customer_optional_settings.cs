using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GymTime.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class customer_optional_settings : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_SubscriptionPackages_SubPackSubscriptionPackageId",
                table: "Customers");

            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Trainers_TrainerId",
                table: "Customers");

            migrationBuilder.AlterColumn<int>(
                name: "TrainerId",
                table: "Customers",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "SubPackSubscriptionPackageId",
                table: "Customers",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_SubscriptionPackages_SubPackSubscriptionPackageId",
                table: "Customers",
                column: "SubPackSubscriptionPackageId",
                principalTable: "SubscriptionPackages",
                principalColumn: "SubscriptionPackageId");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Trainers_TrainerId",
                table: "Customers",
                column: "TrainerId",
                principalTable: "Trainers",
                principalColumn: "TrainerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_SubscriptionPackages_SubPackSubscriptionPackageId",
                table: "Customers");

            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Trainers_TrainerId",
                table: "Customers");

            migrationBuilder.AlterColumn<int>(
                name: "TrainerId",
                table: "Customers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SubPackSubscriptionPackageId",
                table: "Customers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_SubscriptionPackages_SubPackSubscriptionPackageId",
                table: "Customers",
                column: "SubPackSubscriptionPackageId",
                principalTable: "SubscriptionPackages",
                principalColumn: "SubscriptionPackageId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Trainers_TrainerId",
                table: "Customers",
                column: "TrainerId",
                principalTable: "Trainers",
                principalColumn: "TrainerId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
