﻿namespace CalorieCounterEngine.Factories
{
    using CalorieCounterEngine.Models.Food;
    using global::CalorieCounterEngine.Contracts;
    using global::CalorieCounterEngine.Models;

    public class ProductFactory : IProductFactory
    {
        public IProduct CreateProduct(string name, decimal weight, int protein, int carbs, int fat, int calories, int sugar = 0, int fiber = 0)
        {
            // TODO: Validations?
            return new CustomFoodProduct(name, weight, protein, carbs, fat, calories, sugar, fiber);
        }
    }
}
