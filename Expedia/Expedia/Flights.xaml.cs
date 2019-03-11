using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Expedia
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Flights : ContentPage
    {
        public Flights()
        {
            InitializeComponent();

            var flight = new Flight()
            {
                Arrival = "SFO",
                Departure = "LAX",
                BoardingTime = "8:20 PM",
                Term = "1",
                Gate = "A5",
                Seat = "5A",
                Depart = "1:00 PM",
                Status = 0,
            };

            BindingContext = flight;
        }

        async void NavigateToFlightList(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new FlightList());
        }
    }
}