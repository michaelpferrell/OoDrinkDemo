﻿using OoDrinkDemoData;

namespace TestOoDrinkDemoData
{
    [TestClass]
    public class Test_Beer_New_Budweiser
    {
        private const string _Name = "Budweiser";
        private const CarbonationEnum _Carbonation = CarbonationEnum.Carbonated;
        private const double _AlcoholPercentage = 5.0;
        private const string _ExpectedDescription = _Name + ", carbonated, 5%.";

        private Beer? _TestedBeer = null;

        [TestInitialize]
        public void SetUp()
        {
            _TestedBeer = new Beer(_Name, _Carbonation, _AlcoholPercentage);
        }

        [TestMethod]
        public void Test_New()
        {
            Assert.IsNotNull(_TestedBeer);
            Assert.IsInstanceOfType(_TestedBeer, typeof(Beer));
            Assert.IsInstanceOfType(_TestedBeer, typeof(Drink));
        }

        [TestMethod]
        public void Test_Name()
        {
            Assert.IsNotNull(_TestedBeer?.Name);
            Assert.AreEqual(_Name, _TestedBeer?.Name);
        }

        [TestMethod]
        public void Test_CarbonationType()
        {
            Assert.IsNotNull(_TestedBeer);
            Assert.AreEqual(_Carbonation, _TestedBeer?.CarbonationType);
        }
        
        [TestMethod]
        public void Test_AlcoholPercentage()
        {
            Assert.IsNotNull(_TestedBeer);
            Assert.AreEqual(_AlcoholPercentage, _TestedBeer?.AlcoholPercentage);
        }

        [TestMethod]
        public void Test_Description()
        {
            string? CachedDescription = _TestedBeer?.Description;
            Assert.IsNotNull(CachedDescription);
            Assert.AreEqual(_ExpectedDescription, CachedDescription);
            Assert.AreEqual(CachedDescription, _TestedBeer?.Description);
        }
    }


    [TestClass]
    public class Test_Beer_New_Bogus
    {
        private const string _Name = "Bogus Flat";
        private const CarbonationEnum _Carbonation = CarbonationEnum.None;
        private const double _AlcoholPercentage = 6.5;
        private const string _ExpectedDescription = _Name + ", not carbonated, 6.5%.";

        private Beer? _TestedBeer = null;

        [TestInitialize]
        public void SetUp()
        {
            _TestedBeer = new Beer(_Name, _Carbonation, _AlcoholPercentage);
        }

        [TestMethod]
        public void Test_name()
        {
            Assert.IsNotNull(_TestedBeer?.Name);
            Assert.AreEqual(_Name, _TestedBeer.Name);
        }

        [TestMethod]
        public void Test_AlcoholPercentage()
        {
            Assert.IsNotNull(_TestedBeer);
            Assert.AreEqual(_AlcoholPercentage, _TestedBeer?.AlcoholPercentage);
        }

        [TestMethod]
        public void Test_Description()
        {
            string? CachedDescription = _TestedBeer?.Description;
            Assert.IsNotNull(CachedDescription);
            Assert.AreEqual(_ExpectedDescription, CachedDescription);
            Assert.AreEqual(CachedDescription, _TestedBeer?.Description);
        }
    }
}
