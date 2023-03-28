namespace OoDrinkDemoData
{
    public class Drink
    {
        public Drink(string NameIn, CarbonationEnum CarbonationTypeIn)
        {
            Name = NameIn;
            CarbonationType = CarbonationTypeIn;
        }

        public string Name { get; init; }
        public CarbonationEnum CarbonationType { get; init; }

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
                switch (CarbonationType)
                {
                    case CarbonationEnum.None:
                        {
                            return "not carbonated";
                        }
                    case CarbonationEnum.Carbonated:
                        {
                            return "carbonated";
                        }
                    case CarbonationEnum.Nitrogenated:
                        {
                            return "nitrogenated";
                        }
                    default:
                        {
                            return "unknown";
                        }
                }
            }
        }
    }

    public enum CarbonationEnum
    {
        Unknown,
        None,
        Carbonated,
        Nitrogenated
    }
}