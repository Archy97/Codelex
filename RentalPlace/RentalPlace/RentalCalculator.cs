
namespace RentalPlace
{
    public class RentalCalculator
    {
        public decimal CalculateRent(ScooterRentHistory rentalRecord, Scooter scooter)
        {
            var timeDif = rentalRecord.rentEnd - rentalRecord.rentStart;

            var firstDayRent = 1440 - rentalRecord.rentStart.TimeOfDay.TotalMinutes;
            decimal multipleDayIncome = 0;
            var lastDayRentPrice = (int)rentalRecord.rentEnd.Value.TimeOfDay.TotalMinutes;

            var days = timeDif.Value.Days;

            if (days == 0)
            {
                var income = (decimal)timeDif.Value.TotalMinutes * (decimal)scooter.PricePerMinute;
                return income > 20 ? 20 : Math.Floor(income);
            }

            if ((decimal)firstDayRent * (decimal)scooter.PricePerMinute > 20)
            {
                multipleDayIncome += 20;
            }
            else
            {
                multipleDayIncome += (decimal)firstDayRent * (decimal)scooter.PricePerMinute;
            }

            if (lastDayRentPrice * (decimal)scooter.PricePerMinute < 20)
            {
                multipleDayIncome += (decimal)lastDayRentPrice * (decimal)scooter.PricePerMinute;
            }
            else
            {
                multipleDayIncome += 20;
            }

            if (days - 1 > 1)
            {
                if (scooter.PricePerMinute * 1440 >= 20)
                {
                    multipleDayIncome += days * 20;
                }
                else
                {
                    multipleDayIncome += days * 1440 * (decimal)scooter.PricePerMinute;
                }

            }
            return Math.Round(multipleDayIncome, 2);
        }
    }
}
