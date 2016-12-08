using System;
using System.Collections.Generic;

namespace TravelAgency
{
    public class TourSchedule
    {
        private Dictionary<DateTime, List<Tour>> tourList = new Dictionary<DateTime, List<Tour>>();
        public TourSchedule()
        {
        }

        public void GetTourOn(DateTime tourDate)
        {
            tourList.Add(tourDate.Date, new List<Tour>());
        }
        public void CreateTour(string tourName, DateTime tourDate, int availableSeats)
        {
            string daystring = tourDate.ToString("MMMM dd, yyyy");
            DateTime test = DateTime.Parse(daystring);
            tourList[tourDate.Date].Add(new Tour(tourName, test, availableSeats));
        }

        public List<Tour> GetToursFor(DateTime tourDate)
        {
            return tourList[tourDate.Date];
        }

        
    }
}