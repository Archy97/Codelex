using System;

namespace Shop
{
    public class Product
    {
        private string _name { get; }
        private double _priceAtStart { get; }
        private int _amountAtStart { get; }

        public Product(string name, double priceAtStart, int amountAtStart)
        {
            _name = name;
            _priceAtStart = priceAtStart;
            _amountAtStart = amountAtStart;
        }

        public void PrintProduct()
        {
            Console.WriteLine($"{_name}, {_priceAtStart}, EUR {_amountAtStart} units");
        }
    }
}
