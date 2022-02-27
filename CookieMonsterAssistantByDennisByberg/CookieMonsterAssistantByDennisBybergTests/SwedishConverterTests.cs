using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CookieMonsterAssistantByDennisByberg.Tests
{
    [TestClass()]
    public class SwedishConverterTests
    {
        [TestMethod()]
        public void ConvertCupToDlTest()
        {
            var convert = new SwedishConverter();
            const string measure = "cup";
            var actual = convert.ConvertToSwedishMeasure(measure);
            const string expected = "dl";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void ConvertTeaspoonToMlTest()
        {
            var convert = new SwedishConverter();
            const string measure = "teaspoon";
            var actual = convert.ConvertToSwedishMeasure(measure);
            const string expected = "ml";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void ConvertOunceToGTest()
        {
            var convert = new SwedishConverter();
            const string measure = "ounce";
            var actual = convert.ConvertToSwedishMeasure(measure);
            const string expected = "g";
            Assert.AreEqual(expected, actual);
        }
    }
}