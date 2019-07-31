using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace SatelliteCoverageMap
{
    public partial class CoverageMap : ContentPage
    {
        public CoverageMap()
        {
            var map = new CustomMap()
            {
                MapType = MapType.Hybrid,
                IsShowingUser = true,
                HeightRequest = 100,
                WidthRequest = 960,
                VerticalOptions = LayoutOptions.FillAndExpand
            };

            DrawContours(map, new Position(35, -100), 2000);

            var stack = new StackLayout { Spacing = 0 };
            stack.Children.Add(map);
            Content = stack;
        }

        public void DrawContours(CustomMap map, Position position, double diameter)
        {

            map.Circle = new CustomCircle
            {
                Position = position,
                Radius = diameter / 2
            };
            map.MoveToRegion(MapSpan.FromCenterAndRadius(position, Distance.FromMiles(1.0)));
        }
    }
}