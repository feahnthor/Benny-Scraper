﻿// <auto-generated />
using System;
using Benny_Scraper.DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BennyScraper.DataAccess.Migrations
{
    [DbContext(typeof(Database))]
    [Migration("20230929041245_Configuration-SaveAsSingleFile")]
    partial class ConfigurationSaveAsSingleFile
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.11");

            modelBuilder.Entity("Benny_Scraper.Models.Chapter", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasColumnName("id")
                        .HasColumnOrder(0);

                    b.Property<string>("Content")
                        .HasColumnType("TEXT")
                        .HasColumnName("content")
                        .HasColumnOrder(7);

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("TEXT")
                        .HasColumnName("date_created")
                        .HasColumnOrder(4);

                    b.Property<DateTime>("DateLastModified")
                        .HasColumnType("TEXT")
                        .HasColumnName("date_last_modified")
                        .HasColumnOrder(5);

                    b.Property<Guid>("NovelId")
                        .HasColumnType("TEXT")
                        .HasColumnName("novel_id")
                        .HasColumnOrder(1);

                    b.Property<float>("Number")
                        .HasColumnType("REAL")
                        .HasColumnName("number")
                        .HasColumnOrder(6);

                    b.Property<string>("Title")
                        .HasMaxLength(255)
                        .HasColumnType("TEXT")
                        .HasColumnName("title")
                        .HasColumnOrder(2);

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("url")
                        .HasColumnOrder(3);

                    b.HasKey("Id");

                    b.HasIndex("NovelId");

                    b.ToTable("chapter", (string)null);
                });

            modelBuilder.Entity("Benny_Scraper.Models.Configuration", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("id");

                    b.Property<bool>("AutoUpdate")
                        .HasColumnType("INTEGER")
                        .HasColumnName("auto_update");

                    b.Property<int>("ConcurrencyLimit")
                        .HasColumnType("INTEGER")
                        .HasColumnName("concurrency_limit");

                    b.Property<string>("DatabaseFileName")
                        .HasColumnType("TEXT")
                        .HasColumnName("database_file_name");

                    b.Property<string>("DatabaseLocation")
                        .HasColumnType("TEXT")
                        .HasColumnName("database_locatoin");

                    b.Property<int>("DefaultLogLevel")
                        .HasColumnType("INTEGER")
                        .HasColumnName("default_log_level");

                    b.Property<int>("DefaultMangaFileExtension")
                        .HasColumnType("INTEGER")
                        .HasColumnName("default_manga_file_extension");

                    b.Property<string>("LogLocation")
                        .HasColumnType("TEXT")
                        .HasColumnName("log_location");

                    b.Property<string>("MangaSaveLocation")
                        .HasColumnType("TEXT")
                        .HasColumnName("manga_save_location");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT")
                        .HasColumnName("name");

                    b.Property<string>("NovelSaveLocation")
                        .HasColumnType("TEXT")
                        .HasColumnName("novel_save_location");

                    b.Property<bool>("SaveAsSingleFile")
                        .HasColumnType("INTEGER")
                        .HasColumnName("save_as_single_file");

                    b.Property<string>("SaveLocation")
                        .HasColumnType("TEXT")
                        .HasColumnName("save_location");

                    b.HasKey("Id");

                    b.ToTable("configuration", (string)null);
                });

            modelBuilder.Entity("Benny_Scraper.Models.Novel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasColumnName("id");

                    b.Property<string>("Author")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT")
                        .HasColumnName("author");

                    b.Property<string>("CurrentChapter")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("TEXT")
                        .HasColumnName("current_chapter");

                    b.Property<string>("CurrentChapterUrl")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("current_chapter_url");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("TEXT")
                        .HasColumnName("date_created");

                    b.Property<DateTime>("DateLastModified")
                        .HasColumnType("TEXT")
                        .HasColumnName("date_last_modified");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT")
                        .HasColumnName("description");

                    b.Property<string>("FirstChapter")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("TEXT")
                        .HasColumnName("first_chapter");

                    b.Property<string>("Genre")
                        .HasColumnType("TEXT")
                        .HasColumnName("genre");

                    b.Property<bool>("LastChapter")
                        .HasColumnType("INTEGER")
                        .HasColumnName("last_chapter");

                    b.Property<string>("LastTableOfContentsUrl")
                        .HasColumnType("TEXT")
                        .HasColumnName("last_table_of_contents_url");

                    b.Property<string>("SaveLocation")
                        .HasMaxLength(255)
                        .HasColumnType("TEXT")
                        .HasColumnName("save_location");

                    b.Property<string>("SiteName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT")
                        .HasColumnName("site_name");

                    b.Property<string>("Status")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT")
                        .HasColumnName("status");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("TEXT")
                        .HasColumnName("title");

                    b.Property<int?>("TotalChapters")
                        .HasColumnType("INTEGER")
                        .HasColumnName("total_chapters");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("url");

                    b.HasKey("Id");

                    b.ToTable("novel", (string)null);
                });

            modelBuilder.Entity("Benny_Scraper.Models.NovelList", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Completed")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("NovelId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NovelId");

                    b.ToTable("NovelLists");
                });

            modelBuilder.Entity("Benny_Scraper.Models.Page", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("id");

                    b.Property<Guid>("ChapterId")
                        .HasColumnType("TEXT")
                        .HasColumnName("chapter_id");

                    b.Property<byte[]>("Image")
                        .HasColumnType("BLOB")
                        .HasColumnName("image");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("url");

                    b.HasKey("Id");

                    b.HasIndex("ChapterId");

                    b.ToTable("page", (string)null);
                });

            modelBuilder.Entity("Benny_Scraper.Models.Chapter", b =>
                {
                    b.HasOne("Benny_Scraper.Models.Novel", "Novel")
                        .WithMany("Chapters")
                        .HasForeignKey("NovelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Novel");
                });

            modelBuilder.Entity("Benny_Scraper.Models.NovelList", b =>
                {
                    b.HasOne("Benny_Scraper.Models.Novel", "Novel")
                        .WithMany()
                        .HasForeignKey("NovelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Novel");
                });

            modelBuilder.Entity("Benny_Scraper.Models.Page", b =>
                {
                    b.HasOne("Benny_Scraper.Models.Chapter", "Chapter")
                        .WithMany("Pages")
                        .HasForeignKey("ChapterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Chapter");
                });

            modelBuilder.Entity("Benny_Scraper.Models.Chapter", b =>
                {
                    b.Navigation("Pages");
                });

            modelBuilder.Entity("Benny_Scraper.Models.Novel", b =>
                {
                    b.Navigation("Chapters");
                });
#pragma warning restore 612, 618
        }
    }
}
