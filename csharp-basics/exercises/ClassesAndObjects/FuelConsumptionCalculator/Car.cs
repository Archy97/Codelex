using System;

namespace FuelConsumptionCalculator
{
    public class Car
    {
        private double _startKilometers;
        private double _endKilometers;
        private double _liters;

        public Car(double startOdo)
        {
            _startKilometers = startOdo;
        }

        public void FillUp(int mileage, double litersFilled)
        {
            _startKilometers = _endKilometers;
            _endKilometers = mileage;
            _liters = litersFilled;
        }

        public double CalculateConsumption()
        {
            return (double)_liters / (_endKilometers - _startKilometers);
        }

        public bool IsGasHog()
        {
            double consumption = CalculateConsumption();
            return (consumption * 100) > 15.0;
        }

        public bool IsEconomyCar()
        {
            double consumption = CalculateConsumption();
            return (consumption * 100) < 5.0;
        }
    }
}
