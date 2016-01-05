using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamlBasics
{
	public partial class HelloXamlPage : ContentPage
	{
		public HelloXamlPage ()
		{
			InitializeComponent ();
			valueLabel.Text = slider.Value.ToString ("F3");
		}

		void OnSliderValueChanged(object sender, ValueChangedEventArgs args)
		{
			valueLabel.Text = ((Slider)sender).Value.ToString("F3");
		}

		async void OnButtonClicked(object sender, EventArgs args)
		{
			await DisplayAlert(
				"Clicked!",
				"Button was clicked, value is: " + slider.Value.ToString ("F3"), 
				"OK"
			);
		}
	}
}

