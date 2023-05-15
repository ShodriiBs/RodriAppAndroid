using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace RodriAppAndroid
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ExplorarPage : ContentPage
    {
        public ExplorarPage()
        {
            InitializeComponent();
        }

        private void btnUser_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new UserPage());
        }

        private void btnDonacion_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DonacionPage_ExplorarPage());
        }

        private void btnDondeEstoy_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new UbicacionPage());
    }

        private void btnAyuda_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AyudaPage());
        }

        private async void btnECG_Clicked(object sender, EventArgs e)
        {
            await Launcher.OpenAsync("com.samsung.android.shealthmonitors");
        }

        private void MiMedico_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MiMedicoPage());
        }

        private void MisDatos_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MisDatosMedicos());
        }

        private async void gotoTelemedicina1_Clicked(object sender, EventArgs e)
        {
            await Launcher.OpenAsync("telemedicinaapp://index");
        }

        private async void gotoTelemecina0_Clicked(object sender, EventArgs e)
        {
            await Launcher.OpenAsync("telemedicinaapp://index");
        }

        private void btnIMC_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ComposicionCorporal());
        }

        private void btnCiclo_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SeguimientoCiclo());
        }
    }
}