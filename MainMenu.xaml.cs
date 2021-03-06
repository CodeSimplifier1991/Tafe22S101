using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Calculator
{
	/// <summary>
	/// An empty page that can be used on its own or navigated to within a Frame.
	/// </summary>
	public sealed partial class MainMenu : Page
	{
		public MainMenu()
		{
			this.InitializeComponent();
		}

		// START - Math btn click handler
		private void mathBtn_Click(object sender, RoutedEventArgs e)
		{
			this.Frame.Navigate(typeof(MainPage), null);
		}
		// END - Math btn click handler


		// START - Mortgage btn click handler
		private void mortgageBtn_Click(object sender, RoutedEventArgs e)
		{
			this.Frame.Navigate(typeof(MortgageCalculator), null);
		}
		// END - Mortgage btn click handler


		// START - Currency Conversion btn click handler
		private void currencyBtn_Click(object sender, RoutedEventArgs e)
		{
			this.Frame.Navigate(typeof(CurrencyConversion), null);
		}
		// END - Currency Conversion btn click handler


		// START - Trip Calculator btn click handler
		private void tripCalculatorBtn_Click(object sender, RoutedEventArgs e)
		{
			this.Frame.Navigate(typeof(TripCalculator), null);
		}
		// END - Trip Calculator btn click handler



	}
	// MainMenu
}
