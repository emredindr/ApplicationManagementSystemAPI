using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApplicationManagementSystem.DataAccess.Migrations
{
    public partial class mig_1_initial : Migration
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
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifierUserId = table.Column<int>(type: "int", nullable: true),
                    DeletorUserId = table.Column<int>(type: "int", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Response = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                columns: new[] { "Id", "Address", "Birthday", "CreationTime", "DeletionTime", "DeletorUserId", "Email", "FirstName", "IdentityNumber", "IsDeleted", "LastModificationTime", "LastModifierUserId", "LastName", "Reason", "Response", "Status" },
                values: new object[,]
                {
                    { new Guid("17677fdf-de64-415b-a8c1-b8675f7a1800"), "124 Grattan Street, Monument, South Dakota, 5593", new DateTime(1996, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 12, 31, 19, 38, 25, 735, DateTimeKind.Local).AddTicks(1781), null, null, "tanyaboyle@valreda.com", "Tanya", "12345678909", false, null, null, "Boyle", "Laboris cupidatat tempor cupidatat eiusmod occaecat dolore commodo mollit et reprehenderit cupidatat qui elit occaecat. Amet cillum voluptate aliquip elit veniam Lorem commodo sint. Veniam velit irure esse veniam aliqua aliqua velit qui velit.", "", 1 },
                    { new Guid("4f25fa33-b31f-4be8-8eda-1a754efb74c6"), "834 Halsey Street, Madaket, California, 7037", new DateTime(1975, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 12, 31, 19, 38, 25, 735, DateTimeKind.Local).AddTicks(1734), null, null, "hopkinshuff@valreda.com", "Hopkins", "12345678904", false, null, null, "Huff", "Nulla nostrud proident qui ad ea proident aliqua do. Ea in nisi velit in labore veniam enim mollit. Fugiat mollit voluptate amet incididunt non commodo ex. Est sint occaecat sint irure non esse sit commodo minim aute Lorem excepteur.", "", 1 },
                    { new Guid("55777e3c-df5c-4f3a-8e37-a226297f46af"), "761 Hoyt Street, Gardiner, Iowa, 4576", new DateTime(1964, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 12, 31, 19, 38, 25, 735, DateTimeKind.Local).AddTicks(1744), null, null, "hildabarnett@valreda.com", "Hilda", "12345678906", false, null, null, "Barnett", "Pariatur aute sit excepteur id exercitation ad sit occaecat sunt eiusmod ea. Laboris ullamco laborum aliqua culpa voluptate in labore aliquip irure ea ex non commodo.", "", 1 },
                    { new Guid("65cdca36-e3d9-45af-847e-f15486924ac3"), "767 Martense Street, Foxworth, Arizona, 3104", new DateTime(1977, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 12, 31, 19, 38, 25, 735, DateTimeKind.Local).AddTicks(1728), null, null, "mamieengland@valreda.com", "Mamie", "12345678903", false, null, null, "England", "Dolore esse ad cillum id commodo ut dolor laborum mollit mollit nisi exercitation aute ad.Quis veniam aliqua ipsum magna velit aliquip consequat id incididunt.", "", 1 },
                    { new Guid("95ec6f74-ff19-4e6b-8c2d-8ed2f37ada1f"), "784 Furman Street, Vaughn, Montana, 6667", new DateTime(1965, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 12, 31, 19, 38, 25, 735, DateTimeKind.Local).AddTicks(1652), null, null, "tonihampton@valreda.com", "Toni", "67890123456", false, null, null, "Hampton", "Aliqua sint nulla officia esse duis eiusmod enim qui. Fugiat minim deserunt nostrud labore dolore nulla occaecat ut laboris proident pariatur consectetur. ", "", 1 },
                    { new Guid("a4065f80-a496-4d90-8f79-884d2b18bb88"), "280 Clermont Avenue, Jugtown, Ohio, 7483", new DateTime(1972, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 12, 31, 19, 38, 25, 735, DateTimeKind.Local).AddTicks(1739), null, null, "averymcdonald@valreda.com", "Avery", "12345678905", false, null, null, "Mcdonald", "Nostrud ad qui deserunt elit sunt est dolor laborum nisi. Non adipisicing est dolore ut irure irure culpa aute voluptate cupidatat aliquip et.", "", 1 },
                    { new Guid("aef9c2b2-7b9e-4a75-9634-717157036eaa"), "894 Osborn Street, Driftwood, Connecticut, 1546", new DateTime(2000, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 12, 31, 19, 38, 25, 735, DateTimeKind.Local).AddTicks(1776), null, null, "haynesford@valreda.com", "Haynes", "12345678908", false, null, null, "Ford", "Nostrud do aliqua magna pariatur exercitation anim labore amet magna adipisicing.Non enim eu reprehenderit proident ea reprehenderit incididunt occaecat incididunt ipsum. Ullamco nostrud ullamco ut magna mollit reprehenderit officia.", "", 1 },
                    { new Guid("bdda0546-b013-45f0-b6df-6c9e5ee6d77d"), "460 Chauncey Street, Roosevelt, Pennsylvania, 1055", new DateTime(1976, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 12, 31, 19, 38, 25, 735, DateTimeKind.Local).AddTicks(1806), null, null, "jodiewilliams@valreda.com", "Jodie", "12345678914", false, null, null, "Williams", "Mollit ullamco fugiat reprehenderit sunt culpa. Dolore sint eiusmod ad ullamco sint consectetur dolor elit sint occaecat ipsum. Quis esse sunt Lorem irure pariatur do ullamco cillum non amet labore aliqua eu. Deserunt dolore in voluptate officia sunt eu sint adipisicing minim pariatur.", "", 1 },
                    { new Guid("d1254620-51e8-4401-82a6-a065ca88c0d0"), "202 Midwood Street, Barstow, Mississippi, 6264", new DateTime(1967, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 12, 31, 19, 38, 25, 735, DateTimeKind.Local).AddTicks(1801), null, null, "powerslynn@valreda.com", "Powers", "12345678913", false, null, null, "Lynn", "Nulla labore id commodo et quis consectetur. Nisi ipsum cupidatat cillum consequat exercitation voluptate laboris. Ex culpa cillum sit officia qui velit.", "", 1 },
                    { new Guid("da1907d8-2cf0-4a3d-a2ce-30838be5eb75"), "870 Clark Street, Thatcher, Virginia, 775", new DateTime(1982, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 12, 31, 19, 38, 25, 735, DateTimeKind.Local).AddTicks(1749), null, null, "freemandaugherty@valreda.com", "Freeman", "12345678907", false, null, null, "Daugherty", "Excepteur sint irure nostrud eu voluptate incididunt irure minim do ullamco adipisicing irure consequat enim. Reprehenderit nulla exercitation enim elit adipisicing sunt ex ad culpa ut.", "", 1 },
                    { new Guid("e27ab587-e897-4dda-b7dc-72876feba7b1"), "818 Ruby Street, Garnet, Alaska, 1235", new DateTime(1981, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 12, 31, 19, 38, 25, 735, DateTimeKind.Local).AddTicks(1786), null, null, "caradurham@valreda.com", "Cara", "12345678910", false, null, null, "Durham", "Laborum laboris consectetur aliqua laboris non. In in deserunt ut qui voluptate eiusmod. Magna irure elit eu eiusmod veniam adipisicing.", "", 1 },
                    { new Guid("ebd010bf-8dba-4df4-a749-e239dd7da619"), "305 Schermerhorn Street, Boykin, Minnesota, 307", new DateTime(1999, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 12, 31, 19, 38, 25, 735, DateTimeKind.Local).AddTicks(1822), null, null, "puckettoneill@valreda.com", "Puckett", "12345678916", false, null, null, "Oneill", "Tempor commodo nulla voluptate cupidatat amet magna dolor laboris occaecat incididunt. Eu velit proident laborum elit reprehenderit enim mollit occaecat excepteur in ex eu. Incididunt anim elit consequat sunt cupidatat tempor aliquip nostrud occaecat nisi et adipisicing esse nulla.", "", 1 },
                    { new Guid("ed83dfba-0577-4f60-b5cb-63acb8d492a5"), "635 Taaffe Place, Jeff, Idaho, 9876", new DateTime(1992, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 12, 31, 19, 38, 25, 735, DateTimeKind.Local).AddTicks(1796), null, null, "perezcooke@valreda.com", "Perez", "12345678912", false, null, null, "Cooke", "Dolore cillum commodo irure in dolore irure pariatur culpa eiusmod. Aliqua velit consequat labore elit magna adipisicing laborum ipsum.Velit nostrud deserunt consequat minim culpa est. Tempor et Lorem et consequat ipsum cupidatat consectetur dolor minim id enim.", "", 1 },
                    { new Guid("f21f40a9-6cd7-4911-b1a0-ff81b268e6a2"), "737 Provost Street, Odessa, Kentucky, 4490", new DateTime(1992, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 12, 31, 19, 38, 25, 735, DateTimeKind.Local).AddTicks(1791), null, null, "dawsonpratt@valreda.com", "Dawson", "12345678911", false, null, null, "Pratt", "Non Lorem exercitation est proident laborum sint est id amet officia eiusmod elit eiusmod. Ullamco veniam amet sunt aliqua tempor. Non minim consequat irure consequat sint. Sit aliquip non minim ea non magna non ex culpa aliqua ipsum sunt eiusmod.", "", 1 },
                    { new Guid("fb4772dc-f75a-4454-8ea0-0ad60fa09091"), "475 Landis Court, Coultervillle, Missouri, 2696", new DateTime(1999, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 12, 31, 19, 38, 25, 735, DateTimeKind.Local).AddTicks(1811), null, null, "francespeck@valreda.com", "Frances", "12345678915", false, null, null, "Peck", "Aliquip excepteur sint magna mollit dolor exercitation ex. Laboris aute nisi fugiat minim proident ut. In incididunt Lorem id aliquip incididunt dolor pariatur quis cupidatat elit ullamco mollit nulla. Cillum laborum laborum elit tempor. Ut consectetur aute anim Lorem.", "", 1 },
                    { new Guid("fc0e0f17-7bfc-40f5-9afb-ebe5c32be476"), "457 Roosevelt Place, Tilleda, Florida, 5976", new DateTime(1963, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 12, 31, 19, 38, 25, 735, DateTimeKind.Local).AddTicks(1668), null, null, "erickacalderon@valreda.com", "Ericka", "12345678902", false, null, null, "Calderon", "Voluptate ut proident eiusmod ea quis velit ad ut proident nisi. Qui ex ea laboris do in ullamco eiusmod ullamco reprehenderit ea adipisicing anim nulla.", "", 1 }
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
