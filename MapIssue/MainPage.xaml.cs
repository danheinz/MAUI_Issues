namespace MapIssue;

using System;
using System.Collections.Generic;
using Microsoft.Maui.Controls.Maps;
using Microsoft.Maui.Devices.Sensors;
using Microsoft.Maui.Maps;
public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    private async void Map_Loaded(object sender, EventArgs e)
    {

        await Move();
        LocationsMap.IsVisible = true;
    }

    private async Task Move()
    {
        Location geoLocation = await Geolocation.GetLocationAsync();
        Distance dist = Distance.FromMiles(20);
        LocationsMap.MoveToRegion(MapSpan.FromCenterAndRadius(geoLocation, dist));
    }
}

