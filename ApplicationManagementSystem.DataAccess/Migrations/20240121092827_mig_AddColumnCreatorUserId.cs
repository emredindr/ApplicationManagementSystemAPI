using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApplicationManagementSystem.DataAccess.Migrations
{
    public partial class mig_AddColumnCreatorUserId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: new Guid("0a245987-77c1-481e-ae31-856de02f63b3"));

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: new Guid("2bf7150c-328f-41dc-aee1-518c3c4c64c6"));

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: new Guid("2ec934bc-f638-48de-a875-578e6bab4d5f"));

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: new Guid("33b1802b-6767-4531-9334-ba50d8015326"));

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: new Guid("431d8a2e-3e89-400b-9640-01bc75d05d29"));

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: new Guid("4404c389-a015-4534-91ff-65645d917a4d"));

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: new Guid("485391cf-7210-4ac3-8d9c-4acdb5242687"));

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: new Guid("50fd9f39-b9c9-4a70-8c39-b5e553b7a679"));

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: new Guid("5c3df945-3d17-4130-b07c-ec539649922f"));

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: new Guid("624acbc2-ad81-4733-a02d-62f11a1c1531"));

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: new Guid("6afbad22-b2e2-4f36-976d-6ef4ee2337d9"));

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: new Guid("6c9c1812-294b-4c9e-aefa-ebedad88f7a0"));

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: new Guid("6fbba405-9416-4a49-8cfa-37533a6e0d03"));

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: new Guid("76c6bfc5-ed74-4c3d-bde3-705e61b50135"));

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: new Guid("854e0f55-292b-4220-ab6b-6029b6a6a4d9"));

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: new Guid("85f5ec72-abde-46b7-a76a-4eb052a15f34"));

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: new Guid("86dcd9ab-b0f0-42dc-bd95-444b8562c399"));

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: new Guid("8f1df738-9630-4987-ae71-59dcf0d5039e"));

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: new Guid("93a92b23-33ed-4947-9011-b5e40db67346"));

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: new Guid("94f8472b-c963-47f6-9049-4afbcffbea00"));

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: new Guid("c106feb3-0b1e-4f27-991a-e97e47e70d1b"));

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: new Guid("cbc605c3-37f2-4e64-9a4c-cae3534cce5e"));

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: new Guid("cd9da98a-b94f-4923-a3d0-4455a576377a"));

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: new Guid("db5c497a-4369-4aaa-8ab0-52b9dc6b5772"));

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: new Guid("de4c6936-f6fd-4b83-b385-f974ec26b709"));

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: new Guid("e1aecd54-1054-4978-9c3b-5e16f4ea3ad0"));

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: new Guid("e1f648b3-f84d-49ac-a720-e0ba89cdeda1"));

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: new Guid("f048c054-5003-4b99-ae9e-7f0a1969d35c"));

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: new Guid("f0c93f22-485a-42ee-a5df-a86770457fa6"));

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: new Guid("f2b0b6ae-3a12-438f-875e-5b7eafd0b0eb"));

            migrationBuilder.AddColumn<int>(
                name: "CreatorUserId",
                table: "Applications",
                type: "int",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Applications",
                columns: new[] { "Id", "Address", "Birthday", "CreationTime", "CreatorUserId", "DeletionTime", "DeletorUserId", "Email", "FirstName", "IdentityNumber", "IsDeleted", "LastModificationTime", "LastModifierUserId", "LastName", "Reason", "Response", "Status" },
                values: new object[,]
                {
                    { new Guid("01681968-7d57-49b4-8324-5111a5d64dc2"), "202 Midwood Street, Barstow, Mississippi, 6264", new DateTime(1967, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 21, 12, 28, 26, 257, DateTimeKind.Local).AddTicks(6047), null, null, null, "powerslynn@valreda.com", "Powers", "12345678913", false, null, null, "Lynn", "Nulla labore id commodo et quis consectetur. Nisi ipsum cupidatat cillum consequat exercitation voluptate laboris. Ex culpa cillum sit officia qui velit.", "", 1 },
                    { new Guid("073a57b3-d8b0-4a9d-954e-fa7571913aa7"), "124 Grattan Street, Monument, South Dakota, 5593", new DateTime(1996, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 21, 12, 28, 26, 257, DateTimeKind.Local).AddTicks(6003), null, null, null, "tanyaboyle@valreda.com", "Tanya", "12345678909", false, null, null, "Boyle", "Laboris cupidatat tempor cupidatat eiusmod occaecat dolore commodo mollit et reprehenderit cupidatat qui elit occaecat. Amet cillum voluptate aliquip elit veniam Lorem commodo sint. Veniam velit irure esse veniam aliqua aliqua velit qui velit.", "", 1 },
                    { new Guid("0b10a49a-fe82-4da8-bf49-67c8efff318e"), "329 Howard Alley, Noblestown, Northern Mariana Islands, 8023", new DateTime(1962, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 21, 12, 28, 26, 257, DateTimeKind.Local).AddTicks(6267), null, null, null, "valentinekerr@valreda.com", "Valentine", "12345678928", false, null, null, "Kerr", "Deserunt aute labore deserunt commodo. Commodo consectetur dolore laborum dolore anim officia mollit mollit amet. Duis anim voluptate non deserunt esse eu esse ad laboris. Occaecat mollit mollit veniam officia ullamco nisi amet. Tempor laboris veniam officia enim in aliquip qui irure labore aliqua. Nostrud anim do ea mollit enim exercitation laborum commodo consectetur laboris consequat. Anim consequat cillum exercitation laborum qui proident sunt nisi excepteur qui.", "", 1 },
                    { new Guid("133a6f96-e384-4c10-bca6-ebe9ab3efbe1"), "761 Hoyt Street, Gardiner, Iowa, 4576", new DateTime(1964, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 21, 12, 28, 26, 257, DateTimeKind.Local).AddTicks(5978), null, null, null, "hildabarnett@valreda.com", "Hilda", "12345678906", false, null, null, "Barnett", "Pariatur aute sit excepteur id exercitation ad sit occaecat sunt eiusmod ea. Laboris ullamco laborum aliqua culpa voluptate in labore aliquip irure ea ex non commodo.", "", 1 },
                    { new Guid("13d8cd21-0be1-48f3-ba1a-a4f0585a9c36"), "767 Martense Street, Foxworth, Arizona, 3104", new DateTime(1977, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 21, 12, 28, 26, 257, DateTimeKind.Local).AddTicks(5927), null, null, null, "mamieengland@valreda.com", "Mamie", "12345678903", false, null, null, "England", "Dolore esse ad cillum id commodo ut dolor laborum mollit mollit nisi exercitation aute ad.Quis veniam aliqua ipsum magna velit aliquip consequat id incididunt.", "", 1 },
                    { new Guid("1bd02da7-541e-4423-92cf-ec68b34d0803"), "423 Bulwer Place, Williston, Oklahoma, 9490", new DateTime(1980, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 21, 12, 28, 26, 257, DateTimeKind.Local).AddTicks(6281), null, null, null, "chandlerstein@valreda.com", "Chandler", "12345678929", false, null, null, "Stein", "Sint dolore voluptate ea commodo nostrud consequat duis cupidatat reprehenderit. Labore irure est cillum aute anim voluptate consectetur magna consequat elit adipisicing. Laboris occaecat magna id labore exercitation dolore voluptate in sit fugiat voluptate aute ea. Tempor cupidatat voluptate enim aliquip eu aliquip dolore non proident. Consectetur tempor pariatur magna laboris. Magna pariatur ad sit irure nostrud cupidatat culpa.", "", 1 },
                    { new Guid("273754a6-d5b2-4831-828c-1bc97cf5117d"), "457 Roosevelt Place, Tilleda, Florida, 5976", new DateTime(1963, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 21, 12, 28, 26, 257, DateTimeKind.Local).AddTicks(5919), null, null, null, "erickacalderon@valreda.com", "Ericka", "12345678902", false, null, null, "Calderon", "Voluptate ut proident eiusmod ea quis velit ad ut proident nisi. Qui ex ea laboris do in ullamco eiusmod ullamco reprehenderit ea adipisicing anim nulla.", "", 1 },
                    { new Guid("2f4fe72c-b4a7-4087-80e1-2b7e953d9329"), "406 Ferris Street, Kempton, Nevada, 8511", new DateTime(1989, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 21, 12, 28, 26, 257, DateTimeKind.Local).AddTicks(6237), null, null, null, "helenaherrera@valreda.com", "Helena", "12345678924", false, null, null, "Herrera", "Ullamco cillum id nostrud ipsum esse quis velit velit est. Id est sunt enim nisi irure nulla do incididunt sint Lorem ad. Laboris nostrud sunt irure incididunt aute incididunt ipsum elit sit tempor commodo quis.", "", 1 },
                    { new Guid("4734c7b6-9c32-489e-9637-f105a7e2f537"), "894 Osborn Street, Driftwood, Connecticut, 1546", new DateTime(2000, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 21, 12, 28, 26, 257, DateTimeKind.Local).AddTicks(5994), null, null, null, "haynesford@valreda.com", "Haynes", "12345678908", false, null, null, "Ford", "Nostrud do aliqua magna pariatur exercitation anim labore amet magna adipisicing.Non enim eu reprehenderit proident ea reprehenderit incididunt occaecat incididunt ipsum. Ullamco nostrud ullamco ut magna mollit reprehenderit officia.", "", 1 },
                    { new Guid("62894ba9-0633-45a4-88bd-8e23aa5861e6"), "155 Hale Avenue, Alden, Oregon, 4793", new DateTime(1997, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 21, 12, 28, 26, 257, DateTimeKind.Local).AddTicks(6251), null, null, null, "nelsonmorgan@valreda.com", "Nelson", "12345678926", false, null, null, "Morgan", "Tempor in est aliquip excepteur est. Id dolore est excepteur voluptate proident consectetur elit non ad id nostrud pariatur labore anim. Esse magna ex ut consequat exercitation est.", "", 1 },
                    { new Guid("6961b11d-411b-4b65-88a7-120fa25b8803"), "275 Landis Court, Fontanelle, Marshall Islands, 4084", new DateTime(1974, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 21, 12, 28, 26, 257, DateTimeKind.Local).AddTicks(6094), null, null, null, "carrollcarrillo@valreda.com", "Carroll", "12345678919", false, null, null, "Carrillo", "Ipsum occaecat esse cupidatat occaecat tempor. Minim quis in laboris dolore reprehenderit in occaecat esse fugiat excepteur veniam. Voluptate fugiat ex ex pariatur non sint nostrud exercitation sunt deserunt. Tempor ipsum minim amet non laborum labore ullamco duis veniam. Fugiat voluptate anim excepteur anim veniam ut voluptate eiusmod occaecat. Anim reprehenderit magna nisi est nisi sunt non minim cupidatat quis do officia et. Magna adipisicing fugiat labore ea mollit sunt deserunt anim aliquip ea ut ad dolor in.", "", 1 },
                    { new Guid("76407f51-c427-4494-8324-576aee1a8630"), "300 Roosevelt Court, Linganore, Arizona, 9378", new DateTime(1980, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 21, 12, 28, 26, 257, DateTimeKind.Local).AddTicks(6101), null, null, null, "milespearson@valreda.com", "Miles", "12345678920", false, null, null, "Pearson", "Ex non quis qui nulla elit dolore anim do magna. Cupidatat non exercitation cupidatat labore sit nisi do duis. Aliqua Lorem excepteur nisi nisi aute minim.", "", 1 },
                    { new Guid("7b40e419-e875-4c28-8caf-4242719cc254"), "870 Clark Street, Thatcher, Virginia, 775", new DateTime(1982, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 21, 12, 28, 26, 257, DateTimeKind.Local).AddTicks(5986), null, null, null, "freemandaugherty@valreda.com", "Freeman", "12345678907", false, null, null, "Daugherty", "Excepteur sint irure nostrud eu voluptate incididunt irure minim do ullamco adipisicing irure consequat enim. Reprehenderit nulla exercitation enim elit adipisicing sunt ex ad culpa ut.", "", 1 },
                    { new Guid("7dbaedcb-4522-4b5e-a5d0-4a47659a1f5d"), "305 Schermerhorn Street, Boykin, Minnesota, 307", new DateTime(1999, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 21, 12, 28, 26, 257, DateTimeKind.Local).AddTicks(6072), null, null, null, "puckettoneill@valreda.com", "Puckett", "12345678916", false, null, null, "Oneill", "Tempor commodo nulla voluptate cupidatat amet magna dolor laboris occaecat incididunt. Eu velit proident laborum elit reprehenderit enim mollit occaecat excepteur in ex eu. Incididunt anim elit consequat sunt cupidatat tempor aliquip nostrud occaecat nisi et adipisicing esse nulla.", "", 1 },
                    { new Guid("8c3bb04d-1927-43c3-a6c4-b336fe5979a2"), "818 Ruby Street, Garnet, Alaska, 1235", new DateTime(1981, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 21, 12, 28, 26, 257, DateTimeKind.Local).AddTicks(6011), null, null, null, "caradurham@valreda.com", "Cara", "12345678910", false, null, null, "Durham", "Laborum laboris consectetur aliqua laboris non. In in deserunt ut qui voluptate eiusmod. Magna irure elit eu eiusmod veniam adipisicing.", "", 1 },
                    { new Guid("8c40fea6-1245-4c4c-985f-37aa09158a32"), "123 Guernsey Street, Marenisco, Montana, 2971", new DateTime(1999, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 21, 12, 28, 26, 257, DateTimeKind.Local).AddTicks(6122), null, null, null, "candaceburton@valreda.com", "Candace", "12345678922", false, null, null, "Burton", "Eiusmod labore voluptate tempor duis deserunt laborum minim nisi minim qui reprehenderit. Ut in in mollit do irure elit ullamco est. Incididunt minim ea fugiat aute enim ipsum eu cupidatat non occaecat aliquip. Occaecat mollit adipisicing occaecat qui id esse id exercitation.", "", 1 },
                    { new Guid("8ef5b6b0-4f14-4b88-9f1d-def2c8bc7b99"), "378 Lott Avenue, Teasdale, Illinois, 1860", new DateTime(1981, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 21, 12, 28, 26, 257, DateTimeKind.Local).AddTicks(6079), null, null, null, "mccoyclarke@valreda.com", "Mccoy", "12345678917", false, null, null, "Clarke", "Aliqua mollit sint in elit adipisicing dolore pariatur veniam ut laborum consequat. Pariatur est ipsum deserunt in. Minim labore amet est veniam occaecat sit anim. Aliqua culpa enim quis dolor nulla cupidatat. Non elit exercitation et deserunt incididunt veniam. Sit mollit esse laborum Lorem eiusmod irure cillum sint consequat minim qui minim.", "", 1 },
                    { new Guid("92d2286d-1e1c-49e9-9e4e-375d75033555"), "737 Provost Street, Odessa, Kentucky, 4490", new DateTime(1992, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 21, 12, 28, 26, 257, DateTimeKind.Local).AddTicks(6019), null, null, null, "dawsonpratt@valreda.com", "Dawson", "12345678911", false, null, null, "Pratt", "Non Lorem exercitation est proident laborum sint est id amet officia eiusmod elit eiusmod. Ullamco veniam amet sunt aliqua tempor. Non minim consequat irure consequat sint. Sit aliquip non minim ea non magna non ex culpa aliqua ipsum sunt eiusmod.", "", 1 },
                    { new Guid("949f7e77-068b-4e57-bce6-4451dd7a505b"), "616 Louisa Street, Ona, Massachusetts, 2957", new DateTime(1998, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 21, 12, 28, 26, 257, DateTimeKind.Local).AddTicks(6244), null, null, null, "josefacarpenter@valreda.com", "Josefa", "12345678925", false, null, null, "Carpenter", "Est laboris consectetur deserunt esse elit fugiat irure qui sint. Veniam minim exercitation non nisi proident eiusmod et excepteur. Deserunt cupidatat cillum duis officia quis quis proident. Id sunt non Lorem cillum ipsum id tempor aliquip amet fugiat nulla et sunt Lorem. Velit excepteur reprehenderit eu voluptate ex commodo irure consectetur ad id. Ipsum mollit ipsum in incididunt commodo. Commodo mollit do magna dolor.", "", 1 },
                    { new Guid("9c5e6f53-5ce3-4d72-b2ae-8f460275aca6"), "280 Clermont Avenue, Jugtown, Ohio, 7483", new DateTime(1972, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 21, 12, 28, 26, 257, DateTimeKind.Local).AddTicks(5969), null, null, null, "averymcdonald@valreda.com", "Avery", "12345678905", false, null, null, "Mcdonald", "Nostrud ad qui deserunt elit sunt est dolor laborum nisi. Non adipisicing est dolore ut irure irure culpa aute voluptate cupidatat aliquip et.", "", 1 },
                    { new Guid("9f146782-dd33-4ff5-b247-5fdab33f5226"), "475 Landis Court, Coultervillle, Missouri, 2696", new DateTime(1999, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 21, 12, 28, 26, 257, DateTimeKind.Local).AddTicks(6063), null, null, null, "francespeck@valreda.com", "Frances", "12345678915", false, null, null, "Peck", "Aliquip excepteur sint magna mollit dolor exercitation ex. Laboris aute nisi fugiat minim proident ut. In incididunt Lorem id aliquip incididunt dolor pariatur quis cupidatat elit ullamco mollit nulla. Cillum laborum laborum elit tempor. Ut consectetur aute anim Lorem.", "", 1 },
                    { new Guid("9fd45141-5aee-4861-8461-e038016cd3a5"), "779 Poly Place, Welch, Delaware, 5670", new DateTime(1991, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 21, 12, 28, 26, 257, DateTimeKind.Local).AddTicks(6228), null, null, null, "karlalittle@valreda.com", "Karla", "12345678923", false, null, null, "Little", "Do amet Lorem laborum ad cupidatat do enim officia. In voluptate aute laborum Lorem occaecat fugiat. Aliquip id enim qui fugiat deserunt laboris dolor incididunt adipisicing officia consequat. Est nisi non ad est proident cillum nulla proident magna.", "", 1 },
                    { new Guid("a3f51e56-03fe-496e-b418-8ddfc144e59a"), "460 Chauncey Street, Roosevelt, Pennsylvania, 1055", new DateTime(1976, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 21, 12, 28, 26, 257, DateTimeKind.Local).AddTicks(6055), null, null, null, "jodiewilliams@valreda.com", "Jodie", "12345678914", false, null, null, "Williams", "Mollit ullamco fugiat reprehenderit sunt culpa. Dolore sint eiusmod ad ullamco sint consectetur dolor elit sint occaecat ipsum. Quis esse sunt Lorem irure pariatur do ullamco cillum non amet labore aliqua eu. Deserunt dolore in voluptate officia sunt eu sint adipisicing minim pariatur.", "", 1 },
                    { new Guid("aef97e01-880b-442e-92a7-2477a34eaa64"), "635 Taaffe Place, Jeff, Idaho, 9876", new DateTime(1992, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 21, 12, 28, 26, 257, DateTimeKind.Local).AddTicks(6028), null, null, null, "perezcooke@valreda.com", "Perez", "12345678912", false, null, null, "Cooke", "Dolore cillum commodo irure in dolore irure pariatur culpa eiusmod. Aliqua velit consequat labore elit magna adipisicing laborum ipsum.Velit nostrud deserunt consequat minim culpa est. Tempor et Lorem et consequat ipsum cupidatat consectetur dolor minim id enim.", "", 1 },
                    { new Guid("d536e8c9-a2e1-40eb-aef0-2c3e033a489e"), "221 Corbin Place, Jennings, Utah, 323", new DateTime(1969, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 21, 12, 28, 26, 257, DateTimeKind.Local).AddTicks(6288), null, null, null, "robbiesantana@valreda.com", "Robbie", "12345678930", false, null, null, "Santana", "Eu qui cupidatat in cillum culpa deserunt amet dolor mollit aliquip. Excepteur quis ipsum exercitation non duis elit. Reprehenderit ut laboris excepteur id aliquip ullamco nisi proident consectetur ex laborum exercitation veniam. Velit eiusmod laborum officia reprehenderit nisi deserunt est labore. Id nisi dolor laboris labore ex in anim commodo aliqua. Qui fugiat amet nostrud eu est ipsum ipsum cupidatat magna.", "", 1 },
                    { new Guid("ea9c504b-c1a2-48f5-86c0-211530cbf52e"), "295 Harman Street, Forbestown, Pennsylvania, 6491", new DateTime(1966, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 21, 12, 28, 26, 257, DateTimeKind.Local).AddTicks(6115), null, null, null, "randipace@valreda.com", "Randi", "12345678921", false, null, null, "Pace", "Dolor fugiat labore do incididunt mollit deserunt aliquip ad sunt mollit sint. Sunt deserunt quis nisi do adipisicing mollit et enim eiusmod. Deserunt nisi ut cillum reprehenderit consectetur cupidatat in ex duis et.", "", 1 },
                    { new Guid("ec8dc114-6f60-43c3-aeea-22f58ce683da"), "784 Furman Street, Vaughn, Montana, 6667", new DateTime(1965, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 21, 12, 28, 26, 257, DateTimeKind.Local).AddTicks(5895), null, null, null, "tonihampton@valreda.com", "Toni", "67890123456", false, null, null, "Hampton", "Aliqua sint nulla officia esse duis eiusmod enim qui. Fugiat minim deserunt nostrud labore dolore nulla occaecat ut laboris proident pariatur consectetur. ", "", 1 },
                    { new Guid("f76415b2-b746-4f5a-92f5-f1341a2b8a60"), "167 Preston Court, Ada, Nebraska, 7066", new DateTime(1981, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 21, 12, 28, 26, 257, DateTimeKind.Local).AddTicks(6087), null, null, null, "mccarthymartin@valreda.com", "Mccarthy", "12345678918", false, null, null, "Martin", "Proident commodo veniam commodo voluptate ad nisi. Amet qui nisi reprehenderit ex elit nostrud. Eu quis aliqua laborum labore dolore elit. Non consectetur nostrud aliqua sit culpa excepteur. Nostrud culpa cillum sit ad quis aliqua anim ullamco sit nisi et duis ad cupidatat. Dolore elit ipsum consectetur cupidatat magna. Anim officia dolor magna occaecat id.", "", 1 },
                    { new Guid("f7649abe-3b7a-4b7c-baab-54db8eeb06f2"), "895 Kane Street, Hasty, Virgin Islands, 1394", new DateTime(1960, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 21, 12, 28, 26, 257, DateTimeKind.Local).AddTicks(6259), null, null, null, "rileylambert@valreda.com", "Riley", "12345678927", false, null, null, "Lambert", "Et veniam incididunt enim veniam ipsum elit id. Labore dolore incididunt voluptate adipisicing ullamco non. Esse minim ut minim cillum enim proident aliquip cupidatat aliquip esse esse elit tempor. Laborum irure magna et anim irure officia reprehenderit occaecat adipisicing amet ea elit. Culpa sunt fugiat voluptate excepteur consectetur dolore aute.", "", 1 },
                    { new Guid("ff91f806-9464-4def-bbff-3275fe9a2398"), "834 Halsey Street, Madaket, California, 7037", new DateTime(1975, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 21, 12, 28, 26, 257, DateTimeKind.Local).AddTicks(5934), null, null, null, "hopkinshuff@valreda.com", "Hopkins", "12345678904", false, null, null, "Huff", "Nulla nostrud proident qui ad ea proident aliqua do. Ea in nisi velit in labore veniam enim mollit. Fugiat mollit voluptate amet incididunt non commodo ex. Est sint occaecat sint irure non esse sit commodo minim aute Lorem excepteur.", "", 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: new Guid("01681968-7d57-49b4-8324-5111a5d64dc2"));

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: new Guid("073a57b3-d8b0-4a9d-954e-fa7571913aa7"));

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: new Guid("0b10a49a-fe82-4da8-bf49-67c8efff318e"));

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: new Guid("133a6f96-e384-4c10-bca6-ebe9ab3efbe1"));

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: new Guid("13d8cd21-0be1-48f3-ba1a-a4f0585a9c36"));

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: new Guid("1bd02da7-541e-4423-92cf-ec68b34d0803"));

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: new Guid("273754a6-d5b2-4831-828c-1bc97cf5117d"));

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: new Guid("2f4fe72c-b4a7-4087-80e1-2b7e953d9329"));

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: new Guid("4734c7b6-9c32-489e-9637-f105a7e2f537"));

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: new Guid("62894ba9-0633-45a4-88bd-8e23aa5861e6"));

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: new Guid("6961b11d-411b-4b65-88a7-120fa25b8803"));

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: new Guid("76407f51-c427-4494-8324-576aee1a8630"));

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: new Guid("7b40e419-e875-4c28-8caf-4242719cc254"));

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: new Guid("7dbaedcb-4522-4b5e-a5d0-4a47659a1f5d"));

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: new Guid("8c3bb04d-1927-43c3-a6c4-b336fe5979a2"));

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: new Guid("8c40fea6-1245-4c4c-985f-37aa09158a32"));

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: new Guid("8ef5b6b0-4f14-4b88-9f1d-def2c8bc7b99"));

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: new Guid("92d2286d-1e1c-49e9-9e4e-375d75033555"));

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: new Guid("949f7e77-068b-4e57-bce6-4451dd7a505b"));

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: new Guid("9c5e6f53-5ce3-4d72-b2ae-8f460275aca6"));

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: new Guid("9f146782-dd33-4ff5-b247-5fdab33f5226"));

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: new Guid("9fd45141-5aee-4861-8461-e038016cd3a5"));

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: new Guid("a3f51e56-03fe-496e-b418-8ddfc144e59a"));

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: new Guid("aef97e01-880b-442e-92a7-2477a34eaa64"));

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: new Guid("d536e8c9-a2e1-40eb-aef0-2c3e033a489e"));

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: new Guid("ea9c504b-c1a2-48f5-86c0-211530cbf52e"));

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: new Guid("ec8dc114-6f60-43c3-aeea-22f58ce683da"));

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: new Guid("f76415b2-b746-4f5a-92f5-f1341a2b8a60"));

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: new Guid("f7649abe-3b7a-4b7c-baab-54db8eeb06f2"));

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: new Guid("ff91f806-9464-4def-bbff-3275fe9a2398"));

            migrationBuilder.DropColumn(
                name: "CreatorUserId",
                table: "Applications");

            migrationBuilder.InsertData(
                table: "Applications",
                columns: new[] { "Id", "Address", "Birthday", "CreationTime", "DeletionTime", "DeletorUserId", "Email", "FirstName", "IdentityNumber", "IsDeleted", "LastModificationTime", "LastModifierUserId", "LastName", "Reason", "Response", "Status" },
                values: new object[,]
                {
                    { new Guid("0a245987-77c1-481e-ae31-856de02f63b3"), "167 Preston Court, Ada, Nebraska, 7066", new DateTime(1981, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 12, 31, 22, 19, 5, 992, DateTimeKind.Local).AddTicks(7776), null, null, "mccarthymartin@valreda.com", "Mccarthy", "12345678918", false, null, null, "Martin", "Proident commodo veniam commodo voluptate ad nisi. Amet qui nisi reprehenderit ex elit nostrud. Eu quis aliqua laborum labore dolore elit. Non consectetur nostrud aliqua sit culpa excepteur. Nostrud culpa cillum sit ad quis aliqua anim ullamco sit nisi et duis ad cupidatat. Dolore elit ipsum consectetur cupidatat magna. Anim officia dolor magna occaecat id.", "", 1 },
                    { new Guid("2bf7150c-328f-41dc-aee1-518c3c4c64c6"), "475 Landis Court, Coultervillle, Missouri, 2696", new DateTime(1999, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 12, 31, 22, 19, 5, 992, DateTimeKind.Local).AddTicks(7757), null, null, "francespeck@valreda.com", "Frances", "12345678915", false, null, null, "Peck", "Aliquip excepteur sint magna mollit dolor exercitation ex. Laboris aute nisi fugiat minim proident ut. In incididunt Lorem id aliquip incididunt dolor pariatur quis cupidatat elit ullamco mollit nulla. Cillum laborum laborum elit tempor. Ut consectetur aute anim Lorem.", "", 1 },
                    { new Guid("2ec934bc-f638-48de-a875-578e6bab4d5f"), "275 Landis Court, Fontanelle, Marshall Islands, 4084", new DateTime(1974, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 12, 31, 22, 19, 5, 992, DateTimeKind.Local).AddTicks(7781), null, null, "carrollcarrillo@valreda.com", "Carroll", "12345678919", false, null, null, "Carrillo", "Ipsum occaecat esse cupidatat occaecat tempor. Minim quis in laboris dolore reprehenderit in occaecat esse fugiat excepteur veniam. Voluptate fugiat ex ex pariatur non sint nostrud exercitation sunt deserunt. Tempor ipsum minim amet non laborum labore ullamco duis veniam. Fugiat voluptate anim excepteur anim veniam ut voluptate eiusmod occaecat. Anim reprehenderit magna nisi est nisi sunt non minim cupidatat quis do officia et. Magna adipisicing fugiat labore ea mollit sunt deserunt anim aliquip ea ut ad dolor in.", "", 1 },
                    { new Guid("33b1802b-6767-4531-9334-ba50d8015326"), "423 Bulwer Place, Williston, Oklahoma, 9490", new DateTime(1980, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 12, 31, 22, 19, 5, 992, DateTimeKind.Local).AddTicks(7836), null, null, "chandlerstein@valreda.com", "Chandler", "12345678929", false, null, null, "Stein", "Sint dolore voluptate ea commodo nostrud consequat duis cupidatat reprehenderit. Labore irure est cillum aute anim voluptate consectetur magna consequat elit adipisicing. Laboris occaecat magna id labore exercitation dolore voluptate in sit fugiat voluptate aute ea. Tempor cupidatat voluptate enim aliquip eu aliquip dolore non proident. Consectetur tempor pariatur magna laboris. Magna pariatur ad sit irure nostrud cupidatat culpa.", "", 1 },
                    { new Guid("431d8a2e-3e89-400b-9640-01bc75d05d29"), "784 Furman Street, Vaughn, Montana, 6667", new DateTime(1965, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 12, 31, 22, 19, 5, 992, DateTimeKind.Local).AddTicks(7646), null, null, "tonihampton@valreda.com", "Toni", "67890123456", false, null, null, "Hampton", "Aliqua sint nulla officia esse duis eiusmod enim qui. Fugiat minim deserunt nostrud labore dolore nulla occaecat ut laboris proident pariatur consectetur. ", "", 1 },
                    { new Guid("4404c389-a015-4534-91ff-65645d917a4d"), "378 Lott Avenue, Teasdale, Illinois, 1860", new DateTime(1981, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 12, 31, 22, 19, 5, 992, DateTimeKind.Local).AddTicks(7767), null, null, "mccoyclarke@valreda.com", "Mccoy", "12345678917", false, null, null, "Clarke", "Aliqua mollit sint in elit adipisicing dolore pariatur veniam ut laborum consequat. Pariatur est ipsum deserunt in. Minim labore amet est veniam occaecat sit anim. Aliqua culpa enim quis dolor nulla cupidatat. Non elit exercitation et deserunt incididunt veniam. Sit mollit esse laborum Lorem eiusmod irure cillum sint consequat minim qui minim.", "", 1 },
                    { new Guid("485391cf-7210-4ac3-8d9c-4acdb5242687"), "616 Louisa Street, Ona, Massachusetts, 2957", new DateTime(1998, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 12, 31, 22, 19, 5, 992, DateTimeKind.Local).AddTicks(7811), null, null, "josefacarpenter@valreda.com", "Josefa", "12345678925", false, null, null, "Carpenter", "Est laboris consectetur deserunt esse elit fugiat irure qui sint. Veniam minim exercitation non nisi proident eiusmod et excepteur. Deserunt cupidatat cillum duis officia quis quis proident. Id sunt non Lorem cillum ipsum id tempor aliquip amet fugiat nulla et sunt Lorem. Velit excepteur reprehenderit eu voluptate ex commodo irure consectetur ad id. Ipsum mollit ipsum in incididunt commodo. Commodo mollit do magna dolor.", "", 1 },
                    { new Guid("50fd9f39-b9c9-4a70-8c39-b5e553b7a679"), "305 Schermerhorn Street, Boykin, Minnesota, 307", new DateTime(1999, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 12, 31, 22, 19, 5, 992, DateTimeKind.Local).AddTicks(7762), null, null, "puckettoneill@valreda.com", "Puckett", "12345678916", false, null, null, "Oneill", "Tempor commodo nulla voluptate cupidatat amet magna dolor laboris occaecat incididunt. Eu velit proident laborum elit reprehenderit enim mollit occaecat excepteur in ex eu. Incididunt anim elit consequat sunt cupidatat tempor aliquip nostrud occaecat nisi et adipisicing esse nulla.", "", 1 },
                    { new Guid("5c3df945-3d17-4130-b07c-ec539649922f"), "406 Ferris Street, Kempton, Nevada, 8511", new DateTime(1989, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 12, 31, 22, 19, 5, 992, DateTimeKind.Local).AddTicks(7806), null, null, "helenaherrera@valreda.com", "Helena", "12345678924", false, null, null, "Herrera", "Ullamco cillum id nostrud ipsum esse quis velit velit est. Id est sunt enim nisi irure nulla do incididunt sint Lorem ad. Laboris nostrud sunt irure incididunt aute incididunt ipsum elit sit tempor commodo quis.", "", 1 },
                    { new Guid("624acbc2-ad81-4733-a02d-62f11a1c1531"), "460 Chauncey Street, Roosevelt, Pennsylvania, 1055", new DateTime(1976, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 12, 31, 22, 19, 5, 992, DateTimeKind.Local).AddTicks(7752), null, null, "jodiewilliams@valreda.com", "Jodie", "12345678914", false, null, null, "Williams", "Mollit ullamco fugiat reprehenderit sunt culpa. Dolore sint eiusmod ad ullamco sint consectetur dolor elit sint occaecat ipsum. Quis esse sunt Lorem irure pariatur do ullamco cillum non amet labore aliqua eu. Deserunt dolore in voluptate officia sunt eu sint adipisicing minim pariatur.", "", 1 },
                    { new Guid("6afbad22-b2e2-4f36-976d-6ef4ee2337d9"), "123 Guernsey Street, Marenisco, Montana, 2971", new DateTime(1999, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 12, 31, 22, 19, 5, 992, DateTimeKind.Local).AddTicks(7796), null, null, "candaceburton@valreda.com", "Candace", "12345678922", false, null, null, "Burton", "Eiusmod labore voluptate tempor duis deserunt laborum minim nisi minim qui reprehenderit. Ut in in mollit do irure elit ullamco est. Incididunt minim ea fugiat aute enim ipsum eu cupidatat non occaecat aliquip. Occaecat mollit adipisicing occaecat qui id esse id exercitation.", "", 1 },
                    { new Guid("6c9c1812-294b-4c9e-aefa-ebedad88f7a0"), "635 Taaffe Place, Jeff, Idaho, 9876", new DateTime(1992, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 12, 31, 22, 19, 5, 992, DateTimeKind.Local).AddTicks(7742), null, null, "perezcooke@valreda.com", "Perez", "12345678912", false, null, null, "Cooke", "Dolore cillum commodo irure in dolore irure pariatur culpa eiusmod. Aliqua velit consequat labore elit magna adipisicing laborum ipsum.Velit nostrud deserunt consequat minim culpa est. Tempor et Lorem et consequat ipsum cupidatat consectetur dolor minim id enim.", "", 1 },
                    { new Guid("6fbba405-9416-4a49-8cfa-37533a6e0d03"), "894 Osborn Street, Driftwood, Connecticut, 1546", new DateTime(2000, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 12, 31, 22, 19, 5, 992, DateTimeKind.Local).AddTicks(7714), null, null, "haynesford@valreda.com", "Haynes", "12345678908", false, null, null, "Ford", "Nostrud do aliqua magna pariatur exercitation anim labore amet magna adipisicing.Non enim eu reprehenderit proident ea reprehenderit incididunt occaecat incididunt ipsum. Ullamco nostrud ullamco ut magna mollit reprehenderit officia.", "", 1 },
                    { new Guid("76c6bfc5-ed74-4c3d-bde3-705e61b50135"), "457 Roosevelt Place, Tilleda, Florida, 5976", new DateTime(1963, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 12, 31, 22, 19, 5, 992, DateTimeKind.Local).AddTicks(7683), null, null, "erickacalderon@valreda.com", "Ericka", "12345678902", false, null, null, "Calderon", "Voluptate ut proident eiusmod ea quis velit ad ut proident nisi. Qui ex ea laboris do in ullamco eiusmod ullamco reprehenderit ea adipisicing anim nulla.", "", 1 },
                    { new Guid("854e0f55-292b-4220-ab6b-6029b6a6a4d9"), "737 Provost Street, Odessa, Kentucky, 4490", new DateTime(1992, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 12, 31, 22, 19, 5, 992, DateTimeKind.Local).AddTicks(7737), null, null, "dawsonpratt@valreda.com", "Dawson", "12345678911", false, null, null, "Pratt", "Non Lorem exercitation est proident laborum sint est id amet officia eiusmod elit eiusmod. Ullamco veniam amet sunt aliqua tempor. Non minim consequat irure consequat sint. Sit aliquip non minim ea non magna non ex culpa aliqua ipsum sunt eiusmod.", "", 1 },
                    { new Guid("85f5ec72-abde-46b7-a76a-4eb052a15f34"), "280 Clermont Avenue, Jugtown, Ohio, 7483", new DateTime(1972, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 12, 31, 22, 19, 5, 992, DateTimeKind.Local).AddTicks(7699), null, null, "averymcdonald@valreda.com", "Avery", "12345678905", false, null, null, "Mcdonald", "Nostrud ad qui deserunt elit sunt est dolor laborum nisi. Non adipisicing est dolore ut irure irure culpa aute voluptate cupidatat aliquip et.", "", 1 },
                    { new Guid("86dcd9ab-b0f0-42dc-bd95-444b8562c399"), "761 Hoyt Street, Gardiner, Iowa, 4576", new DateTime(1964, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 12, 31, 22, 19, 5, 992, DateTimeKind.Local).AddTicks(7704), null, null, "hildabarnett@valreda.com", "Hilda", "12345678906", false, null, null, "Barnett", "Pariatur aute sit excepteur id exercitation ad sit occaecat sunt eiusmod ea. Laboris ullamco laborum aliqua culpa voluptate in labore aliquip irure ea ex non commodo.", "", 1 },
                    { new Guid("8f1df738-9630-4987-ae71-59dcf0d5039e"), "767 Martense Street, Foxworth, Arizona, 3104", new DateTime(1977, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 12, 31, 22, 19, 5, 992, DateTimeKind.Local).AddTicks(7689), null, null, "mamieengland@valreda.com", "Mamie", "12345678903", false, null, null, "England", "Dolore esse ad cillum id commodo ut dolor laborum mollit mollit nisi exercitation aute ad.Quis veniam aliqua ipsum magna velit aliquip consequat id incididunt.", "", 1 },
                    { new Guid("93a92b23-33ed-4947-9011-b5e40db67346"), "221 Corbin Place, Jennings, Utah, 323", new DateTime(1969, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 12, 31, 22, 19, 5, 992, DateTimeKind.Local).AddTicks(7841), null, null, "robbiesantana@valreda.com", "Robbie", "12345678930", false, null, null, "Santana", "Eu qui cupidatat in cillum culpa deserunt amet dolor mollit aliquip. Excepteur quis ipsum exercitation non duis elit. Reprehenderit ut laboris excepteur id aliquip ullamco nisi proident consectetur ex laborum exercitation veniam. Velit eiusmod laborum officia reprehenderit nisi deserunt est labore. Id nisi dolor laboris labore ex in anim commodo aliqua. Qui fugiat amet nostrud eu est ipsum ipsum cupidatat magna.", "", 1 },
                    { new Guid("94f8472b-c963-47f6-9049-4afbcffbea00"), "124 Grattan Street, Monument, South Dakota, 5593", new DateTime(1996, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 12, 31, 22, 19, 5, 992, DateTimeKind.Local).AddTicks(7720), null, null, "tanyaboyle@valreda.com", "Tanya", "12345678909", false, null, null, "Boyle", "Laboris cupidatat tempor cupidatat eiusmod occaecat dolore commodo mollit et reprehenderit cupidatat qui elit occaecat. Amet cillum voluptate aliquip elit veniam Lorem commodo sint. Veniam velit irure esse veniam aliqua aliqua velit qui velit.", "", 1 },
                    { new Guid("c106feb3-0b1e-4f27-991a-e97e47e70d1b"), "295 Harman Street, Forbestown, Pennsylvania, 6491", new DateTime(1966, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 12, 31, 22, 19, 5, 992, DateTimeKind.Local).AddTicks(7791), null, null, "randipace@valreda.com", "Randi", "12345678921", false, null, null, "Pace", "Dolor fugiat labore do incididunt mollit deserunt aliquip ad sunt mollit sint. Sunt deserunt quis nisi do adipisicing mollit et enim eiusmod. Deserunt nisi ut cillum reprehenderit consectetur cupidatat in ex duis et.", "", 1 },
                    { new Guid("cbc605c3-37f2-4e64-9a4c-cae3534cce5e"), "202 Midwood Street, Barstow, Mississippi, 6264", new DateTime(1967, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 12, 31, 22, 19, 5, 992, DateTimeKind.Local).AddTicks(7747), null, null, "powerslynn@valreda.com", "Powers", "12345678913", false, null, null, "Lynn", "Nulla labore id commodo et quis consectetur. Nisi ipsum cupidatat cillum consequat exercitation voluptate laboris. Ex culpa cillum sit officia qui velit.", "", 1 },
                    { new Guid("cd9da98a-b94f-4923-a3d0-4455a576377a"), "870 Clark Street, Thatcher, Virginia, 775", new DateTime(1982, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 12, 31, 22, 19, 5, 992, DateTimeKind.Local).AddTicks(7709), null, null, "freemandaugherty@valreda.com", "Freeman", "12345678907", false, null, null, "Daugherty", "Excepteur sint irure nostrud eu voluptate incididunt irure minim do ullamco adipisicing irure consequat enim. Reprehenderit nulla exercitation enim elit adipisicing sunt ex ad culpa ut.", "", 1 },
                    { new Guid("db5c497a-4369-4aaa-8ab0-52b9dc6b5772"), "818 Ruby Street, Garnet, Alaska, 1235", new DateTime(1981, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 12, 31, 22, 19, 5, 992, DateTimeKind.Local).AddTicks(7731), null, null, "caradurham@valreda.com", "Cara", "12345678910", false, null, null, "Durham", "Laborum laboris consectetur aliqua laboris non. In in deserunt ut qui voluptate eiusmod. Magna irure elit eu eiusmod veniam adipisicing.", "", 1 },
                    { new Guid("de4c6936-f6fd-4b83-b385-f974ec26b709"), "329 Howard Alley, Noblestown, Northern Mariana Islands, 8023", new DateTime(1962, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 12, 31, 22, 19, 5, 992, DateTimeKind.Local).AddTicks(7830), null, null, "valentinekerr@valreda.com", "Valentine", "12345678928", false, null, null, "Kerr", "Deserunt aute labore deserunt commodo. Commodo consectetur dolore laborum dolore anim officia mollit mollit amet. Duis anim voluptate non deserunt esse eu esse ad laboris. Occaecat mollit mollit veniam officia ullamco nisi amet. Tempor laboris veniam officia enim in aliquip qui irure labore aliqua. Nostrud anim do ea mollit enim exercitation laborum commodo consectetur laboris consequat. Anim consequat cillum exercitation laborum qui proident sunt nisi excepteur qui.", "", 1 },
                    { new Guid("e1aecd54-1054-4978-9c3b-5e16f4ea3ad0"), "300 Roosevelt Court, Linganore, Arizona, 9378", new DateTime(1980, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 12, 31, 22, 19, 5, 992, DateTimeKind.Local).AddTicks(7786), null, null, "milespearson@valreda.com", "Miles", "12345678920", false, null, null, "Pearson", "Ex non quis qui nulla elit dolore anim do magna. Cupidatat non exercitation cupidatat labore sit nisi do duis. Aliqua Lorem excepteur nisi nisi aute minim.", "", 1 },
                    { new Guid("e1f648b3-f84d-49ac-a720-e0ba89cdeda1"), "779 Poly Place, Welch, Delaware, 5670", new DateTime(1991, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 12, 31, 22, 19, 5, 992, DateTimeKind.Local).AddTicks(7801), null, null, "karlalittle@valreda.com", "Karla", "12345678923", false, null, null, "Little", "Do amet Lorem laborum ad cupidatat do enim officia. In voluptate aute laborum Lorem occaecat fugiat. Aliquip id enim qui fugiat deserunt laboris dolor incididunt adipisicing officia consequat. Est nisi non ad est proident cillum nulla proident magna.", "", 1 },
                    { new Guid("f048c054-5003-4b99-ae9e-7f0a1969d35c"), "155 Hale Avenue, Alden, Oregon, 4793", new DateTime(1997, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 12, 31, 22, 19, 5, 992, DateTimeKind.Local).AddTicks(7820), null, null, "nelsonmorgan@valreda.com", "Nelson", "12345678926", false, null, null, "Morgan", "Tempor in est aliquip excepteur est. Id dolore est excepteur voluptate proident consectetur elit non ad id nostrud pariatur labore anim. Esse magna ex ut consequat exercitation est.", "", 1 },
                    { new Guid("f0c93f22-485a-42ee-a5df-a86770457fa6"), "834 Halsey Street, Madaket, California, 7037", new DateTime(1975, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 12, 31, 22, 19, 5, 992, DateTimeKind.Local).AddTicks(7694), null, null, "hopkinshuff@valreda.com", "Hopkins", "12345678904", false, null, null, "Huff", "Nulla nostrud proident qui ad ea proident aliqua do. Ea in nisi velit in labore veniam enim mollit. Fugiat mollit voluptate amet incididunt non commodo ex. Est sint occaecat sint irure non esse sit commodo minim aute Lorem excepteur.", "", 1 },
                    { new Guid("f2b0b6ae-3a12-438f-875e-5b7eafd0b0eb"), "895 Kane Street, Hasty, Virgin Islands, 1394", new DateTime(1960, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 12, 31, 22, 19, 5, 992, DateTimeKind.Local).AddTicks(7825), null, null, "rileylambert@valreda.com", "Riley", "12345678927", false, null, null, "Lambert", "Et veniam incididunt enim veniam ipsum elit id. Labore dolore incididunt voluptate adipisicing ullamco non. Esse minim ut minim cillum enim proident aliquip cupidatat aliquip esse esse elit tempor. Laborum irure magna et anim irure officia reprehenderit occaecat adipisicing amet ea elit. Culpa sunt fugiat voluptate excepteur consectetur dolore aute.", "", 1 }
                });
        }
    }
}
