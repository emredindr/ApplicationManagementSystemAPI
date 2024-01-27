using ApplicationManagementSystem.Core.Constants;
using ApplicationManagementSystem.Core.DbModels;
using ApplicationManagementSystem.Core.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace ApplicationManagementSystem.DataAccess.EntityFrameworkCore.Configurations;

public class ApplicationConfiguration : IEntityTypeConfiguration<Application>
{
    public void Configure(EntityTypeBuilder<Application> builder)
    {
        builder.HasKey(_application => _application.Id);

        builder.Property(_application => _application.Id)
         .HasColumnOrder(0);

        builder.Property(_application => _application.FirstName)
            .HasColumnOrder(1)
            .IsRequired();

        builder.Property(_application => _application.LastName)
           .HasColumnOrder(2)
           .IsRequired();

        builder.Property(_application => _application.Email)
           .HasColumnOrder(3);

        builder.Property(_application => _application.Birthday)
            .IsRequired()
            .HasColumnOrder(4);

        builder.Property(_application => _application.IdentityNumber)
            .HasColumnOrder(5);

        builder.Property(_application => _application.Reason)
            .HasDefaultValue(string.Empty)
            .HasColumnOrder(6);

        builder.Property(_application => _application.Address)
           .HasColumnOrder(7);

        builder.Property(_application => _application.Status)
            .HasDefaultValue(ApplicationStatus.Pending)
        .HasColumnOrder(8);

        builder.Property(_application => _application.Response)
            .HasColumnOrder(9);

        builder.Property(_application => _application.CreatorUserId).
            HasColumnOrder(10);

        builder.Property(_application => _application.CreationTime).
            HasColumnOrder(11);

        builder.Property(_application => _application.LastModifierUserId).
            HasColumnOrder(12);

        builder.Property(_application => _application.LastModifierUserId).
            HasColumnOrder(13);

        builder.Property(_application => _application.DeletorUserId).
            HasColumnOrder(14);

        builder.Property(_application => _application.DeletionTime).
           HasColumnOrder(15);

        builder.Property(_application => _application.IsDeleted)
            .HasColumnOrder(16);

        builder.HasData(
         new Application
         {
             Id = Guid.NewGuid(),
             FirstName = "Toni",
             LastName = "Hampton",
             Email = "tonihampton@valreda.com",
             Address = "784 Furman Street, Vaughn, Montana, 6667",
             Reason = "Aliqua sint nulla officia esse duis eiusmod enim qui. Fugiat minim deserunt nostrud labore dolore nulla occaecat ut laboris proident pariatur consectetur. ",
             Birthday = new DateTime(1965, 12, 25),
             IdentityNumber = "67890123456",
             CreationTime = DateTime.Now,

         },
         new Application
         {
             Id = Guid.NewGuid(),
             FirstName = "Ericka",
             LastName = "Calderon",
             Email = "erickacalderon@valreda.com",
             Address = "457 Roosevelt Place, Tilleda, Florida, 5976",
             Reason = "Voluptate ut proident eiusmod ea quis velit ad ut proident nisi. Qui ex ea laboris do in ullamco eiusmod ullamco reprehenderit ea adipisicing anim nulla.",
             Birthday = new DateTime(1963, 12, 25),
             IdentityNumber = "12345678902",
             CreationTime = DateTime.Now,
         },
         new Application
         {
             Id = Guid.NewGuid(),
             FirstName = "Mamie",
             LastName = "England",
             Email = "mamieengland@valreda.com",
             Address = "767 Martense Street, Foxworth, Arizona, 3104",
             Reason = "Dolore esse ad cillum id commodo ut dolor laborum mollit mollit nisi exercitation aute ad.Quis veniam aliqua ipsum magna velit aliquip consequat id incididunt.",
             Birthday = new DateTime(1977, 10, 25),
             IdentityNumber = "12345678903",
             CreationTime = DateTime.Now,
         },
         new Application
         {
             Id = Guid.NewGuid(),
             FirstName = "Hopkins",
             LastName = "Huff",
             Email = "hopkinshuff@valreda.com",
             Address = "834 Halsey Street, Madaket, California, 7037",
             Reason = "Nulla nostrud proident qui ad ea proident aliqua do. Ea in nisi velit in labore veniam enim mollit. Fugiat mollit voluptate amet incididunt non commodo ex. Est sint occaecat sint irure non esse sit commodo minim aute Lorem excepteur.",
             Birthday = new DateTime(1975, 5, 21),
             IdentityNumber = "12345678904",
             CreationTime = DateTime.Now,
         },
         new Application
         {
             Id = Guid.NewGuid(),
             FirstName = "Avery",
             LastName = "Mcdonald",
             Email = "averymcdonald@valreda.com",
             Address = "280 Clermont Avenue, Jugtown, Ohio, 7483",
             Reason = "Nostrud ad qui deserunt elit sunt est dolor laborum nisi. Non adipisicing est dolore ut irure irure culpa aute voluptate cupidatat aliquip et.",
             Birthday = new DateTime(1972, 4, 11),
             IdentityNumber = "12345678905",
             CreationTime = DateTime.Now,
         },
         new Application
         {
             Id = Guid.NewGuid(),
             FirstName = "Hilda",
             LastName = "Barnett",
             Email = "hildabarnett@valreda.com",
             Address = "761 Hoyt Street, Gardiner, Iowa, 4576",
             Reason = "Pariatur aute sit excepteur id exercitation ad sit occaecat sunt eiusmod ea. Laboris ullamco laborum aliqua culpa voluptate in labore aliquip irure ea ex non commodo.",
             Birthday = new DateTime(1964, 8, 3),
             IdentityNumber = "12345678906",
             CreationTime = DateTime.Now,
         }, new Application
         {
             Id = Guid.NewGuid(),
             FirstName = "Freeman",
             LastName = "Daugherty",
             Email = "freemandaugherty@valreda.com",
             Address = "870 Clark Street, Thatcher, Virginia, 775",
             Reason = "Excepteur sint irure nostrud eu voluptate incididunt irure minim do ullamco adipisicing irure consequat enim. Reprehenderit nulla exercitation enim elit adipisicing sunt ex ad culpa ut.",
             Birthday = new DateTime(1982, 4, 18),
             IdentityNumber = "12345678907",
             CreationTime = DateTime.Now,
         },

         new Application
         {
             Id = Guid.NewGuid(),
             FirstName = "Haynes",
             LastName = "Ford",
             Email = "haynesford@valreda.com",
             Address = "894 Osborn Street, Driftwood, Connecticut, 1546",
             Reason = "Nostrud do aliqua magna pariatur exercitation anim labore amet magna adipisicing.Non enim eu reprehenderit proident ea reprehenderit incididunt occaecat incididunt ipsum. Ullamco nostrud ullamco ut magna mollit reprehenderit officia.",
             Birthday = new DateTime(2000, 11, 20),
             IdentityNumber = "12345678908",
             CreationTime = DateTime.Now,
         },
         new Application
         {
             Id = Guid.NewGuid(),
             FirstName = "Tanya",
             LastName = "Boyle",
             Email = "tanyaboyle@valreda.com",
             Address = "124 Grattan Street, Monument, South Dakota, 5593",
             Reason = "Laboris cupidatat tempor cupidatat eiusmod occaecat dolore commodo mollit et reprehenderit cupidatat qui elit occaecat. Amet cillum voluptate aliquip elit veniam Lorem commodo sint. Veniam velit irure esse veniam aliqua aliqua velit qui velit.",
             Birthday = new DateTime(1996, 04, 18),
             IdentityNumber = "12345678909",
             CreationTime = DateTime.Now,
         },
         new Application
         {
             Id = Guid.NewGuid(),
             FirstName = "Cara",
             LastName = "Durham",
             Email = "caradurham@valreda.com",
             Address = "818 Ruby Street, Garnet, Alaska, 1235",
             Reason = "Laborum laboris consectetur aliqua laboris non. In in deserunt ut qui voluptate eiusmod. Magna irure elit eu eiusmod veniam adipisicing.",
             Birthday = new DateTime(1981, 07, 12),
             IdentityNumber = "12345678910",
             CreationTime = DateTime.Now,
         },
         new Application
         {
             Id = Guid.NewGuid(),
             FirstName = "Dawson",
             LastName = "Pratt",
             Email = "dawsonpratt@valreda.com",
             Address = "737 Provost Street, Odessa, Kentucky, 4490",
             Reason = "Non Lorem exercitation est proident laborum sint est id amet officia eiusmod elit eiusmod. Ullamco veniam amet sunt aliqua tempor. Non minim consequat irure consequat sint. Sit aliquip non minim ea non magna non ex culpa aliqua ipsum sunt eiusmod.",
             Birthday = new DateTime(1992, 09, 16),
             IdentityNumber = "12345678911",
             CreationTime = DateTime.Now,
         },
         new Application
         {
             Id = Guid.NewGuid(),
             FirstName = "Perez",
             LastName = "Cooke",
             Email = "perezcooke@valreda.com",
             Address = "635 Taaffe Place, Jeff, Idaho, 9876",
             Reason = "Dolore cillum commodo irure in dolore irure pariatur culpa eiusmod. Aliqua velit consequat labore elit magna adipisicing laborum ipsum.Velit nostrud deserunt consequat minim culpa est. Tempor et Lorem et consequat ipsum cupidatat consectetur dolor minim id enim.",
             Birthday = new DateTime(1992, 03, 09),
             IdentityNumber = "12345678912",
             CreationTime = DateTime.Now,
         },
         new Application
         {
             Id = Guid.NewGuid(),
             FirstName = "Powers",
             LastName = "Lynn",
             Email = "powerslynn@valreda.com",
             Address = "202 Midwood Street, Barstow, Mississippi, 6264",
             Reason = "Nulla labore id commodo et quis consectetur. Nisi ipsum cupidatat cillum consequat exercitation voluptate laboris. Ex culpa cillum sit officia qui velit.",
             Birthday = new DateTime(1967, 04, 09),
             IdentityNumber = "12345678913",
             CreationTime = DateTime.Now,
         },
         new Application
         {
             Id = Guid.NewGuid(),
             FirstName = "Jodie",
             LastName = "Williams",
             Email = "jodiewilliams@valreda.com",
             Address = "460 Chauncey Street, Roosevelt, Pennsylvania, 1055",
             Reason = "Mollit ullamco fugiat reprehenderit sunt culpa. Dolore sint eiusmod ad ullamco sint consectetur dolor elit sint occaecat ipsum. Quis esse sunt Lorem irure pariatur do ullamco cillum non amet labore aliqua eu. Deserunt dolore in voluptate officia sunt eu sint adipisicing minim pariatur.",
             Birthday = new DateTime(1976, 11, 07),
             IdentityNumber = "12345678914",
             CreationTime = DateTime.Now,
         },
         new Application
         {
             Id = Guid.NewGuid(),
             FirstName = "Frances",
             LastName = "Peck",
             Email = "francespeck@valreda.com",
             Address = "475 Landis Court, Coultervillle, Missouri, 2696",
             Reason = "Aliquip excepteur sint magna mollit dolor exercitation ex. Laboris aute nisi fugiat minim proident ut. In incididunt Lorem id aliquip incididunt dolor pariatur quis cupidatat elit ullamco mollit nulla. Cillum laborum laborum elit tempor. Ut consectetur aute anim Lorem.",
             Birthday = new DateTime(1999, 02, 13),
             IdentityNumber = "12345678915",
             CreationTime = DateTime.Now,
         },

         new Application
         {
             Id = Guid.NewGuid(),
             FirstName = "Puckett",
             LastName = "Oneill",
             Email = "puckettoneill@valreda.com",
             Address = "305 Schermerhorn Street, Boykin, Minnesota, 307",
             Reason = "Tempor commodo nulla voluptate cupidatat amet magna dolor laboris occaecat incididunt. Eu velit proident laborum elit reprehenderit enim mollit occaecat excepteur in ex eu. Incididunt anim elit consequat sunt cupidatat tempor aliquip nostrud occaecat nisi et adipisicing esse nulla.",
             Birthday = new DateTime(1999, 09, 07),
             IdentityNumber = "12345678916",
             CreationTime = DateTime.Now,
         },
         new Application
         {
             Id = Guid.NewGuid(),
             FirstName = "Mccoy",
             LastName = "Clarke",
             Email = "mccoyclarke@valreda.com",
             Address = "378 Lott Avenue, Teasdale, Illinois, 1860",
             Reason = "Aliqua mollit sint in elit adipisicing dolore pariatur veniam ut laborum consequat. Pariatur est ipsum deserunt in. Minim labore amet est veniam occaecat sit anim. Aliqua culpa enim quis dolor nulla cupidatat. Non elit exercitation et deserunt incididunt veniam. Sit mollit esse laborum Lorem eiusmod irure cillum sint consequat minim qui minim.",
             Birthday = new DateTime(1981, 02, 20),
             IdentityNumber = "12345678917",
             CreationTime = DateTime.Now,
         }
         ,
         new Application
         {
             Id = Guid.NewGuid(),
             FirstName = "Mccarthy",
             LastName = "Martin",
             Email = "mccarthymartin@valreda.com",
             Address = "167 Preston Court, Ada, Nebraska, 7066",
             Reason = "Proident commodo veniam commodo voluptate ad nisi. Amet qui nisi reprehenderit ex elit nostrud. Eu quis aliqua laborum labore dolore elit. Non consectetur nostrud aliqua sit culpa excepteur. Nostrud culpa cillum sit ad quis aliqua anim ullamco sit nisi et duis ad cupidatat. Dolore elit ipsum consectetur cupidatat magna. Anim officia dolor magna occaecat id.",
             Birthday = new DateTime(1981, 07, 04),
             IdentityNumber = "12345678918",
             CreationTime = DateTime.Now,
         },
         new Application
         {
             Id = Guid.NewGuid(),
             FirstName = "Carroll",
             LastName = "Carrillo",
             Email = "carrollcarrillo@valreda.com",
             Address = "275 Landis Court, Fontanelle, Marshall Islands, 4084",
             Reason = "Ipsum occaecat esse cupidatat occaecat tempor. Minim quis in laboris dolore reprehenderit in occaecat esse fugiat excepteur veniam. Voluptate fugiat ex ex pariatur non sint nostrud exercitation sunt deserunt. Tempor ipsum minim amet non laborum labore ullamco duis veniam. Fugiat voluptate anim excepteur anim veniam ut voluptate eiusmod occaecat. Anim reprehenderit magna nisi est nisi sunt non minim cupidatat quis do officia et. Magna adipisicing fugiat labore ea mollit sunt deserunt anim aliquip ea ut ad dolor in.",
             Birthday = new DateTime(1974, 06, 24),
             IdentityNumber = "12345678919",
             CreationTime = DateTime.Now,
         },
         new Application
         {
             Id = Guid.NewGuid(),
             FirstName = "Miles",
             LastName = "Pearson",
             Email = "milespearson@valreda.com",
             Address = "300 Roosevelt Court, Linganore, Arizona, 9378",
             Reason = "Ex non quis qui nulla elit dolore anim do magna. Cupidatat non exercitation cupidatat labore sit nisi do duis. Aliqua Lorem excepteur nisi nisi aute minim.",
             Birthday = new DateTime(1980, 08, 13),
             IdentityNumber = "12345678920",
             CreationTime = DateTime.Now,
         },
         new Application
         {
             Id = Guid.NewGuid(),
             FirstName = "Randi",
             LastName = "Pace",
             Email = "randipace@valreda.com",
             Address = "295 Harman Street, Forbestown, Pennsylvania, 6491",
             Reason = "Dolor fugiat labore do incididunt mollit deserunt aliquip ad sunt mollit sint. Sunt deserunt quis nisi do adipisicing mollit et enim eiusmod. Deserunt nisi ut cillum reprehenderit consectetur cupidatat in ex duis et.",
             Birthday = new DateTime(1966, 11, 09),
             IdentityNumber = "12345678921",
             CreationTime = DateTime.Now,
         },
         new Application
         {
             Id = Guid.NewGuid(),
             FirstName = "Candace",
             LastName = "Burton",
             Email = "candaceburton@valreda.com",
             Address = "123 Guernsey Street, Marenisco, Montana, 2971",
             Reason = "Eiusmod labore voluptate tempor duis deserunt laborum minim nisi minim qui reprehenderit. Ut in in mollit do irure elit ullamco est. Incididunt minim ea fugiat aute enim ipsum eu cupidatat non occaecat aliquip. Occaecat mollit adipisicing occaecat qui id esse id exercitation.",
             Birthday = new DateTime(1999, 02, 06),
             IdentityNumber = "12345678922",
             CreationTime = DateTime.Now,
         },
         new Application
         {
             Id = Guid.NewGuid(),
             FirstName = "Karla",
             LastName = "Little",
             Email = "karlalittle@valreda.com",
             Address = "779 Poly Place, Welch, Delaware, 5670",
             Reason = "Do amet Lorem laborum ad cupidatat do enim officia. In voluptate aute laborum Lorem occaecat fugiat. Aliquip id enim qui fugiat deserunt laboris dolor incididunt adipisicing officia consequat. Est nisi non ad est proident cillum nulla proident magna.",
             Birthday = new DateTime(1991, 03, 25),
             IdentityNumber = "12345678923",
             CreationTime = DateTime.Now,
         },
         new Application
         {
             Id = Guid.NewGuid(),
             FirstName = "Helena",
             LastName = "Herrera",
             Email = "helenaherrera@valreda.com",
             Address = "406 Ferris Street, Kempton, Nevada, 8511",
             Reason = "Ullamco cillum id nostrud ipsum esse quis velit velit est. Id est sunt enim nisi irure nulla do incididunt sint Lorem ad. Laboris nostrud sunt irure incididunt aute incididunt ipsum elit sit tempor commodo quis.",
             Birthday = new DateTime(1989, 01, 02),
             IdentityNumber = "12345678924",
             CreationTime = DateTime.Now,
         },
         new Application
         {
             Id = Guid.NewGuid(),
             FirstName = "Josefa",
             LastName = "Carpenter",
             Email = "josefacarpenter@valreda.com",
             Address = "616 Louisa Street, Ona, Massachusetts, 2957",
             Reason = "Est laboris consectetur deserunt esse elit fugiat irure qui sint. Veniam minim exercitation non nisi proident eiusmod et excepteur. Deserunt cupidatat cillum duis officia quis quis proident. Id sunt non Lorem cillum ipsum id tempor aliquip amet fugiat nulla et sunt Lorem. Velit excepteur reprehenderit eu voluptate ex commodo irure consectetur ad id. Ipsum mollit ipsum in incididunt commodo. Commodo mollit do magna dolor.",
             Birthday = new DateTime(1998, 09, 08),
             IdentityNumber = "12345678925",
             CreationTime = DateTime.Now,
         },
         new Application
         {
             Id = Guid.NewGuid(),
             FirstName = "Nelson",
             LastName = "Morgan",
             Email = "nelsonmorgan@valreda.com",
             Address = "155 Hale Avenue, Alden, Oregon, 4793",
             Reason = "Tempor in est aliquip excepteur est. Id dolore est excepteur voluptate proident consectetur elit non ad id nostrud pariatur labore anim. Esse magna ex ut consequat exercitation est.",
             Birthday = new DateTime(1997, 12, 27),
             IdentityNumber = "12345678926",
             CreationTime = DateTime.Now,
         },
         new Application
         {
             Id = Guid.NewGuid(),
             FirstName = "Riley",
             LastName = "Lambert",
             Email = "rileylambert@valreda.com",
             Address = "895 Kane Street, Hasty, Virgin Islands, 1394",
             Reason = "Et veniam incididunt enim veniam ipsum elit id. Labore dolore incididunt voluptate adipisicing ullamco non. Esse minim ut minim cillum enim proident aliquip cupidatat aliquip esse esse elit tempor. Laborum irure magna et anim irure officia reprehenderit occaecat adipisicing amet ea elit. Culpa sunt fugiat voluptate excepteur consectetur dolore aute.",
             Birthday = new DateTime(1960, 8, 9),
             IdentityNumber = "12345678927",
             CreationTime = DateTime.Now,
         },
         new Application
         {
             Id = Guid.NewGuid(),
             FirstName = "Valentine",
             LastName = "Kerr",
             Email = "valentinekerr@valreda.com",
             Address = "329 Howard Alley, Noblestown, Northern Mariana Islands, 8023",
             Reason = "Deserunt aute labore deserunt commodo. Commodo consectetur dolore laborum dolore anim officia mollit mollit amet. Duis anim voluptate non deserunt esse eu esse ad laboris. Occaecat mollit mollit veniam officia ullamco nisi amet. Tempor laboris veniam officia enim in aliquip qui irure labore aliqua. Nostrud anim do ea mollit enim exercitation laborum commodo consectetur laboris consequat. Anim consequat cillum exercitation laborum qui proident sunt nisi excepteur qui.",
             Birthday = new DateTime(1962, 4, 18),
             IdentityNumber = "12345678928",
             CreationTime = DateTime.Now,
         },
         new Application
         {
             Id = Guid.NewGuid(),
             FirstName = "Chandler",
             LastName = "Stein",
             Email = "chandlerstein@valreda.com",
             Address = "423 Bulwer Place, Williston, Oklahoma, 9490",
             Reason = "Sint dolore voluptate ea commodo nostrud consequat duis cupidatat reprehenderit. Labore irure est cillum aute anim voluptate consectetur magna consequat elit adipisicing. Laboris occaecat magna id labore exercitation dolore voluptate in sit fugiat voluptate aute ea. Tempor cupidatat voluptate enim aliquip eu aliquip dolore non proident. Consectetur tempor pariatur magna laboris. Magna pariatur ad sit irure nostrud cupidatat culpa.",
             Birthday = new DateTime(1980, 11, 27),
             IdentityNumber = "12345678929",
             CreationTime = DateTime.Now,
         },
         new Application
         {
             Id = Guid.NewGuid(),
             FirstName = "Robbie",
             LastName = "Santana",
             Email = "robbiesantana@valreda.com",
             Address = "221 Corbin Place, Jennings, Utah, 323",
             Reason = "Eu qui cupidatat in cillum culpa deserunt amet dolor mollit aliquip. Excepteur quis ipsum exercitation non duis elit. Reprehenderit ut laboris excepteur id aliquip ullamco nisi proident consectetur ex laborum exercitation veniam. Velit eiusmod laborum officia reprehenderit nisi deserunt est labore. Id nisi dolor laboris labore ex in anim commodo aliqua. Qui fugiat amet nostrud eu est ipsum ipsum cupidatat magna.",
             Birthday = new DateTime(1969, 06, 06),
             IdentityNumber = "12345678930",
             CreationTime = DateTime.Now,
         }

     );
    }
}
