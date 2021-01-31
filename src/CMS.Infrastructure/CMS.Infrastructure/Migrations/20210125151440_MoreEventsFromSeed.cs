using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CMS.Infrastructure.Migrations
{
    public partial class MoreEventsFromSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Event",
                columns: new[] { "ID", "City", "Date", "DescriptionEn", "DescriptionPl", "EventType", "Latitude", "Longitude", "NameEn", "NamePl", "Organisator", "PhotoPath", "TicketPrice" },
                values: new object[,]
                {
                    { 8, "Warszawa, Poland", new DateTime(2021, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Produced entirely by Sevdaliza together with long-time collaborator Mucky, the 15 track album is the long awaited follow-up to her critically acclaimed 2017 debut album, ‘ISON.’ ‘Shabrang’ sees Sevdaliza take back her power from years of physical and emotional turbulence, which is embodied in the black eye on the album cover. It chronicles her journey of self-discovery, self-love and finding peace amongst all of the chaos in the world serving as a catalyst for empowerment and healing through the collective consciousness. The album further cements Sevdaliza as one of today’s most essential artists as she continues to push the boundaries of sound creating a style completely unique to her lined with elements of alternative electronic, indie, trip-hop, alternative R&B and the avant-garde.                             In celebration, Sevdaliza will be doing a special performance on August 31 at the Royal Theatre in The Hague in the Netherlands that will live stream globally and serve as the only time she’ll take the stage in 2020. The show will feature an array of striking visual effects integrated into Sevdaliza’s gripping live set.", "Wyprodukowany w całości przez Sevdalizę wraz z wieloletnim współpracownikiem Mucky'm, 15-utworowy album jest długo oczekiwaną kontynuacją jej docenionego przez krytyków debiutu z 2017 roku, „ISON”. „Shabrang” pokazuje, jak Sevdaliza odzyskuje moc po latach fizycznych i emocjonalnych turbulencji, których wyrazem jest podbite oko na okładce albumu. Jest to historia jej podróży do odkrywania siebie, miłości do siebie i znajdowania pokoju pośród całego chaosu na świecie. Album dodatkowo wzmacnia pozycję Sevdalizy jako jednej z najważniejszych współczesnych artystek, która nieustannie przesuwa granice brzmienia, tworząc całkowicie unikalny dla niej styl z elementami alternatywnej elektroniki, indie, trip-hopu, alternatywnego R&B i awangardy. Aby uczcić premierę albumu, Sevdaliza zagra 31 sierpnia w Royal Theatre w Hadze w Holandii specjalny spektakl, który będzie transmitowany na żywo na całym świecie i będzie jedynym jej scenicznym występem w 2020 roku. Uderzające efekty wizualne zintegrowane będą z porywającym muzycznym występem Sevdalizy. ", 0, 52.211588m, 21.0080273m, "Sevdaliza", "Sevdaliza", "Klub Stodoła", "/images/sevdaliza.jpg", 105m },
                    { 9, "Warszawa, Poland", new DateTime(2021, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Neck Deep is a Welsh pop-punk band from Wrexham, formed in 2012. Neck Deep's career began with the publication of the song 'What Did You Expect?', which quickly gained recognition from listeners and critics. Following this, the band released two EPs: Rain in July (2012) and A History of Bad Decisions (2013), and then signed a contract with the Hopeless label. urrently, the band has released four studio albums, and the last of them, 'All Distortions Are Intentional', was released in July this year and entered the Official UK Album Chart at number four.", "Neck Deep to walijski zespół pop-punkowy z Wrexham, utworzony w 2012 roku. Kariera Neck Deep rozpoczęła się od publikacji utworu  „What Did You Expect?”, który bardzo szybko zyskał uznanie słuchaczy oraz krytyków. W ślad za tym, zespół opublikował w sieci dwie EP-ki: Rain in July (2012) and A History of Bad Decisions (2013), a następnie podpisał kontrakt z wytwórnią Hopeless. Obecnie zespół ma na koncie cztery studyjne albumy, a ostatni z nich, ,, All Distortions Are Intentional’’ został wydany w lipcu tego roku i trafił na 4 miejsce na liście sprzedaży w Wielkiej Brytanii.", 0, 52.2213831m, 20.9755266m, "Neck Deep", "Neck Deep", "Klub Proxima", "/images/neck.jpg", 115m },
                    { 10, "Warszawa, Poland", new DateTime(2021, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "WATERPARKS ogłaszają trasę 'SEE YOU IN THE FUTURE' i film koncertowy 'FANDOM: LIVE IN THE UK'!", "WATERPARKS announce the 'SEE YOU IN THE FUTURE' headline tour and the release of the 'FANDOM: LIVE IN THE UK' concert film!", 0, 52.2213831m, 20.9755266m, "Waterparks", "Waterparks", "Klub Proxima", "/images/waterparks.jpg", 79m },
                    { 11, "Lublin, Poland", new DateTime(2021, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Buy tickets for World Exhibition of Orchids, Bonsai and Succulents in Targi Lublin, Hale Targowe Expo, NETTO Arena Szczecin.", "Światowa Wystawa Orchidei, Bonsai i Sukulentów wiosną zawita do Lublina, Łodzi i Szczecina! Weź udział w kolorowej, niezwykle pachnącej przygodzie wśród tysięcy najwspanialszych kwiatów. Na zwiedzających czekają prawdziwe cuda natury oraz fenomenalne aranżacje z okazami pochodzącymi z blisko 40 państw. Światowa Wystawa Orchidei, Bonsai i Sukulentów bilety już dostępne. ", 1, 51.2349941m, 22.5628468m, "World Exhibition of Orchids, Bonsai and Succulents", "Światowa Wystawa Orchidei, Bonsai i Sukulentów", "http://swiatowawystawa.pl/", "/images/orchid.jpg", 25m },
                    { 12, "Białystok, Poland", new DateTime(2021, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Buy tickets for Festival of Whisky in Białystok in Restauracja Kawelin.", "Zapraszamy na Festiwal Whisky do Białegostoku! Święto whisky odbędzie się w Restauracji Kawelin .", 1, 53.1308333m, 23.1572557m, "Festival of Whisky in Białystok", "Festiwal Whisky Białystok ", "Restauracja Kawelin", "/images/whisky.jpg", 85m },
                    { 13, "Warszawa, Poland", new DateTime(2021, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wage War - an American metalcore band from Florida. The band includes vocalist Briton Bond, rhythm guitarist and vocalist Cody Quistad, lead guitarist Seth Blake, bassist Chris Gaylord and drummer Stephen Kluesener. Wage War released three studio albums, and the last of them titled 'Pressure' was released in 2019.Wage War previously supported such bands as August Burns Red, Chelsea Grin, I Prevail, The Amity Affliction, Northlane, Every Time I Die, For Today or Of Mice & Men", "Wage War - amerykański zespół metalcore pochodzący z Florydy. W skład zespołu wchodzą wokalista Briton Bond, gitarzysta rytmiczny i wokalista Cody Quistad, główny gitarzysta Seth Blake, basista Chris Gaylord oraz perkusista Stephen Kluesener. Wage War mają na koncie trzy albumy studyjne, a ostatni z nich zatytułowany ,,Pressure’’ został wydany w 2019 roku.", 0, 52.2592708m, 21.0346782m, "Wage War", "Wage War", "Hydrozagadka", "/images/wagewar.jpg", 89m },
                    { 14, "Łódź, Poland", new DateTime(2021, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Buy tickets for Festival of Insectivorous Plants 'Attack of the Giants' - the most exciting flower expo in the world. ", "Nadchodzi prawdziwy Atak Gigantów - Festiwal Roślin Owadożernych wiosną zawita do Polski! W programie największej na świecie żywej wystawy wyjątkowe pokazy, prelekcje, a przede wszystkim szaleństwo różnych atrakcji zarówno dla dorosłych, jak i dzieci. Wejdź do niesamowitej, magicznej krainy roślin owadożernych! Festiwal Roślin Owadożernych Atak Gigantów bilety już w sprzedaży.", 0, 51.7635352m, 19.457063m, "Festival of Insectivorous Plants 'Attack of the Giants'", "Festiwal Roślin Owadożernych 'Atak Gigantów'", "Arena Expo", "/images/owady.png", 15m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "ID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "ID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "ID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "ID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "ID",
                keyValue: 14);
        }
    }
}
