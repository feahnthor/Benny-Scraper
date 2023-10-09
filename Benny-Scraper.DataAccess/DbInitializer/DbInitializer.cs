﻿using Benny_Scraper.DataAccess.Data;
using Benny_Scraper.Models;
using Microsoft.EntityFrameworkCore;

namespace Benny_Scraper.DataAccess.DbInitializer
{
    public class DbInitializer
    {
        private readonly Database _db;

        public DbInitializer(Database db)
        {
            _db = db;
        }

        /// <summary>
        /// Initializes the database. Will allow us to not need to call update-databse in the package manager console.
        /// If there are migrations, apply them
        /// </summary>
        /// <exception cref="Exception"></exception>
        public void Initialize()
        {
            // apply Migrations if they are not applied
            try
            {
                if (_db.Database.GetPendingMigrations().Any())
                {
                    _db.Database.Migrate();
                }

                SeedData();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void SeedData()
        {
            try
            {
                if (!_db.Configurations.Any())
                {
                    var defaultConfig = new Configuration
                    {
                        Name = "Default",
                        AutoUpdate = false,
                        ConcurrencyLimit = 2,
                        SaveLocation = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "BennyScrapedNovels"),
                        NovelSaveLocation = string.Empty,
                        MangaSaveLocation = string.Empty,
                        LogLocation = string.Empty,
                        DatabaseLocation = string.Empty,
                        DatabaseFileName = "BennyTestDb.db",
                        SaveAsSingleFile = true,
                        DefaultMangaFileExtension = FileExtension.PDF,
                        DefaultLogLevel = LogLevel.Info,
                        FontType = "Arial"
                    };
                    _db.Configurations.Add(defaultConfig);
                    _db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while seeding the database: " + ex.Message, ex);
            }
        }
    }
}
