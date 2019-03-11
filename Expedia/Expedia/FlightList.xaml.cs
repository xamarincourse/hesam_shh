using System;
using System.Collections.ObjectModel;
using System.Globalization;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Expedia
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FlightList : ContentPage
    {
        ObservableCollection<Boarding> BoardingList;
        public FlightList()
        {
            InitializeComponent();

            BoardingList = new ObservableCollection<Boarding>()
            {
                new Boarding{
                    DepartCityName = "London",
                    AirlineCode = "EK",
                    ETA = DateTime.Now,
                    STA = DateTime.Now,
                    Status = FlightStatus.onTime,
                    Terminal = "D3"
                },
                new Boarding{
                    DepartCityName = "Paris",
                    AirlineCode = "LH",
                    ETA = DateTime.Now,
                    STA = DateTime.Now,
                    Status = FlightStatus.onTime,
                    Terminal = "D3"
                },
                new Boarding{
                    DepartCityName = "Dubai",
                    AirlineCode = "W5",
                    ETA = DateTime.Now,
                    STA = DateTime.Now,
                    Status = FlightStatus.delayed,
                    Terminal = "D3"
                },
                new Boarding{
                    DepartCityName = "New York",
                    AirlineCode = "W5",
                    ETA = DateTime.Now,
                    STA = DateTime.Now,
                    Status = FlightStatus.delayed,
                    Terminal = "D3"
                },
                new Boarding{
                    DepartCityName = "Italy",
                    AirlineCode = "LH",
                    ETA = DateTime.Now,
                    STA = DateTime.Now,
                    Status = FlightStatus.onTime,
                    Terminal = "D3"
                },
                new Boarding{
                    DepartCityName = "Barcelona",
                    AirlineCode = "EK",
                    ETA = DateTime.Now,
                    STA = DateTime.Now,
                    Status = FlightStatus.onTime,
                    Terminal = "D3"
                },
            };

            BoardingView.ItemsSource = BoardingList;
        }
    }
}