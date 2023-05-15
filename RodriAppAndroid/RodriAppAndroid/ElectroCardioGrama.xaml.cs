using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RodriAppAndroid
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ElectroCardioGrama : ContentPage
    {
        public ElectroCardioGrama()
        {
            InitializeComponent();
        }

        private async void GotoApp2_Clicked(object sender, EventArgs e)
        {
           await Launcher.OpenAsync("telemedicinaapp://index");

        }
    }

}