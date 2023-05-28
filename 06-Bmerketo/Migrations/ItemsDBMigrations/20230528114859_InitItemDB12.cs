using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace _06_Bmerketo.Migrations.ItemsDBMigrations
{
    /// <inheritdoc />
    public partial class InitItemDB12 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Item",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageData = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Price = table.Column<decimal>(type: "money", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Item", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tags",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TagName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tags", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ItemTags",
                columns: table => new
                {
                    ItemId = table.Column<int>(type: "int", nullable: false),
                    TagId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemTags", x => new { x.ItemId, x.TagId });
                    table.ForeignKey(
                        name: "FK_ItemTags_Item_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Item",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItemTags_Tags_TagId",
                        column: x => x.TagId,
                        principalTable: "Tags",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Item",
                columns: new[] { "Id", "Description", "ImageData", "ImageUrl", "Price", "Title" },
                values: new object[,]
                {
                    { 1, "Uppdaterade Logitech Mx Master 3s – nu med 90 % tystare brytare och en skarpare 8K DPI-sensor. Med en ergonomisk design, elektromagnetisk scrollhjul i stål och snabbladdning via USB-C (1 minuts laddning ger hela 3 h användning). Ansluts via Bluetooth LE eller medföljande Logi Bolt-mottagare. Med Darkfield High Precision för användning på de flesta ytor, även glasbord. Mått: 125×84×51 mm. Vikt: 141 g.", null, "https://www.kjell.com/se/produkter/dator/datormus/tradlosa-moss/logitech-mx-master-3s-tradlos-datormus-graphite-p65123", 1290m, "Logitech Mx Master 3s Trådlös datormus Graphite" },
                    { 2, "Logitech G603 är en högpresterande, trådlös gaming-mus med optisk sensor och en upplösning på upp till 12000 DPI 400 IPS (inch per sekund). Med USB-mottagaren kan musen kommunicera med endast 1 ms latens, perfekt för snabba tryck och rörelser. Batterisparläget ger upp till 18 månaders batteritid med endast 8 ms responstid.", null, "https://www.kjell.com/se/produkter/dator/datormus/tradlosa-moss/logitech-g-603-lightspeed-tradlos-gaming-mus-p62111", 649m, "Logitech G 603 Lightspeed Trådlös gaming-mus" },
                    { 3, "Tunn musmatta med låg friktion som kan rullas ihop och tas med i väskan. Den gummibelagda undersidan gör att musmattan ligger stabilt. Tjocklek: 2 mm. Mått: 260x220 mm.", null, "https://www.kjell.com/se/produkter/dator/datormus/musmattor/plexgear-musmatta-svart-p94244", 519m, "Plexgear Musmatta Svart" },
                    { 4, "TP-link Archer AX1500 är en Wifi 6-router med stöd för upp till 1500 Mb/s i överföringshastighet. Genom att använda Wifi 6-standarden (802.11ax) kan routern ge upp till 1201 Mbps över 5 GHz-bandet. Tack vare AX-standarden kan routern utnyttja tekniken OFDMA, som ger enheter kortare fördröjningar och mer responsiv uppkoppling. Med stöd för Amazon Alexa kan routern integreras och användas tillsammans med det smarta hemmet.", null, "https://www.kjell.com/se/produkter/natverk/tradlosa-routrar/tp-link-archer-ax1500-tradlos-router-p62755", 499m, "TP-link Archer AX1500 Trådlös router" },
                    { 5, "TP-link Deco M5 är ett paket med Wireless AC-repeatrar som tillsammans kan täcka upp till 500 m² med ett enda wifi-nätverk. Ansluts direkt till fiberanslutning eller till ett befintligt modem eller router. Paket med trådlösa mesh-noder som tillsammans skapar ett heltäckande och sömlöst trådlöst nätverk. En enskild mesh-nod ger ett lättinstallerat och framtidsförberett nätverk för den lilla lägenheten.", null, "https://www.kjell.com/se/produkter/natverk/tradlosa-routrar/tp-link-deco-m5-mesh-system-ac1300-p61990", 1690m, "TP-link Deco M5 Mesh-system AC1300" },
                    { 6, "Logitech MX Keys Mini är ett kompakt och minimalistiskt tangentbord en bekväm skrivkänsla och optimal komfort. Automatisk bakgrundsbelysning aktiveras när händerna förs över tangentbordet, och funktionsknapparna låter dig göra saker som diktering, mediakontroll och skicka emojis direkt från tangentbordet. Ansluts med Bluetooth, och med enhetsväljaren kan du enkelt växla mellan upp till tre enheter – perfekt till både datorn, mobilen och surfplattan.", null, "https://www.kjell.com/se/produkter/dator/tangentbord/tradlosa-tangentbord/logitech-mx-keys-mini-tradlost-tangentbord-gra-p64975", 899m, "Logitech MX Keys Mini Trådlöst tangentbord Grå" },
                    { 7, "Logitech MX Mechanical - ett mekaniskt tangentbord med taktil känsla och precision, tack vara de mekaniska brytarna i låg profil. Utformat för en förbättrad ergonomisk hållning. De bakgrundsupplysta tangenterna justeras automatiskt efter aktuellt ljusförhållande i rummet. Med tre olika brytartyper som ger tillfredsställande feedback med varje tangentkoppling: Tactile Quiet, Linear och Clicky. Batteritid: Upp till 10 månader.", null, "https://www.kjell.com/se/produkter/dator/tangentbord/tradlosa-tangentbord/logitech-mx-mechanical-mekaniskt-tangentbord-brown-tactile-quiet-p65117", 1499m, "Logitech Mx Mechanical Mekaniskt tangentbord Brown Tactile Quiet" },
                    { 8, "Nikabe S5 är ett par passiva, stilrena utomhushögtalare som passar perfekt till altanen, poolen och uteplatsen. Utrustade med kraftiga baselement på 5,25 tum av gjuten polyprolypen som parats ihop med precisa diskanter som tillsammans levererar ett klart och kraftfullt ljud. Monteras enkelt på tak eller vägg med medföljande fäste. Ansluts till förstärkare eller receiver med lämplig högtalarkabel (säljes separat).", null, "https://www.kjell.com/se/produkter/ljud-bild/hogtalare/passiva-hogtalare/nikabe-s5-utomhushogtalare-2-pack-p90577", 799m, "Nikabe S5 Utomhushögtalare 2-pack" },
                    { 9, "Marshall Emberton är en kompakt och portabel Bluetooth-högtalare designad för äventyr. Levererar kraftfullt och färgglatt ljud med unik 360°-ljudbild från dubbla 10 W-element. Högtalaren är helt vattentålig och utrustad med ett stort batteri för att hålla musiken i gång hela dagen.", null, "https://www.kjell.com/se/produkter/ljud-bild/hogtalare/tradlosa-hogtalare/marshall-emberton-portabel-hogtalare-p23882", 1599m, "Marshall Emberton Portabel högtalare" },
                    { 10, "Plexgear SV-110 är ett lätt och bekvämt datorheadset som passar perfekt till Teams, Skype och Zoom-möten. Utrustat med brusreducerande mikrofon och headsetet ansluts till datorn via 3,5 mm-anslutning. Kabellängd: 1,4 m. Frekvensomfång: 20 Hz till 20 kHz.", null, "https://www.kjell.com/se/produkter/dator/headset-till-dator/datorheadset/plexgear-sv-110-datorheadset-p62824", 199m, "Plexgear SV-110 Datorheadset" }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "TagName" },
                values: new object[,]
                {
                    { 1, "New" },
                    { 2, "Featured" },
                    { 3, "Popular" },
                    { 4, "Sale" }
                });

            migrationBuilder.InsertData(
                table: "ItemTags",
                columns: new[] { "ItemId", "TagId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 3, 2 },
                    { 4, 2 },
                    { 5, 3 },
                    { 6, 3 },
                    { 7, 4 },
                    { 8, 4 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ItemTags_TagId",
                table: "ItemTags",
                column: "TagId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ItemTags");

            migrationBuilder.DropTable(
                name: "Item");

            migrationBuilder.DropTable(
                name: "Tags");
        }
    }
}
