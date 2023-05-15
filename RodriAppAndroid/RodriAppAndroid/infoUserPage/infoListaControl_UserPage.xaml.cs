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
    public partial class infoListaControl_UserPage : ContentPage
    {
        public infoListaControl_UserPage()
        {
            InitializeComponent();
        }

    private void btnVolver_Clicked(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }
}
}