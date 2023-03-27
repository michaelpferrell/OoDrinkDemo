using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OoDrinkDemoData;

namespace TestOoDrinkDemoData
{
    [TestClass]
    public class Test_DrinkList_New_Empty
    {
        DrinkList MyList = null;

        [TestInitialize]
        public void SetUp()
        {
            MyList = new DrinkList();
        }

        [TestMethod]
        public void Test_New()
        {
            Assert.IsNotNull(MyList);
            Assert.IsInstanceOfType(MyList, typeof(List<Drink>));
        }

        [TestMethod]
        public void Test_Count()
        {
            Assert.AreEqual(0, MyList.Count);
        }
    }


    [TestClass]
    public class Test_DrinkList_ListRecall
    {
        DrinkList? _Drinks = null;

        [TestInitialize]
        public void SetUp()
        {
            _Drinks = new DrinkList();
            _Drinks.Add(new Juice("Orange Juice", CarbonationEnum.None, "oranges"));
            _Drinks.Add(new Beer("Yuengling Lager", CarbonationEnum.Carbonated, 5.0));
            _Drinks.Add(new Juice("Cranberry Juice", CarbonationEnum.None, "cranberries"));
            _Drinks.Add(new Soda("Nitro Pepsi", CarbonationEnum.Nitrogenated));
        }

        [TestMethod]
        public void Test_New()
        {
            Assert.IsNotNull(_Drinks);
            Assert.IsInstanceOfType(_Drinks, typeof(DrinkList));
        }

        [TestMethod]
        public void Test_Count()
        {
            Assert.AreEqual(4, _Drinks.Count);
        }

        [TestMethod]
        public void Test_Item_0()
        {
            Drink? MyItem = _Drinks?[0];
            Assert.IsNotNull(MyItem);
            Assert.IsInstanceOfType(MyItem, typeof(Juice));
            Juice MyJuice = (Juice)MyItem;
            Assert.IsNotNull(MyJuice);
            Assert.AreEqual("Orange Juice", MyJuice.Name);
            Assert.AreEqual(CarbonationEnum.None, MyJuice.CarbonationType);
            Assert.AreEqual("oranges", MyJuice.Fruit);
        }

        [TestMethod]
        public void Test_Item_1()
        {
            Drink? MyItem = _Drinks?[1];
            Assert.IsNotNull(MyItem);
            Assert.IsInstanceOfType(MyItem, typeof(Beer));
            Beer MyBeer = (Beer)MyItem;
            Assert.IsNotNull(MyBeer);
            Assert.AreEqual("Yuengling Lager", MyBeer.Name);
            Assert.AreEqual(CarbonationEnum.Carbonated, MyBeer.CarbonationType);
            Assert.AreEqual(5.0, MyBeer.AlcoholPercentage);
        }

        [TestMethod]
        public void Test_Item_2()
        {
            Drink? MyItem = _Drinks?[2];
            Assert.IsNotNull(MyItem);
            Assert.IsInstanceOfType(MyItem, typeof(Juice));
            Juice MyJuice = (Juice)MyItem;
            Assert.IsNotNull(MyJuice);
            Assert.AreEqual("Cranberry Juice", MyJuice.Name);
            Assert.AreEqual(CarbonationEnum.None, MyJuice.CarbonationType);
            Assert.AreEqual("cranberries", MyJuice.Fruit);
        }

        [TestMethod]
        public void Test_Item_3()
        {
            Drink? MyItem = _Drinks?[3];
            Assert.IsNotNull(MyItem);
            Assert.IsInstanceOfType(MyItem, typeof(Soda));
            Soda MySoda = (Soda)MyItem;
            Assert.IsNotNull(MySoda);
            Assert.AreEqual("Nitro Pepsi", MySoda.Name);
            Assert.AreEqual(CarbonationEnum.Nitrogenated, MySoda.CarbonationType);
        }
    }

    [TestClass]
    public class Test_DrinkList_Descriptions
    {
        DrinkList? _Drinks = null;
        List<string>? MyDescs = null;

        [TestInitialize]
        public void SetUp()
        {
            _Drinks = new DrinkList();
            _Drinks.Add(new Juice("Orange Juice", CarbonationEnum.None, "oranges"));
            _Drinks.Add(new Beer("Yuengling Lager", CarbonationEnum.Carbonated, 5.0));
            _Drinks.Add(new Juice("Cranberry Juice", CarbonationEnum.None, "cranberries"));
            _Drinks.Add(new Soda("Nitro Pepsi", CarbonationEnum.Nitrogenated));
            MyDescs = new();
            MyDescs.AddRange(_Drinks.Descriptions());
        }

        [TestMethod]
        public void Test_DescCount()
        {
            Assert.AreEqual(4, MyDescs?.Count);
        }

        [TestMethod]
        public void Test_0()
        {
            TestOneDesc(0);
        }

        [TestMethod]
        public void Test_1()
        {
            TestOneDesc(1);
        }

        [TestMethod]
        public void Test_2()
        {
            TestOneDesc(2);
        }

        [TestMethod]
        public void Test_3()
        {
            TestOneDesc(3);
        }

        private void TestOneDesc(int IndexIn)
        {
            //Order may vary, but OK for testing.
            Assert.AreEqual(_Drinks?[IndexIn].Description, MyDescs?[IndexIn]);
        }
    }

}
