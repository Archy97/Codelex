using System;

namespace Exercise__3
{
    internal class Odometer
    {
        public int CurrentMileage;
        private FuelGauge _fuelGauge;
        private int _count;

        public Odometer(FuelGauge fuelgauge, int CurrentMileage)
        {
            _fuelGauge = fuelgauge;
            CurrentMileage = 0;
        }

        public int ReportCurrentMileage()
        {
            return CurrentMileage;
        }

        public void IncrementMileage()
        {
            if (CurrentMileage == 9999999)
            {
                CurrentMileage = 0;
            }
            else
            {
                CurrentMileage++;
                _count++;
            }
        }

        public void Decrement()
        {
            if (_count == 10)
            {
                _fuelGauge.DecrementFuel();
                _count = 0;
            }
        }
    }
}