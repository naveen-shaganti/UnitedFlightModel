using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightModel
{
    public class Flight : IFlight
    {
        public string FlightNo { get; set; }
        public string Source { get; set; }
        public string Destination { get; set; }
        public DateTime Departure { get; set; }
        public DateTime Arrival { get; set; }
        public DateTime BoardingTime { get; set; }
        public string FlightType { get; set; }      //domestic, international
        public int NoOfSeats { get; set; }
        public int NoOfReservedSeats { get; set; }
        public int Duration { get; set; }
        public bool IsLayover { get; set; }
        public List<string> ConnectingPorts { get; set; }
        public string TypeOfPlane { get; set; }
        public List<Passenger> Travellers{ get; set; }

        public int AvailableSeats()
        {
            return (NoOfSeats - NoOfReservedSeats);
        }

        public Ticket BookTicket()
        {
            return new Ticket() { };
        }

        public void CancelTicket(Ticket ticket)
        {
            NoOfReservedSeats = (NoOfReservedSeats - ticket.BookedSeats);
        }
    }
}
