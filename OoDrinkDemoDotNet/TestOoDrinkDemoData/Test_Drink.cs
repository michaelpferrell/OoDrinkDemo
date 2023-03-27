using Microsoft.VisualStudio.TestTools.UnitTesting;
using OoDrinkDemoData;

namespace TestOoDrinkDemoData
{
    [TestClass]
    public class Test_Drink_New_Carb
    {
        private const string _Name = "Some Carbonated Drink";
        private const CarbonationEnum _CarbonationType = CarbonationEnum.Carbonated;
        private const string _ExpectedDescription = _Name + ", carbonated.";

        private Drink? _TestedDrink = null;

        [TestInitialize]
        public void SetUp()
        {
            _TestedDrink = new Drink(_Name, _CarbonationType);
        }

        [TestMethod]
        public void Test_Name()
        {
            Assert.IsNotNull(_TestedDrink?.Name);
            Assert.AreEqual(_Name, _TestedDrink?.Name);
        }

        [TestMethod]
        public void Test_CarbonationType()
        {
            Assert.IsNotNull(_TestedDrink);
            Assert.AreEqual(_CarbonationType, _TestedDrink.CarbonationType);
        }

        [TestMethod]
        public void Test_Description()
        {
            string? CachedDescription = _TestedDrink?.Description;
            Assert.IsNotNull(CachedDescription);
            Assert.AreEqual(_ExpectedDescription, CachedDescription);
        }
    }


    [TestClass]
    public class Test_Drink_New_NonCarb
    {
        private const string _Name = "Some Noncarbonated Drink";
        private const CarbonationEnum _CarbonationType = CarbonationEnum.None;
        private const string _ExpectedDescription = _Name + ", not carbonated.";

        private Drink? _TestedDrink = null;

        [TestInitialize]
        public void SetUp()
        {
            _TestedDrink = new Drink(_Name, _CarbonationType);
        }

        [TestMethod]
        public void Test_Name()
        {
            Assert.IsNotNull(_TestedDrink?.Name);
            Assert.AreEqual(_Name, _TestedDrink?.Name);
        }

        [TestMethod]
        public void Test_CarbonationType()
        {
            Assert.IsNotNull(_TestedDrink);
            Assert.AreEqual(_CarbonationType, _TestedDrink?.CarbonationType);
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
