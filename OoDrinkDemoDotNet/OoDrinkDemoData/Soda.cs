namespace OoDrinkDemoData
{
    // For now, this looks like Drink.  In the future, it could have additional
    // attributes like caffeine content, color, sweetener type.
    public class Soda: Drink
    {
        public Soda(string NameIn, CarbonationEnum CarbonationTypeIn):
                base(NameIn, CarbonationTypeIn)
        {
            
        }
    }
}
