﻿using Benny_Scraper.Models;

namespace Benny_Scraper.DataAccess.Repository.IRepository;
public interface IConfigurationRepository : IRepository<Configuration>
{
    void Update(Configuration obj);
    Task<Configuration> GetAsync(int id);
}
