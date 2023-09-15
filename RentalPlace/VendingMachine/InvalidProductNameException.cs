namespace VendingMachine
{
    public class InvalidProductNameException : Exception
    {
        public InvalidProductNameException() : base("Name is null or empty.")
        {
        }
    }
}