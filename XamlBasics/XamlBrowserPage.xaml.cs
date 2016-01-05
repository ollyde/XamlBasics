using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamlBasics
{
	public partial class XamlBrowserPage : ContentPage
	{
		public XamlBrowserPage (string xaml)
		{
			InitializeComponent ();
			label.Text = xaml;
		}
	}
}

