using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PrimerosPasos
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void saludar(object sender, EventArgs e)
        {

            string nm = txtNombre.Text;
            lblResultado.Text = $"Un saludo, {nm}!!!";

        }
    }
}
