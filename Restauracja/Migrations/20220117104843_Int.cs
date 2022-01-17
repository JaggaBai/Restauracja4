using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Restauracja.Migrations
{
    public partial class Int : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Klienci",
                columns: table => new
                {
                    KlientId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumerStolika = table.Column<int>(type: "int", nullable: false),
                    Ocena = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Klienci", x => x.KlientId);
                });

            migrationBuilder.CreateTable(
                name: "PozycjeZamowienia",
                columns: table => new
                {
                    IdPozycji = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nazwa = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Cena = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PozycjeZamowienia", x => x.IdPozycji);
                });

            migrationBuilder.CreateTable(
                name: "Zamownia",
                columns: table => new
                {
                    IdZamownie = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KlientId = table.Column<int>(type: "int", nullable: false),
                    DataZamowienia = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zamownia", x => x.IdZamownie);
                    table.ForeignKey(
                        name: "FK_Zamownia_Klienci_KlientId",
                        column: x => x.KlientId,
                        principalTable: "Klienci",
                        principalColumn: "KlientId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Zamowienie_PozycjaZamowienia",
                columns: table => new
                {
                    IdZamownie = table.Column<int>(type: "int", nullable: false),
                    IdPozycji = table.Column<int>(type: "int", nullable: false),
                    Liczba = table.Column<int>(type: "int", nullable: false),
                    Cena = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zamowienie_PozycjaZamowienia", x => new { x.IdZamownie, x.IdPozycji });
                    table.ForeignKey(
                        name: "FK_Zamowienie_PozycjaZamowienia_PozycjeZamowienia_IdPozycji",
                        column: x => x.IdPozycji,
                        principalTable: "PozycjeZamowienia",
                        principalColumn: "IdPozycji",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Zamowienie_PozycjaZamowienia_Zamownia_IdZamownie",
                        column: x => x.IdZamownie,
                        principalTable: "Zamownia",
                        principalColumn: "IdZamownie",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Zamowienie_PozycjaZamowienia_IdPozycji",
                table: "Zamowienie_PozycjaZamowienia",
                column: "IdPozycji");

            migrationBuilder.CreateIndex(
                name: "IX_Zamownia_KlientId",
                table: "Zamownia",
                column: "KlientId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Zamowienie_PozycjaZamowienia");

            migrationBuilder.DropTable(
                name: "PozycjeZamowienia");

            migrationBuilder.DropTable(
                name: "Zamownia");

            migrationBuilder.DropTable(
                name: "Klienci");
        }
    }
}
