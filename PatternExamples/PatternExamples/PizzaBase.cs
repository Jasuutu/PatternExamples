﻿namespace FactoryExample
{
    public abstract class PizzaBase
    {
        /// <summary>
        /// Add cheese to the pizza.
        /// </summary>
        /// <returns>Message with the result.</returns>
        public abstract string AddCheese();

        /// <summary>
        /// Add sauce to the pizza.
        /// </summary>
        /// <returns>Message with the result.</returns>
        public abstract string AddSauce();

        /// <summary>
        /// Add toppings to the pizza.
        /// </summary>
        /// <returns>Message with the result.</returns>
        public abstract string AddToppings();

        /// <summary>
        /// Bake the pizza
        /// </summary>
        /// <returns>Message with the result.</returns>
        public abstract string BakePizza();
    }
}
