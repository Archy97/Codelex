using FluentAssertions;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using Moq;
using static System.Net.Mime.MediaTypeNames;

namespace RentalPlace.tests
{
    [TestClass]
    public class ScooterServiceTests
    {
        private ScooterService _scooterService;
        private List<Scooter>  _scooterStorage;
        private const string DEFAULT_SCOOTER_ID = "1";
        private const decimal DEFAULT_PRICE_PER_MINUTE = 0.2m;

        [TestInitialize]
        public void Setup()
        {
            _scooterStorage = new List<Scooter>();
            _scooterService = new ScooterService(_scooterStorage);
        }

        [TestMethod]
        public void AddScooter_WithIdAndPricePerMinute_ScooterAdded()

        {
            _scooterService.AddScooter(DEFAULT_SCOOTER_ID, DEFAULT_PRICE_PER_MINUTE);
            _scooterStorage.Count.Should().Be(1);
        }

        [TestMethod]
        public void AddScooter_WithId1AndPricePerMinute1_ScooterAddedWithId1andPrice1()
        {
            _scooterService.AddScooter(DEFAULT_SCOOTER_ID, 1m);

            var scooter = _scooterStorage.First();
            scooter.Id.Should().Be(DEFAULT_SCOOTER_ID);
            scooter.PricePerMinute.Should().Be(1m);
        }

        [TestMethod]
        public void AddScooter_DuplicateScooter_ThrowsExceptionDuplicateScooter()
        {
            _scooterStorage.Add(new Scooter(DEFAULT_SCOOTER_ID, DEFAULT_PRICE_PER_MINUTE));

            Action action = () => _scooterService.AddScooter(DEFAULT_SCOOTER_ID, DEFAULT_PRICE_PER_MINUTE);

            action.Should().Throw<DuplicateScooterException>();
        }

        [TestMethod]
        public void AddScooter_With_Negative_Price_ThrowsExceptionNegativePrice()
        {
            Action action = () => _scooterService.AddScooter(DEFAULT_SCOOTER_ID, -1);

            action.Should().Throw<NegativePriceException>();
        }

        [TestMethod]
        public void AddScooter_With_Empty_Id_ThrowsExceptionInvalidId()

        {
            Action action = () => _scooterService.AddScooter("", DEFAULT_PRICE_PER_MINUTE);

            action.Should().Throw<InvalidIdException>();
        }

        [TestMethod]
        public void GetScooterById_IfTheIdIsRight()
        {
            _scooterService.AddScooter(DEFAULT_SCOOTER_ID, DEFAULT_PRICE_PER_MINUTE);

            var foundScooter = _scooterService.GetScooterById(DEFAULT_SCOOTER_ID);

            Assert.AreEqual(foundScooter.Id, DEFAULT_SCOOTER_ID);
        }

        [TestMethod]
        public void GetScooterById_With_Empty_Id_ThrowsExceptionInvalidId()
        {
            Action action = () => _scooterService.GetScooterById("");

            action.Should().Throw<InvalidIdException>();
        }

        [TestMethod]
        public void GetScooterById_WhenMultipleScooters_ReturnsCorrectScooter()
        {
            _scooterService.AddScooter("Scooter1", 1.0m);
            _scooterService.AddScooter(DEFAULT_SCOOTER_ID, DEFAULT_PRICE_PER_MINUTE);
            _scooterService.AddScooter("Scooter3", 1.5m);

            var foundScooter = _scooterService.GetScooterById(DEFAULT_SCOOTER_ID);

            Assert.AreEqual(DEFAULT_SCOOTER_ID, foundScooter.Id);
        }

        [TestMethod]
        public void GetScooterById_With_NonExisting_Id_Returns_Null()
        {
            var result = _scooterService.GetScooterById("NonExistingId");

            result.Should().BeNull();
        }

        [TestMethod]
        public void GetScooters_ReturnsListOfScooters()
        {
            _scooterService.AddScooter("Scooter1", 0.5m);
            _scooterService.AddScooter("Scooter2", 0.6m);
            _scooterService.AddScooter("Scooter3", 0.7m);

            var scooters = _scooterService.GetScooters();
            
            scooters.Should().Contain(s => s.Id == "Scooter1");
            scooters.Should().Contain(s => s.Id == "Scooter2");
            scooters.Should().Contain(s => s.Id == "Scooter3");
        }

        [TestMethod]
        public void GetScooters_ReturnsCountOfScooters()
        {
            _scooterService.AddScooter("Scooter1", 0.5m);
            _scooterService.AddScooter("Scooter2", 0.6m);
            _scooterService.AddScooter("Scooter3", 0.7m);

            var scooters = _scooterService.GetScooters();

            scooters.Count.Should().Be(3);
        }

        [TestMethod]
        public void RemoveScooter_ScooterCountMustBe0()
        {
            _scooterService.AddScooter(DEFAULT_SCOOTER_ID, DEFAULT_PRICE_PER_MINUTE);
            _scooterService.RemoveScooter(DEFAULT_SCOOTER_ID);

            var remainingScooters = _scooterService.GetScooters();

            remainingScooters.Count.Should().Be(0);
        }

        [TestMethod]
        public void RemoveScooterById_ScooterNotFound_ThrowsScooterNotFoundException()
        {
            var nonExistentScooterId = "NonExistentId";

            Action action = () => _scooterService.RemoveScooter(nonExistentScooterId);

            action.Should().Throw<ScooterNotFoundException>();
        }

        [TestMethod]
        public void RemoveScooter_ThrowsExceptionForRentedScooter()
        {
            _scooterService.AddScooter(DEFAULT_SCOOTER_ID, 1);

            _scooterStorage.First().IsRented = true;

            Assert.ThrowsException<ScooterRentedException>(() => _scooterService.RemoveScooter(DEFAULT_SCOOTER_ID));
        }
    }     
}