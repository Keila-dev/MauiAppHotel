using MauiAppHotel.Views;
using System;
using Microsoft.Maui.Controls;

namespace MauiAppHotel.Views;

public partial class Galeria : ContentPage
{
	public Galeria()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
		await Navigation.PopAsync();
    }
}