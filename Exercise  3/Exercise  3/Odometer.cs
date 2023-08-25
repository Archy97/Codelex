using System;

namespace Exercise__3
{
    internal class Odometer
    {
        private int _currentMileage;
        private FuelGauge _fuelGauge;
        private int _count;

        public Odometer(FuelGauge fuelgauge, int CurrentMileage)
        {
            _fuelGauge = fuelgauge;
            CurrentMileage = 0;
        }

        public int ReportCurrentMileage()
        {
            return _currentMileage;
        }

        public void IncrementMileage()
        {
            if (_currentMileage == 9999999)
            {
                _currentMileage = 0;
            }
            else
            {
                _currentMileage++;
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