using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SoundBeats.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class CountriesValues : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Country",
                columns: new[] { "Id", "ISO2", "ISO3", "NameEn", "NameEs" },
                values: new object[,]
                {
                    { 1, "AD", "AND", " ", "Andorra" },
                    { 2, "AE", "ARE", " ", "Emiratos Árabes Unidos" },
                    { 3, "AF", "AFG", " ", "Afganistán" },
                    { 4, "AG", "ATG", " ", "Antigua y Barbuda" },
                    { 5, "AI", "AIA", " ", "Anguila" },
                    { 6, "AL", "ALB", " ", "Albania" },
                    { 7, "AL", "ALB", " ", "Albania" },
                    { 8, "AM", "ARM", " ", "Armenia" },
                    { 9, "AN", "ANT", " ", "Antillas Holandesas" },
                    { 10, "AO", "AGO", " ", "Angola" },
                    { 11, "AQ", "ATA", " ", "Antártida" },
                    { 12, "AR", "ARG", " ", "Argentina" },
                    { 13, "AS", "ASM", " ", "Samoa Americana" },
                    { 14, "AT", "AUT", " ", "Austria" },
                    { 15, "AU", "AUS", " ", "Australia" },
                    { 16, "AW", "ABW", " ", "Aruba" },
                    { 17, "AX", "ALA", " ", "Islas Aland" },
                    { 18, "AZ", "AZE", " ", "Azerbaiyán" },
                    { 19, "BA", "BIH", " ", "Bosnia y Herzegovina" },
                    { 20, "BB", "BRB", " ", "Barbados" },
                    { 21, "BD", "BGD", " ", "Bangladesh" },
                    { 22, "BE", "BEL", " ", "Bélgica" },
                    { 23, "BF", "BFA", " ", "Burkina Faso" },
                    { 24, "BG", "BGR", " ", "Bulgaria" },
                    { 25, "BH", "BHR", " ", "Bahrein" },
                    { 26, "BI", "BDI", " ", "Burundi" },
                    { 27, "BJ", "BEN", " ", "Benín" },
                    { 28, "BM", "BMU", " ", "Bermudas" },
                    { 29, "BN", "BRN", " ", "Brunei" },
                    { 30, "BO", "BOL", " ", "Bolivia" },
                    { 31, "BR", "BRA", " ", "Brasil" },
                    { 32, "BS", "BHS", " ", "Bahamas" },
                    { 33, "BT", "BTN", " ", "Bután" },
                    { 34, "BV", "BVT", " ", "Isla Bouvet" },
                    { 35, "BW", "BWA", " ", "Botswana" },
                    { 36, "BY", "BLR", " ", "Bielorusia" },
                    { 37, "BZ", "BLZ", " ", "Belice" },
                    { 38, "CA", "CAN", " ", "Canadá" },
                    { 39, "CC", "CCK", " ", "Islas Cocos" },
                    { 40, "CD", "COD", " ", "Republica Democrática del Congo" },
                    { 41, "CF", "CAF", " ", "República Centrofricana" },
                    { 42, "CG", "COG", " ", "República del Congo" },
                    { 43, "CH", "CHE", " ", "Suiza" },
                    { 44, "CI", "CIV", " ", "Costa de Marfil" },
                    { 45, "CK", "COK", " ", "Islas Cook" },
                    { 46, "CL", "CHL", " ", "Chile" },
                    { 47, "CM", "CMR", " ", "Camerún" },
                    { 48, "CN", "CHN", " ", "China" },
                    { 49, "CO", "COL", " ", "Colombia" },
                    { 50, "CR", "CRI", " ", "Costa Rica" },
                    { 51, "CU", "CUB", " ", "Cuba" },
                    { 52, "CV", "CPV", " ", "Cabo Verde" },
                    { 53, "CX", "CXR", " ", "Isla de Navidad" },
                    { 54, "CY", "CYP", " ", "Chipre" },
                    { 55, "CZ", "CZE", " ", "República Checa" },
                    { 56, "DE", "DEU", " ", "Alemania" },
                    { 57, "DJ", "DJI", " ", "Yibuti" },
                    { 58, "DK", "DNK", " ", "Dinamarca" },
                    { 59, "DM", "DMA", " ", "Dominica" },
                    { 60, "DO", "DOM", " ", "República Dominicana" },
                    { 61, "DZ", "DZA", " ", "Argelia" },
                    { 62, "EC", "ECU", " ", "Ecuador" },
                    { 63, "EE", "EST", " ", "Estonia" },
                    { 64, "EG", "EGY", " ", "Egipto" },
                    { 65, "EH", "ESH", " ", "Sahara Occidental" },
                    { 66, "ER", "ERI", " ", "Eritrea" },
                    { 67, "ES", "ESP", " ", "España" },
                    { 68, "ET", "ETH", " ", "Etiopía" },
                    { 69, "FI", "FIN", " ", "Finlandia" },
                    { 70, "FJ", "FJI", " ", "Fiji" },
                    { 71, "FK", "FLK", " ", "Islas Malvinas" },
                    { 72, "FM", "FSM", " ", "Micronesia" },
                    { 73, "FO", "FRO", " ", "Islas Faroe" },
                    { 74, "FR", "FRA", " ", "Francia" },
                    { 75, "GA", "GAB", " ", "Gabón" },
                    { 76, "GB", "GBR", " ", "Reino Unido" },
                    { 77, "GD", "GRD", " ", "Granada" },
                    { 78, "GE", "GEO", " ", "Georgia" },
                    { 79, "GF", "GUF", " ", "Guayana Francesa" },
                    { 80, "GG", "GGY", " ", "Guernsey" },
                    { 81, "GH", "GHA", " ", "Ghana" },
                    { 82, "GI", "GIB", " ", "Gibraltar" },
                    { 83, "GL", "GRL", " ", "Groenlandia" },
                    { 84, "GM", "GMB", " ", "Gambia" },
                    { 85, "GN", "GIN", " ", "Guinea" },
                    { 86, "GP", "GLP", " ", "Guadalupe" },
                    { 87, "GQ", "GNQ", " ", "Guinea Ecuatorial" },
                    { 88, "GR", "GRC", " ", "Grecia" },
                    { 89, "GS", "SGS", " ", "Georgia del Sur y las islas Sandwich" },
                    { 90, "GT", "GTM", " ", "Guatemala" },
                    { 91, "GU", "GUM", " ", "Guam" },
                    { 92, "GW", "GNB", " ", "Guinea-Bissau" },
                    { 93, "GY", "GUY", " ", "Guyana" },
                    { 94, "HK", "HKG", " ", "Hong Kong" },
                    { 95, "HM", "HMD", " ", "Islas Heard y McDonald" },
                    { 96, "HN", "HND", " ", "Honduras" },
                    { 97, "HR", "HRV", " ", "Croacia" },
                    { 98, "HT", "HTI", " ", "Haití" },
                    { 99, "HU", "HUN", " ", "Hungría" },
                    { 100, "ID", "IDN", " ", "Indonesia" },
                    { 101, "IE", "IRL", " ", "Irlanda" },
                    { 102, "IL", "ISR", " ", "Israel" },
                    { 103, "IM", "IMN", " ", "Isla de Man" },
                    { 104, "IN", "IND", " ", "India" },
                    { 105, "IO", "IOT", " ", "Terrirorio Británico del Océano Índico" },
                    { 106, "IQ", "IRQ", " ", "Irak" },
                    { 107, "IR", "IRN", " ", "Irán" },
                    { 108, "IS", "ISL", " ", "Islandia" },
                    { 109, "IT", "ITA", " ", "Italia" },
                    { 110, "JE", "JEY", " ", "Jersey" },
                    { 111, "JM", "JAM", " ", "Jamaica" },
                    { 112, "JO", "JOR", " ", "Jordania" },
                    { 113, "JP", "JPN", " ", "Japón" },
                    { 114, "KE", "KEN", " ", "Kenia" },
                    { 115, "KG", "KGZ", " ", "Kirguistán" },
                    { 116, "KH", "KHM", " ", "Camboya" },
                    { 117, "KI", "KIR", " ", "Kiribati" },
                    { 118, "KM", "COM", " ", "Comoras" },
                    { 119, "KN", "KNA", " ", "San Cristóbal y Nieves" },
                    { 120, "KP", "PRK", " ", "República Democrática de Corea" },
                    { 121, "KR", "KOR", " ", "República de Corea" },
                    { 122, "KW", "KWT", " ", "Kuwait" },
                    { 123, "KY", "CYM", " ", "Islas Caimán" },
                    { 124, "KZ", "KAZ", " ", "Kasajistán" },
                    { 125, "LA", "LAO", " ", "Laos" },
                    { 126, "LB", "LBN", " ", "Líbano" },
                    { 127, "LC", "LCA", " ", "Santa Lucía" },
                    { 128, "LI", "LIE", " ", "Liechtenstein" },
                    { 129, "LK", "LKA", " ", "Sri Lanka" },
                    { 130, "LR", "LBR", " ", "Liberia" },
                    { 131, "LS", "LSO", " ", "Lesotho" },
                    { 132, "LT", "LTU", " ", "Lituana" },
                    { 133, "LU", "LUX", " ", "Luxembur " },
                    { 134, "LV", "LVA", " ", "Letonia" },
                    { 135, "LY", "LBY", " ", "Libia" },
                    { 136, "MA", "MAR", " ", "Marruecos" },
                    { 137, "MC", "MCO", " ", "Mónaco" },
                    { 138, "MD", "MDA", " ", "Moldavia" },
                    { 139, "ME", "MNE", " ", "Montenegro" },
                    { 140, "MG", "MDG", " ", "Madagascar" },
                    { 141, "MH", "MHL", " ", "Islas Marschall" },
                    { 142, "MK", "MKD", " ", "Macedonia" },
                    { 143, "ML", "MLI", " ", "Malí" },
                    { 144, "MM", "MMR", " ", "Myanmar" },
                    { 145, "MN", "MNG", " ", "Mon lia" },
                    { 146, "MO", "MAC", " ", "Macao" },
                    { 147, "MP", "MNP", " ", "Islas Marianas del Norte" },
                    { 148, "MQ", "MTQ", " ", "Martinica" },
                    { 149, "MR", "MRT", " ", "Mauritania" },
                    { 150, "MS", "MSR", " ", "Montserrat" },
                    { 151, "MT", "MLT", " ", "Malta" },
                    { 152, "MU", "MUS", " ", "Mauricio" },
                    { 153, "MV", "MDV", " ", "Maldivas" },
                    { 154, "MW", "MWI", " ", "Malawi" },
                    { 155, "MX", "MEX", " ", "México" },
                    { 156, "MY", "MYS", " ", "Malasia" },
                    { 157, "MZ", "MOZ", " ", "Mozambique" },
                    { 158, "NA", "NAM", " ", "Namibia" },
                    { 159, "NC", "NCL", " ", "Nueva Caledonia" },
                    { 160, "NE", "NER", " ", "Níger" },
                    { 161, "NF", "NFK", " ", "Isla Norfolk" },
                    { 162, "NG", "NGA", " ", "Nigeria" },
                    { 163, "NI", "NIC", " ", "Nicaragua" },
                    { 164, "NL", "NLD", " ", "Países Bajos" },
                    { 165, "NO", "NOR", " ", "Noruega" },
                    { 166, "NP", "NPL", " ", "Nepal" },
                    { 167, "NR", "NRU", " ", "Naurú" },
                    { 168, "NU", "NIU", " ", "Niue" },
                    { 169, "NZ", "NZL", " ", "Nueva Zelanda" },
                    { 170, "OM", "OMN", " ", "Omán" },
                    { 171, "PA", "PAN", " ", "Panamá" },
                    { 172, "PE", "PER", " ", "Perú" },
                    { 173, "PF", "PYF", " ", "Polinesia Francesa" },
                    { 174, "PG", "PNG", " ", "Papúa-Nueva Guinea" },
                    { 175, "PH", "PHL", " ", "Filipinas" },
                    { 176, "PK", "PAK", " ", "Pakistán" },
                    { 177, "PL", "POL", " ", "Polonia" },
                    { 178, "PM", "SPM", " ", "San Pedro y Miquelón" },
                    { 179, "PN", "PCN", " ", "Pitcairn" },
                    { 180, "PR", "PRI", " ", "Puerto Rico" },
                    { 181, "PS", "PSE", " ", "Estado de Palestina" },
                    { 182, "PT", "PRT", " ", "Portugal" },
                    { 183, "PW", "PLW", " ", "Palau" },
                    { 184, "PY", "PRY", " ", "Paraguay" },
                    { 185, "QA", "QAT", " ", "Qatar" },
                    { 186, "RE", "REU", " ", "Reunión" },
                    { 187, "RO", "ROM", " ", "Rumania" },
                    { 188, "RS", "SRB", " ", "Serbia" },
                    { 189, "RU", "RUS", " ", "Rusia" },
                    { 190, "RW", "RWA", " ", "Ruanda" },
                    { 191, "SA", "SAU", " ", "Arabia Saudita" },
                    { 192, "SB", "SLB", " ", "Islas Salomón" },
                    { 193, "SC", "SYC", " ", "Seychelles" },
                    { 194, "SD", "SDN", " ", "Sudán" },
                    { 195, "SE", "SWE", " ", "Suecia" },
                    { 196, "SG", "SGP", " ", "Singapur" },
                    { 197, "SH", "SHN", " ", "Santa Helena" },
                    { 198, "SI", "SVN", " ", "Eslovenia" },
                    { 199, "SJ", "SJM", " ", "Svalbard y Jan Mayen" },
                    { 200, "SK", "SVK", " ", "Eslovaquia" },
                    { 201, "SL", "SLE", " ", "Sierra Leona" },
                    { 202, "SM", "SMR", " ", "San Marino" },
                    { 203, "SN", "SEN", " ", "Senegal" },
                    { 204, "SO", "SOM", " ", "Somalia" },
                    { 205, "SR", "SUR", " ", "Surinam" },
                    { 206, "ST", "STP", " ", "Santo Tomé y Príncipe" },
                    { 207, "SV", "SLV", " ", "El Salvador" },
                    { 208, "SY", "SYR", " ", "Siria" },
                    { 209, "SZ", "SWZ", " ", "Swazilandia" },
                    { 210, "TC", "TCA", " ", "Isla Turks y Caicos" },
                    { 211, "TD", "TCD", " ", "Chad" },
                    { 212, "TF", "ATF", " ", "Territorios Franceses del Sur" },
                    { 213, "TG", "TGO", " ", "Togo" },
                    { 214, "TH", "THA", " ", "Tailandia" },
                    { 215, "TJ", "TJK", " ", "Tajikistán" },
                    { 216, "TK", "TKL", " ", "Tokelau" },
                    { 217, "TL", "TKM", " ", "Timor Este" },
                    { 218, "TM", "TUN", " ", "Turkmenistán" },
                    { 219, "TN", "TON", " ", "Tunicia" },
                    { 220, "TO", "TMP", " ", "Tonga" },
                    { 221, "TR", "TUR", " ", "Turquía" },
                    { 222, "TT", "TTO", " ", "Trinidad y Toba " },
                    { 223, "TV", "TUV", " ", "Tuvalú" },
                    { 224, "TW", "TWN", " ", "Taiwán" },
                    { 225, "TZ", "TZA", " ", "Tanzania" },
                    { 226, "UA", "UKR", " ", "Ucrania" },
                    { 227, "UG", "UGA", " ", "Uganda" },
                    { 228, "UM", "UMI", " ", "Islas Menores de Estados Unidos" },
                    { 229, "US", "USA", " ", "Estados Unidos" },
                    { 230, "UY", "URY", " ", "Uruguay" },
                    { 231, "UZ", "UZB", " ", "Uzbekistán" },
                    { 232, "VA", "VAT", " ", "El Vaticano" },
                    { 233, "VC", "VCT", " ", "San Vicente y Granadinas" },
                    { 234, "VE", "VEN", " ", "Venezuela" },
                    { 235, "VG", "VGB", " ", "Islas Vírgenes Británicas" },
                    { 236, "VI", "VIR", " ", "Islas Vírgenes de Estados Unidos" },
                    { 237, "VN", "VNM", " ", "Vietnam" },
                    { 238, "VU", "VUT", " ", "Vanuatu" },
                    { 239, "WF", "WLF", " ", "Wallis y Futuna" },
                    { 240, "WS", "WSM", " ", "Samoa" },
                    { 241, "YE", "YEM", " ", "Yemén" },
                    { 242, "YT", "MYT", " ", "Mayotte" },
                    { 243, "ZA", "ZAF", " ", "Suráfrica" },
                    { 244, "ZM", "ZMB", " ", "Zambia" },
                    { 245, "ZW", "ZWE", " ", "Zimbabwe" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 245);
        }
    }
}
