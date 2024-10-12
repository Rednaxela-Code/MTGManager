﻿// <auto-generated />
using System;
using MTGManager.DataAccess.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MTGManager.DataAccess.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20241012161244_WorkingModel")]
    partial class WorkingModel
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MTGManager.Shared.Models.ImageUris", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ArtCrop")
                        .HasColumnType("nvarchar(max)")
                        .HasAnnotation("Relational:JsonPropertyName", "art_crop");

                    b.Property<string>("BorderCrop")
                        .HasColumnType("nvarchar(max)")
                        .HasAnnotation("Relational:JsonPropertyName", "border_crop");

                    b.Property<string>("Large")
                        .HasColumnType("nvarchar(max)")
                        .HasAnnotation("Relational:JsonPropertyName", "large");

                    b.Property<string>("Normal")
                        .HasColumnType("nvarchar(max)")
                        .HasAnnotation("Relational:JsonPropertyName", "normal");

                    b.Property<string>("Png")
                        .HasColumnType("nvarchar(max)")
                        .HasAnnotation("Relational:JsonPropertyName", "png");

                    b.Property<string>("Small")
                        .HasColumnType("nvarchar(max)")
                        .HasAnnotation("Relational:JsonPropertyName", "small");

                    b.HasKey("Id");

                    b.ToTable("ImageUris");

                    b.HasAnnotation("Relational:JsonPropertyName", "image_uris");
                });

            modelBuilder.Entity("MTGManager.Shared.Models.Legalities", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Commander")
                        .HasColumnType("nvarchar(max)")
                        .HasAnnotation("Relational:JsonPropertyName", "commander");

                    b.Property<string>("Duel")
                        .HasColumnType("nvarchar(max)")
                        .HasAnnotation("Relational:JsonPropertyName", "duel");

                    b.Property<string>("Explorer")
                        .HasColumnType("nvarchar(max)")
                        .HasAnnotation("Relational:JsonPropertyName", "explorer");

                    b.Property<string>("Future")
                        .HasColumnType("nvarchar(max)")
                        .HasAnnotation("Relational:JsonPropertyName", "future");

                    b.Property<string>("Gladiator")
                        .HasColumnType("nvarchar(max)")
                        .HasAnnotation("Relational:JsonPropertyName", "gladiator");

                    b.Property<string>("Historic")
                        .HasColumnType("nvarchar(max)")
                        .HasAnnotation("Relational:JsonPropertyName", "historic");

                    b.Property<string>("Legacy")
                        .HasColumnType("nvarchar(max)")
                        .HasAnnotation("Relational:JsonPropertyName", "legacy");

                    b.Property<string>("Modern")
                        .HasColumnType("nvarchar(max)")
                        .HasAnnotation("Relational:JsonPropertyName", "modern");

                    b.Property<string>("Oathbreaker")
                        .HasColumnType("nvarchar(max)")
                        .HasAnnotation("Relational:JsonPropertyName", "oathbreaker");

                    b.Property<string>("Oldschool")
                        .HasColumnType("nvarchar(max)")
                        .HasAnnotation("Relational:JsonPropertyName", "oldschool");

                    b.Property<string>("Pauper")
                        .HasColumnType("nvarchar(max)")
                        .HasAnnotation("Relational:JsonPropertyName", "pauper");

                    b.Property<string>("Paupercommander")
                        .HasColumnType("nvarchar(max)")
                        .HasAnnotation("Relational:JsonPropertyName", "paupercommander");

                    b.Property<string>("Penny")
                        .HasColumnType("nvarchar(max)")
                        .HasAnnotation("Relational:JsonPropertyName", "penny");

                    b.Property<string>("Pioneer")
                        .HasColumnType("nvarchar(max)")
                        .HasAnnotation("Relational:JsonPropertyName", "pioneer");

                    b.Property<string>("Predh")
                        .HasColumnType("nvarchar(max)")
                        .HasAnnotation("Relational:JsonPropertyName", "predh");

                    b.Property<string>("Premodern")
                        .HasColumnType("nvarchar(max)")
                        .HasAnnotation("Relational:JsonPropertyName", "premodern");

                    b.Property<string>("Standard")
                        .HasColumnType("nvarchar(max)")
                        .HasAnnotation("Relational:JsonPropertyName", "standard");

                    b.Property<string>("Vintage")
                        .HasColumnType("nvarchar(max)")
                        .HasAnnotation("Relational:JsonPropertyName", "vintage");

                    b.HasKey("Id");

                    b.ToTable("Legalities");

                    b.HasAnnotation("Relational:JsonPropertyName", "legalities");
                });

            modelBuilder.Entity("MTGManager.Shared.Models.PurchaseUris", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Cardhoarder")
                        .HasColumnType("nvarchar(max)")
                        .HasAnnotation("Relational:JsonPropertyName", "cardhoarder");

                    b.Property<string>("Cardmarket")
                        .HasColumnType("nvarchar(max)")
                        .HasAnnotation("Relational:JsonPropertyName", "cardmarket");

                    b.Property<string>("Tcgplayer")
                        .HasColumnType("nvarchar(max)")
                        .HasAnnotation("Relational:JsonPropertyName", "tcgplayer");

                    b.HasKey("Id");

                    b.ToTable("PurchaseUris");

                    b.HasAnnotation("Relational:JsonPropertyName", "purchase_uris");
                });

            modelBuilder.Entity("MTGManager.Shared.Models.RelatedUris", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Edhrec")
                        .HasColumnType("nvarchar(max)")
                        .HasAnnotation("Relational:JsonPropertyName", "edhrec");

                    b.Property<string>("Gatherer")
                        .HasColumnType("nvarchar(max)")
                        .HasAnnotation("Relational:JsonPropertyName", "gatherer");

                    b.Property<string>("TcgplayerInfiniteArticles")
                        .HasColumnType("nvarchar(max)")
                        .HasAnnotation("Relational:JsonPropertyName", "tcgplayer_infinite_articles");

                    b.Property<string>("TcgplayerInfiniteDecks")
                        .HasColumnType("nvarchar(max)")
                        .HasAnnotation("Relational:JsonPropertyName", "tcgplayer_infinite_decks");

                    b.HasKey("Id");

                    b.ToTable("RelatedUris");

                    b.HasAnnotation("Relational:JsonPropertyName", "related_uris");
                });

            modelBuilder.Entity("MTGManager.Shared.Models.ScryfallCard", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasAnnotation("Relational:JsonPropertyName", "id");

                    b.Property<string>("Artist")
                        .HasColumnType("nvarchar(max)")
                        .HasAnnotation("Relational:JsonPropertyName", "artist");

                    b.Property<string>("ArtistIds")
                        .HasColumnType("nvarchar(max)")
                        .HasAnnotation("Relational:JsonPropertyName", "artist_ids");

                    b.Property<bool?>("Booster")
                        .HasColumnType("bit")
                        .HasAnnotation("Relational:JsonPropertyName", "booster");

                    b.Property<string>("BorderColor")
                        .HasColumnType("nvarchar(max)")
                        .HasAnnotation("Relational:JsonPropertyName", "border_color");

                    b.Property<Guid?>("CardBackId")
                        .HasColumnType("uniqueidentifier")
                        .HasAnnotation("Relational:JsonPropertyName", "card_back_id");

                    b.Property<int?>("CardMarketId")
                        .HasColumnType("int")
                        .HasAnnotation("Relational:JsonPropertyName", "cardmarket_id");

                    b.Property<decimal?>("Cmc")
                        .HasColumnType("decimal(18,2)")
                        .HasAnnotation("Relational:JsonPropertyName", "cmc");

                    b.Property<string>("CollectorNumber")
                        .HasColumnType("nvarchar(max)")
                        .HasAnnotation("Relational:JsonPropertyName", "collector_number");

                    b.Property<string>("ColorIdentity")
                        .HasColumnType("nvarchar(max)")
                        .HasAnnotation("Relational:JsonPropertyName", "color_identity");

                    b.Property<string>("Colors")
                        .HasColumnType("nvarchar(max)")
                        .HasAnnotation("Relational:JsonPropertyName", "colors");

                    b.Property<bool?>("Digital")
                        .HasColumnType("bit")
                        .HasAnnotation("Relational:JsonPropertyName", "digital");

                    b.Property<int?>("EdhrecRank")
                        .HasColumnType("int")
                        .HasAnnotation("Relational:JsonPropertyName", "edhrec_rank");

                    b.Property<string>("Finishes")
                        .HasColumnType("nvarchar(max)")
                        .HasAnnotation("Relational:JsonPropertyName", "finishes");

                    b.Property<string>("FlavorText")
                        .HasColumnType("nvarchar(max)")
                        .HasAnnotation("Relational:JsonPropertyName", "flavor_text");

                    b.Property<bool?>("Foil")
                        .HasColumnType("bit")
                        .HasAnnotation("Relational:JsonPropertyName", "foil");

                    b.Property<string>("Frame")
                        .HasColumnType("nvarchar(max)")
                        .HasAnnotation("Relational:JsonPropertyName", "frame");

                    b.Property<bool?>("FullArt")
                        .HasColumnType("bit")
                        .HasAnnotation("Relational:JsonPropertyName", "full_art");

                    b.Property<string>("Games")
                        .HasColumnType("nvarchar(max)")
                        .HasAnnotation("Relational:JsonPropertyName", "games");

                    b.Property<bool?>("HighresImage")
                        .HasColumnType("bit")
                        .HasAnnotation("Relational:JsonPropertyName", "highres_image");

                    b.Property<Guid?>("IllustrationId")
                        .HasColumnType("uniqueidentifier")
                        .HasAnnotation("Relational:JsonPropertyName", "illustration_id");

                    b.Property<string>("ImageStatus")
                        .HasColumnType("nvarchar(max)")
                        .HasAnnotation("Relational:JsonPropertyName", "image_status");

                    b.Property<int?>("ImageUrisId")
                        .HasColumnType("int");

                    b.Property<string>("Language")
                        .HasColumnType("nvarchar(max)")
                        .HasAnnotation("Relational:JsonPropertyName", "lang");

                    b.Property<string>("Layout")
                        .HasColumnType("nvarchar(max)")
                        .HasAnnotation("Relational:JsonPropertyName", "layout");

                    b.Property<int?>("LegalitiesId")
                        .HasColumnType("int");

                    b.Property<string>("ManaCost")
                        .HasColumnType("nvarchar(max)")
                        .HasAnnotation("Relational:JsonPropertyName", "mana_cost");

                    b.Property<int?>("MtgoFoilId")
                        .HasColumnType("int")
                        .HasAnnotation("Relational:JsonPropertyName", "mtgo_foil_id");

                    b.Property<int?>("MtgoId")
                        .HasColumnType("int")
                        .HasAnnotation("Relational:JsonPropertyName", "mtgo_id");

                    b.Property<string>("MultiverseIds")
                        .HasColumnType("nvarchar(max)")
                        .HasAnnotation("Relational:JsonPropertyName", "multiverse_ids");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)")
                        .HasAnnotation("Relational:JsonPropertyName", "name");

                    b.Property<bool?>("NonFoil")
                        .HasColumnType("bit")
                        .HasAnnotation("Relational:JsonPropertyName", "nonfoil");

                    b.Property<string>("Object")
                        .HasColumnType("nvarchar(max)")
                        .HasAnnotation("Relational:JsonPropertyName", "object");

                    b.Property<Guid?>("OracleId")
                        .HasColumnType("uniqueidentifier")
                        .HasAnnotation("Relational:JsonPropertyName", "oracle_id");

                    b.Property<string>("OracleText")
                        .HasColumnType("nvarchar(max)")
                        .HasAnnotation("Relational:JsonPropertyName", "oracle_text");

                    b.Property<bool?>("Oversized")
                        .HasColumnType("bit")
                        .HasAnnotation("Relational:JsonPropertyName", "oversized");

                    b.Property<int?>("PennyRank")
                        .HasColumnType("int")
                        .HasAnnotation("Relational:JsonPropertyName", "penny_rank");

                    b.Property<string>("Power")
                        .HasColumnType("nvarchar(max)")
                        .HasAnnotation("Relational:JsonPropertyName", "power");

                    b.Property<string>("PrintsSearchUri")
                        .HasColumnType("nvarchar(max)")
                        .HasAnnotation("Relational:JsonPropertyName", "prints_search_uri");

                    b.Property<bool?>("Promo")
                        .HasColumnType("bit")
                        .HasAnnotation("Relational:JsonPropertyName", "promo");

                    b.Property<int?>("PurchaseUrisId")
                        .HasColumnType("int");

                    b.Property<string>("Rarity")
                        .HasColumnType("nvarchar(max)")
                        .HasAnnotation("Relational:JsonPropertyName", "rarity");

                    b.Property<int?>("RelatedUrisId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ReleasedAt")
                        .HasColumnType("datetime2")
                        .HasAnnotation("Relational:JsonPropertyName", "released_at");

                    b.Property<bool?>("Reprint")
                        .HasColumnType("bit")
                        .HasAnnotation("Relational:JsonPropertyName", "reprint");

                    b.Property<bool?>("Reserved")
                        .HasColumnType("bit")
                        .HasAnnotation("Relational:JsonPropertyName", "reserved");

                    b.Property<string>("RulingsUri")
                        .HasColumnType("nvarchar(max)")
                        .HasAnnotation("Relational:JsonPropertyName", "rulings_uri");

                    b.Property<string>("ScryfallSetUri")
                        .HasColumnType("nvarchar(max)")
                        .HasAnnotation("Relational:JsonPropertyName", "scryfall_set_uri");

                    b.Property<string>("ScryfallUri")
                        .HasColumnType("nvarchar(max)")
                        .HasAnnotation("Relational:JsonPropertyName", "scryfall_uri");

                    b.Property<string>("Set")
                        .HasColumnType("nvarchar(max)")
                        .HasAnnotation("Relational:JsonPropertyName", "set");

                    b.Property<Guid?>("SetId")
                        .HasColumnType("uniqueidentifier")
                        .HasAnnotation("Relational:JsonPropertyName", "set_id");

                    b.Property<string>("SetName")
                        .HasColumnType("nvarchar(max)")
                        .HasAnnotation("Relational:JsonPropertyName", "set_name");

                    b.Property<string>("SetSearchUri")
                        .HasColumnType("nvarchar(max)")
                        .HasAnnotation("Relational:JsonPropertyName", "set_search_uri");

                    b.Property<string>("SetType")
                        .HasColumnType("nvarchar(max)")
                        .HasAnnotation("Relational:JsonPropertyName", "set_type");

                    b.Property<string>("SetUri")
                        .HasColumnType("nvarchar(max)")
                        .HasAnnotation("Relational:JsonPropertyName", "set_uri");

                    b.Property<bool?>("StorySpotlight")
                        .HasColumnType("bit")
                        .HasAnnotation("Relational:JsonPropertyName", "story_spotlight");

                    b.Property<int?>("TcgplayerId")
                        .HasColumnType("int")
                        .HasAnnotation("Relational:JsonPropertyName", "tcgplayer_id");

                    b.Property<bool?>("Textless")
                        .HasColumnType("bit")
                        .HasAnnotation("Relational:JsonPropertyName", "textless");

                    b.Property<string>("Toughness")
                        .HasColumnType("nvarchar(max)")
                        .HasAnnotation("Relational:JsonPropertyName", "toughness");

                    b.Property<string>("TypeLine")
                        .HasColumnType("nvarchar(max)")
                        .HasAnnotation("Relational:JsonPropertyName", "type_line");

                    b.Property<string>("Uri")
                        .HasColumnType("nvarchar(max)")
                        .HasAnnotation("Relational:JsonPropertyName", "uri");

                    b.HasKey("Id");

                    b.HasIndex("ImageUrisId")
                        .IsUnique()
                        .HasFilter("[ImageUrisId] IS NOT NULL");

                    b.HasIndex("LegalitiesId")
                        .IsUnique()
                        .HasFilter("[LegalitiesId] IS NOT NULL");

                    b.HasIndex("PurchaseUrisId")
                        .IsUnique()
                        .HasFilter("[PurchaseUrisId] IS NOT NULL");

                    b.HasIndex("RelatedUrisId")
                        .IsUnique()
                        .HasFilter("[RelatedUrisId] IS NOT NULL");

                    b.ToTable("Cards");
                });

            modelBuilder.Entity("MTGManager.Shared.Models.ScryfallCard", b =>
                {
                    b.HasOne("MTGManager.Shared.Models.ImageUris", "ImageUris")
                        .WithOne()
                        .HasForeignKey("MTGManager.Shared.Models.ScryfallCard", "ImageUrisId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("MTGManager.Shared.Models.Legalities", "Legalities")
                        .WithOne()
                        .HasForeignKey("MTGManager.Shared.Models.ScryfallCard", "LegalitiesId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("MTGManager.Shared.Models.PurchaseUris", "PurchaseUris")
                        .WithOne()
                        .HasForeignKey("MTGManager.Shared.Models.ScryfallCard", "PurchaseUrisId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("MTGManager.Shared.Models.RelatedUris", "RelatedUris")
                        .WithOne()
                        .HasForeignKey("MTGManager.Shared.Models.ScryfallCard", "RelatedUrisId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("ImageUris");

                    b.Navigation("Legalities");

                    b.Navigation("PurchaseUris");

                    b.Navigation("RelatedUris");
                });
#pragma warning restore 612, 618
        }
    }
}