namespace CheckOddEven
{
    internal class Program
    {
        static void Main(string[] args)
        {    
            int x = int.Parse(Console.ReadLine());
            CheckOddEven(x);
        }

        static void CheckOddEven (int x)
        {
            if( x % 2 == 1)
            {
                Console.WriteLine("Odd Number");
            }

            else
            {
                Console.WriteLine("Even Number");
            }

                Console.WriteLine("bye!");
        }

    }
}