﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace s3GallegosTrujillo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
       

        public Page1()
        {
            InitializeComponent();
        }

        private void btnAbrir_Clicked(object sender, EventArgs e)
        {

            String datoUno = txtDatoUno.Text;
            int datoDos = Convert.ToInt32(txtDatoDos.Text);

            Navigation.PushAsync(new Page2(datoUno, datoDos));

        }
    }
}