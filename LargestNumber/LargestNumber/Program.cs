namespace LargestNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Numbers");
            Console.WriteLine(Math.Max(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())));
        }
    }
}