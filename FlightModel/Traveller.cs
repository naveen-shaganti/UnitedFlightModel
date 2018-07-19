using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightModel
{
    public class Passenger
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string SeatNo { get; set; }
        public Ticket Ticket { get; set; }
    }
}
