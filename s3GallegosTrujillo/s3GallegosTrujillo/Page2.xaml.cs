using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace s3GallegosTrujillo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page2 : ContentPage
    {
        public Page2( string datoUno, int datoDos)
        {
            InitializeComponent();
            lblDatoUno.Text = "Dato Uno"+datoUno;
            lblDatoDos.Text = "Datos Dos"+datoDos.ToString();
        }

        private void btnAbrir_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page3());
        }
    }
}