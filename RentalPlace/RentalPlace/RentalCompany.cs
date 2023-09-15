
using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Xml.Schema;

namespace RentalPlace
{
    public class RentalCompany : IRentalCompany
    {
        private readonly IScooterService _scooterService;
        private readonly List<ScooterRentHistory> _rentedScooterList;
        private string DEFAULT_COMPANY_NAME;
        private ScooterService scooterService;
        private readonly RentalCalculator _calculator;

        public RentalCompany(string name, IScooterService scooterService, List<ScooterRentHistory> rentedScooterList,
            RentalCalculator calculator)
        {
            Name = name;
            _scooterService = scooterService;
            _rentedScooterList = rentedScooterList;
            _calculator = calculator;
        }

        public RentalCompany(string DEFAULT_COMPANY_NAME, ScooterService scooterService)
        {
            this.DEFAULT_COMPANY_NAME = DEFAULT_COMPANY_NAME;
            this.scooterService = scooterService;
        }

        public string Name { get; }

        public void StartRent(string id)
        {
            var scooter = _scooterService.GetScooterById(id);

            if (scooter == null)
            {
                throw new ScooterNotFoundException();
            }

            if (scooter.IsRented)
            {
                throw new AlreadyRentedException();
            }

            scooter.IsRented = true;
            _rentedScooterList.Add(new ScooterRentHistory(scooter.Id, DateTime.Now));

        }
        public decimal CalculateIncome(int? year, bool includeNotCompletedRentals)
        {
            var rentedScooters = _rentedScooterList;

            if (year.HasValue && includeNotCompletedRentals)
            {
                return rentedScooters
                    .Where(s => s.rentStart.Year == year)
                    .Sum(s => EndRent(s.Id));
            }

            if (year.HasValue && !includeNotCompletedRentals)
            {
                return rentedScooters
                    .Where(s => s.rentStart.Year == year)
                    .Where(s => !_scooterService.GetScooterById(s.Id).IsRented)
                    .Sum(s => EndRent(s.Id));
            }

            if (!year.HasValue && includeNotCompletedRentals)
            {
                return rentedScooters.Sum(s => EndRent(s.Id));
            }

            return rentedScooters
                .Where(s => !_scooterService.GetScooterById(s.Id).IsRented)
                .Sum(s => EndRent(s.Id));
        }

        public decimal EndRent(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                throw new InvalidIdException();
            }
           
            var rentalRecord = _rentedScooterList.FirstOrDefault(r => r.Id == id);

            if (rentalRecord == null)
            {
                throw new WrongIdException();
            }

            if (!rentalRecord.rentEnd.HasValue)
            {
                rentalRecord.rentEnd = DateTime.Now;
                return _calculator.CalculateRent(rentalRecord, _scooterService.GetScooterById(id));
            }

            return _calculator.CalculateRent(rentalRecord, _scooterService.GetScooterById(id));
        }
    }
}

