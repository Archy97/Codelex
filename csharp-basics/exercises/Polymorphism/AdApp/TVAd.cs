using System.Diagnostics;

namespace AdApp
{
    public class TVAd : Advert
    {
        private int _secondsRate;
        private bool _peakTime;
        private int _seconds;
        private int _TvAdTotalCost;

        public TVAd(int fee, int secondsRate, int rate, bool peakTime) : base(fee)
        {
            _secondsRate = secondsRate;
            _peakTime = peakTime;
            _seconds = rate;
        }

        public override int Cost()
        {
            var getfee = getFee();
            int baseCost = _secondsRate * _seconds;

            if (_peakTime)
            {
                baseCost *= 2;
            }
            _TvAdTotalCost += baseCost + getfee;

            return _TvAdTotalCost;
        }

        public override string ToString()
        {
            var result = base.ToString();
            
            result += " Seconds Rate: " + _secondsRate;
            result += " Seconds: " + _seconds;
            result += " PeakTime: " + _peakTime + " |";
            result += $" TotalCost: £{Cost()}";
            return result;
        }
    }
}
