using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise__3
{
    internal class FuelGauge
    {
        public int CurrentFuelLiters;

        public FuelGauge()
        {
            CurrentFuelLiters = 0;
        }

        public int ReportCurrentLiters()
        {
            return CurrentFuelLiters;
        }

        public void FillUp(int amount)
        {
            CurrentFuelLiters += amount;
        }

        public int DecrementFuel()
        {
            return CurrentFuelLiters--;
        }
    }
}