﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using _06_Bmerketo.Databases;

#nullable disable

namespace _06_Bmerketo.Migrations.ItemsDBMigrations
{
    [DbContext(typeof(ItemsDB))]
    [Migration("20230528140957_InitItemDB")]
    partial class InitItemDB
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("_06_Bmerketo.Items.Models.ItemsEntites.ItemEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("Price")
                        .HasColumnType("money");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Item");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Uppdaterade Logitech Mx Master 3s – nu med 90 % tystare brytare och en skarpare 8K DPI-sensor. Med en ergonomisk design, elektromagnetisk scrollhjul i stål och snabbladdning via USB-C (1 minuts laddning ger hela 3 h användning). Ansluts via Bluetooth LE eller medföljande Logi Bolt-mottagare. Med Darkfield High Precision för användning på de flesta ytor, även glasbord. Mått: 125×84×51 mm. Vikt: 141 g.",
                            ImageUrl = "https://www.kjell.com/se/produkter/dator/datormus/tradlosa-moss/logitech-mx-master-3s-tradlos-datormus-graphite-p65123",
                            Price = 1290m,
                            Title = "Logitech Mx Master 3s Trådlös datormus Graphite"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Logitech G603 är en högpresterande, trådlös gaming-mus med optisk sensor och en upplösning på upp till 12000 DPI 400 IPS (inch per sekund). Med USB-mottagaren kan musen kommunicera med endast 1 ms latens, perfekt för snabba tryck och rörelser. Batterisparläget ger upp till 18 månaders batteritid med endast 8 ms responstid.",
                            ImageUrl = "https://www.kjell.com/se/produkter/dator/datormus/tradlosa-moss/logitech-g-603-lightspeed-tradlos-gaming-mus-p62111",
                            Price = 649m,
                            Title = "Logitech G 603 Lightspeed Trådlös gaming-mus"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Tunn musmatta med låg friktion som kan rullas ihop och tas med i väskan. Den gummibelagda undersidan gör att musmattan ligger stabilt. Tjocklek: 2 mm. Mått: 260x220 mm.",
                            ImageUrl = "https://www.kjell.com/se/produkter/dator/datormus/musmattor/plexgear-musmatta-svart-p94244",
                            Price = 519m,
                            Title = "Plexgear Musmatta Svart"
                        },
                        new
                        {
                            Id = 4,
                            Description = "TP-link Archer AX1500 är en Wifi 6-router med stöd för upp till 1500 Mb/s i överföringshastighet. Genom att använda Wifi 6-standarden (802.11ax) kan routern ge upp till 1201 Mbps över 5 GHz-bandet. Tack vare AX-standarden kan routern utnyttja tekniken OFDMA, som ger enheter kortare fördröjningar och mer responsiv uppkoppling. Med stöd för Amazon Alexa kan routern integreras och användas tillsammans med det smarta hemmet.",
                            ImageUrl = "https://www.kjell.com/se/produkter/natverk/tradlosa-routrar/tp-link-archer-ax1500-tradlos-router-p62755",
                            Price = 499m,
                            Title = "TP-link Archer AX1500 Trådlös router"
                        },
                        new
                        {
                            Id = 5,
                            Description = "TP-link Deco M5 är ett paket med Wireless AC-repeatrar som tillsammans kan täcka upp till 500 m² med ett enda wifi-nätverk. Ansluts direkt till fiberanslutning eller till ett befintligt modem eller router. Paket med trådlösa mesh-noder som tillsammans skapar ett heltäckande och sömlöst trådlöst nätverk. En enskild mesh-nod ger ett lättinstallerat och framtidsförberett nätverk för den lilla lägenheten.",
                            ImageUrl = "https://www.kjell.com/se/produkter/natverk/tradlosa-routrar/tp-link-deco-m5-mesh-system-ac1300-p61990",
                            Price = 1690m,
                            Title = "TP-link Deco M5 Mesh-system AC1300"
                        },
                        new
                        {
                            Id = 6,
                            Description = "Logitech MX Keys Mini är ett kompakt och minimalistiskt tangentbord en bekväm skrivkänsla och optimal komfort. Automatisk bakgrundsbelysning aktiveras när händerna förs över tangentbordet, och funktionsknapparna låter dig göra saker som diktering, mediakontroll och skicka emojis direkt från tangentbordet. Ansluts med Bluetooth, och med enhetsväljaren kan du enkelt växla mellan upp till tre enheter – perfekt till både datorn, mobilen och surfplattan.",
                            ImageUrl = "https://www.kjell.com/se/produkter/dator/tangentbord/tradlosa-tangentbord/logitech-mx-keys-mini-tradlost-tangentbord-gra-p64975",
                            Price = 899m,
                            Title = "Logitech MX Keys Mini Trådlöst tangentbord Grå"
                        },
                        new
                        {
                            Id = 7,
                            Description = "Logitech MX Mechanical - ett mekaniskt tangentbord med taktil känsla och precision, tack vara de mekaniska brytarna i låg profil. Utformat för en förbättrad ergonomisk hållning. De bakgrundsupplysta tangenterna justeras automatiskt efter aktuellt ljusförhållande i rummet. Med tre olika brytartyper som ger tillfredsställande feedback med varje tangentkoppling: Tactile Quiet, Linear och Clicky. Batteritid: Upp till 10 månader.",
                            ImageUrl = "https://www.kjell.com/se/produkter/dator/tangentbord/tradlosa-tangentbord/logitech-mx-mechanical-mekaniskt-tangentbord-brown-tactile-quiet-p65117",
                            Price = 1499m,
                            Title = "Logitech Mx Mechanical Mekaniskt tangentbord Brown Tactile Quiet"
                        },
                        new
                        {
                            Id = 8,
                            Description = "Nikabe S5 är ett par passiva, stilrena utomhushögtalare som passar perfekt till altanen, poolen och uteplatsen. Utrustade med kraftiga baselement på 5,25 tum av gjuten polyprolypen som parats ihop med precisa diskanter som tillsammans levererar ett klart och kraftfullt ljud. Monteras enkelt på tak eller vägg med medföljande fäste. Ansluts till förstärkare eller receiver med lämplig högtalarkabel (säljes separat).",
                            ImageUrl = "https://www.kjell.com/se/produkter/ljud-bild/hogtalare/passiva-hogtalare/nikabe-s5-utomhushogtalare-2-pack-p90577",
                            Price = 799m,
                            Title = "Nikabe S5 Utomhushögtalare 2-pack"
                        },
                        new
                        {
                            Id = 9,
                            Description = "Marshall Emberton är en kompakt och portabel Bluetooth-högtalare designad för äventyr. Levererar kraftfullt och färgglatt ljud med unik 360°-ljudbild från dubbla 10 W-element. Högtalaren är helt vattentålig och utrustad med ett stort batteri för att hålla musiken i gång hela dagen.",
                            ImageUrl = "https://www.kjell.com/se/produkter/ljud-bild/hogtalare/tradlosa-hogtalare/marshall-emberton-portabel-hogtalare-p23882",
                            Price = 1599m,
                            Title = "Marshall Emberton Portabel högtalare"
                        },
                        new
                        {
                            Id = 10,
                            Description = "Plexgear SV-110 är ett lätt och bekvämt datorheadset som passar perfekt till Teams, Skype och Zoom-möten. Utrustat med brusreducerande mikrofon och headsetet ansluts till datorn via 3,5 mm-anslutning. Kabellängd: 1,4 m. Frekvensomfång: 20 Hz till 20 kHz.",
                            ImageUrl = "https://www.kjell.com/se/produkter/dator/headset-till-dator/datorheadset/plexgear-sv-110-datorheadset-p62824",
                            Price = 199m,
                            Title = "Plexgear SV-110 Datorheadset"
                        });
                });

            modelBuilder.Entity("_06_Bmerketo.Items.Models.ItemsEntites.ItemTagEntity", b =>
                {
                    b.Property<int>("ItemId")
                        .HasColumnType("int");

                    b.Property<int>("TagId")
                        .HasColumnType("int");

                    b.HasKey("ItemId", "TagId");

                    b.HasIndex("TagId");

                    b.ToTable("ItemTags");

                    b.HasData(
                        new
                        {
                            ItemId = 1,
                            TagId = 1
                        },
                        new
                        {
                            ItemId = 2,
                            TagId = 1
                        },
                        new
                        {
                            ItemId = 3,
                            TagId = 2
                        },
                        new
                        {
                            ItemId = 4,
                            TagId = 2
                        },
                        new
                        {
                            ItemId = 5,
                            TagId = 3
                        },
                        new
                        {
                            ItemId = 6,
                            TagId = 3
                        },
                        new
                        {
                            ItemId = 7,
                            TagId = 4
                        },
                        new
                        {
                            ItemId = 8,
                            TagId = 4
                        });
                });

            modelBuilder.Entity("_06_Bmerketo.Items.Models.ItemsEntites.TagEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("TagName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tags");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            TagName = "New"
                        },
                        new
                        {
                            Id = 2,
                            TagName = "Featured"
                        },
                        new
                        {
                            Id = 3,
                            TagName = "Popular"
                        },
                        new
                        {
                            Id = 4,
                            TagName = "Sale"
                        });
                });

            modelBuilder.Entity("_06_Bmerketo.Items.Models.ItemsEntites.ItemTagEntity", b =>
                {
                    b.HasOne("_06_Bmerketo.Items.Models.ItemsEntites.ItemEntity", "Item")
                        .WithMany("ItemTags")
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_06_Bmerketo.Items.Models.ItemsEntites.TagEntity", "Tag")
                        .WithMany("ItemTags")
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Item");

                    b.Navigation("Tag");
                });

            modelBuilder.Entity("_06_Bmerketo.Items.Models.ItemsEntites.ItemEntity", b =>
                {
                    b.Navigation("ItemTags");
                });

            modelBuilder.Entity("_06_Bmerketo.Items.Models.ItemsEntites.TagEntity", b =>
                {
                    b.Navigation("ItemTags");
                });
#pragma warning restore 612, 618
        }
    }
}