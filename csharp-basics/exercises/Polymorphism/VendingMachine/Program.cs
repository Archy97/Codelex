using System;

namespace VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            VendingMachine vendingMachine = new VendingMachine("Acme Vending");

            vendingMachine.AddProduct("Soda", new Money { Euros = 1, Cents = 40 }, 10);
            vendingMachine.AddProduct("Chips", new Money { Euros = 2, Cents = 00}, 2);
            vendingMachine.AddProduct("Candy", new Money { Euros = 1, Cents = 60 }, 8);
            vendingMachine.AddProduct("Milk", new Money { Euros = 3, Cents = 00 }, 8);

            Menu(vendingMachine);
        }


        public static void InsertCoins(VendingMachine vendingMachine)
        {
            Console.WriteLine("Choice Amount");
            Console.WriteLine("1 - 0.10");
            Console.WriteLine("2 - 0.20");
            Console.WriteLine("3 - 0.50");
            Console.WriteLine("4 - 1.00");
            Console.WriteLine("5 - 2.00");
            var userChoice = Console.ReadLine();

            var amountAdd = 0;
            switch (userChoice)
            {
                case "1":
                    amountAdd += 10;
                    break;
                case "2":
                    amountAdd += 20;
                    break;
                case "3":
                    amountAdd += 50;
                    break;
                case "4":
                    amountAdd += 100;
                    break;
                case "5":
                    amountAdd += 200;
                    break;
            }

            int euro;
            int cents;

            if (amountAdd >= 100)
            {
                euro = amountAdd / 100;
                cents = amountAdd % 100;
            }
            else
            {
                euro = 0;
                cents = amountAdd;
            }

            Money coin = new Money();
            coin.Euros = euro;
            coin.Cents = cents;

            vendingMachine.InsertCoin(coin);
        }

        public static void Menu(VendingMachine vendingMachine)
        {
            var userChoice = string.Empty;
            while (!userChoice.Equals("3"))
            {
                Console.WriteLine("1. Choice Product");
                Console.WriteLine("2. Insert Coins");
                Console.WriteLine("3. Exit");
                userChoice = Console.ReadLine();

                switch (userChoice)
                {
                    case "1":
                        ProductMenu(vendingMachine);
                        break;
                    case "2":
                        InsertCoins(vendingMachine);
                        break;
                }
            }
        }

        public static void ProductMenu(VendingMachine vendingMachine)
        {
            Console.WriteLine("Available Products:");
            for (int i = 0; i < vendingMachine.Products.Length; i++)
            {
                var product = vendingMachine.Products[i];
                var euro = product.Price.Euros;
                var cent = product.Price.Cents;
                Console.WriteLine($"{i + 1}. {product.Name} - Price: ${euro}.{cent:00} - Available: {product.Available}");
            }
            Console.WriteLine("0 Cancel");

            Console.WriteLine($"Inserted Amount: {vendingMachine.Amount.Euros}.{vendingMachine.Amount.Cents:00}");

            Console.Write("Enter the number of the product you want to buy: ");
            int choice = int.Parse(Console.ReadLine());
            if (choice == 0)
            {
                Menu(vendingMachine);
            }
            Product selectedProduct = vendingMachine.Products[choice - 1];

            if (selectedProduct.Price.Euros * 100 + selectedProduct.Price.Cents <= vendingMachine.Amount.Euros * 100 + vendingMachine.Amount.Cents)
            {
                if (choice >= 1 && choice <= vendingMachine.Products.Length)
                {
                    if (selectedProduct.Available == 0)
                    {
                        Console.WriteLine($"\nOut of stock {selectedProduct.Name}");
                    }
                    else
                    { 
                        Console.WriteLine($"You bought {selectedProduct.Name}");
                        vendingMachine.UpdateProduct(choice - 1, selectedProduct.Name, selectedProduct.Price, selectedProduct.Available - 1);
                        vendingMachine.ReturnMoney();
                    }
                }
                else
                {
                    Console.WriteLine("Invalid choice.");
                }
            }
            else
            {
                Console.WriteLine("Nav Naudas");
            }
        }
    }
}
