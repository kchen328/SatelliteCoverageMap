using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace SatelliteCoverageMap
{
    public partial class CoverageMap : ContentPage
    {
        public CoverageMap()
        {
            Map map = new Map(
                MapSpan.FromCenterAndRadius(
                        new Position(35, -100), Distance.FromMiles(5000)))
            {
                IsShowingUser = true,
                HeightRequest = 100,
                WidthRequest = 960,
                VerticalOptions = LayoutOptions.FillAndExpand
            };
            var stack = new StackLayout { Spacing = 0 };
            stack.Children.Add(map);
            Content = stack;

        }

        public void DrawContours()
        {
        }
    }
}
