
namespace VendingMachine
{
    public class InvalidProductPriceException: Exception
    {
        public InvalidProductPriceException(): base("Price can't be null")
        {
        }
    }
}
