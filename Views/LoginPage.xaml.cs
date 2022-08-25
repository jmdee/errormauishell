namespace InvestAfrica.Views;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
	}

	private void CounterBtn_Clicked(object sender, EventArgs e)
	{
        Application.Current.MainPage = new NavigationPage(new AppShell());
    }
}