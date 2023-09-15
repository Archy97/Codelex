namespace VendingMachine
{
    public class InvalidPriceException : Exception
    {
        public InvalidPriceException() : base("Price can't be Negative")
        {
        }
    }
}
