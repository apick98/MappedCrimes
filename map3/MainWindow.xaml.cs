using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Windows.Devices.Geolocation;
using Windows.Storage.Streams;
using Windows.UI.Xaml.Controls.Maps;

namespace map3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       public MainWindow()
       {
            InitializeComponent();
       }
        private async void MapControl_Loaded(object sender, RoutedEventArgs e)
        {
            BasicGeoposition centrePos = new BasicGeoposition() { Latitude = 53, Longitude = -3.2 };
            var centre = new Geopoint(centrePos);
            BasicGeoposition geoPosition = new BasicGeoposition() { Latitude = 51.491947, Longitude = -0.161720 };
            var myPoint = new Geopoint(geoPosition);
            MapIcon myPOI = new MapIcon { Location = myPoint, Title = "75273563", NormalizedAnchorPoint = new Windows.Foundation.Point(0.5,1.0), ZIndex = 0 };
            myPOI.Image = RandomAccessStreamReference.CreateFromUri(new Uri("ms-appx:Assets/pin.png"));
            MapControl.MapElements.Add(item: myPOI);

            //await MapControl.TrySetViewAsync(myPoint,10);
            await MapControl.TrySetViewAsync(centre, 5.9);
        }
    }
}
