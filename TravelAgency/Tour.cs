using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgency
{
    public class Tour
    {
        public string TourName { get; set; }
        public DateTime TourDate { get; set; }
        public int AvailableSeats { get; set; }

        public Tour(string tourName, DateTime tourDate, int availableSeats)
        {
            TourName = tourName;
            TourDate = tourDate;
            AvailableSeats = availableSeats;
        }
    }
}
