using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightModel
{
    public interface IFlight
    {
        int AvailableSeats();
        Ticket BookTicket();
        void CancelTicket(Ticket ticket);
    }
}
