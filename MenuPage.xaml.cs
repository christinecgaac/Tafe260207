using Calculator;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Calculator

{
<<<<<<< HEAD

public sealed partial class MenuPage : Page

{

public MenuPage()

{
this.InitializeComponent();
}

private void MathCalculator_Click(object sender, RoutedEventArgs e)

{

Frame.Navigate(typeof(MainPage));

}
private void MortgageCalculator_Click(object sender, RoutedEventArgs e)

{
	
// Add mortgage navigation later
}

private void CurrencyCalculator_Click(object sender, RoutedEventArgs e)

{
	
Frame.Navigate(typeof(CurrencyConverterPage));
	
}




private void Exit_Click(object sender, RoutedEventArgs e)

{

Application.Current.Exit();
	
}

}

}
=======
	public sealed partial class MenuPage : Page
	{
		public MenuPage()
		{
			this.InitializeComponent();
		}

		private void MortgageButton_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
		{
			Frame.Navigate(typeof(MortgagePage));
		}
	}
}
>>>>>>> remotes/origin/feature/mortgage-calculator
