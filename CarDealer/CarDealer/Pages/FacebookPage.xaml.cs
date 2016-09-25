using CarDealer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace CarDealer.Pages
{
   public partial class FacebookPage : ContentPage
   {
      public FacebookPage()
      {
         InitializeComponent();
            BindingContext = this;

            wView.Source = new UrlWebViewSource() { Url = "https://www.facebook.com/Car.Dealerships/" };
        }

        private async void OnBackTapped(Object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }


        public List<Sample> Items
        {
            get
            {
                return SampleData.SamplesCategories["Facebook"].SamplesList;
            }
        }
    }
}
