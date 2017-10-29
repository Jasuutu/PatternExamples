using System;
using FactoryExample;
using Xunit;

namespace FactoryExampleTests
{
    public class CheesePizzaTests
    {
        private const string CheesePizzaAddCheeseString = "Adding cheese to the cheese pizza";
        private const string CheesePizzaAddSauceString = "Adding sauce to the cheese pizza.";
        private const string CheesePizzaAddToppingString = "Assing extra cheese to the pizza.";
        private const string CheesePizzaBakePizzaString = "Baking cheese pizza";

        private PizzaBase cheesePizza;

        /// <summary>
        /// Creats the pizza object that will be used for all the tests.
        /// </summary>
        public CheesePizzaTests()
        {
            cheesePizza = new CheesePizza();
        }

        [Fact]
        public void AddCheeseTest()
        {
            Assert.True(Utility.AreEqual(cheesePizza.AddCheese(), CheesePizzaAddCheeseString));
        }

        [Fact]
        public void AddSauceTest()
        {
            Assert.True(Utility.AreEqual(cheesePizza.AddSauce(), CheesePizzaAddSauceString));
        }

        [Fact]
        public void AddToppingsTest()
        {
            Assert.True(Utility.AreEqual(cheesePizza.AddToppings(), CheesePizzaAddToppingString));
        }

        [Fact]
        public void BakePizzaTest()
        {
            Assert.True(Utility.AreEqual(cheesePizza.BakePizza(), CheesePizzaBakePizzaString));
        }

    }
}
