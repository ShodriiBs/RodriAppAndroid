using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;
using Plugin.Messaging;
using System.IO;
using Xamarin.Forms.OpenWhatsApp;

namespace RodriAppAndroid
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CompartirPage : ContentPage
    {
        public CompartirPage()
        {
            InitializeComponent();
        }

        private void btnCompartirCorreo_Clicked(object sender,EventArgs e)
        {
            var mensaje = CrossMessaging.Current.EmailMessenger;
            if (mensaje.CanSendEmail)
            {
                mensaje.SendEmail("rbustos.mssolutions@gmail.com",
                    "Resultados ECG",
                    "Adjunta el archivo descargado");
            }
        }

        private void btnCompartirWpp_Clicked(object sender, EventArgs e)
        {
            Chat.Open("+54 9 11 7361-0441", "holaa");
        }
    }
}