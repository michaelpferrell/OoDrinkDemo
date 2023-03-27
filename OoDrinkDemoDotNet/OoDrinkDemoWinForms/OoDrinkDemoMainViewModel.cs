using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OoDrinkDemoData;

namespace OoDrinkDemoWinForms
{
    internal class OoDrinkDemoMainViewModel
    {
        public event EventHandler? DrinkListChanged;

        private DrinkList? _Drinks = null;

        public OoDrinkDemoMainViewModel()
        {
            _Drinks = new DrinkList();
        }

        public IEnumerable<string>? DrinkDescriptions()
        {
            return _Drinks?.Descriptions();
        }

        public void AddDefaultDrinksToList()
        {
            AddOneDrink(new Juice("Orange Juice", CarbonationEnum.None, "oranges"));
            AddOneDrink(new Juice("Sparkling Lemonade", CarbonationEnum.Carbonated, "lemons"));
            AddOneDrink(new Soda("Pepsi", CarbonationEnum.Carbonated));
            AddOneDrink(new Soda("Nitro Pepsi", CarbonationEnum.Nitrogenated));
            AddOneDrink(new Beer("Budweiser", CarbonationEnum.Carbonated, 5.0));
        }

        private void AddOneDrink(Drink DrinkIn)
        {
            _Drinks?.Add(DrinkIn);
            DrinkListChanged?.Invoke(this, new EventArgs());
        }
    }
}
