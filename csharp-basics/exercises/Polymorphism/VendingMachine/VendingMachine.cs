using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public class VendingMachine : IVendingMachine<Money, Product>
    {
        private List<Product> _products = new List<Product>();
        private Money _coin = new Money();
        public string Manufacturer { get; }
        public bool HasProducts => _products.Any(product => product.Available > 0);
        public Money Amount => _coin;
        public Product[] Products => _products.ToArray();

        public VendingMachine(string manufacturer)
        {
            Manufacturer = manufacturer; 
        }

        public Money InsertCoin(Money amount)
        {
            _coin = new Money
            {
                Euros = Amount.Euros + amount.Euros + (Amount.Cents + amount.Cents) / 100,
                Cents = (Amount.Cents + amount.Cents) % 100
            };

            return new Money { Euros = 0, Cents = 0 };
        }

        public Money ReturnMoney()
        {
            Money returnedAmount = new Money();
            returnedAmount.Euros = _coin.Euros;
            returnedAmount.Cents = _coin.Cents;
            _coin.Cents = 0;
            _coin.Euros = 0;
            return returnedAmount;
        }

        public bool AddProduct(string name, Money price, int count)
        {
            var newProduct = new Product
            {
                Name = name,
                Price = price,
                Available = count
            };

            _products.Add(newProduct);

            return true;
        }

        public bool UpdateProduct(int productNumber, string name, Money? price, int amount)
        {
            if (productNumber >= 0 && productNumber < _products.Count)
            {
                Product product = _products[productNumber];

                    int availableDifference = product.Available - amount;
                    if (availableDifference > 0)
                    {
                        Money deductedPrice = new Money
                        {
                            Euros = product.Price.Euros * availableDifference,
                            Cents = product.Price.Cents * availableDifference
                        };

                        _coin.Euros -= deductedPrice.Euros;
                        _coin.Cents -= deductedPrice.Cents;

                        while (_coin.Cents < 0)
                        {
                            _coin.Euros--;
                            _coin.Cents += 100;
                        }

                        Console.WriteLine($"Amount Returned: {_coin.Euros}.{_coin.Cents:00}");
                    }

                    product.Available = amount;
                    _products[productNumber] = product;
                
            }
            return true;

        }
    }

}
