using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReserveRoom.Models
{
    internal class Reservation
    {
        public RoomID RoomID { get; }
        public DateTime StateTime { get; }
        public DateTime EndTime { get; }

        public Reservation(RoomID roomID, DateTime stateTime, DateTime endTime)
        {
            RoomID = roomID;
            StateTime = stateTime;
            EndTime = endTime;
        }

    }
}
