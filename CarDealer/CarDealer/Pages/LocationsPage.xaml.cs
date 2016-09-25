using CarDealer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace CarDealer.Pages
{
   public partial class LocationsPage : ContentPage
   {
      public LocationsPage()
      {
         InitializeComponent();
            BindingContext = this;

            var position = new Position(43.662369, -79.383573); // Latitude, Longitude
            var pin = new Pin
            {
                Type = PinType.Place,
                Position = position,
                Label = "Car Dealer",
                Address = "Car Dealer's Address"
            };
            MyMap.Pins.Add(pin);

            MyMap.MoveToRegion(
                    MapSpan.FromCenterAndRadius(
                        position, Distance.FromMiles(1)));
        }

        private async void OnBackTapped(Object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }


        public List<Sample> Items
        {
            get
            {
                return SampleData.SamplesCategories["Locations"].SamplesList;
            }
        }
    }
}
