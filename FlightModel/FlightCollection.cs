using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightModel
{
    public class FlightCollection
    {
        public List<Flight> Flights { get; set; }

        public List<Flight> Sort(List<Flight> listFlight, string sortCriteria)
        {
            List<Flight> sortedFlights = new List<Flight>();

            if (sortCriteria.Equals("NoOfReservedSeats", StringComparison.OrdinalIgnoreCase))       //Passenger count
            {
                listFlight.Sort((L1, L2) => { return L1.NoOfReservedSeats - L2.NoOfReservedSeats; });
            }

            if (sortCriteria.Equals("Departure", StringComparison.OrdinalIgnoreCase))       
            {
                listFlight.Sort((L1, L2) => { return DateTime.Compare(L1.Departure,L2.Departure); });
            }

            if (sortCriteria.Equals("Source", StringComparison.OrdinalIgnoreCase))       
            {
                listFlight.Sort((L1, L2) => { return L1.Source.CompareTo(L2.Source); });
            }

            if (sortCriteria.Equals("Destination", StringComparison.OrdinalIgnoreCase))       
            {
                listFlight.Sort((L1, L2) => { return L1.Destination.CompareTo(L2.Destination); });
            }

            sortedFlights = listFlight;
            return sortedFlights;
        }
    }
}
