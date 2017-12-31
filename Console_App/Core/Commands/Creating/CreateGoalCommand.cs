﻿using CalorieCounter.Contracts;
using CalorieCounter.Factories.Contracts;
using Console_App.Core.Contracts;
using Console_App.Core.Engine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_App.Core.Commands.Creating
{
    class CreateGoalCommand : ICommand
    {
        private readonly ICommandParserEngine engine;
        private readonly ICalorieCounterEngine calorieCounterEngine;

        public CreateGoalCommand( ICommandParserEngine engine, ICalorieCounterEngine calorieCounterEngine)
        {
            this.engine = engine;
            this.calorieCounterEngine = calorieCounterEngine;
        }

        public string Execute(IList<string> parameters)
        {
            double startingWeight;
            double goalWeight;
            double height;
            int age;
            GenderType gender;
            GoalType type;
            ActivityLevel level;

            try
            {
                startingWeight = double.Parse(parameters[0]);
                goalWeight = double.Parse(parameters[1]);
                height = double.Parse(parameters[2]);
                age = int.Parse(parameters[3]);
                gender = (GenderType)Enum.Parse(typeof(GenderType), parameters[4]);
                type = (GoalType)Enum.Parse(typeof(GoalType), parameters[5]);
                level = (ActivityLevel)Enum.Parse(typeof(ActivityLevel), parameters[6]);
            }
            catch (Exception)
            {
                throw new ArgumentException("Failed to parse CreateGoal command parameters.");
            }

            //var goal = this.factory.CreateGoal(startingWeight, goalWeight, height, age, gender, type, level);

            return $"Goal {type.ToString()} was created!";
        }
    }
}
