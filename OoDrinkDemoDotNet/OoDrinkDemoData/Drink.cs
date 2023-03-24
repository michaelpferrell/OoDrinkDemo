namespace OoDrinkDemoData
{
    public class Drink
    {
        public Drink(string NameIn, bool IsCarbonatedIn)
        {
            Name = NameIn;
            IsCarbonated = IsCarbonatedIn;
        }

        public string Name { get; init; }
        public bool IsCarbonated { get; init; }

        public virtual string Description
        {
            get
            {
                return string.Format("{0}, {1}.", Name, CarbonatedString);
            }
        }

        protected string CarbonatedString
        {
            get
            {
                string IsIsnt = (IsCarbonated ? "" : "not ");
                return IsIsnt + "carbonated";
            }
        }
    }
}