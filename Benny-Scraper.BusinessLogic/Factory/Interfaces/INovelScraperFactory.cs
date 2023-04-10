﻿using Benny_Scraper.BusinessLogic.Interfaces;

namespace Benny_Scraper.BusinessLogic.Factory.Interfaces
{
    public interface INovelScraperFactory
    {
        INovelScraper CreateSeleniumOrHttpScraper(Uri novelTableOfContentsUri);
    }
}