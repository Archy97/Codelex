using VendingMachine;

public class Constant
{
    public static readonly Money[] MoneyList = new Money[]
    {
        new Money { Euros = 0, Cents = 10 },
        new Money { Euros = 0, Cents = 20 },
        new Money { Euros = 0, Cents = 50 },
        new Money { Euros = 1, Cents = 0 },
        new Money { Euros = 2, Cents = 0 }
    };
}