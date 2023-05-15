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
    public partial class ComposicionCorporal : ContentPage
    {
        public ComposicionCorporal()
        {
            InitializeComponent();
        }

        private void CalcularIMC_Clicked(object sender, EventArgs e)
        {
            var pesaje = Convert.ToDouble(peso.Text);
            var altitud = Convert.ToDouble(altura.Text);

            var IMC = pesaje / (altitud * altitud);

            ResultadoIMC.Text = Convert.ToString(IMC);

            double resultadoDouble = Convert.ToDouble(ResultadoIMC.Text);

            if (resultadoDouble < 15)
            {
                DescripcionIMC.Text = "Su IMC se encuentra por debajo del bajo peso, se le recomienda comunicarse con un médico";
            }
            else if (resultadoDouble > 15 && resultadoDouble < 18.5)
            {
                DescripcionIMC.Text = "Su IMC se encuentra por debajo del peso adecuado";

            }else if (resultadoDouble >= 18.5 && resultadoDouble < 25)
            {
                DescripcionIMC.Text = "Su IMC se encuentra en el peso adecuado";

            }
            else if (resultadoDouble >= 25 && resultadoDouble < 30)
            {
                DescripcionIMC.Text = "Su IMC se encuentra un poco por encima del peso adecuado";

            }
            else if (resultadoDouble >= 30 && resultadoDouble < 35)
            {
                DescripcionIMC.Text = "Su IMC se encuentra por encima del sopreseso, con posible obesidad grado 1";

            }
            else if (resultadoDouble >= 35 && resultadoDouble < 40)
            {
                DescripcionIMC.Text = "Su IMC se encuentra por encima del sobrepeso, con posible obesidad grado 2";

            }
            else if (resultadoDouble >= 40)
            {
                DescripcionIMC.Text = "Su IMC se encuentra por encima del sobrepeso, con posible obesidad grado 3";

            }

        }
    }
}