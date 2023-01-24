﻿using Benny_Scraper.Models;
using Benny_Scraper;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Benny_Scraper.DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        // Clear nuget packages with errors Scaffolding for Identity
        // https://social.msdn.microsoft.com/Forums/en-US/07c93e8b-5092-4211-80e6-3932d87664c3/always-got-this-error-when-scaffolding-suddenly-8220there-was-an-error-running-the-selected-code?forum=aspdotnetcore
        // Setup for this https://learn.microsoft.com/en-us/ef/ef6/modeling/code-first/workflows/new-database?source=recommendations//}

        /// <summary>
        /// Connection string is handled in the Program.cs injection
        /// </summary>
        /// <param name="options"></param>
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {            
        }

        #region Required
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Novel>().ToTable("novel");
            modelBuilder.Entity<Chapter>().ToTable("chapter");

            // Rename column            
            modelBuilder.Entity<Chapter>().Property(x => x.Id).HasColumnName("id");
            modelBuilder.Entity<Chapter>().Property(x => x.Title).HasColumnName("title");
            modelBuilder.Entity<Chapter>().Property(x => x.Url).HasColumnName("url");
            modelBuilder.Entity<Chapter>().Property(x => x.Content).HasColumnName("content");
            modelBuilder.Entity<Chapter>().Property(x => x.Number).HasColumnName("number");
            modelBuilder.Entity<Chapter>().Property(x => x.DateCreated).HasColumnName("date_created");
            modelBuilder.Entity<Novel>().Property(x => x.Id).HasColumnName("id");
            modelBuilder.Entity<Novel>().Property(x => x.Title).HasColumnName("title");
            modelBuilder.Entity<Novel>().Property(x => x.Url).HasColumnName("url");
            modelBuilder.Entity<Novel>().Property(x => x.DateCreated).HasColumnName("date_created");
            modelBuilder.Entity<Novel>().Property(x => x.Author).HasColumnName("author");
            modelBuilder.Entity<Novel>().Property(x => x.Description).HasColumnName("description");
            modelBuilder.Entity<Novel>().Property(x => x.Genre).HasColumnName("genre");
            modelBuilder.Entity<Novel>().Property(x => x.Status).HasColumnName("status");
            modelBuilder.Entity<Novel>().Property(x => x.TotalChapters).HasColumnName("total_chapters");
            modelBuilder.Entity<Novel>().Property(x => x.SiteName).HasColumnName("site_name");
            modelBuilder.Entity<Novel>().Property(x => x.SaveLocation).HasColumnName("save_location");
            modelBuilder.Entity<Novel>().Property(x => x.LastChapter).HasColumnName("last_chapter");
            modelBuilder.Entity<Novel>().Property(x => x.FirstChapter).HasColumnName("first_chapter");
            modelBuilder.Entity<Novel>().Property(x => x.CurrentChapter).HasColumnName("current_chapter");
        }
        #endregion

        // Creates maps to the database
        public DbSet<Novel> Novels { get; set; }
        public DbSet<NovelList> NovelLists { get; set; }
        public DbSet<Chapter> Chapters { get; set; }
    }
}
