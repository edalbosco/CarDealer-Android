using CarDealer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace CarDealer.Pages
{
    public partial class OurNewsPage : ContentPage
    {
        public OurNewsPage()
        {
            InitializeComponent();

            BindingContext = this;

        }

        private async void OnBackTapped(Object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }

        public List<Sample> Items
        {
            get
            {
                return SampleData.SamplesCategories["Our News"].SamplesList;
            }
        }

        public List<News> NewsItems
        {
            get
            {
                return SampleData.newsList;
            }
        }
    }
}
