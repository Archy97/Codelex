namespace SumOfAllNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var number = input.ToCharArray();
            var sum = 0;

            for (int i = 0; i < number.Length; i++)
            {
                sum += int.Parse(number[i].ToString());
            }

            Console.WriteLine(sum);
            Console.ReadKey();
           
        }
    }
}