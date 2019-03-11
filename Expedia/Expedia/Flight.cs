using System;

namespace Expedia
{
    class Flight
    {
        public string Arrival { get; set; }
        public string Departure { get; set; }
        public string BoardingTime { get; set; }
        public string Gate { get; set; }
        public string Term { get; set; }
        public string Seat { get; set; }
        public string Depart { get; set; }
        public FlightStatus Status { get; set; }
    }

    public enum FlightStatus
    {
        onTime = 0,
        delayed = 1,
    }
}
