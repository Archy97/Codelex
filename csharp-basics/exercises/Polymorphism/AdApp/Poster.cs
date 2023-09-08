using System.Collections.Generic;

namespace AdApp
{
    public class Poster : Advert
    {
        private double _dimensions;
        private int _numCopies;
        private double _costPerCopy;
        private int _PosterTotalCost;

        private Dictionary<double, int> _dimensionToBaseCost = new Dictionary<double, int>
        {
            { 1, 300 }, 
            { 2, 500 }, 
            { 3, 700 }  
        };

        public Poster(int fee, double dimensions, int numCopies, double costPerCopy) : base(fee)
        {
            _dimensions = dimensions;
            _numCopies = numCopies;
            _costPerCopy = costPerCopy;
        }

        public override int Cost()
        {
            var getfee = getFee();
            int baseCost;

            if (_dimensionToBaseCost.ContainsKey(_dimensions))
            {
                baseCost = _dimensionToBaseCost[_dimensions];
            }
            else
            {
                baseCost = (int)(_numCopies * _costPerCopy * _dimensions);
            }

            _PosterTotalCost += baseCost + getfee;

            return _PosterTotalCost;
        }

        public override string ToString()
        {
            var result = base.ToString();
            result += $" Dimensions: {_dimensions} sq. ft.";
            result += $" Number of Copies: {_numCopies}";
            result += $" Cost Per Copy: £{_costPerCopy}";
            result += $" Total Cost: £{Cost()}";

            return result;
        }
    }
}
