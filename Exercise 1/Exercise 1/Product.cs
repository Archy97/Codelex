using System;

namespace Shop
{
    public class Product
    {
        private string _name;
        private double _priceAtStart;
        private int _amountAtStart;

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
