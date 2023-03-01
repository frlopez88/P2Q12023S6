using PrimerosPasos.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PrimerosPasos.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ViewPersonaCarro : ContentPage
    {
        public ViewPersonaCarro()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            this.BindingContext = new ViewModelPersonaCarro();
        }
    }
}