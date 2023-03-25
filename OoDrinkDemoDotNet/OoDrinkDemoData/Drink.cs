namespace OoDrinkDemoData
{
    public class Drink
    {
        [Obsolete]
        public Drink(string NameIn, bool IsCarbonatedIn): 
                this(NameIn, IsCarbonatedIn, CarbonationTypeFromBool(IsCarbonatedIn))
        {
        }

        [Obsolete]
        public Drink(string NameIn, bool IsCarbonatedIn, 
                CarbonationEnum CarbonationTypeIn):
                this(NameIn, CarbonationTypeIn)
        {
        }

        public Drink(string NameIn, CarbonationEnum CarbonationTypeIn)
        {
            Name = NameIn;
            CarbonationType = CarbonationTypeIn;
            IsCarbonated = (CarbonationTypeIn == CarbonationEnum.Carbonated);
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

        protected static CarbonationEnum CarbonationTypeFromBool(bool BoolIn)
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