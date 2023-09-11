using FluentAssertions;
using System.Diagnostics;
using System.Xml.Linq;

namespace VendingMachine.Tests
{
    [TestClass]
    public class VendingMachineTests
    {
        private VendingMachine _vendingMachine;
        private Money MONEY_AMOUNT;
        private const string DEFAULT_PRODUCT_NAME = "Chips";
        private const int DEFAULT_PRODUCT_AVAILABILTY = 5;

        [TestInitialize]
        public void Setup()
        {
            _vendingMachine = new VendingMachine("Manufacturer");
            MONEY_AMOUNT = new Money { Euros = 0, Cents = 50 };

        }

        [TestMethod]
        public void InsertCoin_UpdateAmount_WhenValidCoinInserted()
        {
            var validCoin = MONEY_AMOUNT;

            var result = _vendingMachine.InsertCoin(validCoin);

            result.Should().Be(new Money { Euros = 0, Cents = 0 });
            _vendingMachine.Amount.Should().Be(MONEY_AMOUNT);
        }

        [TestMethod]
        public void InsertCoin_WithNegativeCents_ThrowsArgumentException()
        {
            var negativeCoin = new Money { Euros = 0, Cents = -50 };

            Action insertNegativeCoin = () => _vendingMachine.InsertCoin(negativeCoin);

            insertNegativeCoin.Should().Throw<NegativeCoinsException>();
        }

        [TestMethod]
        public void InsertCoin_WithNegativeEuros_ThrowsArgumentException()
        {
            var negativeCoin = new Money { Euros = -1, Cents = 0 };

            Action insertNegativeCoin = () => _vendingMachine.InsertCoin(negativeCoin);

            insertNegativeCoin.Should().Throw<NegativeCoinsException>();
        }

        [TestMethod]
        public void InsertCoin_WithInvalidMoney_ThrowNoCoinInsertedException()
        {
            var noCoin = new Money();

            Action insertNoCoin = () => _vendingMachine.InsertCoin(noCoin);

            insertNoCoin.Should().Throw<NoCoinInsertedException>();
        }

        [TestMethod]
        public void InsertCoin_ReturnSameCoin_IfTheCoinISWrongValue()
        {
            Money WrongValues = new Money { Euros = 0, Cents = 1 };

            var result = _vendingMachine.InsertCoin(WrongValues);

            result.Euros.Should().Be(WrongValues.Euros);
            result.Cents.Should().Be(WrongValues.Cents);
        }

        [TestMethod]
        public void ReturnMoney_ReturnsCurrentCoinAmountAndResetsCoinToZero()
        {
            Money coinToReturn = MONEY_AMOUNT;

            _vendingMachine.InsertCoin(coinToReturn);
            var returnedAmount = _vendingMachine.ReturnMoney();

            returnedAmount.Should().Be(MONEY_AMOUNT);
            _vendingMachine.Amount.Should().Be(new Money { Euros = 0, Cents = 0 });
        }

        [TestMethod]
        public void ReturnMoney_BalanceZeroNoCoinsInserted()
        {
            
            Action action = () => _vendingMachine.ReturnMoney();

            action.Should().Throw<NoCoinInsertedException>();
        }

        [TestMethod]
        public void AddProduct_WhenValidProductAdded_ShouldIncreaseProductCount()
        {
            bool result = _vendingMachine.AddProduct(DEFAULT_PRODUCT_NAME, MONEY_AMOUNT, DEFAULT_PRODUCT_AVAILABILTY);

            Assert.IsTrue(result); 
            Assert.AreEqual(1, _vendingMachine.Products.Length);
        }

        [TestMethod]
        public void AddProduct_NamePriceAvailable_VerifyAddedProductProperties()
        {
           _vendingMachine.AddProduct(DEFAULT_PRODUCT_NAME, MONEY_AMOUNT, DEFAULT_PRODUCT_AVAILABILTY);

            var addedProduct = _vendingMachine.Products[0];

            Assert.AreEqual(DEFAULT_PRODUCT_NAME, addedProduct.Name);
            Assert.AreEqual(MONEY_AMOUNT, addedProduct.Price);
            Assert.AreEqual(DEFAULT_PRODUCT_AVAILABILTY, addedProduct.Available);
        }

        [TestMethod]
        public void AddProductWithNegativeCount_ThrowInvalidCountException()

        {
            var NewCount = -5;

            Action action = () => _vendingMachine.AddProduct(DEFAULT_PRODUCT_NAME, MONEY_AMOUNT, NewCount);

            action.Should().Throw<InvalidCountException>();
        }

        [TestMethod]
        public void AddProductWithNegativeCents_ThrowInvalidPriceException()

        {
            var newPrice = new Money { Euros = 0, Cents = -50 };

            Action action = () => _vendingMachine.AddProduct(DEFAULT_PRODUCT_NAME, newPrice, DEFAULT_PRODUCT_AVAILABILTY);

            action.Should().Throw<InvalidPriceException>();

        }

