using System;

namespace Shop
{
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
}