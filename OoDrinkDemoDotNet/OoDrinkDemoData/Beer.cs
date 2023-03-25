namespace OoDrinkDemoData
{
    public class Beer: Drink
    {
        public Beer(string NameIn, bool IsCarbonatedIn, double AlcoholPercentageIn) : 
                base(NameIn, IsCarbonatedIn)
        {
            AlcoholPercentage = AlcoholPercentageIn;
        }

        public double AlcoholPercentage { get; init; }

        public override string Description
        {
            get
            {
                return string.Format("{0}, {1}, {2}.", Name, CarbonatedString,
                    AcoholString);
            }
        }

        private string AcoholString
        {
            get
            {
                return AlcoholPercentage.ToString("0.#") + "%";
            }
        }
    }
}
