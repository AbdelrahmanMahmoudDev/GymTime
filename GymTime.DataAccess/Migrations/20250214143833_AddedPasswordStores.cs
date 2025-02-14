using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GymTime.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddedPasswordStores : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CustomerPasswords",
                columns: table => new
                {
                    CustomerPasswordId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordSalt = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerPasswords", x => x.CustomerPasswordId);
                });

            migrationBuilder.CreateTable(
                name: "ManagerPasswords",
                columns: table => new
                {
                    ManagerPasswordId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordSalt = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ManagerPasswords", x => x.ManagerPasswordId);
                });

            migrationBuilder.CreateTable(
                name: "TrainerPasswords",
                columns: table => new
                {
                    TrainerPasswordId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordSalt = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainerPasswords", x => x.TrainerPasswordId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CustomerPasswords");

            migrationBuilder.DropTable(
                name: "ManagerPasswords");

            migrationBuilder.DropTable(
                name: "TrainerPasswords");
        }
    }
}
