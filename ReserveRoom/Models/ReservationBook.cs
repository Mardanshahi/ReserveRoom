using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReserveRoom.Models
{
    public class ReservationBook
    {
        private Dictionary<RoomID, List<Reservation>> _roomsToReserve;

        public ReservationBook()
        {
                _roomsToReserve = new Dictionary<RoomID, List<Reservation>>();
        }




    }
}
