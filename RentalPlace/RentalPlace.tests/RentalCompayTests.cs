

using FluentAssertions;
using System.Collections.Generic;

namespace RentalPlace.tests
{
    [TestClass]
    public class RentalCompayTests
    {
        private IRentalCompany _rentalcompany;
        private const string DEFAULT_COMPANY_NAME = "default";
        private List<Scooter> _scooterList;
        private List<ScooterRentHistory> _scooterRentHistory;
        private RentalCalculator _rentalCalculator;

      
        [TestInitialize]
        public void Setup()
        {
            _rentalCalculator = new RentalCalculator();
            _scooterList = new List<Scooter>();
            _scooterRentHistory = new List<ScooterRentHistory>();
            _rentalcompany = new RentalCompany(DEFAULT_COMPANY_NAME, new ScooterService(_scooterList), _scooterRentHistory , _rentalCalculator);

        }

        [TestMethod]
        public void StartRent_ThrowsExceptionForNonExistentScooter()
        {
            _scooterList.Add(new Scooter("1", 1));
            _scooterRentHistory.Add(new ScooterRentHistory("1" , DateTime.Now));

            Action action = () => _rentalcompany.StartRent("2");

            action.Should().Throw<ScooterNotFoundException>();
        }

        [TestMethod]
        public void StartRent_ForAlreadyRentedScooter_ThrowsAlreadyRentedException()
        {
            var rentedScooter = new Scooter("1", 1);
            rentedScooter.IsRented = true;
            _scooterList.Add(rentedScooter);

            Action action = () => _rentalcompany.StartRent("1");

            action.Should().Throw<AlreadyRentedException>();
        }

        [TestMethod]
        public void StartRent_SetsIsRentedToTrue()
        {
            _scooterList.Add(new Scooter("1", 1));

            _scooterRentHistory.Add(new ScooterRentHistory("1", DateTime.Now));

            _rentalcompany.StartRent("1");

            var scooter = _scooterList.FirstOrDefault(s => s.Id == "1");

            scooter.IsRented.Should().BeTrue();
        }

        [TestMethod]
        public void EndRent_ScooterRentedFor10Minutes_ReturnsTotalPrice()
        {    
            _scooterList.Add(new Scooter("1", 0.10m));
            _scooterRentHistory.Add(new ScooterRentHistory("1",  DateTime.Now.AddMinutes(-10)));

            var price = _rentalcompany.EndRent("1");

            price.Should().Be(1);

        }

        [TestMethod]
        public void EndRent_NullOrEmptyId_ThrowsArgumentException()
        {
            Action actionWithNullId = () => _rentalcompany.EndRent(null);
            Action actionWithEmptyId = () => _rentalcompany.EndRent("");

            actionWithNullId.Should().Throw<InvalidIdException>();
            actionWithEmptyId.Should().Throw<InvalidIdException>();
        }

        [TestMethod]
        public void CalculateIncome_WithYearAndIncludeNotCompletedRentalTrue_ReturnsTotalIncome()
        {
            _scooterList.Add(new Scooter("1", 0.10m));
            
            _scooterRentHistory.Add(new ScooterRentHistory("1", new DateTime(2023, 12, 31, 10, 0, 0)));
            
            var income = _rentalcompany.CalculateIncome(2023, true);

            income.Should().Be(_rentalcompany.EndRent("1"));
        }

        [TestMethod]
        public void CalculateIncome_WithYearAndExcludeNotCompletedRentalsFalse_ReturnsTotalIncome()
        {
            _scooterList.Add(new Scooter("1", 0.10m));

            _scooterRentHistory.Add(new ScooterRentHistory("1", new DateTime(2023, 12, 31, 10, 0, 0)));

            var income = _rentalcompany.CalculateIncome(2023, false);

            income.Should().Be(_rentalcompany.EndRent("1"));
        }

