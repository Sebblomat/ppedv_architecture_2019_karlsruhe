﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace TradingDayBI
{
    public class History
    {
        public History(string url)
        {
            this.TradingDays = GetData(url);
        }

        private List<TradingDay> GetData(string url)
        {
            var tradingDays = new List<TradingDay>();
            var document = XDocument.Load(url);
            //attribut erbt namespace von nodename vorher. Kann man aber auch explizit schreiben
            var q = document.Root.Descendants()
                .Where(d => d.Name.LocalName == "Cube" && d.Attributes().Any(at => at.Name == "time"))
                .Select(d => new TradingDay (d));

            //explizit, statt wie oben angehangen. Dann oben Select(d => d);
            //foreach (var item in q)
            //{
            //    var day = new TradingDay { Date = Convert.ToDateTime(item.Attribute("time").Value)};
            //    tradingDays.Add(day);
            //}

            tradingDays = q.ToList();

            return tradingDays;
        }
        public List<TradingDay> TradingDays { get; set; }
    }
}
