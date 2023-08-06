namespace CountPositiveAndSumNegatives
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 92, 6, 73, -77, 81, -90, 99, 8, -85, 34 };
            CountAndSum(numbers);
        }

        static void CountAndSum(int[] array)
        {
            int positiveCount = 0;
            int sumNegatives = 0;

            foreach (int number in array)
            {
                if (number > 0)
                {
                    positiveCount++;
                }
                else if (number < 0)
                {
                    sumNegatives += number;
                }
            }

            Console.WriteLine(positiveCount == 0 ? "[]" : $"{positiveCount} {sumNegatives}");
        }