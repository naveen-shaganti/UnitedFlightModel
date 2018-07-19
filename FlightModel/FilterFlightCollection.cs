using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightModel
{
    public static class FilterFlightCollection
    {
        public static FlightCollection Filter(this FlightCollection flightCollection, string filterCriteria)
        {
            FlightCollection filteredFlights = new FlightCollection();

            if (filterCriteria.Equals("Source", StringComparison.OrdinalIgnoreCase))
                filteredFlights.Flights = flightCollection.Flights.Where(x => x.Source.Equals(filterCriteria, StringComparison.OrdinalIgnoreCase)).ToList();
            else if(filterCriteria.Equals("Destination", StringComparison.OrdinalIgnoreCase))
                filteredFlights.Flights = flightCollection.Flights.Where(x => x.Destination.Equals(filterCriteria, StringComparison.OrdinalIgnoreCase)).ToList();
            else if (filterCriteria.Equals("Duration", StringComparison.OrdinalIgnoreCase))
                filteredFlights.Flights = flightCollection.Flights.OrderBy(x => x.Duration).ToList();
            
            return filteredFlights;
        }
    }
}
