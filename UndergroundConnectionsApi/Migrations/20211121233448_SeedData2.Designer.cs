﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UndergroundConnectionsApi.Models;

namespace UndergroundConnectionsApi.Migrations
{
    [DbContext(typeof(UndergroundConnectionsApiContext))]
    [Migration("20211121233448_SeedData2")]
    partial class SeedData2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("UndergroundConnectionsApi.Models.Artist", b =>
                {
                    b.Property<int>("ArtistId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Bio")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Email")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("PastWork")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Seeking")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("ArtistId");

                    b.ToTable("Artists");

                    b.HasData(
                        new
                        {
                            ArtistId = 1,
                            Age = 19,
                            Bio = "Hey yall I make macaroni art and music",
                            Email = "marni@yomama.com",
                            Name = "Marni On Rails",
                            PastWork = "Eiffle tower made out of penne",
                            Seeking = "Photographers"
                        },
                        new
                        {
                            ArtistId = 2,
                            Age = 65,
                            Bio = "Wonder if you'll ever have a woman like me, wonderwoman is who I be",
                            Email = "sisi@yomama.com",
                            Name = "Gozi",
                            PastWork = "I killed a lot of bad guys",
                            Seeking = "Rappers"
                        },
                        new
                        {
                            ArtistId = 3,
                            Age = 4,
                            Bio = "I'm Mike cheese aka the big cheese",
                            Email = "daddy@yomama.com",
                            Name = "Mike Cheese",
                            PastWork = "Past work? Look no further, this biceps are years in the making",
                            Seeking = "Painters"
                        },
                        new
                        {
                            ArtistId = 4,
                            Age = 50,
                            Bio = "I love myself like kanye likes kanye",
                            Email = "ye@yomama.com",
                            Name = "Kanye Rest",
                            PastWork = "Your childhood music is me",
                            Seeking = "Producer"
                        },
                        new
                        {
                            ArtistId = 5,
                            Age = 27,
                            Bio = "Wonder if you'll ever have a woman like me, wonderwoman is who I be",
                            Email = "starynite@yomama.com",
                            Name = "Van Gno",
                            PastWork = "I killed a lot of bad guys",
                            Seeking = "Graphic Designer"
                        },
                        new
                        {
                            ArtistId = 6,
                            Age = 23,
                            Bio = "I'm looking only for the peak of human life",
                            Email = "hipster_garbo@yomama.com",
                            Name = "Mouse and String",
                            PastWork = "Cats, the Musical 2.0",
                            Seeking = "Xylophonist's"
                        },
                        new
                        {
                            ArtistId = 7,
                            Age = 18,
                            Bio = "Bringing you the best of salt extravaganza, each and every day!",
                            Email = "Salty_blanket@yomama.com",
                            Name = "Salt Shank",
                            PastWork = "Bucket of salty salmon",
                            Seeking = "Screamers"
                        },
                        new
                        {
                            ArtistId = 8,
                            Age = 66,
                            Bio = "Always striving to extract the most profound CRUCH out of my clients.",
                            Email = "crunchdaddy@yomama.com",
                            Name = "Crunchist",
                            PastWork = "Cap'n Crunch commercial theme",
                            Seeking = "DJ's"
                        },
                        new
                        {
                            ArtistId = 9,
                            Age = 29,
                            Bio = "If you want it lets do it",
                            Email = "papi@yomama.com",
                            Name = "Magic Mike",
                            PastWork = "Just put on pony and I'll show you my past work",
                            Seeking = "Singer"
                        },
                        new
                        {
                            ArtistId = 10,
                            Age = 46,
                            Bio = "I will talk to you all night long.",
                            Email = "phoneme@yomama.com",
                            Name = "Don't Hang Up",
                            PastWork = "Many conversations recorded and replayed",
                            Seeking = "Videographers"
                        },
                        new
                        {
                            ArtistId = 11,
                            Age = 36,
                            Bio = "Don't mess with me or I will punch your lights out",
                            Email = "biker@yomama.com",
                            Name = "Dusty Hogg",
                            PastWork = "I beat the shit out of people",
                            Seeking = "Rappers"
                        },
                        new
                        {
                            ArtistId = 12,
                            Age = 32,
                            Bio = "I will predict your future by connecting with the spirits",
                            Email = "psychicmeera@yomama.com",
                            Name = "Meera Lax",
                            PastWork = "I helped many find their spiritual purposes.",
                            Seeking = "Painters"
                        });
                });

            modelBuilder.Entity("UndergroundConnectionsApi.Models.ArtistClassification", b =>
                {
                    b.Property<int>("ArtistClassificationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("ArtistId")
                        .HasColumnType("int");

                    b.Property<int>("ClassificationId")
                        .HasColumnType("int");

                    b.HasKey("ArtistClassificationId");

                    b.HasIndex("ArtistId");

                    b.HasIndex("ClassificationId");

                    b.ToTable("ArtistClassifications");
                });

            modelBuilder.Entity("UndergroundConnectionsApi.Models.Classification", b =>
                {
                    b.Property<int>("ClassificationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClassificationName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("ClassificationSpecification")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("ClassificationId");

                    b.ToTable("Classifications");

                    b.HasData(
                        new
                        {
                            ClassificationId = 1,
                            ClassificationName = "Singer",
                            ClassificationSpecification = "Country"
                        });
                });

            modelBuilder.Entity("UndergroundConnectionsApi.Models.ArtistClassification", b =>
                {
                    b.HasOne("UndergroundConnectionsApi.Models.Artist", "Artist")
                        .WithMany("JoinEntities")
                        .HasForeignKey("ArtistId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UndergroundConnectionsApi.Models.Classification", "Classification")
                        .WithMany("JoinEntities")
                        .HasForeignKey("ClassificationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Artist");

                    b.Navigation("Classification");
                });

            modelBuilder.Entity("UndergroundConnectionsApi.Models.Artist", b =>
                {
                    b.Navigation("JoinEntities");
                });

            modelBuilder.Entity("UndergroundConnectionsApi.Models.Classification", b =>
                {
                    b.Navigation("JoinEntities");
                });
#pragma warning restore 612, 618
        }
    }
}
