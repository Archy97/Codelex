namespace Exercise_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length = 4;
            int input = int.Parse(Console.ReadLine());
            int totalLength = (input - 1) * length;

            for (int i = 0; i < input; i++)
            {
                int strLength = i * length;

                Console.WriteLine(new string('/', totalLength - strLength) + new string('*', strLength)
                                    + new string('*', strLength) + new string('\\', totalLength - strLength));
            }
        }
    }
}
