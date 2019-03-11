using System;
using Xamarin.Forms;

namespace Expedia
{
    class Boarding
    {
        public string AirlineCode { get; set; }
        public ImageSource Logo { get { return ImageSource.FromResource($"Expedia.images.{AirlineCode}.png"); } }
        public string DepartCityName { get; set; }
        public DateTime STA { get; set; }
        public DateTime ETA { get; set; }
        public string Terminal { get; set; }
        public FlightStatus Status { get; set; }
    }
}
