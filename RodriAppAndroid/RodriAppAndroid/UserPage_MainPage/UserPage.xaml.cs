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
    public partial class UserPage : ContentPage
    {

        public UserPage()
        {
            InitializeComponent();
        }


        private void btnPerfilSalud_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new infoPerfilSalud_UserPage());
        }

        private void btnFichaMedica_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new infoFichaMedica_UserPage());
        }
        
        private void btnVolver_Clicked(object sender,EventArgs e)
        {
            Navigation.PopAsync();
        }
        private void btnListaControl_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new infoListaControl_UserPage());
        }
    }
}