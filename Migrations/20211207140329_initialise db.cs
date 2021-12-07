using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VeiligProgrammerenBlog.Migrations
{
    public partial class initialisedb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Auteurs",
                columns: table => new
                {
                    AuteurID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Aanmelddatum = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Auteurs", x => x.AuteurID);
                });

            migrationBuilder.CreateTable(
                name: "Blogs",
                columns: table => new
                {
                    BlogId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AuteurId = table.Column<int>(type: "int", nullable: false),
                    Titel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Afbeelding = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Plaatsingsdatum = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LaatsteUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Inhoud = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Beeld = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blogs", x => x.BlogId);
                    table.ForeignKey(
                        name: "FK_Blogs_Auteurs_AuteurId",
                        column: x => x.AuteurId,
                        principalTable: "Auteurs",
                        principalColumn: "AuteurID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Commentaar",
                columns: table => new
                {
                    CommentaarID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GeplaatstDoor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CommentaarInhoud = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AantalRespects = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PlaatsingsDatum = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BlogId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BlogId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Commentaar", x => x.CommentaarID);
                    table.ForeignKey(
                        name: "FK_Commentaar_Blogs_BlogId1",
                        column: x => x.BlogId1,
                        principalTable: "Blogs",
                        principalColumn: "BlogId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_AuteurId",
                table: "Blogs",
                column: "AuteurId");

            migrationBuilder.CreateIndex(
                name: "IX_Commentaar_BlogId1",
                table: "Commentaar",
                column: "BlogId1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Commentaar");

            migrationBuilder.DropTable(
                name: "Blogs");

            migrationBuilder.DropTable(
                name: "Auteurs");
        }
    }
}
