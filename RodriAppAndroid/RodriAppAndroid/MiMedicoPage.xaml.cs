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
    public partial class MiMedicoPage : ContentPage
    {
        public MiMedicoPage()
        {
            InitializeComponent();
        }

        private void Guardar_Clicked(object sender, EventArgs e)
        {
            NombreMedicoSave.Text = EntryMedicoNombre.Text;
            CorreoMedicoSave.Text = EntryMedicoCorreo.Text;
            NumeroMedicoSave.Text = EntryMedicoNumero.Text;
            EntryMedicoCorreo.Text = "";
            EntryMedicoNombre.Text = "";
            
        }

    }
}