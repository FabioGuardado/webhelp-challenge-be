using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebhelpChallengeBackend.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class StandarizeDBAndAPILanguage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Empleados");

            migrationBuilder.DropTable(
                name: "Paises");

            migrationBuilder.DropTable(
                name: "TiposDeDocumento");

            migrationBuilder.RenameColumn(
                name: "Nombre",
                table: "SubAreas",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "Nombre",
                table: "Areas",
                newName: "Name");

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DocumentTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocumentTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastNames = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DocumentTypeId = table.Column<int>(type: "int", nullable: false),
                    DocumentNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HiringDate = table.Column<DateOnly>(type: "date", nullable: false),
                    CountryId = table.Column<int>(type: "int", nullable: false),
                    AreaId = table.Column<int>(type: "int", nullable: false),
                    SubAreaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employees_Areas_AreaId",
                        column: x => x.AreaId,
                        principalTable: "Areas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Employees_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Employees_DocumentTypes_DocumentTypeId",
                        column: x => x.DocumentTypeId,
                        principalTable: "DocumentTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Employees_SubAreas_SubAreaId",
                        column: x => x.SubAreaId,
                        principalTable: "SubAreas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Canadá" },
                    { 2, "Estados Unidos" },
                    { 3, "México" },
                    { 4, "Guatemala" },
                    { 5, "Belice" },
                    { 6, "El Salvador" },
                    { 7, "Honduras" },
                    { 8, "Nicaragua" },
                    { 9, "Costa Rica" },
                    { 10, "Panamá" }
                });

            migrationBuilder.InsertData(
                table: "DocumentTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "DUI" },
                    { 2, "Pasaporte" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "AreaId", "CountryId", "DocumentNumber", "DocumentTypeId", "FirstName", "HiringDate", "LastNames", "SubAreaId" },
                values: new object[,]
                {
                    { 1, 5, 6, "062094829", 1, "Fabio Ernesto", new DateOnly(2024, 1, 7), "Guardado Gil", 11 },
                    { 2, 5, 6, "062359236", 1, "Kevin Armando", new DateOnly(2024, 1, 7), "Grande Chávez", 10 },
                    { 3, 4, 6, "123658522", 1, "Kimberly Aronet", new DateOnly(2024, 1, 7), "Vásquez Rodriguez", 9 },
                    { 4, 1, 7, "0623598456", 2, "Nelson Alberto", new DateOnly(2024, 1, 7), "Serrano López", 1 },
                    { 5, 1, 6, "555141659", 1, "Mónica Alejandra", new DateOnly(2024, 1, 7), "Reyes Ramos", 2 },
                    { 6, 1, 3, "654658987", 2, "Alejandro Andrés", new DateOnly(2024, 1, 7), "Nuila Santos", 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_AreaId",
                table: "Employees",
                column: "AreaId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_CountryId",
                table: "Employees",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_DocumentTypeId",
                table: "Employees",
                column: "DocumentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_SubAreaId",
                table: "Employees",
                column: "SubAreaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "DocumentTypes");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "SubAreas",
                newName: "Nombre");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Areas",
                newName: "Nombre");

            migrationBuilder.CreateTable(
                name: "Paises",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paises", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TiposDeDocumento",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposDeDocumento", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Empleados",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AreaId = table.Column<int>(type: "int", nullable: false),
                    PaisId = table.Column<int>(type: "int", nullable: false),
                    SubAreaId = table.Column<int>(type: "int", nullable: false),
                    TipoDeDocumentoId = table.Column<int>(type: "int", nullable: false),
                    Apellidos = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaDeContratacion = table.Column<DateOnly>(type: "date", nullable: false),
                    Nombres = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumeroDeDocumento = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empleados", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Empleados_Areas_AreaId",
                        column: x => x.AreaId,
                        principalTable: "Areas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Empleados_Paises_PaisId",
                        column: x => x.PaisId,
                        principalTable: "Paises",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Empleados_SubAreas_SubAreaId",
                        column: x => x.SubAreaId,
                        principalTable: "SubAreas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Empleados_TiposDeDocumento_TipoDeDocumentoId",
                        column: x => x.TipoDeDocumentoId,
                        principalTable: "TiposDeDocumento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Paises",
                columns: new[] { "Id", "Nombre" },
                values: new object[,]
                {
                    { 1, "Canadá" },
                    { 2, "Estados Unidos" },
                    { 3, "México" },
                    { 4, "Guatemala" },
                    { 5, "Belice" },
                    { 6, "El Salvador" },
                    { 7, "Honduras" },
                    { 8, "Nicaragua" },
                    { 9, "Costa Rica" },
                    { 10, "Panamá" }
                });

            migrationBuilder.InsertData(
                table: "TiposDeDocumento",
                columns: new[] { "Id", "Nombre" },
                values: new object[,]
                {
                    { 1, "DUI" },
                    { 2, "Pasaporte" }
                });

            migrationBuilder.InsertData(
                table: "Empleados",
                columns: new[] { "Id", "Apellidos", "AreaId", "FechaDeContratacion", "Nombres", "NumeroDeDocumento", "PaisId", "SubAreaId", "TipoDeDocumentoId" },
                values: new object[,]
                {
                    { 1, "Guardado Gil", 5, new DateOnly(2024, 1, 6), "Fabio Ernesto", "062094829", 6, 11, 1 },
                    { 2, "Grande Chávez", 5, new DateOnly(2024, 1, 6), "Kevin Armando", "062359236", 6, 10, 1 },
                    { 3, "Vásquez Rodriguez", 4, new DateOnly(2024, 1, 6), "Kimberly Aronet", "123658522", 6, 9, 1 },
                    { 4, "Serrano López", 1, new DateOnly(2024, 1, 6), "Nelson Alberto", "0623598456", 7, 1, 2 },
                    { 5, "Reyes Ramos", 1, new DateOnly(2024, 1, 6), "Mónica Alejandra", "555141659", 6, 2, 1 },
                    { 6, "Nuila Santos", 1, new DateOnly(2024, 1, 6), "Alejandro Andrés", "654658987", 3, 2, 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Empleados_AreaId",
                table: "Empleados",
                column: "AreaId");

            migrationBuilder.CreateIndex(
                name: "IX_Empleados_PaisId",
                table: "Empleados",
                column: "PaisId");

            migrationBuilder.CreateIndex(
                name: "IX_Empleados_SubAreaId",
                table: "Empleados",
                column: "SubAreaId");

            migrationBuilder.CreateIndex(
                name: "IX_Empleados_TipoDeDocumentoId",
                table: "Empleados",
                column: "TipoDeDocumentoId");
        }
    }
}
