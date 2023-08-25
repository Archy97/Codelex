using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public class VendingMachine : IVendingMachine<Money, Product>
    {
        public string Manufacturer { get; }
        public bool HasProducts { get; }
        public Money Amount { get; set; }
        public Product[] Products { get; set; }

        public VendingMachine(string manufacturer)
        {
            Manufacturer = manufacturer;
            HasProducts = false;
            Amount = new Money();
            Products = new Product[0];
        }

        public Money InsertCoin(Money amount)
        {
            Amount = new Money
            {
                Euros = Amount.Euros + amount.Euros + (Amount.Cents + amount.Cents) / 100,
                Cents = (Amount.Cents + amount.Cents) % 100
            };

            return Amount;
        }

        public Money ReturnMoney()
        {
            Money returnedAmount = Amount;
            Amount = new Money();
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

            Products = Products.Concat(new[] { newProduct }).ToArray();
            return true;
        }

        public bool UpdateProduct(int productNumber, string name, Money? price, int amount)
        {
            for (int i = 0; i < Products.Length; i++)
            {
                if (name.Equals(Products[i].Name))
                {
                    Products[i].Available = amount;
                }
            }

            return true;
        }
    }
}
