namespace OoDrinkDemoData
{
    public class Juice: Drink
    {
        public Juice(string NameIn, CarbonationEnum CarbonationTypeIn,
                string FruitIn):
                base(NameIn, CarbonationTypeIn)
        {
            Fruit = FruitIn;
        }

        public string Fruit { get; init; }   

        public override string Description
        {
            get
            {
                return string.Format("{0}, {1}, {2}.", Name, CarbonatedString, MadeFromString);
            }
        }

        private string MadeFromString
        {
            get
            {
                return "made from " + Fruit;
            }
        }

    }
}
