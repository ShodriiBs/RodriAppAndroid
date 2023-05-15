using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RodriAppAndroid
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HealthyUtil : ContentPage
    {
        public HealthyUtil()
        {
            InitializeComponent();
        }

        private void menuAnterior_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AyudaPage());
        }

        private void menuPrincipal_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }
    }
}