        [TestMethod]
        public void AddProductWithNegativeEuros_ThrowInvalidPriceException()

        {
            var newPrice = new Money { Euros = -1, Cents = 0};

            Action action = () => _vendingMachine.AddProduct(DEFAULT_PRODUCT_NAME, newPrice, DEFAULT_PRODUCT_AVAILABILTY);

            action.Should().Throw<InvalidPriceException>();

        }

        [TestMethod]
        public void UpdateProduct_EmptyString_ThrowInvalidProductNameException()
        {
            Action action = () => _vendingMachine.UpdateProduct(1, "", MONEY_AMOUNT, 2);

            action.Should().Throw< InvalidProductNameException>();
        }

        [TestMethod]
        public void UpdateProduct_WithNullPrice_ShouldThrowInvalidProductPriceException()
        {
           Action action = () => _vendingMachine.UpdateProduct(1, DEFAULT_PRODUCT_NAME, null, 2);

           action.Should().Throw<InvalidProductPriceException>();
        }

        [TestMethod]
        public void UpdateProduct_NegativeAmount_ShouldThrowInvalidProductPriceException()
        {
            Action action = () => _vendingMachine.UpdateProduct(1, DEFAULT_PRODUCT_NAME, MONEY_AMOUNT , -2);

            action.Should().Throw< InvalidProductAmountException >();
        }

        [TestMethod]
        public void UpdateProduct_UpdateProductNamePriceAvailable_ProductUpdated()
        {
            var newPrice = new Money { Euros = 1, Cents = 0 };

            _vendingMachine.AddProduct(DEFAULT_PRODUCT_NAME, MONEY_AMOUNT, DEFAULT_PRODUCT_AVAILABILTY);
            _vendingMachine.UpdateProduct(0, "Carlis", newPrice, 10);

            _vendingMachine.Products[0].Name.Should().Be("Carlis");
            _vendingMachine.Products[0].Price.Should().Be(new Money { Euros = 1, Cents = 0 });
            _vendingMachine.Products[0].Available.Should().Be(10);

        }

        [TestMethod]
        public void UpdateProduct_UpdateNonExistentProduct_ReturnsFalse()
        {
            bool result = _vendingMachine.UpdateProduct(99, DEFAULT_PRODUCT_NAME, MONEY_AMOUNT, 11);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void UpdateProduct_UpdateProductWithSameProduct_ProductUpdated()
        {
            var newPrice = new Money { Euros = 1, Cents = 0 };

            _vendingMachine.AddProduct(DEFAULT_PRODUCT_NAME, MONEY_AMOUNT, DEFAULT_PRODUCT_AVAILABILTY);
            _vendingMachine.UpdateProduct(0, DEFAULT_PRODUCT_NAME, MONEY_AMOUNT, DEFAULT_PRODUCT_AVAILABILTY);

            _vendingMachine.Products[0].Name.Should().Be(DEFAULT_PRODUCT_NAME);
            _vendingMachine.Products[0].Price.Should().Be(MONEY_AMOUNT);
            _vendingMachine.Products[0].Available.Should().Be(DEFAULT_PRODUCT_AVAILABILTY);

        }

        [TestMethod]
        public void UpdateProduct_UpdateMultipleProducts_ProductUpdated()
        {
            var newPrice = new Money { Euros = 1, Cents = 0 };

            _vendingMachine.AddProduct(DEFAULT_PRODUCT_NAME, MONEY_AMOUNT, DEFAULT_PRODUCT_AVAILABILTY);
            _vendingMachine.UpdateProduct(0, "Carlis", newPrice, 10);
            _vendingMachine.AddProduct(DEFAULT_PRODUCT_NAME, MONEY_AMOUNT, DEFAULT_PRODUCT_AVAILABILTY);
            _vendingMachine.UpdateProduct(1, "Tetis", newPrice, 22);

            _vendingMachine.Products[0].Name.Should().Be("Carlis");
            _vendingMachine.Products[0].Price.Should().Be(new Money { Euros = 1, Cents = 0 });
            _vendingMachine.Products[0].Available.Should().Be(10);

            _vendingMachine.Products[1].Name.Should().Be("Tetis");
            _vendingMachine.Products[1].Price.Should().Be(new Money { Euros = 1, Cents = 0 });
            _vendingMachine.Products[1].Available.Should().Be(22);

        }

        [TestMethod]
        public void HasProducts_WhenProductsAvailable_BuyableProduct()
        {
            _vendingMachine.AddProduct("Chips", new Money { Euros = 2, Cents = 50 }, 5);

            bool hasProducts = _vendingMachine.HasProducts;

            Assert.IsTrue(hasProducts);
        }

        [TestMethod]
        public void HasProducts_WhenProductCountIs0_NoBuyableProduct()
        {
            _vendingMachine.AddProduct("Chips", new Money { Euros = 2, Cents = 50 }, 0);

            bool hasProducts = _vendingMachine.HasProducts;

            Assert.IsFalse(hasProducts);
        }
    }    
}
