using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Projet_PFA.Migrations
{
    /// <inheritdoc />
    public partial class creation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Penalite",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Duree = table.Column<int>(type: "int", nullable: false),
                    Sanction = table.Column<float>(type: "real", nullable: false),
                    Unite = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Penalite", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Supplementaire",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Duree = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Prim = table.Column<float>(type: "real", nullable: false),
                    Unite = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Supplementaire", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserAuthentifier",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Login = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CIN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateNaissance = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Adress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RIB = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Salaire = table.Column<float>(type: "real", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    superviseurId = table.Column<int>(type: "int", nullable: true),
                    SuperviseurId = table.Column<int>(type: "int", nullable: true),
                    DirecteurId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAuthentifier", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserAuthentifier_UserAuthentifier_DirecteurId",
                        column: x => x.DirecteurId,
                        principalTable: "UserAuthentifier",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserAuthentifier_UserAuthentifier_superviseurId",
                        column: x => x.superviseurId,
                        principalTable: "UserAuthentifier",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Absence",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EmployerId = table.Column<int>(type: "int", nullable: false),
                    SuperviseurId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Absence", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Absence_UserAuthentifier_EmployerId",
                        column: x => x.EmployerId,
                        principalTable: "UserAuthentifier",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Absence_UserAuthentifier_SuperviseurId",
                        column: x => x.SuperviseurId,
                        principalTable: "UserAuthentifier",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HeuresSupp",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Duree = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Unitee = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmployerId = table.Column<int>(type: "int", nullable: false),
                    SuperviseurId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HeuresSupp", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HeuresSupp_UserAuthentifier_EmployerId",
                        column: x => x.EmployerId,
                        principalTable: "UserAuthentifier",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HeuresSupp_UserAuthentifier_SuperviseurId",
                        column: x => x.SuperviseurId,
                        principalTable: "UserAuthentifier",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Pointage",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HeureEntree = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HeureSortie = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EmployerId = table.Column<int>(type: "int", nullable: false),
                    SuperviseurId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pointage", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pointage_UserAuthentifier_EmployerId",
                        column: x => x.EmployerId,
                        principalTable: "UserAuthentifier",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pointage_UserAuthentifier_SuperviseurId",
                        column: x => x.SuperviseurId,
                        principalTable: "UserAuthentifier",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Retard",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Duree = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EmployerId = table.Column<int>(type: "int", nullable: false),
                    SuperviseurId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Retard", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Retard_UserAuthentifier_EmployerId",
                        column: x => x.EmployerId,
                        principalTable: "UserAuthentifier",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Retard_UserAuthentifier_SuperviseurId",
                        column: x => x.SuperviseurId,
                        principalTable: "UserAuthentifier",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Absence_EmployerId",
                table: "Absence",
                column: "EmployerId");

            migrationBuilder.CreateIndex(
                name: "IX_Absence_SuperviseurId",
                table: "Absence",
                column: "SuperviseurId");

            migrationBuilder.CreateIndex(
                name: "IX_HeuresSupp_EmployerId",
                table: "HeuresSupp",
                column: "EmployerId");

            migrationBuilder.CreateIndex(
                name: "IX_HeuresSupp_SuperviseurId",
                table: "HeuresSupp",
                column: "SuperviseurId");

            migrationBuilder.CreateIndex(
                name: "IX_Pointage_EmployerId",
                table: "Pointage",
                column: "EmployerId");

            migrationBuilder.CreateIndex(
                name: "IX_Pointage_SuperviseurId",
                table: "Pointage",
                column: "SuperviseurId");

            migrationBuilder.CreateIndex(
                name: "IX_Retard_EmployerId",
                table: "Retard",
                column: "EmployerId");

            migrationBuilder.CreateIndex(
                name: "IX_Retard_SuperviseurId",
                table: "Retard",
                column: "SuperviseurId");

            migrationBuilder.CreateIndex(
                name: "IX_UserAuthentifier_DirecteurId",
                table: "UserAuthentifier",
                column: "DirecteurId");

            migrationBuilder.CreateIndex(
                name: "IX_UserAuthentifier_superviseurId",
                table: "UserAuthentifier",
                column: "superviseurId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Absence");

            migrationBuilder.DropTable(
                name: "HeuresSupp");

            migrationBuilder.DropTable(
                name: "Penalite");

            migrationBuilder.DropTable(
                name: "Pointage");

            migrationBuilder.DropTable(
                name: "Retard");

            migrationBuilder.DropTable(
                name: "Supplementaire");

            migrationBuilder.DropTable(
                name: "UserAuthentifier");
        }
    }
}
