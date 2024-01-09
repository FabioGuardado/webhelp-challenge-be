using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebhelpChallengeBackend.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class ChangesOnPaisAreaSubAreaRelations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.AddColumn<int>(
                name: "AreaId",
                table: "SubAreas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CountryId",
                table: "Areas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                column: "CountryId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                column: "CountryId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CountryId", "Name" },
                values: new object[] { 1, "Informática" });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CountryId", "Name" },
                values: new object[] { 2, "Finanzas" });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CountryId", "Name" },
                values: new object[] { 2, "Talento Humano" });

            migrationBuilder.InsertData(
                table: "Areas",
                columns: new[] { "Id", "CountryId", "Name" },
                values: new object[,]
                {
                    { 6, 2, "Operaciones" },
                    { 7, 3, "Finanzas" },
                    { 8, 3, "Mercadeo" }
                });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Guatemala");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "El Salvador");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Costa Rica");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AreaId", "CountryId", "DocumentTypeId", "HiringDate", "SubAreaId" },
                values: new object[] { 3, 1, 2, new DateOnly(2024, 1, 8), 14 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CountryId", "HiringDate", "SubAreaId" },
                values: new object[] { 2, new DateOnly(2024, 1, 8), 7 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CountryId", "HiringDate", "SubAreaId" },
                values: new object[] { 2, new DateOnly(2024, 1, 8), 3 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AreaId", "CountryId", "HiringDate", "SubAreaId" },
                values: new object[] { 8, 3, new DateOnly(2024, 1, 8), 9 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AreaId", "CountryId", "HiringDate", "SubAreaId" },
                values: new object[] { 6, 2, new DateOnly(2024, 1, 8), 13 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CountryId", "HiringDate" },
                values: new object[] { 1, new DateOnly(2024, 1, 8) });

            migrationBuilder.UpdateData(
                table: "SubAreas",
                keyColumn: "Id",
                keyValue: 1,
                column: "AreaId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "SubAreas",
                keyColumn: "Id",
                keyValue: 2,
                column: "AreaId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "SubAreas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AreaId", "Name" },
                values: new object[] { 4, "Financiamiento" });

            migrationBuilder.UpdateData(
                table: "SubAreas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AreaId", "Name" },
                values: new object[] { 7, "Auditoría" });

            migrationBuilder.UpdateData(
                table: "SubAreas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AreaId", "Name" },
                values: new object[] { 2, "Contrataciones" });

            migrationBuilder.UpdateData(
                table: "SubAreas",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AreaId", "Name" },
                values: new object[] { 2, "Capacitación y Desarrollo" });

            migrationBuilder.UpdateData(
                table: "SubAreas",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AreaId", "Name" },
                values: new object[] { 5, "Contrataciones" });

            migrationBuilder.UpdateData(
                table: "SubAreas",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AreaId", "Name" },
                values: new object[] { 5, "Capacitación y Desarrollo" });

            migrationBuilder.UpdateData(
                table: "SubAreas",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AreaId", "Name" },
                values: new object[] { 8, "Ventas" });

            migrationBuilder.UpdateData(
                table: "SubAreas",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AreaId", "Name" },
                values: new object[] { 8, "Publicidad" });

            migrationBuilder.UpdateData(
                table: "SubAreas",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AreaId", "Name" },
                values: new object[] { 6, "Gestión de Proveedores" });

            migrationBuilder.UpdateData(
                table: "SubAreas",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AreaId", "Name" },
                values: new object[] { 6, "Inventario" });

            migrationBuilder.InsertData(
                table: "SubAreas",
                columns: new[] { "Id", "AreaId", "Name" },
                values: new object[,]
                {
                    { 14, 3, "Soporte Técnico" },
                    { 15, 3, "Desarrollo de Software y Bases de Datos" },
                    { 16, 3, "Redes e Infraestructura" },
                    { 13, 6, "Planificación" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_SubAreas_AreaId",
                table: "SubAreas",
                column: "AreaId");

            migrationBuilder.CreateIndex(
                name: "IX_Areas_CountryId",
                table: "Areas",
                column: "CountryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Areas_Countries_CountryId",
                table: "Areas",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SubAreas_Areas_AreaId",
                table: "SubAreas",
                column: "AreaId",
                principalTable: "Areas",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Areas_Countries_CountryId",
                table: "Areas");

            migrationBuilder.DropForeignKey(
                name: "FK_SubAreas_Areas_AreaId",
                table: "SubAreas");

            migrationBuilder.DropIndex(
                name: "IX_SubAreas_AreaId",
                table: "SubAreas");

            migrationBuilder.DropIndex(
                name: "IX_Areas_CountryId",
                table: "Areas");

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "SubAreas",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "SubAreas",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "SubAreas",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "SubAreas",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DropColumn(
                name: "AreaId",
                table: "SubAreas");

            migrationBuilder.DropColumn(
                name: "CountryId",
                table: "Areas");

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Mercadeo");

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Operaciones");

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "Informática");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Canadá");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Estados Unidos");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "México");

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 4, "Guatemala" },
                    { 5, "Belice" },
                    { 6, "El Salvador" },
                    { 7, "Honduras" },
                    { 8, "Nicaragua" },
                    { 9, "Costa Rica" },
                    { 10, "Panamá" }
                });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AreaId", "CountryId", "DocumentTypeId", "HiringDate", "SubAreaId" },
                values: new object[] { 5, 6, 1, new DateOnly(2024, 1, 7), 11 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CountryId", "HiringDate", "SubAreaId" },
                values: new object[] { 6, new DateOnly(2024, 1, 7), 10 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CountryId", "HiringDate", "SubAreaId" },
                values: new object[] { 6, new DateOnly(2024, 1, 7), 9 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AreaId", "CountryId", "HiringDate", "SubAreaId" },
                values: new object[] { 1, 7, new DateOnly(2024, 1, 7), 1 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AreaId", "CountryId", "HiringDate", "SubAreaId" },
                values: new object[] { 1, 6, new DateOnly(2024, 1, 7), 2 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CountryId", "HiringDate" },
                values: new object[] { 3, new DateOnly(2024, 1, 7) });

            migrationBuilder.UpdateData(
                table: "SubAreas",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Contrataciones");

            migrationBuilder.UpdateData(
                table: "SubAreas",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Capacitación y Desarrollo");

            migrationBuilder.UpdateData(
                table: "SubAreas",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "Ventas");

            migrationBuilder.UpdateData(
                table: "SubAreas",
                keyColumn: "Id",
                keyValue: 6,
                column: "Name",
                value: "Publicidad");

            migrationBuilder.UpdateData(
                table: "SubAreas",
                keyColumn: "Id",
                keyValue: 7,
                column: "Name",
                value: "Gestión de Proveedores");

            migrationBuilder.UpdateData(
                table: "SubAreas",
                keyColumn: "Id",
                keyValue: 8,
                column: "Name",
                value: "Inventario");

            migrationBuilder.UpdateData(
                table: "SubAreas",
                keyColumn: "Id",
                keyValue: 9,
                column: "Name",
                value: "Planificación");

            migrationBuilder.UpdateData(
                table: "SubAreas",
                keyColumn: "Id",
                keyValue: 10,
                column: "Name",
                value: "Soporte Técnico");

            migrationBuilder.UpdateData(
                table: "SubAreas",
                keyColumn: "Id",
                keyValue: 11,
                column: "Name",
                value: "Desarrollo de Software y Bases de Datos");

            migrationBuilder.UpdateData(
                table: "SubAreas",
                keyColumn: "Id",
                keyValue: 12,
                column: "Name",
                value: "Redes e Infraestructura");
        }
    }
}
