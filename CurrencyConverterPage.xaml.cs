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
	public sealed partial class CurrencyConverterPage : Page
	{
		public CurrencyConverterPage()
		{
			this.InitializeComponent();
		}

		private void ConvertButton_Click(object sender, RoutedEventArgs e)
		{
			double amount = Convert.ToDouble(txtAmount.Text);

			string fromCurrency =
				((ComboBoxItem)cmbFrom.SelectedItem).Content.ToString();

			string toCurrency =
				((ComboBoxItem)cmbTo.SelectedItem).Content.ToString();

			double result = 0;

			if (fromCurrency == "USD" && toCurrency == "EUR")
			{
				result = amount * 0.85189982;
			}
			else if (fromCurrency == "USD" && toCurrency == "GBP")
			{
				result = amount * 0.72872436;
			}
			else if (fromCurrency == "USD" && toCurrency == "INR")
			{
				result = amount * 74.257327;
			}
			else if (fromCurrency == "EUR" && toCurrency == "USD")
			{
				result = amount * 1.1739732;
			}
			else if (fromCurrency == "EUR" && toCurrency == "GBP")
			{
				result = amount * 0.8556672;
			}
			else if (fromCurrency == "EUR" && toCurrency == "INR")
			{
				result = amount * 87.00755;
			}
			else if (fromCurrency == "GBP" && toCurrency == "USD")
			{
				result = amount * 1.371907;
			}
			else if (fromCurrency == "GBP" && toCurrency == "EUR")
			{
				result = amount * 1.1686692;
			}
			else if (fromCurrency == "GBP" && toCurrency == "INR")
			{
				result = amount * 101.68635;
			}
			else if (fromCurrency == "INR" && toCurrency == "USD")
			{
				result = amount * 0.011492628;
			}
			else if (fromCurrency == "INR" && toCurrency == "EUR")
			{
				result = amount * 0.013492774;
			}
			else if (fromCurrency == "INR" && toCurrency == "GBP")
			{
				result = amount * 0.0098339397;
			}
			else
			{
				result = amount;
			}

			txtResult.Text = result.ToString();
		}
	}
}
