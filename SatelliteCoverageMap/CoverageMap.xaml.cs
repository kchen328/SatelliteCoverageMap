using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace SatelliteCoverageMap
{
    public partial class CoverageMap : ContentPage
    {
        private double Latitude { get; set; }
        private double Longitude { get; set; }
        private double Diameter { get; set; }

        private CustomMap Map { get; set; }

        public CoverageMap(double lat, double lon, double diameter)
        {
            Latitude = lat;
            Longitude = lon;
            Diameter = diameter;

            Map = new CustomMap()
            {
                MapType = MapType.Hybrid,
                IsShowingUser = true,
                HeightRequest = 100,
                WidthRequest = 960,
                VerticalOptions = LayoutOptions.FillAndExpand
            };

            DrawContours();

            var stack = new StackLayout { Spacing = 0 };
            stack.Children.Add(Map);
            Content = stack;
        }

        public void DrawContours()
        {
            Position position = new Position(Latitude, Longitude);

            Map.Circle = new CustomCircle
            {
                Position = position,
                Radius = (Diameter * 1000) / 2
            };
            Map.MoveToRegion(MapSpan.FromCenterAndRadius(position, Distance.FromMiles(1000)));
        }
    }
}