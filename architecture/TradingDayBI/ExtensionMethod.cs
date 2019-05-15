using System.Linq;
using System.Xml.Linq;

namespace TradingDayBl
{
    public static class ExtensionMethod
    {
        public static bool HasAttribute(this XElement xElement, string attributeName)
        {
            return xElement.Attributes().Any(at => at.Name == attributeName);
        }
    }
}
