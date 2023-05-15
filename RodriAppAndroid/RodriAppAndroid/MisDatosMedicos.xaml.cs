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
    public partial class MisDatosMedicos : ContentPage
    {
        public MisDatosMedicos()
        {
            InitializeComponent();
        }

        private void SiDiabetes_Clicked(object sender, EventArgs e)
        {
            Insu.IsVisible = true;
            SiInsu.IsVisible = true;
            NoInsu.IsVisible = true;
            (sender as Button).BackgroundColor = Color.FromHex("66B366");
            NoDiabetes.BackgroundColor = Color.FromHex("EEEEEE");
        }

        private void NoDiabetes_Clicked(object sender, EventArgs e)
        {
            Insu.IsVisible = false;
            SiInsu.IsVisible = false;
            NoInsu.IsVisible = false;
            (sender as Button).BackgroundColor = Color.FromHex("66B366");
            SiDiabetes.BackgroundColor = Color.FromHex("EEEEEE");
            SiInsu.BackgroundColor = Color.FromHex("EEEEEE");
            NoInsu.BackgroundColor = Color.FromHex("EEEEEE");
        }

        private void SiInsu_Clicked(object sender, EventArgs e)
        {
            (sender as Button).BackgroundColor = Color.FromHex("66B366");
            NoInsu.BackgroundColor = Color.FromHex("EEEEEE");
        }

        private void NoInsu_Clicked(object sender, EventArgs e)
        {
            (sender as Button).BackgroundColor = Color.FromHex("66B366");
            SiInsu.BackgroundColor = Color.FromHex("EEEEEE");
        }

        private void SiResInsu_Clicked(object sender, EventArgs e)
        {
            (sender as Button).BackgroundColor = Color.FromHex("66B366");
            NoResInsu.BackgroundColor = Color.FromHex("EEEEEE");
        }

        private void NoResInsu_Clicked(object sender, EventArgs e)
        {
            (sender as Button).BackgroundColor = Color.FromHex("66B366");
            SiResInsu.BackgroundColor = Color.FromHex("EEEEEE");
        }

        private void SiHipertension_Clicked(object sender, EventArgs e)
        {
            (sender as Button).BackgroundColor = Color.FromHex("66B366");
            NoHipertension.BackgroundColor = Color.FromHex("EEEEEE");
        }

        private void NoHipertension_Clicked(object sender, EventArgs e)
        {
            (sender as Button).BackgroundColor = Color.FromHex("66B366");
            SiHipertension.BackgroundColor = Color.FromHex("EEEEEE");
        }

        private void SiInfarto_Clicked(object sender, EventArgs e)
        {
            (sender as Button).BackgroundColor = Color.FromHex("66B366");
            NoInfarto.BackgroundColor = Color.FromHex("EEEEEE");
        }

        private void NoInfarto_Clicked(object sender, EventArgs e)
        {
            (sender as Button).BackgroundColor = Color.FromHex("66B366");
            SiInfarto.BackgroundColor = Color.FromHex("EEEEEE");
        }

        private void SiAngio_Clicked(object sender, EventArgs e)
        {
            (sender as Button).BackgroundColor = Color.FromHex("66B366");
            NoAngio.BackgroundColor = Color.FromHex("EEEEEE");
        }

        private void NoAngio_Clicked(object sender, EventArgs e)
        {
            (sender as Button).BackgroundColor = Color.FromHex("66B366");
            SiAngio.BackgroundColor = Color.FromHex("EEEEEE");
        }

        private void NoArritmia_Clicked(object sender, EventArgs e)
        {
            (sender as Button).BackgroundColor = Color.FromHex("66B366");
            SiArritmia.BackgroundColor = Color.FromHex("EEEEEE");
            Arritmias0.IsVisible = false;
            Arritmias1.IsVisible = false;
            Describa.IsVisible = false;
        }

        private void SiArritmia_Clicked(object sender, EventArgs e)
        {
            (sender as Button).BackgroundColor = Color.FromHex("66B366");
            NoArritmia.BackgroundColor = Color.FromHex("EEEEEE");
            Arritmias0.IsVisible = true;
            Arritmias1.IsVisible = true;
        }

        private void SiExtra_Clicked(object sender, EventArgs e)
        {

        }

        private void SiFibrilación_Clicked(object sender, EventArgs e)
        {

        }

        private void SiTaquicardia_Clicked(object sender, EventArgs e)
        {

        }

        private void SiBloqueo_Clicked(object sender, EventArgs e)
        {

        }

        private void SiOtros_Clicked(object sender, EventArgs e)
        {
            Describa.IsVisible = true;
        }

        private void SiCancelar_Clicked(object sender, EventArgs e)
        {
            Describa.IsVisible = false;
        }

        private void SiMarcaPasos_Clicked(object sender, EventArgs e)
        {
            (sender as Button).BackgroundColor = Color.FromHex("66B366");
            NoMarcaPasos.BackgroundColor = Color.FromHex("EEEEEE");
        }

        private void NoMarcaPasos_Clicked(object sender, EventArgs e)
        {
            (sender as Button).BackgroundColor = Color.FromHex("66B366");
            SiMarcaPasos.BackgroundColor = Color.FromHex("EEEEEE");
        }

        private void NoAngina_Clicked(object sender, EventArgs e)
        {
            (sender as Button).BackgroundColor = Color.FromHex("66B366");
            SiAngina.BackgroundColor = Color.FromHex("EEEEEE");
        }

        private void SiAngina_Clicked(object sender, EventArgs e)
        {
            (sender as Button).BackgroundColor = Color.FromHex("66B366");
            NoAngina.BackgroundColor = Color.FromHex("EEEEEE");
        }

        private void SiCirugia_Clicked(object sender, EventArgs e)
        {
            (sender as Button).BackgroundColor = Color.FromHex("66B366");
            NoCirugia.BackgroundColor = Color.FromHex("EEEEEE");
            SiBypass.IsVisible = true;
            SiValvula.IsVisible = true;
        }

        private void NoCirugia_Clicked(object sender, EventArgs e)
        {
            (sender as Button).BackgroundColor = Color.FromHex("66B366");
            SiCirugia.BackgroundColor = Color.FromHex("EEEEEE");
            SiBypass.IsVisible = false;
            SiValvula.IsVisible = false;
        }

        private void SiValvula_Clicked(object sender, EventArgs e)
        {
            (sender as Button).BackgroundColor = Color.FromHex("66B366");
            
        }

        private void SiBypass_Clicked(object sender, EventArgs e)
        {
            (sender as Button).BackgroundColor = Color.FromHex("66B366");
            
        }
    }
}