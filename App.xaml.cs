﻿using InvestAfrica.Views;

namespace InvestAfrica;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new LoginPage();
	}
}
