using Lab1;
using NUnit.Framework;
using System.Collections.Generic;

namespace Lab1Test
{
    public class Tests
    {
        [Test]
        public void TestCalcDailyPopulation()
        {
            // Arrange
            Population population = new Population(startingSize: 100, dailyIncreasePercent: 5, numberOfDays: 7);
            List<int> expectedPopulation = new List<int> { 105, 110, 115, 121, 127, 134, 140 };

            // Act
            List<int> dailyPopulation = population.calcDailyPopulation();

            // Assert
            CollectionAssert.AreEqual(expectedPopulation, dailyPopulation);
        }

        [Test]
        public void TestCalcServiceFees_LowNumberOfChecks()
        {
            // Arrange
            BankCharges bankCharges = new BankCharges(accBalance: 500, nbOfChecks: 10);
            double expectedFees = 11.00;

            // Act
            double totalFees = bankCharges.CalcServiceFees();

            // Assert
            Assert.That(totalFees, Is.EqualTo(expectedFees));
        }

        [Test]
        public void TestCalcServiceFees_HighNumberOfChecks()
        {
            // Arrange
            BankCharges bankCharges = new BankCharges(accBalance: 500, nbOfChecks: 20);
            double expectedFees = 11.60d;

            // Act
            double totalFees = bankCharges.CalcServiceFees();

            // Assert
            Assert.That(totalFees, Is.EqualTo(expectedFees));
        }

        [Test]
        public void TestCalcShippingCharge()
        {
            // Arrange
            ShippingCharges shippingCharges = new ShippingCharges();
            double weight = 5.5;
            double distance = 1200;
            double expectedCharge = 6.6000000000000005d;

            // Act
            double totalShippingCharge = shippingCharges.CalcShippingCharge(weight, distance);

            // Assert
            Assert.That(totalShippingCharge, Is.EqualTo(expectedCharge));
        }
    }
}