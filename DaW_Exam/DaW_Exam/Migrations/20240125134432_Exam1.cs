using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DaW_Exam.Migrations
{
    /// <inheritdoc />
    public partial class Exam1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Autori",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Autori", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Edituri",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Judet = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AutorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Edituri", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Edituri_Autori_AutorId",
                        column: x => x.AutorId,
                        principalTable: "Autori",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Carti",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ISIN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EdituraId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carti", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Carti_Edituri_EdituraId",
                        column: x => x.EdituraId,
                        principalTable: "Edituri",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AutoriCartiRelations",
                columns: table => new
                {
                    CarteId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AutorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AutoriCartiRelations", x => new { x.AutorId, x.CarteId });
                    table.ForeignKey(
                        name: "FK_AutoriCartiRelations_Autori_AutorId",
                        column: x => x.AutorId,
                        principalTable: "Autori",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AutoriCartiRelations_Carti_CarteId",
                        column: x => x.CarteId,
                        principalTable: "Carti",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AutoriCartiRelations_CarteId",
                table: "AutoriCartiRelations",
                column: "CarteId");

            migrationBuilder.CreateIndex(
                name: "IX_Carti_EdituraId",
                table: "Carti",
                column: "EdituraId");

            migrationBuilder.CreateIndex(
                name: "IX_Edituri_AutorId",
                table: "Edituri",
                column: "AutorId",
                unique: true,
                filter: "[AutorId] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AutoriCartiRelations");

            migrationBuilder.DropTable(
                name: "Carti");

            migrationBuilder.DropTable(
                name: "Edituri");

            migrationBuilder.DropTable(
                name: "Autori");
        }
    }
}
