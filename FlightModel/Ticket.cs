using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightModel
{
    public class Ticket
    {
        public string TicketID { get; set; }
        public string FlightNo { get; set; }
        public string TicketType { get; set; }
        public int BookedSeats { get; set; }
        public float Cost { get; set; }
        public DateTime BookedDate { get; set; }
        public string Source { get; set; }
        public string Destination { get; set; }

    }
}