        [TestMethod]
        public void CalculateIncome_ForAllYearsNullBooleanFalse_ReturnsSumOffFinishedRents()
        {
            _scooterList.Add(new Scooter("1", 0.10m));
            _scooterList.Add(new Scooter("2", 0.10m));

            _scooterRentHistory.Add(new ScooterRentHistory("1", new DateTime(2022, 12, 31, 10, 0, 0)));
            _scooterRentHistory.Add(new ScooterRentHistory("2", new DateTime(2023, 1, 1, 15, 0, 0)));

            var income = _rentalcompany.CalculateIncome(null, false);

            income.Should().Be(_rentalcompany.EndRent("1") + _rentalcompany.EndRent("2"));
        }

        [TestMethod]
        public void CalculateIncome_ForAllYearsNullBooleanTrue_ReturnsTotalIncomeForAllYears()

        {
            _scooterList.Add(new Scooter("1", 0.10m));
            _scooterList.Add(new Scooter("2", 0.10m));
            
            _scooterRentHistory.Add(new ScooterRentHistory("1", new DateTime(2022, 12, 31, 10, 0, 0)));
            _scooterRentHistory.Add(new ScooterRentHistory("2", new DateTime(2023, 1, 1, 15, 0, 0)));
            
            var income = _rentalcompany.CalculateIncome(null, true);

            income.Should().Be(_rentalcompany.EndRent("1") + _rentalcompany.EndRent("2"));
        }

        [TestMethod]
        public void EndRent_InvalidScooterId_ThrowsWrongIdException()
        {
            _scooterList.Add(new Scooter("1", 0.10m));

            Action action = () => _rentalcompany.EndRent("2"); 

            action.Should().Throw<WrongIdException>();
        }


        [TestMethod]
        public void EndRent_ScooterRentedFor1Minute_ReturnsTotalPriceAndIsRentedShouldBeFalse()
        {
            _scooterList.Add(new Scooter("1", 1));
            _scooterRentHistory.Add(new ScooterRentHistory("1", DateTime.Now.AddMinutes(-1)));

            var price = _rentalcompany.EndRent("1");

            price.Should().Be(1);
            var scooter = _scooterList.First();
            scooter.IsRented.Should().BeFalse();
        }

        [TestMethod]
        public void EndRent_ScooterRentedFor1Hour_ReturnsTotalPrice()
        {
            _scooterList.Add(new Scooter("1", 0.05m));
            _scooterRentHistory.Add(new ScooterRentHistory("1",DateTime.Now.AddHours(-1)));

            var price = _rentalcompany.EndRent("1");

            price.Should().Be(3);

        }

        [TestMethod]
        public void EndRent_ScooterRented_ReturnsPriceFor24Hours()
        {
            _scooterList.Add(new Scooter("1", 0.10m));
            _scooterRentHistory.Add(new ScooterRentHistory("1", new DateTime(2023, 9, 12, 21, 00, 00)));
            _scooterRentHistory.First().rentEnd = new DateTime(2023, 9, 13, 21, 00, 00);
            var price = _rentalcompany.EndRent("1");

            price.Should().Be(38.00m);
        }

        [TestMethod]
        public void EndRent_ScooterRented_ReturnsMaximumAmountForSameDay()
        {
            _scooterList.Add(new Scooter("1", 1));
            _scooterRentHistory.Add(new ScooterRentHistory("1", new DateTime(2023, 9, 13, 00, 00, 00)));
            _scooterRentHistory.First().rentEnd = new DateTime(2023, 9, 13, 21, 00, 00);

            var price = _rentalcompany.EndRent("1");

            price.Should().Be(20);
        }

        [TestMethod]
        public void EndRent_ScooterRented_ReturnsMaximumAmountBeforeAndAfterMidnight()
        {
            _scooterList.Add(new Scooter("1", 1));
            _scooterRentHistory.Add(new ScooterRentHistory("1", new DateTime(2023, 9, 12, 00, 00, 00)));
            _scooterRentHistory.First().rentEnd = new DateTime(2023, 9, 13, 10, 00, 00);

            var price = _rentalcompany.EndRent("1");

            price.Should().Be(40);
        }
    }
}
