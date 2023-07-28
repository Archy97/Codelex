namespace Product1ToN
{
    internal class Program
    {
        static void Main(string[] args)
        {
           var sum = 1;

            for (int number = 1; number <= 10; number++)
            {
                sum *= number;
            }

            Console.WriteLine(sum);

        }
    }
}