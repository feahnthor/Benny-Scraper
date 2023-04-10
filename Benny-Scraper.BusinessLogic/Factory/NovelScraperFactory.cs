﻿using Benny_Scraper.BusinessLogic.Factory.Interfaces;
using Benny_Scraper.BusinessLogic.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Benny_Scraper.BusinessLogic.Config;
using NLog;
using Autofac;

namespace Benny_Scraper.BusinessLogic.Factory
{
    public class NovelScraperFactory : INovelScraperFactory
    {
        private readonly Func<string, INovelScraper> _novelScraperResolver;
        private static readonly ILogger Logger = LogManager.GetCurrentClassLogger();
        private readonly NovelScraperSettings _novelScraperSettings;

        public NovelScraperFactory(Func<string, INovelScraper> novelScraperResolver, IOptions<NovelScraperSettings> novelScraperSettings)
        {
            _novelScraperResolver = novelScraperResolver;
            _novelScraperSettings = novelScraperSettings.Value;
        }

        public INovelScraper CreateSeleniumOrHttpScraper(Uri novelTableOfContentsUri)
        {
            bool isSeleniumUrl = _novelScraperSettings.SeleniumSites.Any(x => novelTableOfContentsUri.Host.Contains(x));

            if (isSeleniumUrl)
            {
                try
                {
                    return _novelScraperResolver("Selenium");
                }
                catch (Exception ex)
                {
                    Logger.Error($"Error when getting SeleniumNovelScraper. {ex}");
                    throw;
                }
            }

            try
            {
                return _novelScraperResolver("Http");
            }
            catch (Exception ex)
            {
                Logger.Error($"Error when getting HttpNovelScraper. {ex}");
                throw;
            }
        }

    }

}