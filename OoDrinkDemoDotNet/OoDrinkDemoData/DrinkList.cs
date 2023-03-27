using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OoDrinkDemoData
{
    public class DrinkList: List<Drink>
    {
        public IEnumerable<string> Descriptions()
        {
            return from Drink CurDrink in this
                               select CurDrink.Description;
        }
    }
}
