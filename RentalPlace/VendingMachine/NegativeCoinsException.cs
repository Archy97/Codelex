namespace VendingMachine
{
    public class NegativeCoinsException : Exception
    {
        public NegativeCoinsException() :base ("Money values must be non-negative.")
        { 
        }
    }
}
