using OoDrinkDemoData;

namespace TestOoDrinkDemoData
{
    [TestClass]
    public class Test_Soda_New_Pepsi
    {
        private const string _Name = "Pepsi";
        private const bool _IsCarbonated = true;
        private const string _ExpectedDescription = _Name + ", carbonated.";

        private Soda? _TestedSoda = null;

        [TestInitialize]
        public void SetUp()
        {
            _TestedSoda = new Soda(_Name, _IsCarbonated);
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
        public void Test_IsCarbonated()
        {
            Assert.IsNotNull(_TestedSoda);
            Assert.AreEqual(_IsCarbonated, _TestedSoda.IsCarbonated);
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
        private const bool _IsCarbonated = false;
        private const string _ExpectedDescription = _Name + ", not carbonated.";

        private Soda? _TestedSoda = null;

        [TestInitialize]
        public void SetUp()
        {
            _TestedSoda = new Soda(_Name, _IsCarbonated);
        }

        [TestMethod]
        public void Test_Name()
        {
            Assert.IsNotNull(_TestedSoda?.Name);
            Assert.AreEqual(_Name, _TestedSoda?.Name);
        }

        [TestMethod]
        public void Test_IsCarbonated()
        {
            Assert.IsNotNull(_TestedSoda);
            Assert.AreEqual(_IsCarbonated, _TestedSoda.IsCarbonated);
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
