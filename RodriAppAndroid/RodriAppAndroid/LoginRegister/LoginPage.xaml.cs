using RodriAppAndroid.ConexionSQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;

namespace RodriAppAndroid
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            Notificaciones();
        }

        private async void btnIngresar_Clicked(object sender, EventArgs e)
        {
            try
            {
                ConexionSQL.ConexionMySQL objetoconexion = new ConexionSQL.ConexionMySQL();
                objetoconexion.Conectar();
                await Navigation.PushAsync(new MainPage());

            }
            catch(Exception ex)
            {
                
            }


        }

        private void Notificaciones()
        {
            Plugin.LocalNotifications.CrossLocalNotifications.Current.Show("Electrocardiograma", "Recuerde hacerse un ECG diario",0);
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new RegisterPage());
        }

        private void OlvidarContra_Clicked(object sender, EventArgs e)
        {
            
        }
    }
}