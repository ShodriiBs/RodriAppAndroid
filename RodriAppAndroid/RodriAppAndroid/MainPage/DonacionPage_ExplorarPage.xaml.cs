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
    public partial class DonacionPage_ExplorarPage : ContentPage
    {
        public DonacionPage_ExplorarPage()
        {
            InitializeComponent();
        }

        private void btnVolver_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

        private void btnDonate_Clicked(object sender, EventArgs e)
        {
            Launcher.OpenAsync("https://www.donatelife.net/");
        }
    }
}