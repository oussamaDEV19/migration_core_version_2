using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CoreMigration.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "admin",
                columns: table => new
                {
                    id_admin = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    username = table.Column<string>(maxLength: 255, nullable: false),
                    mdp = table.Column<string>(maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_admin", x => x.id_admin);
                });

            migrationBuilder.CreateTable(
                name: "association",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_association", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "BDE",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nom = table.Column<string>(maxLength: 255, nullable: false),
                    prenom = table.Column<string>(maxLength: 255, nullable: false),
                    email = table.Column<string>(maxLength: 255, nullable: false),
                    password = table.Column<string>(maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BDE", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "filiere",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nom = table.Column<string>(maxLength: 255, nullable: false),
                    departement = table.Column<string>(maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_filiere", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Responsable",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nom = table.Column<string>(maxLength: 255, nullable: false),
                    prenom = table.Column<string>(maxLength: 255, nullable: false),
                    email = table.Column<string>(maxLength: 255, nullable: false),
                    password = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Responsable", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "membre_BDE",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nom = table.Column<string>(maxLength: 255, nullable: false),
                    prenom = table.Column<string>(maxLength: 255, nullable: false),
                    role = table.Column<string>(maxLength: 255, nullable: false),
                    picture = table.Column<string>(maxLength: 255, nullable: false),
                    bde_id = table.Column<int>(nullable: true),
                    BDEid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_membre_BDE", x => x.id);
                    table.ForeignKey(
                        name: "FK_membre_BDE_BDE_BDEid",
                        column: x => x.BDEid,
                        principalTable: "BDE",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "laureat",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nom = table.Column<string>(maxLength: 255, nullable: false),
                    prenom = table.Column<string>(maxLength: 255, nullable: false),
                    email = table.Column<string>(maxLength: 255, nullable: false),
                    password = table.Column<string>(maxLength: 255, nullable: false),
                    societe_actuelle = table.Column<string>(maxLength: 255, nullable: false),
                    salaire = table.Column<float>(nullable: false),
                    filiere = table.Column<int>(nullable: false),
                    age = table.Column<int>(nullable: false),
                    bio = table.Column<string>(type: "text", nullable: false),
                    state = table.Column<string>(maxLength: 255, nullable: false),
                    filiere1id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_laureat", x => x.id);
                    table.ForeignKey(
                        name: "FK_laureat_filiere_filiere1id",
                        column: x => x.filiere1id,
                        principalTable: "filiere",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "activite",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    titre = table.Column<string>(type: "text", nullable: false),
                    date = table.Column<DateTime>(type: "date", nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    state = table.Column<string>(maxLength: 255, nullable: false),
                    responsable = table.Column<int>(nullable: true),
                    piece_joint = table.Column<string>(maxLength: 255, nullable: false),
                    BDE = table.Column<int>(nullable: true),
                    BDE1id = table.Column<int>(nullable: true),
                    Responsable1id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_activite", x => x.id);
                    table.ForeignKey(
                        name: "FK_activite_BDE_BDE1id",
                        column: x => x.BDE1id,
                        principalTable: "BDE",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_activite_Responsable_Responsable1id",
                        column: x => x.Responsable1id,
                        principalTable: "Responsable",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "club",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    titre = table.Column<string>(type: "text", nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    date_creation = table.Column<DateTime>(type: "date", nullable: false),
                    logo = table.Column<string>(maxLength: 255, nullable: false),
                    id_respo = table.Column<int>(nullable: false),
                    Responsableid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_club", x => x.id);
                    table.ForeignKey(
                        name: "FK_club_Responsable_Responsableid",
                        column: x => x.Responsableid,
                        principalTable: "Responsable",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "gallerie",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    date = table.Column<DateTime>(type: "date", nullable: false),
                    path = table.Column<string>(maxLength: 255, nullable: false),
                    type = table.Column<string>(maxLength: 255, nullable: false),
                    id_activite = table.Column<int>(nullable: false),
                    activiteid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_gallerie", x => x.id);
                    table.ForeignKey(
                        name: "FK_gallerie_activite_activiteid",
                        column: x => x.activiteid,
                        principalTable: "activite",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_activite_BDE1id",
                table: "activite",
                column: "BDE1id");

            migrationBuilder.CreateIndex(
                name: "IX_activite_Responsable1id",
                table: "activite",
                column: "Responsable1id");

            migrationBuilder.CreateIndex(
                name: "IX_club_Responsableid",
                table: "club",
                column: "Responsableid");

            migrationBuilder.CreateIndex(
                name: "IX_gallerie_activiteid",
                table: "gallerie",
                column: "activiteid");

            migrationBuilder.CreateIndex(
                name: "IX_laureat_filiere1id",
                table: "laureat",
                column: "filiere1id");

            migrationBuilder.CreateIndex(
                name: "IX_membre_BDE_BDEid",
                table: "membre_BDE",
                column: "BDEid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "admin");

            migrationBuilder.DropTable(
                name: "association");

            migrationBuilder.DropTable(
                name: "club");

            migrationBuilder.DropTable(
                name: "gallerie");

            migrationBuilder.DropTable(
                name: "laureat");

            migrationBuilder.DropTable(
                name: "membre_BDE");

            migrationBuilder.DropTable(
                name: "activite");

            migrationBuilder.DropTable(
                name: "filiere");

            migrationBuilder.DropTable(
                name: "BDE");

            migrationBuilder.DropTable(
                name: "Responsable");
        }
    }
}
