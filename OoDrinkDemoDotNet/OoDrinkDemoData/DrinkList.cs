using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OoDrinkDemoData
{
    public class DrinkList: List<Drink>
    {
        public List<string> Descriptions()
        {
            //return from Drink CurDrink in this
            //       select CurDrink.Description;
            //Instructions say to use a loop instead.
            List<string> MyList = new();
            foreach (Drink CurDrink in this)
            {
                MyList.Add(CurDrink.Description);
            }
            return MyList;
        }
    }
}
