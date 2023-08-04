namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int res;
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            string symbol = Console.ReadLine();

            switch (symbol)
            {
                case "+":
                    res = num1 + num2;
                    Console.WriteLine("Addition:" + res);
                    break;
                case "-":
                    res = num1 - num2;
                    Console.WriteLine("Subtraction:" + res);
                    break;
                case "*":
                    res = num1 * num2;
                    Console.WriteLine("Multiplication:" + res);
                    break;
                case "/":
                    res = num1 / num2;
                    Console.WriteLine("Division:" + res);
                    break;
                default:
                    Console.WriteLine("Wrong input");
                    break;
            }
        } 
    }
}