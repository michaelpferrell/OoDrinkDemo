using OoDrinkDemoData;

namespace TestOoDrinkDemoData
{
    [TestClass]
    public class Test_Soda_New_Pepsi
    {
        private const string _Name = "Pepsi";
        private const CarbonationEnum _Carbonation = CarbonationEnum.Carbonated;
        private const string _ExpectedDescription = _Name + ", carbonated.";

        private Soda? _TestedSoda = null;

        [TestInitialize]
        public void SetUp()
        {
            _TestedSoda = new Soda(_Name, _Carbonation);
        }

        [TestMethod]
        public void Test_New()
        {
            Assert.IsNotNull(_TestedSoda);
            Assert.IsInstanceOfType(_TestedSoda, typeof(Soda));
            Assert.IsInstanceOfType(_TestedSoda, typeof(Drink));
        }

        [TestMethod]
        public void Test_Name()
        {
            Assert.IsNotNull(_TestedSoda?.Name);
            Assert.AreEqual(_Name, _TestedSoda?.Name);
        }

        [TestMethod]
        public void Test_CarbonationType()
        {
            Assert.IsNotNull(_TestedSoda);
            Assert.AreEqual(_Carbonation, _TestedSoda?.CarbonationType);
        }

        [TestMethod]
        public void Test_Description()
        {
            string? CachedDescription = _TestedSoda?.Description;
            Assert.IsNotNull(CachedDescription);
            Assert.AreEqual(_ExpectedDescription, CachedDescription);
        }
    }


    [TestClass]
    public class Test_Soda_New_Nitro_Pepsi
    {
        private const string _Name = "Nitro Pepsi";
        private const CarbonationEnum _Carbonation = CarbonationEnum.Nitrogenated;
        private const string _ExpectedDescription = _Name + ", nitrogenated.";

        private Soda? _TestedSoda = null;

        [TestInitialize]
        public void SetUp()
        {
            _TestedSoda = new Soda(_Name, _Carbonation);
        }

        [TestMethod]
        public void Test_Name()
        {
            Assert.IsNotNull(_TestedSoda?.Name);
            Assert.AreEqual(_Name, _TestedSoda?.Name);
        }

        [TestMethod]
        public void Test_CarbonationType()
        {
            Assert.IsNotNull(_TestedSoda);
            Assert.AreEqual(_Carbonation, _TestedSoda?.CarbonationType);
        }

        [TestMethod]
        public void Test_Description()
        {
            string? CachedDescription = _TestedSoda?.Description;
            Assert.IsNotNull(CachedDescription);
            Assert.AreEqual(_ExpectedDescription, CachedDescription);
        }
    }
}
