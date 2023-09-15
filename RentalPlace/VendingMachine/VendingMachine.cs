using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Runtime.Serialization;

namespace VendingMachine
{
    public class VendingMachine : IVendingMachine<Money, Product>
    {
        private List<Product> _products = new List<Product>();
        private Money _coin = new Money();
        private readonly List<Money> _moneyList;

        public string Manufacturer { get; }
        public bool HasProducts => _products.Any(product => product.Available > 0);
        public Money Amount => _coin;
        public Product[] Products => _products.ToArray();

        public VendingMachine(string manufacturer)
        {
            Manufacturer = manufacturer;
            _moneyList = new List<Money>
            {
                new Money { Euros = 0, Cents = 10 },
                new Money { Euros = 0, Cents = 20 },
                new Money { Euros = 0, Cents = 50 },
                new Money { Euros = 1, Cents = 0 },
                new Money { Euros = 2, Cents = 0 }
            };    
        }

        public Money InsertCoin(Money amount)
        {   
            _coin = new Money
            {
                Euros = Amount.Euros + amount.Euros + (Amount.Cents + amount.Cents) / 100,
                Cents = (Amount.Cents + amount.Cents) % 100
            };


            if (amount.Euros < 0 || amount.Cents < 0)
            {
                throw new NegativeCoinsException();
            }

            if (_coin.Euros == 0 && _coin.Cents == 0)
            {
                throw new NoCoinInsertedException();
            }

            foreach (Money money in _moneyList)
            {
                if (money.Euros == amount.Euros && money.Cents == amount.Cents)
                {
                    return new Money { Euros = 0, Cents = 0 };
                }
            }

            return amount;
        }

            public Money ReturnMoney()
            {

            if (_coin.Euros == 0 && _coin.Cents == 0)
            {
                throw new NoCoinInsertedException();
            }

            Money returnedAmount = Amount;
            _coin = new Money();

            return returnedAmount;
            }

        public bool AddProduct(string name, Money price, int count)
        {
            Product newProduct = new Product
            {
                Name = name,
                Price = price,
                Available = count
            };

            _products.Add(newProduct);

            if ( count < 0)
            {
                throw new InvalidCountException();
            }

            if ( price.Euros < 0 || price.Cents < 0)
            {
                throw new InvalidPriceException();
            }

            return true;
        }

        public bool UpdateProduct(int productNumber, string name, Money? price, int amount)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new InvalidProductNameException();
            }

            if(!price.HasValue)
            {
                throw new InvalidProductPriceException();

            }

            if (amount  < 0)
            {
                throw new InvalidProductAmountException();
            }

            if (productNumber >= 0 && productNumber < _products.Count)
            {
                Product product = _products[productNumber];

                product.Name = name;
                product.Price = price.Value;
                product.Available = amount;

                _products[productNumber] = product;

                return true;
            }

            return false; 
        }
    }
 }

