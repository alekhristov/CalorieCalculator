﻿using System;
using CalorieCounter.Models.Contracts;
using CalorieCounter.UnitTests.Mocks;
using CalorieCounterEngine.Contracts;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace CalorieCounter.UnitTests.Utils.SuggestedDailyNutrientsIntakeCalcTests
{
    [TestClass]
    public class CalculateSuggestedDailyFatIntake_Should
    {
        [TestMethod]
        public void ReturnCorrectValue_WhenInvokedWithGoalTypeLoseweightParameter()
        {
            // Arrange
            var expectedResult = 107;

            var goalMock = new Mock<IGoal>();
            var restingEnergyMock = new Mock<IRestingEnergy>();

            goalMock
           .SetupGet(m => m.Type)
           .Returns(GoalType.loseweight);

            var calc = new SuggestedDailyNutrientsIntakeCalcFake(goalMock.Object, restingEnergyMock.Object);
            calc.SuggestedDailyCalorieIntakeExposed = 2750;

            // Act
            var actualResult = calc.CalculateSuggestedDailyFatIntake();

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ReturnCorrectValue_WhenInvokedWithGoalTypeMaintainweightParameter()
        {
            // Arrange
            var expectedResult = 92;

            var goalMock = new Mock<IGoal>();
            var restingEnergyMock = new Mock<IRestingEnergy>();

            goalMock
                .SetupGet(m => m.Type)
                .Returns(GoalType.maintainweight);

            var calc = new SuggestedDailyNutrientsIntakeCalcFake(goalMock.Object, restingEnergyMock.Object);
            calc.SuggestedDailyCalorieIntakeExposed = 2750;

            // Act
            var actualResult = calc.CalculateSuggestedDailyFatIntake();

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ReturnCorrectValue_WhenInvokedWithGoalTypeGainweightParameter()
        {
            // Arrange
            var expectedResult = 61;

            var goalMock = new Mock<IGoal>();
            var restingEnergyMock = new Mock<IRestingEnergy>();

            goalMock
           .SetupGet(m => m.Type)
           .Returns(GoalType.gainweight);

            var calc = new SuggestedDailyNutrientsIntakeCalcFake(goalMock.Object, restingEnergyMock.Object);
            calc.SuggestedDailyCalorieIntakeExposed = 2750;

            // Act
            var actualResult = calc.CalculateSuggestedDailyFatIntake();

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
