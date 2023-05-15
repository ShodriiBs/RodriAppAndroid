using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Data;
using MySql.Data.MySqlClient;
using System.Reflection;
using Org.BouncyCastle.Bcpg;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

namespace RodriAppAndroid
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegisterPage : ContentPage
    {
        public RegisterPage()
        {
            InitializeComponent();
        }

        private void btnTerminos_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TerminosCondicionesPage());
        }

        private void btnVolver_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

        private async void btnRegistro_Clicked(object sender, EventArgs e)
        {
            
            string Nombre = Nombres.Text;
            string Apellido = Apellidos.Text;
            string TipoSangre = Sangre.Text;
            string user = Usuario.Text;
            string pass = Contraseña.Text;

            if (Nombre != null && Apellido != null  && user != null && pass != null)
            {

                await DisplayAlert("Bienvenido a Hearty", "Esperamos que disfrute de su experiencia", "¡Gracias!");
                await Navigation.PushAsync(new MainPage());
            }
            else
            {
               await DisplayAlert("Faltan completar datos", "Por favor complete todos los datos para continuar con su registro", "Entendido");
            }

        }

    }
}