using System;

namespace RentalPlace
{
    public class AlreadyRentedException : Exception
    {
        public AlreadyRentedException() : base("Already rented scooter")
        {
        }
    }
}
