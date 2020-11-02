using System;

namespace Flight_Reservation_System
{
    class Flight
    {
        public
            Int32 FlightNumber;
        Int32 Capacity;
        string Source;
        string Destination;
        DateTime FlightTime;

        Int32 get_capacity() { return Capacity; }
    }
}
