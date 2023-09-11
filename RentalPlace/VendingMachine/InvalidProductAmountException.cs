
namespace VendingMachine
{
    public class InvalidProductAmountException : Exception
    {
        public InvalidProductAmountException() :base ("Amount can't be negative")
        {
        }
    }
}
