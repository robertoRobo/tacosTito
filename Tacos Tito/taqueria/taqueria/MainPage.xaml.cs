using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FFImageLoading;
using Xamarin.Forms;

namespace taqueria
{
	public partial class MainPage : ContentPage
	{
        public MainPage()
        {
            InitializeComponent();
            btnMenu.Clicked += BtnMenu_Clicked;
            btnSucursales.Clicked += BtnSucursales_Clicked;
        }

        private void BtnSucursales_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Sucursales());
        }

        private void BtnMenu_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Menu());
        }
    }
}
