using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApplicationManagementSystem.DataAccess.Migrations
{
    public partial class initial_migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ApplicationDocuments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DocumentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationDocuments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Applications",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Birthday = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdentityNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Reason = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValue: ""),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false, defaultValue: 1),
                    Response = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatorUserId = table.Column<int>(type: "int", nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifierUserId = table.Column<int>(type: "int", nullable: true),
                    DeletorUserId = table.Column<int>(type: "int", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Applications", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Documents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContentType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Documents", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Username = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Applications",
                columns: new[] { "Id", "Address", "Birthday", "CreationTime", "CreatorUserId", "DeletionTime", "DeletorUserId", "Email", "FirstName", "IdentityNumber", "IsDeleted", "LastModificationTime", "LastModifierUserId", "LastName", "Reason", "Response", "Status" },
                values: new object[,]
                {
                    { new Guid("04ad583c-104b-4d21-929b-48c0539e5987"), "123 Guernsey Street, Marenisco, Montana, 2971", new DateTime(1999, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 27, 15, 48, 31, 331, DateTimeKind.Local).AddTicks(504), null, null, null, "candaceburton@valreda.com", "Candace", "12345678922", false, null, null, "Burton", "Eiusmod labore voluptate tempor duis deserunt laborum minim nisi minim qui reprehenderit. Ut in in mollit do irure elit ullamco est. Incididunt minim ea fugiat aute enim ipsum eu cupidatat non occaecat aliquip. Occaecat mollit adipisicing occaecat qui id esse id exercitation.", "", 1 },
                    { new Guid("058b4c97-4188-4f2c-b700-2425ace63103"), "329 Howard Alley, Noblestown, Northern Mariana Islands, 8023", new DateTime(1962, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 27, 15, 48, 31, 331, DateTimeKind.Local).AddTicks(532), null, null, null, "valentinekerr@valreda.com", "Valentine", "12345678928", false, null, null, "Kerr", "Deserunt aute labore deserunt commodo. Commodo consectetur dolore laborum dolore anim officia mollit mollit amet. Duis anim voluptate non deserunt esse eu esse ad laboris. Occaecat mollit mollit veniam officia ullamco nisi amet. Tempor laboris veniam officia enim in aliquip qui irure labore aliqua. Nostrud anim do ea mollit enim exercitation laborum commodo consectetur laboris consequat. Anim consequat cillum exercitation laborum qui proident sunt nisi excepteur qui.", "", 1 },
                    { new Guid("0700e751-9c0a-457c-8f9b-68b9d6d1303c"), "457 Roosevelt Place, Tilleda, Florida, 5976", new DateTime(1963, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 27, 15, 48, 31, 331, DateTimeKind.Local).AddTicks(371), null, null, null, "erickacalderon@valreda.com", "Ericka", "12345678902", false, null, null, "Calderon", "Voluptate ut proident eiusmod ea quis velit ad ut proident nisi. Qui ex ea laboris do in ullamco eiusmod ullamco reprehenderit ea adipisicing anim nulla.", "", 1 },
                    { new Guid("0c6374a9-6226-4929-ac1d-81b574676303"), "818 Ruby Street, Garnet, Alaska, 1235", new DateTime(1981, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 27, 15, 48, 31, 331, DateTimeKind.Local).AddTicks(434), null, null, null, "caradurham@valreda.com", "Cara", "12345678910", false, null, null, "Durham", "Laborum laboris consectetur aliqua laboris non. In in deserunt ut qui voluptate eiusmod. Magna irure elit eu eiusmod veniam adipisicing.", "", 1 },
                    { new Guid("10945b81-c84e-454d-baed-08f72e452911"), "616 Louisa Street, Ona, Massachusetts, 2957", new DateTime(1998, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 27, 15, 48, 31, 331, DateTimeKind.Local).AddTicks(518), null, null, null, "josefacarpenter@valreda.com", "Josefa", "12345678925", false, null, null, "Carpenter", "Est laboris consectetur deserunt esse elit fugiat irure qui sint. Veniam minim exercitation non nisi proident eiusmod et excepteur. Deserunt cupidatat cillum duis officia quis quis proident. Id sunt non Lorem cillum ipsum id tempor aliquip amet fugiat nulla et sunt Lorem. Velit excepteur reprehenderit eu voluptate ex commodo irure consectetur ad id. Ipsum mollit ipsum in incididunt commodo. Commodo mollit do magna dolor.", "", 1 },
                    { new Guid("18ad013b-bf99-4898-80f2-3799d0d305e8"), "305 Schermerhorn Street, Boykin, Minnesota, 307", new DateTime(1999, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 27, 15, 48, 31, 331, DateTimeKind.Local).AddTicks(470), null, null, null, "puckettoneill@valreda.com", "Puckett", "12345678916", false, null, null, "Oneill", "Tempor commodo nulla voluptate cupidatat amet magna dolor laboris occaecat incididunt. Eu velit proident laborum elit reprehenderit enim mollit occaecat excepteur in ex eu. Incididunt anim elit consequat sunt cupidatat tempor aliquip nostrud occaecat nisi et adipisicing esse nulla.", "", 1 },
                    { new Guid("1a6a7160-71a9-4203-99f7-5b6b0f206e98"), "737 Provost Street, Odessa, Kentucky, 4490", new DateTime(1992, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 27, 15, 48, 31, 331, DateTimeKind.Local).AddTicks(439), null, null, null, "dawsonpratt@valreda.com", "Dawson", "12345678911", false, null, null, "Pratt", "Non Lorem exercitation est proident laborum sint est id amet officia eiusmod elit eiusmod. Ullamco veniam amet sunt aliqua tempor. Non minim consequat irure consequat sint. Sit aliquip non minim ea non magna non ex culpa aliqua ipsum sunt eiusmod.", "", 1 },
                    { new Guid("2e1ddce4-0928-4f19-be96-038e386364b2"), "423 Bulwer Place, Williston, Oklahoma, 9490", new DateTime(1980, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 27, 15, 48, 31, 331, DateTimeKind.Local).AddTicks(542), null, null, null, "chandlerstein@valreda.com", "Chandler", "12345678929", false, null, null, "Stein", "Sint dolore voluptate ea commodo nostrud consequat duis cupidatat reprehenderit. Labore irure est cillum aute anim voluptate consectetur magna consequat elit adipisicing. Laboris occaecat magna id labore exercitation dolore voluptate in sit fugiat voluptate aute ea. Tempor cupidatat voluptate enim aliquip eu aliquip dolore non proident. Consectetur tempor pariatur magna laboris. Magna pariatur ad sit irure nostrud cupidatat culpa.", "", 1 },
                    { new Guid("36b21b04-0a1f-4e68-8d08-dea46b597970"), "870 Clark Street, Thatcher, Virginia, 775", new DateTime(1982, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 27, 15, 48, 31, 331, DateTimeKind.Local).AddTicks(419), null, null, null, "freemandaugherty@valreda.com", "Freeman", "12345678907", false, null, null, "Daugherty", "Excepteur sint irure nostrud eu voluptate incididunt irure minim do ullamco adipisicing irure consequat enim. Reprehenderit nulla exercitation enim elit adipisicing sunt ex ad culpa ut.", "", 1 },
                    { new Guid("387b8da4-40cb-437a-a4af-0a3343dcf82a"), "767 Martense Street, Foxworth, Arizona, 3104", new DateTime(1977, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 27, 15, 48, 31, 331, DateTimeKind.Local).AddTicks(376), null, null, null, "mamieengland@valreda.com", "Mamie", "12345678903", false, null, null, "England", "Dolore esse ad cillum id commodo ut dolor laborum mollit mollit nisi exercitation aute ad.Quis veniam aliqua ipsum magna velit aliquip consequat id incididunt.", "", 1 },
                    { new Guid("3bca0f99-29ad-4cfe-8c40-a9f93fcf5787"), "124 Grattan Street, Monument, South Dakota, 5593", new DateTime(1996, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 27, 15, 48, 31, 331, DateTimeKind.Local).AddTicks(429), null, null, null, "tanyaboyle@valreda.com", "Tanya", "12345678909", false, null, null, "Boyle", "Laboris cupidatat tempor cupidatat eiusmod occaecat dolore commodo mollit et reprehenderit cupidatat qui elit occaecat. Amet cillum voluptate aliquip elit veniam Lorem commodo sint. Veniam velit irure esse veniam aliqua aliqua velit qui velit.", "", 1 },
                    { new Guid("3d2eda47-f6f6-4f87-a236-06c4e2fa737e"), "460 Chauncey Street, Roosevelt, Pennsylvania, 1055", new DateTime(1976, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 27, 15, 48, 31, 331, DateTimeKind.Local).AddTicks(461), null, null, null, "jodiewilliams@valreda.com", "Jodie", "12345678914", false, null, null, "Williams", "Mollit ullamco fugiat reprehenderit sunt culpa. Dolore sint eiusmod ad ullamco sint consectetur dolor elit sint occaecat ipsum. Quis esse sunt Lorem irure pariatur do ullamco cillum non amet labore aliqua eu. Deserunt dolore in voluptate officia sunt eu sint adipisicing minim pariatur.", "", 1 },
                    { new Guid("4277e296-2277-4df5-a281-8c8e39892fc9"), "406 Ferris Street, Kempton, Nevada, 8511", new DateTime(1989, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 27, 15, 48, 31, 331, DateTimeKind.Local).AddTicks(513), null, null, null, "helenaherrera@valreda.com", "Helena", "12345678924", false, null, null, "Herrera", "Ullamco cillum id nostrud ipsum esse quis velit velit est. Id est sunt enim nisi irure nulla do incididunt sint Lorem ad. Laboris nostrud sunt irure incididunt aute incididunt ipsum elit sit tempor commodo quis.", "", 1 },
                    { new Guid("63adfc83-8315-4bfb-af79-09540aacccc6"), "834 Halsey Street, Madaket, California, 7037", new DateTime(1975, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 27, 15, 48, 31, 331, DateTimeKind.Local).AddTicks(381), null, null, null, "hopkinshuff@valreda.com", "Hopkins", "12345678904", false, null, null, "Huff", "Nulla nostrud proident qui ad ea proident aliqua do. Ea in nisi velit in labore veniam enim mollit. Fugiat mollit voluptate amet incididunt non commodo ex. Est sint occaecat sint irure non esse sit commodo minim aute Lorem excepteur.", "", 1 },
                    { new Guid("7f03ed2d-19db-473d-9216-c9221b370153"), "378 Lott Avenue, Teasdale, Illinois, 1860", new DateTime(1981, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 27, 15, 48, 31, 331, DateTimeKind.Local).AddTicks(475), null, null, null, "mccoyclarke@valreda.com", "Mccoy", "12345678917", false, null, null, "Clarke", "Aliqua mollit sint in elit adipisicing dolore pariatur veniam ut laborum consequat. Pariatur est ipsum deserunt in. Minim labore amet est veniam occaecat sit anim. Aliqua culpa enim quis dolor nulla cupidatat. Non elit exercitation et deserunt incididunt veniam. Sit mollit esse laborum Lorem eiusmod irure cillum sint consequat minim qui minim.", "", 1 },
                    { new Guid("867513f1-e68e-4b6a-90cc-55b2ef950704"), "280 Clermont Avenue, Jugtown, Ohio, 7483", new DateTime(1972, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 27, 15, 48, 31, 331, DateTimeKind.Local).AddTicks(408), null, null, null, "averymcdonald@valreda.com", "Avery", "12345678905", false, null, null, "Mcdonald", "Nostrud ad qui deserunt elit sunt est dolor laborum nisi. Non adipisicing est dolore ut irure irure culpa aute voluptate cupidatat aliquip et.", "", 1 },
                    { new Guid("8df0ef50-0e8e-41bf-b7c0-a1f5ace64b8b"), "779 Poly Place, Welch, Delaware, 5670", new DateTime(1991, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 27, 15, 48, 31, 331, DateTimeKind.Local).AddTicks(508), null, null, null, "karlalittle@valreda.com", "Karla", "12345678923", false, null, null, "Little", "Do amet Lorem laborum ad cupidatat do enim officia. In voluptate aute laborum Lorem occaecat fugiat. Aliquip id enim qui fugiat deserunt laboris dolor incididunt adipisicing officia consequat. Est nisi non ad est proident cillum nulla proident magna.", "", 1 },
                    { new Guid("adc7e0ae-1fb6-4f7a-9d27-aa14370dc923"), "761 Hoyt Street, Gardiner, Iowa, 4576", new DateTime(1964, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 27, 15, 48, 31, 331, DateTimeKind.Local).AddTicks(414), null, null, null, "hildabarnett@valreda.com", "Hilda", "12345678906", false, null, null, "Barnett", "Pariatur aute sit excepteur id exercitation ad sit occaecat sunt eiusmod ea. Laboris ullamco laborum aliqua culpa voluptate in labore aliquip irure ea ex non commodo.", "", 1 },
                    { new Guid("af77d19a-d1a2-4252-b1ed-0d3696eca3e7"), "167 Preston Court, Ada, Nebraska, 7066", new DateTime(1981, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 27, 15, 48, 31, 331, DateTimeKind.Local).AddTicks(480), null, null, null, "mccarthymartin@valreda.com", "Mccarthy", "12345678918", false, null, null, "Martin", "Proident commodo veniam commodo voluptate ad nisi. Amet qui nisi reprehenderit ex elit nostrud. Eu quis aliqua laborum labore dolore elit. Non consectetur nostrud aliqua sit culpa excepteur. Nostrud culpa cillum sit ad quis aliqua anim ullamco sit nisi et duis ad cupidatat. Dolore elit ipsum consectetur cupidatat magna. Anim officia dolor magna occaecat id.", "", 1 },
                    { new Guid("b4a5c3af-34e2-4272-b906-df16d0362b41"), "475 Landis Court, Coultervillle, Missouri, 2696", new DateTime(1999, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 27, 15, 48, 31, 331, DateTimeKind.Local).AddTicks(465), null, null, null, "francespeck@valreda.com", "Frances", "12345678915", false, null, null, "Peck", "Aliquip excepteur sint magna mollit dolor exercitation ex. Laboris aute nisi fugiat minim proident ut. In incididunt Lorem id aliquip incididunt dolor pariatur quis cupidatat elit ullamco mollit nulla. Cillum laborum laborum elit tempor. Ut consectetur aute anim Lorem.", "", 1 },
                    { new Guid("c373ee45-b7bc-45b9-b0aa-eae8f1ff2a7e"), "300 Roosevelt Court, Linganore, Arizona, 9378", new DateTime(1980, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 27, 15, 48, 31, 331, DateTimeKind.Local).AddTicks(490), null, null, null, "milespearson@valreda.com", "Miles", "12345678920", false, null, null, "Pearson", "Ex non quis qui nulla elit dolore anim do magna. Cupidatat non exercitation cupidatat labore sit nisi do duis. Aliqua Lorem excepteur nisi nisi aute minim.", "", 1 },
                    { new Guid("e9d925fb-54e0-443b-8334-bbdba3f69b0d"), "894 Osborn Street, Driftwood, Connecticut, 1546", new DateTime(2000, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 27, 15, 48, 31, 331, DateTimeKind.Local).AddTicks(424), null, null, null, "haynesford@valreda.com", "Haynes", "12345678908", false, null, null, "Ford", "Nostrud do aliqua magna pariatur exercitation anim labore amet magna adipisicing.Non enim eu reprehenderit proident ea reprehenderit incididunt occaecat incididunt ipsum. Ullamco nostrud ullamco ut magna mollit reprehenderit officia.", "", 1 },
                    { new Guid("ea7e77e6-655f-48bb-ab9a-f9ebaff04be0"), "155 Hale Avenue, Alden, Oregon, 4793", new DateTime(1997, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 27, 15, 48, 31, 331, DateTimeKind.Local).AddTicks(523), null, null, null, "nelsonmorgan@valreda.com", "Nelson", "12345678926", false, null, null, "Morgan", "Tempor in est aliquip excepteur est. Id dolore est excepteur voluptate proident consectetur elit non ad id nostrud pariatur labore anim. Esse magna ex ut consequat exercitation est.", "", 1 },
                    { new Guid("ed8d5cf6-9dde-4033-b245-186ed96ec829"), "295 Harman Street, Forbestown, Pennsylvania, 6491", new DateTime(1966, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 27, 15, 48, 31, 331, DateTimeKind.Local).AddTicks(499), null, null, null, "randipace@valreda.com", "Randi", "12345678921", false, null, null, "Pace", "Dolor fugiat labore do incididunt mollit deserunt aliquip ad sunt mollit sint. Sunt deserunt quis nisi do adipisicing mollit et enim eiusmod. Deserunt nisi ut cillum reprehenderit consectetur cupidatat in ex duis et.", "", 1 },
                    { new Guid("eeab568b-d16d-457e-a028-57772bfba2ee"), "202 Midwood Street, Barstow, Mississippi, 6264", new DateTime(1967, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 27, 15, 48, 31, 331, DateTimeKind.Local).AddTicks(456), null, null, null, "powerslynn@valreda.com", "Powers", "12345678913", false, null, null, "Lynn", "Nulla labore id commodo et quis consectetur. Nisi ipsum cupidatat cillum consequat exercitation voluptate laboris. Ex culpa cillum sit officia qui velit.", "", 1 },
                    { new Guid("f3f733ea-0dca-4883-ace4-8c686a32c6e2"), "895 Kane Street, Hasty, Virgin Islands, 1394", new DateTime(1960, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 27, 15, 48, 31, 331, DateTimeKind.Local).AddTicks(528), null, null, null, "rileylambert@valreda.com", "Riley", "12345678927", false, null, null, "Lambert", "Et veniam incididunt enim veniam ipsum elit id. Labore dolore incididunt voluptate adipisicing ullamco non. Esse minim ut minim cillum enim proident aliquip cupidatat aliquip esse esse elit tempor. Laborum irure magna et anim irure officia reprehenderit occaecat adipisicing amet ea elit. Culpa sunt fugiat voluptate excepteur consectetur dolore aute.", "", 1 },
                    { new Guid("f9171101-2364-439b-9f58-91391fa84514"), "221 Corbin Place, Jennings, Utah, 323", new DateTime(1969, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 27, 15, 48, 31, 331, DateTimeKind.Local).AddTicks(547), null, null, null, "robbiesantana@valreda.com", "Robbie", "12345678930", false, null, null, "Santana", "Eu qui cupidatat in cillum culpa deserunt amet dolor mollit aliquip. Excepteur quis ipsum exercitation non duis elit. Reprehenderit ut laboris excepteur id aliquip ullamco nisi proident consectetur ex laborum exercitation veniam. Velit eiusmod laborum officia reprehenderit nisi deserunt est labore. Id nisi dolor laboris labore ex in anim commodo aliqua. Qui fugiat amet nostrud eu est ipsum ipsum cupidatat magna.", "", 1 },
                    { new Guid("fab13530-8151-433b-b34b-fc5b7703bdb6"), "275 Landis Court, Fontanelle, Marshall Islands, 4084", new DateTime(1974, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 27, 15, 48, 31, 331, DateTimeKind.Local).AddTicks(485), null, null, null, "carrollcarrillo@valreda.com", "Carroll", "12345678919", false, null, null, "Carrillo", "Ipsum occaecat esse cupidatat occaecat tempor. Minim quis in laboris dolore reprehenderit in occaecat esse fugiat excepteur veniam. Voluptate fugiat ex ex pariatur non sint nostrud exercitation sunt deserunt. Tempor ipsum minim amet non laborum labore ullamco duis veniam. Fugiat voluptate anim excepteur anim veniam ut voluptate eiusmod occaecat. Anim reprehenderit magna nisi est nisi sunt non minim cupidatat quis do officia et. Magna adipisicing fugiat labore ea mollit sunt deserunt anim aliquip ea ut ad dolor in.", "", 1 },
                    { new Guid("fec832d4-7696-4a72-a149-38cb6ff52735"), "784 Furman Street, Vaughn, Montana, 6667", new DateTime(1965, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 27, 15, 48, 31, 331, DateTimeKind.Local).AddTicks(359), null, null, null, "tonihampton@valreda.com", "Toni", "67890123456", false, null, null, "Hampton", "Aliqua sint nulla officia esse duis eiusmod enim qui. Fugiat minim deserunt nostrud labore dolore nulla occaecat ut laboris proident pariatur consectetur. ", "", 1 },
                    { new Guid("fffa87b7-2419-4289-bc4a-b788771d52ff"), "635 Taaffe Place, Jeff, Idaho, 9876", new DateTime(1992, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 27, 15, 48, 31, 331, DateTimeKind.Local).AddTicks(444), null, null, null, "perezcooke@valreda.com", "Perez", "12345678912", false, null, null, "Cooke", "Dolore cillum commodo irure in dolore irure pariatur culpa eiusmod. Aliqua velit consequat labore elit magna adipisicing laborum ipsum.Velit nostrud deserunt consequat minim culpa est. Tempor et Lorem et consequat ipsum cupidatat consectetur dolor minim id enim.", "", 1 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Name", "Password", "PhoneNumber", "Role", "Surname", "Username" },
                values: new object[,]
                {
                    { 1, "emredindr@gmail.com", "Emre", "asd123", "1234567890", 1, "Dindar", "emredindr" },
                    { 2, "kodluyoruz@patika.dev", "DevPatika", "bootcamp109", "1234567890", 2, "Kodluyoruz", "kodluyoruz" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApplicationDocuments");

            migrationBuilder.DropTable(
                name: "Applications");

            migrationBuilder.DropTable(
                name: "Documents");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
