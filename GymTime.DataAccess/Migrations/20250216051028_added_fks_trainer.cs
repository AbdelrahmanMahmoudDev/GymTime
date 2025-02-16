using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GymTime.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class added_fks_trainer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Trainers_Managers_ManagerId",
                table: "Trainers");

            migrationBuilder.AlterColumn<int>(
                name: "ManagerId",
                table: "Trainers",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Trainers_Managers_ManagerId",
                table: "Trainers",
                column: "ManagerId",
                principalTable: "Managers",
                principalColumn: "ManagerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Trainers_Managers_ManagerId",
                table: "Trainers");

            migrationBuilder.AlterColumn<int>(
                name: "ManagerId",
                table: "Trainers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Trainers_Managers_ManagerId",
                table: "Trainers",
                column: "ManagerId",
                principalTable: "Managers",
                principalColumn: "ManagerId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
