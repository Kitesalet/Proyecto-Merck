using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProyectoMerck.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class fixer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Consultations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ConsultationReason = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Clinic = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateAndtime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Consultations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Provinces",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProvinceName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Provinces", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Clinics",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClinicName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Latitude = table.Column<double>(type: "float", nullable: false),
                    Length = table.Column<double>(type: "float", nullable: false),
                    ProvinceName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProvinceId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clinics", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Clinics_Provinces_ProvinceId",
                        column: x => x.ProvinceId,
                        principalTable: "Provinces",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProvinceId = table.Column<int>(type: "int", nullable: true),
                    LocationName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Locations_Provinces_ProvinceId",
                        column: x => x.ProvinceId,
                        principalTable: "Provinces",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Consultations",
                columns: new[] { "Id", "Clinic", "ConsultationReason", "DateAndtime", "Url" },
                values: new object[,]
                {
                    { 1, "CEGYR Medicina Reproductiva", "Edad y Reserva Ovarica", new DateTime(2024, 2, 22, 17, 0, 28, 457, DateTimeKind.Local).AddTicks(3644), "https://ejemplo.com/" },
                    { 2, "Centro de Investigaciones en Medicina Reproductiva", "Evaluación de Reserva Ovárica", new DateTime(2024, 2, 22, 17, 0, 28, 457, DateTimeKind.Local).AddTicks(3736), "https://ejemplo2.com/" }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "CountryName" },
                values: new object[] { 1, "Argentina" });

            migrationBuilder.InsertData(
                table: "Provinces",
                columns: new[] { "Id", "ProvinceName" },
                values: new object[,]
                {
                    { 1, "Buenos Aires" },
                    { 2, "Buenos Aires-GBA" },
                    { 3, "Capital Federal" },
                    { 4, "Catamarca" },
                    { 5, "Chaco" },
                    { 6, "Chubut" },
                    { 7, "Córdoba" },
                    { 8, "Corrientes" },
                    { 9, "Entre Ríos" },
                    { 10, "Formosa" },
                    { 11, "Jujuy" },
                    { 12, "La Pampa" },
                    { 13, "La Rioja" },
                    { 14, "Mendoza" },
                    { 15, "Misiones" },
                    { 16, "Neuquén" },
                    { 17, "Río Negro" },
                    { 18, "Salta" },
                    { 19, "San Juan" },
                    { 20, "San Luis" },
                    { 21, "Santa Cruz" },
                    { 22, "Santa Fe" },
                    { 23, "Santiago del Estero" },
                    { 24, "Tierra del Fuego" },
                    { 25, "Tucumán" }
                });

            migrationBuilder.InsertData(
                table: "Clinics",
                columns: new[] { "Id", "Address", "ClinicName", "Latitude", "Length", "ProvinceId", "ProvinceName" },
                values: new object[,]
                {
                    { 1, "Viamonte 1432", "CEGYR Medicina Reproductiva", -34.6007441, -58.387174100000003, 3, "Capital Federal" },
                    { 2, "Humboldt 2263", "CER", -34.5806714, -58.4302438, 4, "Catamarca" },
                    { 3, "Av.Forest 1166", "Centro de Investigaciones en Medicina Reproductiva", -34.578822199999998, -58.460096700000001, 4, "Chaco" },
                    { 4, "Alvear 514", "Centro Gens", -34.7197709, -58.256260400000002, 5, "Chubut" },
                    { 5, "Marcelo T. de Alvear 2084", "Halitus Instituto Médico", -34.597464299999999, -58.3971746, 3, "Capital Federal" },
                    { 6, "Bulnes 1104", "Maternity Bank", -34.598300000000002, -58.417900000000003, 3, "Capital Federal" },
                    { 7, "Av. del Libertador 5962", "WeFIV", -34.557099999999998, -58.447600000000001, 3, "Capital Federal" }
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "LocationName", "ProvinceId" },
                values: new object[,]
                {
                    { 1, "25 de Mayo", 1 },
                    { 2, "3 de febrero", 1 },
                    { 3, "A. Alsina", 1 },
                    { 4, "A. Gonzáles Cháves", 1 },
                    { 5, "Aguas Verdes", 1 },
                    { 6, "Alberti", 1 },
                    { 7, "Arrecifes", 1 },
                    { 8, "Ayacucho", 1 },
                    { 9, "Azul", 1 },
                    { 10, "Bahía Blanca", 1 },
                    { 11, "Balcarce", 1 },
                    { 12, "Baradero", 1 },
                    { 13, "Benito Juárez", 1 },
                    { 14, "Berisso", 1 },
                    { 15, "Bolívar", 1 },
                    { 16, "Bragado", 1 },
                    { 17, "Brandsen", 1 },
                    { 18, "Campana", 1 },
                    { 19, "Cañuelas", 1 },
                    { 20, "Capilla del Señor", 1 },
                    { 21, "Capitán Sarmiento", 1 },
                    { 22, "Carapachay", 1 },
                    { 23, "Carhue", 1 },
                    { 24, "Cariló", 1 },
                    { 25, "Carlos Casares", 1 },
                    { 26, "Carlos Tejedor", 1 },
                    { 27, "Carmen de Areco", 1 },
                    { 28, "Carmen de Patagones", 1 },
                    { 29, "Castelli", 1 },
                    { 30, "Chacabuco", 1 },
                    { 31, "Chascomús", 1 },
                    { 32, "Chivilcoy", 1 },
                    { 33, "Colón", 1 },
                    { 34, "Coronel Dorrego", 1 },
                    { 35, "Coronel Pringles", 1 },
                    { 36, "Coronel Rosales", 1 },
                    { 37, "Coronel Suarez", 1 },
                    { 38, "Costa Azul", 1 },
                    { 39, "Costa Chica", 1 },
                    { 40, "Costa del Este", 1 },
                    { 41, "Costa Esmeralda", 1 },
                    { 42, "Daireaux", 1 },
                    { 43, "Darregueira", 1 },
                    { 44, "Del Viso", 1 },
                    { 45, "Dolores", 1 },
                    { 46, "Don Torcuato", 1 },
                    { 47, "Ensenada", 1 },
                    { 48, "Escobar", 1 },
                    { 49, "Exaltación de la Cruz", 1 },
                    { 50, "Florentino Ameghino", 1 },
                    { 282, "Agronomía", 3 },
                    { 283, "Almagro", 3 },
                    { 284, "Balvanera", 3 },
                    { 285, "Barracas", 3 },
                    { 286, "Belgrano", 3 },
                    { 287, "Boca", 3 },
                    { 288, "Boedo", 3 },
                    { 289, "Caballito", 3 },
                    { 290, "Chacarita", 3 },
                    { 291, "Coghlan", 3 },
                    { 292, "Colegiales", 3 },
                    { 293, "Constitución", 3 },
                    { 294, "Flores", 3 },
                    { 295, "Floresta", 3 },
                    { 296, "La Paternal", 3 },
                    { 297, "Liniers", 3 },
                    { 298, "Mataderos", 3 },
                    { 299, "Monserrat", 3 },
                    { 300, "Monte Castro", 3 },
                    { 301, "Nueva Pompeya", 3 },
                    { 302, "Núñez", 3 },
                    { 303, "Palermo", 3 },
                    { 304, "Parque Avellaneda", 3 },
                    { 305, "Parque Chacabuco", 3 },
                    { 306, "Parque Chas", 3 },
                    { 307, "Parque Patricios", 3 },
                    { 308, "Puerto Madero", 3 },
                    { 309, "Recoleta", 3 },
                    { 310, "Retiro", 3 },
                    { 311, "Saavedra", 3 },
                    { 312, "San Cristóbal", 3 },
                    { 313, "San Nicolás", 3 },
                    { 314, "San Telmo", 3 },
                    { 315, "Vélez Sársfield", 3 },
                    { 316, "Versalles", 3 },
                    { 317, "Villa Crespo", 3 },
                    { 318, "Villa del Parque", 3 },
                    { 319, "Villa Devoto", 3 },
                    { 320, "Villa Gral. Mitre", 3 },
                    { 321, "Villa Lugano", 3 },
                    { 322, "Villa Luro", 3 },
                    { 323, "Villa Ortúzar", 3 },
                    { 324, "Villa Pueyrredón", 3 },
                    { 325, "Villa Real", 3 },
                    { 326, "Villa Riachuelo", 3 },
                    { 327, "Villa Santa Rita", 3 },
                    { 328, "Villa Soldati", 3 },
                    { 329, "Villa Urquiza", 3 },
                    { 330, "Aconquija", 4 },
                    { 331, "Ancasti", 4 },
                    { 332, "Andalgalá", 4 },
                    { 333, "Antofagasta", 4 },
                    { 334, "Belén", 4 },
                    { 335, "Capayán", 4 },
                    { 336, "Capital", 4 },
                    { 337, "4", 4 },
                    { 338, "Corral Quemado", 4 },
                    { 339, "El Alto", 4 },
                    { 340, "El Rodeo", 4 },
                    { 341, "F.Mamerto Esquiú", 4 },
                    { 342, "Fiambalá", 4 },
                    { 343, "Hualfín", 4 },
                    { 344, "Huillapima", 4 },
                    { 345, "Icaño", 4 },
                    { 346, "La Puerta", 4 },
                    { 347, "Las Juntas", 4 },
                    { 348, "Londres", 4 },
                    { 381, "Col. Elisa", 5 },
                    { 382, "Col. Popular", 5 },
                    { 383, "Colonias Unidas", 5 },
                    { 384, "Concepción", 5 },
                    { 385, "Corzuela", 5 },
                    { 386, "Cote Lai", 5 },
                    { 387, "El Sauzalito", 5 },
                    { 388, "Enrique Urien", 5 },
                    { 389, "Fontana", 5 },
                    { 390, "Fte. Esperanza", 5 },
                    { 391, "Gancedo", 5 },
                    { 392, "Gral. Capdevila", 5 },
                    { 393, "Gral. Pinero", 5 },
                    { 394, "Gral. San Martín", 5 },
                    { 395, "Gral. Vedia", 5 },
                    { 396, "Hermoso Campo", 5 },
                    { 397, "I. del Cerrito", 5 },
                    { 398, "J.J. Castelli", 5 },
                    { 399, "La Clotilde", 5 },
                    { 400, "La Eduvigis", 5 },
                    { 401, "La Escondida", 5 },
                    { 402, "La Leonesa", 5 },
                    { 403, "La Tigra", 5 },
                    { 404, "La Verde", 5 },
                    { 453, "Dolavón", 6 },
                    { 454, "Dr. R. Rojas", 6 },
                    { 455, "El Hoyo", 6 },
                    { 456, "El Maitén", 6 },
                    { 457, "Epuyén", 6 },
                    { 458, "Esquel", 6 },
                    { 459, "Facundo", 6 },
                    { 460, "Gaimán", 6 },
                    { 461, "Gan Gan", 6 },
                    { 462, "Gastre", 6 },
                    { 463, "Gdor. Costa", 6 },
                    { 464, "Gualjaina", 6 },
                    { 465, "J. de San Martín", 6 },
                    { 466, "Lago Blanco", 6 },
                    { 467, "Lago Puelo", 6 },
                    { 468, "Lagunita Salada", 6 },
                    { 469, "Las Plumas", 6 },
                    { 470, "Los Altares", 6 },
                    { 504, "Arias", 7 },
                    { 505, "Arroyito", 7 },
                    { 506, "Arroyo Algodon", 7 },
                    { 507, "Arroyo Cabral", 7 },
                    { 508, "Arroyo Los Patos", 7 },
                    { 509, "Assunta", 7 },
                    { 510, "Atahona", 7 },
                    { 511, "Ausonia", 7 },
                    { 512, "Avellaneda", 7 },
                    { 513, "Ballesteros", 7 },
                    { 514, "Ballesteros Sud", 7 },
                    { 515, "Balnearia", 7 },
                    { 516, "Bañado de Soto", 7 },
                    { 517, "Bell Ville", 7 },
                    { 518, "Bengolea", 7 },
                    { 519, "Benjamin Gould", 7 },
                    { 520, "Berrotaran", 7 },
                    { 521, "Bialet Masse", 7 },
                    { 522, "Bouwer", 7 },
                    { 523, "Brinkmann", 7 },
                    { 524, "Buchardo", 7 },
                    { 525, "Bulnes", 7 },
                    { 526, "Cabalango", 7 },
                    { 527, "Calamuchita", 7 },
                    { 963, "Saladas", 8 },
                    { 964, "San Antonio", 8 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Clinics_ProvinceId",
                table: "Clinics",
                column: "ProvinceId");

            migrationBuilder.CreateIndex(
                name: "IX_Locations_ProvinceId",
                table: "Locations",
                column: "ProvinceId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Clinics");

            migrationBuilder.DropTable(
                name: "Consultations");

            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Provinces");
        }
    }
}
