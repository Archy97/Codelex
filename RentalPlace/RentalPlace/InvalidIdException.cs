
namespace RentalPlace
{
    public class InvalidIdException : Exception
    {
        public InvalidIdException():base ("The id cannot be Null or Empty") { }
    }
}
