using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelAgency;

namespace TravelAgencyTests
{
    [TestFixture]
    public class TourScheduleTests
    {
        [Test]
        public void CanCreateTour()
        {
            var sut = new TourSchedule();

            sut.GetTourOn(new DateTime(2013, 1, 1));

            sut.CreateTour("New years day safari", new DateTime(2013, 1, 1), 20);  //name, date, available seats

            var tour = sut.GetToursFor(new DateTime(2013, 1, 1));
            
            Assert.AreEqual(1, tour.Count, "Contains one item");
            Assert.AreEqual("New years day safari", tour[0].TourName);
            Assert.AreEqual(20, tour[0].AvailableSeats);
        }

        [Test]
        public void ToursAreScheduledByTheDateOnly()
        {
            var sut = new TourSchedule();

            sut.GetTourOn(new DateTime(2013, 1, 1));

            sut.CreateTour("New years day safari", new DateTime(2013, 1, 1,10,15,0), 20);

            var date = sut.GetToursFor(new DateTime(2013, 1, 1));

            Assert.AreEqual(new DateTime(2013, 1, 1), date[0].TourDate);
        }

    }
}
