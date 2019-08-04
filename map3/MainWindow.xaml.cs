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
            APIHelper.InitialiseClient();
        }
        private async void MapControl_Loaded(object sender, RoutedEventArgs e)
        {
            var ukCrimes = await PoliceProcessor.LoadCrimesByLatitudeLongitude(52.9, -1.13);
            foreach (var crime in ukCrimes)
            {
                MapControl.MapElements.Add(new MapIcon { Location = new Geopoint(new BasicGeoposition() { Latitude = crime.location.latitude, Longitude = crime.location.longitude }), NormalizedAnchorPoint = new Windows.Foundation.Point(0.5, 1.0), ZIndex = 0 });
            }
            Geopoint centre = new Geopoint(new BasicGeoposition() { Latitude = ukCrimes.First().location.latitude, Longitude = ukCrimes.First().location.longitude });
            CrimeType.Content = ukCrimes.First().category;
            Year.Content = ukCrimes.First().Month;
            await MapControl.TrySetViewAsync(centre, 13.5);
        }
    }
}
