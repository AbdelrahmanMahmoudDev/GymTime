using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GymTime.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class initial_migration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Managers",
                columns: table => new
                {
                    ManagerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Managers", x => x.ManagerId);
                });

            migrationBuilder.CreateTable(
                name: "SubscriptionPackages",
                columns: table => new
                {
                    SubscriptionPackageId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BasePrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DiscountPercent = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubscriptionPackages", x => x.SubscriptionPackageId);
                });

            migrationBuilder.CreateTable(
                name: "ManagerPasswords",
                columns: table => new
                {
                    ManagerPasswordId = table.Column<int>(type: "int", nullable: false),
                    ManagerUsername = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordSalt = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ManagerPasswords", x => x.ManagerPasswordId);
                    table.ForeignKey(
                        name: "FK_ManagerPasswords_Managers_ManagerPasswordId",
                        column: x => x.ManagerPasswordId,
                        principalTable: "Managers",
                        principalColumn: "ManagerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Trainers",
                columns: table => new
                {
                    TrainerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Salary = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    KPI = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ManagerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trainers", x => x.TrainerId);
                    table.ForeignKey(
                        name: "FK_Trainers_Managers_ManagerId",
                        column: x => x.ManagerId,
                        principalTable: "Managers",
                        principalColumn: "ManagerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrainerId = table.Column<int>(type: "int", nullable: false),
                    SubPackSubscriptionPackageId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerId);
                    table.ForeignKey(
                        name: "FK_Customers_SubscriptionPackages_SubPackSubscriptionPackageId",
                        column: x => x.SubPackSubscriptionPackageId,
                        principalTable: "SubscriptionPackages",
                        principalColumn: "SubscriptionPackageId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Customers_Trainers_TrainerId",
                        column: x => x.TrainerId,
                        principalTable: "Trainers",
                        principalColumn: "TrainerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TrainerPasswords",
                columns: table => new
                {
                    TrainerPasswordId = table.Column<int>(type: "int", nullable: false),
                    TrainerUsername = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordSalt = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainerPasswords", x => x.TrainerPasswordId);
                    table.ForeignKey(
                        name: "FK_TrainerPasswords_Trainers_TrainerPasswordId",
                        column: x => x.TrainerPasswordId,
                        principalTable: "Trainers",
                        principalColumn: "TrainerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CustomerPasswords",
                columns: table => new
                {
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    CustomerUsername = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordSalt = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerPasswords", x => x.CustomerId);
                    table.ForeignKey(
                        name: "FK_CustomerPasswords_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TrainingSchedules",
                columns: table => new
                {
                    TrainingScheduleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstDay = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SecondDay = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ThirdDay = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FourthDay = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TrainerId = table.Column<int>(type: "int", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainingSchedules", x => x.TrainingScheduleId);
                    table.ForeignKey(
                        name: "FK_TrainingSchedules_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "CustomerId");
                    table.ForeignKey(
                        name: "FK_TrainingSchedules_Trainers_TrainerId",
                        column: x => x.TrainerId,
                        principalTable: "Trainers",
                        principalColumn: "TrainerId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Customers_SubPackSubscriptionPackageId",
                table: "Customers",
                column: "SubPackSubscriptionPackageId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_TrainerId",
                table: "Customers",
                column: "TrainerId");

            migrationBuilder.CreateIndex(
                name: "IX_Trainers_ManagerId",
                table: "Trainers",
                column: "ManagerId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingSchedules_CustomerId",
                table: "TrainingSchedules",
                column: "CustomerId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TrainingSchedules_TrainerId",
                table: "TrainingSchedules",
                column: "TrainerId");
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

            migrationBuilder.DropTable(
                name: "TrainingSchedules");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "SubscriptionPackages");

            migrationBuilder.DropTable(
                name: "Trainers");

            migrationBuilder.DropTable(
                name: "Managers");
        }
    }
}
