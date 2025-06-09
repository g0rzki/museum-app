using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace museum_app.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "exhibitions",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    title = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    description = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    startdate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    enddate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_exhibitions", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ticketorders",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    purchasedate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_ticketorders", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tickettypes",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    price = table.Column<decimal>(type: "numeric", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_tickettypes", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ticketitems",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ticketorderid = table.Column<int>(type: "integer", nullable: false),
                    tickettypeid = table.Column<int>(type: "integer", nullable: false),
                    exhibitionid = table.Column<int>(type: "integer", nullable: false),
                    quantity = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_ticketitems", x => x.id);
                    table.ForeignKey(
                        name: "fk_ticketitems_exhibitions_exhibitionid",
                        column: x => x.exhibitionid,
                        principalTable: "exhibitions",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_ticketitems_ticketorders_ticketorderid",
                        column: x => x.ticketorderid,
                        principalTable: "ticketorders",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_ticketitems_tickettypes_tickettypeid",
                        column: x => x.tickettypeid,
                        principalTable: "tickettypes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "ix_ticketitems_exhibitionid",
                table: "ticketitems",
                column: "exhibitionid");

            migrationBuilder.CreateIndex(
                name: "ix_ticketitems_ticketorderid",
                table: "ticketitems",
                column: "ticketorderid");

            migrationBuilder.CreateIndex(
                name: "ix_ticketitems_tickettypeid",
                table: "ticketitems",
                column: "tickettypeid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ticketitems");

            migrationBuilder.DropTable(
                name: "exhibitions");

            migrationBuilder.DropTable(
                name: "ticketorders");

            migrationBuilder.DropTable(
                name: "tickettypes");
        }
    }
}
