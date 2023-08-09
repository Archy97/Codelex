using Shop;
using System;

namespace Shop
{
    public class Product
    {
        public string Name { get; }
        public double PriceAtStart { get; }
        public int AmountAtStart { get; }

        public Product(string name, double priceAtStart, int amountAtStart)
        {
            Name = name;
            PriceAtStart = priceAtStart;
            AmountAtStart = amountAtStart;
        }

        public void PrintProduct()
        {
            Console.WriteLine($"{Name},  {PriceAtStart}, EUR {AmountAtStart} units");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Product mouse = new Product("Logitech mouse", 70.00, 14);
        Product iphone = new Product("iPhone 5s", 999.99, 3);
        Product projector = new Product("Epson EB-U05", 440.46, 1);

        mouse.PrintProduct();
        iphone.PrintProduct();
        projector.PrintProduct();
    }
}
