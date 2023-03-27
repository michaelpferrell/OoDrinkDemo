namespace OoDrinkDemoData
{
    public class Beer: Drink
    {
        [Obsolete]
        public Beer(string NameIn, bool IsCarbonatedIn, double AlcoholPercentageIn) : 
                this(NameIn, CarbonationTypeFromBool(IsCarbonatedIn), 
                    AlcoholPercentageIn)
        {
            //AlcoholPercentage = AlcoholPercentageIn;
        }

        public Beer(string NameIn, CarbonationEnum CarbonationTypeIn,
                double AlcoholPercentageIn):
                base(NameIn, CarbonationTypeIn)
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
