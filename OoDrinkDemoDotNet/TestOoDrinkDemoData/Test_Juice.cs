﻿using OoDrinkDemoData;

namespace TestOoDrinkDemoData
{
    [TestClass]
    public class Test_Juice_Apple
    {
        private const string _Name = "Apple Juice";
        private const CarbonationEnum _Carbonation = CarbonationEnum.None;
        private const string _Fruit = "apples";
        private const string _ExpectedDescription = _Name + ", not carbonated, made from apples.";

        private Juice? _TestedJuice = null;

        [TestInitialize]
        public void SetUp()
        {
            _TestedJuice = new Juice(_Name, _Carbonation, _Fruit);
        }

        [TestMethod]
        public void Test_New()
        {
            Assert.IsNotNull(_TestedJuice);
            Assert.IsInstanceOfType(_TestedJuice, typeof(Juice));
            Assert.IsInstanceOfType(_TestedJuice, typeof(Drink));
        }

        [TestMethod]
        public void Test_Name()
        {
            Assert.IsNotNull(_TestedJuice?.Name);
            Assert.AreEqual(_Name, _TestedJuice?.Name);
        }

        [TestMethod]
        public void Test_CarbonationType()
        {
            Assert.IsNotNull(_TestedJuice);
            Assert.AreEqual(_Carbonation, _TestedJuice?.CarbonationType);
        }

        [TestMethod]
        public void Test_Fruit()
        {
            Assert.IsNotNull(_TestedJuice?.Fruit);
            Assert.AreEqual(_Fruit, _TestedJuice.Fruit);
        }

        [TestMethod]
        public void Test_Description()
        {
            string? CachedDescription = _TestedJuice?.Description;
            Assert.IsNotNull(CachedDescription);
            Assert.AreEqual(_ExpectedDescription, CachedDescription);

            Assert.AreEqual(CachedDescription, _TestedJuice?.Description);
        }
    }


    [TestClass]
    public class Test_Juice_Lemonade
    {
        private const string _Name = "Sparkling Lemonade";
        private const CarbonationEnum _Carbonation = CarbonationEnum.Carbonated;
        private const string _Fruit = "lemons";
        private const string _ExpectedDescription = _Name + ", carbonated, made from lemons.";

        private Juice? _TestedJuice = null;

        [TestInitialize]
        public void SetUp()
        {
            _TestedJuice = new Juice(_Name, _Carbonation, _Fruit);
        }

        [TestMethod]
        public void Test_Name()
        {
            Assert.IsNotNull(_TestedJuice?.Name);
            Assert.AreEqual(_Name, _TestedJuice?.Name);
        }

        [TestMethod]
        public void Test_CarbonationType()
        {
            Assert.IsNotNull(_TestedJuice);
            Assert.AreEqual(_Carbonation, _TestedJuice?.CarbonationType);
        }

        [TestMethod]
        public void Test_Fruit()
        {
            Assert.IsNotNull(_TestedJuice?.Fruit);
            Assert.AreEqual(_Fruit, _TestedJuice.Fruit);
        }

        [TestMethod]
        public void Test_Description()
        {
            string? CachedDescription = _TestedJuice?.Description;
            Assert.IsNotNull(CachedDescription);
            Assert.AreEqual(_ExpectedDescription, CachedDescription);

            Assert.AreEqual(CachedDescription, _TestedJuice?.Description);
        }
    }
}
