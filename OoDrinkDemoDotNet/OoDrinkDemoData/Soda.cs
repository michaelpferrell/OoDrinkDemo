namespace OoDrinkDemoData
{
    // For now, this looks like Drink.  In the future, it could have additional
    // attributes like caffeine content, color, sweetener type.
    public class Soda: Drink
    {
        [Obsolete]
        public Soda(string NameIn, bool IsCarbonatedIn): 
                this(NameIn, CarbonationTypeFromBool(IsCarbonatedIn))
        {

        }

        public Soda(string NameIn, CarbonationEnum CarbonationTypeIn):
                base(NameIn, CarbonationTypeIn)
        {
            
        }
    }
}
