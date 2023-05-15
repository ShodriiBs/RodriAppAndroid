using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;
using System.Resources;

namespace RodriAppAndroid
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UbicacionPage : ContentPage
    {
        public UbicacionPage()
        {
            InitializeComponent();
            IniciaCoordenadas();
        }

        private async void btnGPS_Clicked(object sender, EventArgs e)
        {
            string latitudMapa = lat.Text;
            double latitudMapaDouble = Convert.ToDouble(latitudMapa);

            string longitudMapa = lon.Text;
            double longitudMapaDouble = Convert.ToDouble(longitudMapa);

            MapLaunchOptions options = new MapLaunchOptions { Name = "Mi posición actual" };
            await Map.OpenAsync(latitudMapaDouble, longitudMapaDouble, options);
        }

        private async void coordenadas_Clicked(object sender, EventArgs e)
        {
            var location = await Geolocation.GetLastKnownLocationAsync();
            if (location == null)
            {
                location = await Geolocation.GetLocationAsync(new GeolocationRequest
                {
                    DesiredAccuracy = GeolocationAccuracy.Medium,
                    Timeout = TimeSpan.FromSeconds(5)
                });
            }

            if (location == null)
            {
              
            }
            else
            {
                lon.Text = location.Longitude.ToString();
                lat.Text = location.Latitude.ToString();
            }
        }

        private async void IniciaCoordenadas()
        {
            var location = await Geolocation.GetLastKnownLocationAsync();
            if (location == null)
            {
                location = await Geolocation.GetLocationAsync(new GeolocationRequest
                {
                    DesiredAccuracy = GeolocationAccuracy.Medium,
                    Timeout = TimeSpan.FromSeconds(5)
                });
            }

            if (location == null)
            {

            }
            else
            {
                lon.Text = location.Longitude.ToString();
                lat.Text = location.Latitude.ToString();
            }
        }
    }
}