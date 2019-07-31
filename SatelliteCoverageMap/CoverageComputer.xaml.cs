using System;
using System.Collections.Generic;

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
            await Navigation.PushAsync(new CoverageMap());
        }
    }
}
