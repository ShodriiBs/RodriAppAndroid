using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Plugin.Messaging;

namespace RodriAppAndroid
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AyudaPage : ContentPage
    {
        public AyudaPage()
        {
            InitializeComponent();
        }

        private void btnTextbox_Clicked(object sender, EventArgs e)
        {
            
            var mensaje = CrossMessaging.Current.EmailMessenger;
            if (mensaje.CanSendEmail)
            {
                mensaje.SendEmail("rbustos.mssolutions@gmail.com",Asunto.Text,Descripcion.Text);
            }
        }
        private void TapUtil_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new HealthyUtil());
        }
    }
}