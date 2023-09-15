using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalPlace
{
    public class ScooterService : IScooterService
    {
        private readonly List<Scooter> _scooter;

        public ScooterService(List<Scooter> ScooterStorage)
        { 
            _scooter = ScooterStorage;
        }
        public void AddScooter(string id, decimal pricePerMinute)
        {    
            if(_scooter.Any(s => s.Id == id ))
            {
                throw new DuplicateScooterException();
            }

            if (pricePerMinute <= 0) 
            { 
                throw new NegativePriceException();
            }

            if(string.IsNullOrEmpty(id))
            {
                throw new InvalidIdException();
            }
            _scooter.Add(new Scooter(id, pricePerMinute));
        }

        public Scooter GetScooterById(string scooterId)

        {  
            if (string.IsNullOrEmpty(scooterId))
            {
                throw new InvalidIdException();
            }

            return _scooter.FirstOrDefault(s => s.Id == scooterId);
        }

        public IList<Scooter> GetScooters()
        {
            return _scooter.ToList();
        }

        public void RemoveScooter(string id)
        {
            var scooter = _scooter.FirstOrDefault(s => s.Id == id);

            if (scooter == null)
            {
                throw new ScooterNotFoundException(); 
            }

            _scooter.Remove(scooter);

            if (scooter.IsRented)
            {
                throw new ScooterRentedException();
            }
        }
    }
}
