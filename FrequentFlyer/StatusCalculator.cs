using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrequentFlyer
{
    public class StatusCalculator
    {
        public int currentPoints = 0;

        private List<Tuple<string, int>> statusLevels;
        public int Points { get { return currentPoints; } }
        public string Status { get
            {
                return (from sl in statusLevels
                        where sl.Item2 <= currentPoints
                        orderby sl.Item2 descending
                        select sl.Item1).First();
                    } }


        public StatusCalculator(List<Tuple<string, int>> statusLevels)
        {
            this.statusLevels = statusLevels;
        }

        public void AddPoints(int newPoints)
        {
            currentPoints += newPoints;
        }
    }
}
