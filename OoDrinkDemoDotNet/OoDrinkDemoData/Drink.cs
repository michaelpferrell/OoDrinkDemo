namespace OoDrinkDemoData
{
    public class Drink
    {
        public Drink(string NameIn, bool IsCarbonatedIn)
        {
            Name = NameIn;
            IsCarbonated = IsCarbonatedIn;
            CarbonationType = CarbonationTypeFromBool(IsCarbonated);
        }

        public string Name { get; init; }
        public bool IsCarbonated { get; init; }
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

        protected CarbonationEnum CarbonationTypeFromBool(bool BoolIn)
        {
            if (BoolIn)
            {
                return CarbonationEnum.Carbonated;
            }
            else
            {
                return CarbonationEnum.None;
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