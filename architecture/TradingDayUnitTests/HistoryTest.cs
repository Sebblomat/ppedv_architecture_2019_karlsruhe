using Microsoft.VisualStudio.TestTools.UnitTesting;
using TradingDayBI;

namespace TradingDayUnitTests
{
    [TestClass]
    public class HistoryTest
    {
        string url = "https://www.ecb.europa.eu/stats/eurofxref/eurofxref-hist-90d.xml";

        [TestMethod]
        public void HistoryInitTest()
        {
            var hist = new History(url);
            Assert.AreEqual(61, hist.TradingDays.Count);
        }
    }
}
