﻿using CalorieCounterEngine.Models.Contracts;

namespace CalorieCounterEngine.Models.Drinks
{
    public abstract class Drink : IWater
    {
        private readonly string name;
        private readonly decimal weightInMl;

        public Drink(string name, decimal weightInMl)
        {
            this.name = name;
            this.weightInMl = weightInMl;
        }

        public string Name => this.name;

        public decimal Weight => this.weightInMl;
    }
}
