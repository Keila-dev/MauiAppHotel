using System;
using Microsoft.Maui.Controls;

namespace MauiAppHotel.Views
{
    public partial class ContratacaoHospedagem : ContentPage
    {
        public ContratacaoHospedagem()
        {
            InitializeComponent();
        }

        private async void btnSobre_Clicked(object sender, EventArgs e)
        {
            // Navega para a p�gina Sobre
            await Navigation.PushAsync(new Sobre());
        }
    }
}