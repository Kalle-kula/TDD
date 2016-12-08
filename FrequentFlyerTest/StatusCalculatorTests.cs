using FrequentFlyer;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrequentFlyerTest
{
    [TestFixture] 
    public class StatusCalculatorTests
    {
        private List<Tuple<string, int>> statusLevels =
            new List<Tuple<string, int>> {
            new Tuple<string, int>("Basic", 0),
            new Tuple<string, int>("Silver", 50000),
            new Tuple<string, int>("Gold", 100000)
            };

        [Test]
        public void StartWithZeroPointsAndBasicStatus()
        {
            var sut = new StatusCalculator(statusLevels); //sut = System Under Test

            Assert.AreEqual(0, sut.Points, "zero points");
            Assert.AreEqual("Basic", sut.Status, "Basic status");
        }

        [Test]
        public void RecordsExtraPointsAndKeepsCorrectStatus()
        {
            //Arrange
            var sut = new StatusCalculator(statusLevels);

            //Act
            sut.AddPoints(2000);
            sut.AddPoints(5000);

            //Assert
            Assert.AreEqual(7000, sut.Points, "Correct number of points");
            Assert.AreEqual("Basic", sut.Status, "Still have basic status");

        }

        [Test]
        public void EnoughPointsEarnSilverStatus()
        {
            //Arrange
            var sut = new StatusCalculator(statusLevels);

            //Act
            sut.AddPoints(20000);
            sut.AddPoints(35000);

            //Assert
            Assert.AreEqual(55000, sut.Points, "Correct number of points");
            Assert.AreEqual("Silver", sut.Status, "Will have silver status");
        }

        
    }
}
