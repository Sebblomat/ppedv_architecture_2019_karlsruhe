﻿using System.Data.Entity;

namespace TradingDayBI
{
    public class DataManager : DbContext
    {
        public DataManager()
        {
        }

        public DbSet<TradingDay> TradingDays { get; set; }
        public DbSet<Currency> Currencies { get; set; }
    }
}
