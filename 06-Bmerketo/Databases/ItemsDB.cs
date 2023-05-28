using _06_Bmerketo.Items.Models.ItemsEntites;
using Microsoft.EntityFrameworkCore;


namespace _06_Bmerketo.Databases
{
	public class ItemsDB : DbContext
	{
        #region EtitySet & option DB
        public ItemsDB(DbContextOptions<ItemsDB> options)
            : base(options)
        { }

        public DbSet<ItemEntity> Item { get; set; }
        public DbSet<TagEntity> Tags { get; set; }
        public DbSet<ItemTagEntity> ItemTags { get; set; }
        #endregion
        protected override void OnModelCreating(ModelBuilder builder)
		{
			builder.Entity<TagEntity>().HasData(

			new TagEntity { Id = 1, TagName = "New" },
			new TagEntity { Id = 2, TagName = "Featured" },
			new TagEntity { Id = 3, TagName = "Popular" },
			new TagEntity { Id = 4, TagName = "Sale" }
			);

			builder.Entity<ItemEntity>().HasData(
			new ItemEntity { Id = 1, Title = "Logitech Mx Master 3s Trådlös datormus Graphite", Price = 1290,ImageUrl = "https://www.kjell.com/se/produkter/dator/datormus/tradlosa-moss/logitech-mx-master-3s-tradlos-datormus-graphite-p65123", Description = "Uppdaterade Logitech Mx Master 3s – nu med 90 % tystare brytare och en skarpare 8K DPI-sensor. Med en ergonomisk design, elektromagnetisk scrollhjul i stål och snabbladdning via USB-C (1 minuts laddning ger hela 3 h användning). Ansluts via Bluetooth LE eller medföljande Logi Bolt-mottagare. Med Darkfield High Precision för användning på de flesta ytor, även glasbord. Mått: 125×84×51 mm. Vikt: 141 g." },
			new ItemEntity { Id = 2, Title = "Logitech G 603 Lightspeed Trådlös gaming-mus", Price = 649, ImageUrl = "https://www.kjell.com/se/produkter/dator/datormus/tradlosa-moss/logitech-g-603-lightspeed-tradlos-gaming-mus-p62111", Description = "Logitech G603 är en högpresterande, trådlös gaming-mus med optisk sensor och en upplösning på upp till 12000 DPI 400 IPS (inch per sekund). Med USB-mottagaren kan musen kommunicera med endast 1 ms latens, perfekt för snabba tryck och rörelser. Batterisparläget ger upp till 18 månaders batteritid med endast 8 ms responstid." },
			new ItemEntity { Id = 3, Title = "Plexgear Musmatta Svart", Price = 519, ImageUrl = "https://www.kjell.com/se/produkter/dator/datormus/musmattor/plexgear-musmatta-svart-p94244", Description = "Tunn musmatta med låg friktion som kan rullas ihop och tas med i väskan. Den gummibelagda undersidan gör att musmattan ligger stabilt. Tjocklek: 2 mm. Mått: 260x220 mm." },
			new ItemEntity { Id = 4, Title = "TP-link Archer AX1500 Trådlös router", Price = 499, ImageUrl = "https://www.kjell.com/se/produkter/natverk/tradlosa-routrar/tp-link-archer-ax1500-tradlos-router-p62755", Description = "TP-link Archer AX1500 är en Wifi 6-router med stöd för upp till 1500 Mb/s i överföringshastighet. Genom att använda Wifi 6-standarden (802.11ax) kan routern ge upp till 1201 Mbps över 5 GHz-bandet. Tack vare AX-standarden kan routern utnyttja tekniken OFDMA, som ger enheter kortare fördröjningar och mer responsiv uppkoppling. Med stöd för Amazon Alexa kan routern integreras och användas tillsammans med det smarta hemmet." },
			new ItemEntity { Id = 5, Title = "TP-link Deco M5 Mesh-system AC1300", Price = 1690, ImageUrl = "https://www.kjell.com/se/produkter/natverk/tradlosa-routrar/tp-link-deco-m5-mesh-system-ac1300-p61990", Description = "TP-link Deco M5 är ett paket med Wireless AC-repeatrar som tillsammans kan täcka upp till 500 m² med ett enda wifi-nätverk. Ansluts direkt till fiberanslutning eller till ett befintligt modem eller router. Paket med trådlösa mesh-noder som tillsammans skapar ett heltäckande och sömlöst trådlöst nätverk. En enskild mesh-nod ger ett lättinstallerat och framtidsförberett nätverk för den lilla lägenheten." },
			new ItemEntity { Id = 6, Title = "Logitech MX Keys Mini Trådlöst tangentbord Grå", Price = 899, ImageUrl = "https://www.kjell.com/se/produkter/dator/tangentbord/tradlosa-tangentbord/logitech-mx-keys-mini-tradlost-tangentbord-gra-p64975", Description = "Logitech MX Keys Mini är ett kompakt och minimalistiskt tangentbord en bekväm skrivkänsla och optimal komfort. Automatisk bakgrundsbelysning aktiveras när händerna förs över tangentbordet, och funktionsknapparna låter dig göra saker som diktering, mediakontroll och skicka emojis direkt från tangentbordet. Ansluts med Bluetooth, och med enhetsväljaren kan du enkelt växla mellan upp till tre enheter – perfekt till både datorn, mobilen och surfplattan." },
			new ItemEntity { Id = 7, Title = "Logitech Mx Mechanical Mekaniskt tangentbord Brown Tactile Quiet", Price = 1499, ImageUrl = "https://www.kjell.com/se/produkter/dator/tangentbord/tradlosa-tangentbord/logitech-mx-mechanical-mekaniskt-tangentbord-brown-tactile-quiet-p65117", Description = "Logitech MX Mechanical - ett mekaniskt tangentbord med taktil känsla och precision, tack vara de mekaniska brytarna i låg profil. Utformat för en förbättrad ergonomisk hållning. De bakgrundsupplysta tangenterna justeras automatiskt efter aktuellt ljusförhållande i rummet. Med tre olika brytartyper som ger tillfredsställande feedback med varje tangentkoppling: Tactile Quiet, Linear och Clicky. Batteritid: Upp till 10 månader." },
			new ItemEntity { Id = 8, Title = "Nikabe S5 Utomhushögtalare 2-pack", Price = 799, ImageUrl = "https://www.kjell.com/se/produkter/ljud-bild/hogtalare/passiva-hogtalare/nikabe-s5-utomhushogtalare-2-pack-p90577", Description = "Nikabe S5 är ett par passiva, stilrena utomhushögtalare som passar perfekt till altanen, poolen och uteplatsen. Utrustade med kraftiga baselement på 5,25 tum av gjuten polyprolypen som parats ihop med precisa diskanter som tillsammans levererar ett klart och kraftfullt ljud. Monteras enkelt på tak eller vägg med medföljande fäste. Ansluts till förstärkare eller receiver med lämplig högtalarkabel (säljes separat)." },
			new ItemEntity { Id = 9, Title = "Marshall Emberton Portabel högtalare", Price = 1599, ImageUrl = "https://www.kjell.com/se/produkter/ljud-bild/hogtalare/tradlosa-hogtalare/marshall-emberton-portabel-hogtalare-p23882", Description = "Marshall Emberton är en kompakt och portabel Bluetooth-högtalare designad för äventyr. Levererar kraftfullt och färgglatt ljud med unik 360°-ljudbild från dubbla 10 W-element. Högtalaren är helt vattentålig och utrustad med ett stort batteri för att hålla musiken i gång hela dagen." },
			new ItemEntity { Id = 10, Title = "Plexgear SV-110 Datorheadset", Price = 199, ImageUrl = "https://www.kjell.com/se/produkter/dator/headset-till-dator/datorheadset/plexgear-sv-110-datorheadset-p62824", Description = "Plexgear SV-110 är ett lätt och bekvämt datorheadset som passar perfekt till Teams, Skype och Zoom-möten. Utrustat med brusreducerande mikrofon och headsetet ansluts till datorn via 3,5 mm-anslutning. Kabellängd: 1,4 m. Frekvensomfång: 20 Hz till 20 kHz." }
			);

			builder.Entity<ItemTagEntity>().HasData(
			new ItemTagEntity { ItemId = 1, TagId = 1 },
			new ItemTagEntity { ItemId = 2, TagId = 1 },
			new ItemTagEntity { ItemId = 3, TagId = 2 },
			new ItemTagEntity { ItemId = 4, TagId = 2 },
			new ItemTagEntity { ItemId = 5, TagId = 3 },
			new ItemTagEntity { ItemId = 6, TagId = 3 },
			new ItemTagEntity { ItemId = 7, TagId = 4 },
			new ItemTagEntity { ItemId = 8, TagId = 4 }
			);
		}
	}
}
