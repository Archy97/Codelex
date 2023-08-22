using System.Data.Common;

namespace AdApp
{
    public class NewspaperAd : Advert
    {
        private int _column;
        private int _rate;
        private int _NewsTotalCost;

        public NewspaperAd(int fee, int column, int rate) : base(fee)
        {
            _rate = rate;
            _column = column;
        }

        public override int Cost()
        {
            var getfee = getFee();
            int totalCost = _column * _rate;
            _NewsTotalCost += totalCost + getfee;

            return _NewsTotalCost;
        }

        public override string ToString()
        {
            var result = base.ToString();
            result += " Column : " + _column;
            result += " Rate : " + _rate + "%";
            result += $" TotalCost: £{Cost()}";

            return result;
        }
    }
}
