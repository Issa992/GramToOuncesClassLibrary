using GramToOuncesClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ToOunces()
        {
            double s = Conversion.ConvertToOunce(5);
            Assert.AreEqual(0.17637, s);
        }

        [TestMethod]
        public void ToGram()
        {
            double s = Conversion.ConvertToGram(6);
            Assert.AreEqual(170.09712, s);
        }
    }
}
