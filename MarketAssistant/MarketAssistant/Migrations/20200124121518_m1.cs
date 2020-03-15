using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MarketAssistant.Migrations
{
    public partial class m1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Administrator",
                columns: table => new
                {
                    AdministratorID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Ime = table.Column<string>(nullable: true),
                    Prezime = table.Column<string>(nullable: true),
                    Mail = table.Column<string>(nullable: true),
                    Telefon = table.Column<string>(nullable: true),
                    Adresa = table.Column<string>(nullable: true),
                    DatumRodjenja = table.Column<DateTime>(nullable: false),
                    DatumZaposlenja = table.Column<DateTime>(nullable: false),
                    Staz = table.Column<int>(nullable: true),
                    Spol = table.Column<bool>(nullable: true),
                    Slika = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Administrator", x => x.AdministratorID);
                });

            migrationBuilder.CreateTable(
                name: "Brend",
                columns: table => new
                {
                    BrendID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Naziv = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brend", x => x.BrendID);
                });

            migrationBuilder.CreateTable(
                name: "Vrsta",
                columns: table => new
                {
                    VrstaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Naziv = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vrsta", x => x.VrstaID);
                });

            migrationBuilder.CreateTable(
                name: "KorisnickiRacun",
                columns: table => new
                {
                    korisnickiRacunID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    KorisnickoIme = table.Column<string>(nullable: true),
                    SifraSalt = table.Column<string>(nullable: true),
                    SifraHash = table.Column<string>(nullable: true),
                    Aktivan = table.Column<bool>(nullable: true),
                    Administrator_FK = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KorisnickiRacun", x => x.korisnickiRacunID);
                    table.ForeignKey(
                        name: "FK_KorisnickiRacun_Administrator_Administrator_FK",
                        column: x => x.Administrator_FK,
                        principalTable: "Administrator",
                        principalColumn: "AdministratorID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Market",
                columns: table => new
                {
                    MarketID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Naziv = table.Column<string>(nullable: true),
                    Adresa = table.Column<string>(nullable: true),
                    Administrator_FK = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Market", x => x.MarketID);
                    table.ForeignKey(
                        name: "FK_Market_Administrator_Administrator_FK",
                        column: x => x.Administrator_FK,
                        principalTable: "Administrator",
                        principalColumn: "AdministratorID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Proizvod",
                columns: table => new
                {
                    ProizvodID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Naziv = table.Column<string>(nullable: true),
                    DatumProizvodnje = table.Column<DateTime>(nullable: true),
                    TrajeDo = table.Column<DateTime>(nullable: true),
                    Sastav = table.Column<string>(nullable: true),
                    Opis = table.Column<string>(nullable: true),
                    Slika = table.Column<byte[]>(nullable: true),
                    Brend_FK = table.Column<int>(nullable: true),
                    Vrsta_FK = table.Column<int>(nullable: true),
                    Administrator_FK = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proizvod", x => x.ProizvodID);
                    table.ForeignKey(
                        name: "FK_Proizvod_Administrator_Administrator_FK",
                        column: x => x.Administrator_FK,
                        principalTable: "Administrator",
                        principalColumn: "AdministratorID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Proizvod_Brend_Brend_FK",
                        column: x => x.Brend_FK,
                        principalTable: "Brend",
                        principalColumn: "BrendID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Proizvod_Vrsta_Vrsta_FK",
                        column: x => x.Vrsta_FK,
                        principalTable: "Vrsta",
                        principalColumn: "VrstaID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "QR_Code",
                columns: table => new
                {
                    QR_CodeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Slika = table.Column<byte[]>(nullable: true),
                    Market_FK = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QR_Code", x => x.QR_CodeID);
                    table.ForeignKey(
                        name: "FK_QR_Code_Market_Market_FK",
                        column: x => x.Market_FK,
                        principalTable: "Market",
                        principalColumn: "MarketID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Sema",
                columns: table => new
                {
                    SemaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    sema = table.Column<string>(nullable: true),
                    Market_FK = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sema", x => x.SemaID);
                    table.ForeignKey(
                        name: "FK_Sema_Market_Market_FK",
                        column: x => x.Market_FK,
                        principalTable: "Market",
                        principalColumn: "MarketID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "market_proizvod",
                columns: table => new
                {
                    mpID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NaStanju = table.Column<int>(nullable: true),
                    DatumDobavljanja = table.Column<DateTime>(nullable: true),
                    Rasprodano = table.Column<bool>(nullable: true),
                    Market_FK = table.Column<int>(nullable: true),
                    Proizvod_FK = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_market_proizvod", x => x.mpID);
                    table.ForeignKey(
                        name: "FK_market_proizvod_Market_Market_FK",
                        column: x => x.Market_FK,
                        principalTable: "Market",
                        principalColumn: "MarketID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_market_proizvod_Proizvod_Proizvod_FK",
                        column: x => x.Proizvod_FK,
                        principalTable: "Proizvod",
                        principalColumn: "ProizvodID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_KorisnickiRacun_Administrator_FK",
                table: "KorisnickiRacun",
                column: "Administrator_FK");

            migrationBuilder.CreateIndex(
                name: "IX_Market_Administrator_FK",
                table: "Market",
                column: "Administrator_FK");

            migrationBuilder.CreateIndex(
                name: "IX_market_proizvod_Market_FK",
                table: "market_proizvod",
                column: "Market_FK");

            migrationBuilder.CreateIndex(
                name: "IX_market_proizvod_Proizvod_FK",
                table: "market_proizvod",
                column: "Proizvod_FK");

            migrationBuilder.CreateIndex(
                name: "IX_Proizvod_Administrator_FK",
                table: "Proizvod",
                column: "Administrator_FK");

            migrationBuilder.CreateIndex(
                name: "IX_Proizvod_Brend_FK",
                table: "Proizvod",
                column: "Brend_FK");

            migrationBuilder.CreateIndex(
                name: "IX_Proizvod_Vrsta_FK",
                table: "Proizvod",
                column: "Vrsta_FK");

            migrationBuilder.CreateIndex(
                name: "IX_QR_Code_Market_FK",
                table: "QR_Code",
                column: "Market_FK");

            migrationBuilder.CreateIndex(
                name: "IX_Sema_Market_FK",
                table: "Sema",
                column: "Market_FK");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KorisnickiRacun");

            migrationBuilder.DropTable(
                name: "market_proizvod");

            migrationBuilder.DropTable(
                name: "QR_Code");

            migrationBuilder.DropTable(
                name: "Sema");

            migrationBuilder.DropTable(
                name: "Proizvod");

            migrationBuilder.DropTable(
                name: "Market");

            migrationBuilder.DropTable(
                name: "Brend");

            migrationBuilder.DropTable(
                name: "Vrsta");

            migrationBuilder.DropTable(
                name: "Administrator");
        }
    }
}
