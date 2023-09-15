
namespace RentalPlace
{
    public class DuplicateScooterException : Exception
    {

        public DuplicateScooterException() : base("Scooter already exists") { 
        
        }
    }
}
