
namespace VendingMachine
{
    public class InvalidCountException: Exception

    {
        public InvalidCountException(): base("Count can't be negative")
        { 
        }
    }
}
