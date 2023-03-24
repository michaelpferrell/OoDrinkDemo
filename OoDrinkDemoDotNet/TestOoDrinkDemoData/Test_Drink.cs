using Microsoft.VisualStudio.TestTools.UnitTesting;
using OoDrinkDemoData;

namespace TestOoDrinkDemoData
{
    [TestClass]
    public class Test_Drink_New_Carb
    {
        private const string _Name = "Some Carbonated Drink";
        private const bool _IsCarbonated = true;
        private const string _ExpectedDescription = _Name + ", carbonated.";

        private Drink? _TestedDrink = null;

        [TestInitialize]
        public void SetUp()
        {
            _TestedDrink = new Drink(_Name, _IsCarbonated);
        }

        [TestMethod]
        public void Test_Name()
        {
            Assert.IsNotNull(_TestedDrink?.Name);
            Assert.AreEqual(_Name, _TestedDrink?.Name);
        }

        [TestMethod]
        public void Test_IsCarbonated()
        {
            Assert.IsTrue(_TestedDrink?.IsCarbonated);
            Assert.AreEqual(_IsCarbonated, _TestedDrink?.IsCarbonated);
        }

        [TestMethod]
        public void Test_Description()
        {
            string? CachedDescription = _TestedDrink?.Description;
            Assert.IsNotNull(CachedDescription);
            Assert.AreEqual(_ExpectedDescription, CachedDescription);
        }
    }
}