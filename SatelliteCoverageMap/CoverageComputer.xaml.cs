using System;

using Xamarin.Forms;

namespace SatelliteCoverageMap
{
    public partial class CoverageComputer : ContentPage
    {
        public CoverageComputer()
        {
            InitializeComponent();
            drawContour.Clicked += drawContours_Clicked;
        }

        private async void drawContours_Clicked(object sender, EventArgs e)
        {
            double lat = Double.Parse(latitude.Text);
            double lon = Double.Parse(longitude.Text);
            double dia = Double.Parse(diameter.Text);

            await Navigation.PushAsync(new CoverageMap(lat, lon, dia));
        }
    }
}
