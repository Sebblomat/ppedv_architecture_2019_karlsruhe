using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Xml.Linq;

namespace TradingDayBI
{
    public class TradingDay
    {
        public TradingDay(XElement xElement)
        {
            Date = Convert.ToDateTime(xElement.Attribute("time").Value);
            var q = xElement.Descendants().Select(d => new Currency
            {
                //Alternative statt InvariantCulture: new NumberFormatInfo
                //{
                //    NumberDecimalSeparator = "."
                //})
                Rate = Convert.ToDouble(d.Attribute("rate").Value, CultureInfo.InvariantCulture),
                Symbol = d.Attribute("currency").Value
            });

            Currencies = q.ToList();
        }

        public DateTime Date { get; set; }
        public List<Currency> Currencies { get; set; }
    }
}
