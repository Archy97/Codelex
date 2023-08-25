using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise__3
{
    internal class FuelGauge
    {
        private int _currentFuelLiters;

        public FuelGauge()
        {
            _currentFuelLiters = 0;
        }

        public int ReportCurrentLiters()
        {
            return _currentFuelLiters;
        }

        public void FillUp(int amount)
        {
            _currentFuelLiters += amount;
        }

        public int DecrementFuel()
        {
            return _currentFuelLiters--;
        }
    }
}