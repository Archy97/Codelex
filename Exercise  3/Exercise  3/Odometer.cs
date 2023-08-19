using System;

namespace Exercise__3
{
    internal class Odometer
    {
        public int CurrentMileage;
        public FuelGauge fuelGauge;
        public int Count;

        public Odometer(FuelGauge fuelgauge, int CurrentMileage)
        {
            fuelGauge = fuelgauge;
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
                Count++;
            }
        }
        public void Decrement()
        {
            if (Count == 10)
            {
                fuelGauge.DecrementFuel();
                Count = 0;
            }
        }
    }
}