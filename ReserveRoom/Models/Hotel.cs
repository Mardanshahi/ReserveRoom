﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReserveRoom.Models
{
    internal class Hotel
    {
        private readonly ReservationBook _reservationBook;
        public string Name { get; set; }

        public Hotel(string name)
        {
            Name = name;

            _reservationBook = new ReservationBook();
        }

    }
}
