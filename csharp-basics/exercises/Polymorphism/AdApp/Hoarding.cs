namespace AdApp
{
    public class Hoarding : Advert
    {
        private int _rate;
        private int _numDays;
        private bool _primeLocation;
        private int _HoardingTotalCost;

        public Hoarding(int fee, int rate, int numDays, bool primeLocation) : base(fee)
        {
            _numDays = numDays;
            _rate = rate;
            _primeLocation = primeLocation;
        }

        public override int Cost()
        {
            var getfee = getFee();
            double totalCost = _numDays * _rate;

            if (_primeLocation)
            {
                totalCost += 0.5 * totalCost;
            }
            _HoardingTotalCost += (int)totalCost + getfee;

            return _HoardingTotalCost;
        }

        public override string ToString()
        {
            var result = base.ToString();
            result += " Days : " + _numDays;
            result += " Rate : " + _rate +"%";
            result += " PrimeLocation : " + _primeLocation + " |";
            result += $" TotalCost: £{Cost()}";

            return result;
        }
    }
}
