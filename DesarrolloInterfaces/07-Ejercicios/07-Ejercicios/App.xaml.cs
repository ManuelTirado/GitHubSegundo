﻿using _07_Ejercicios.Views;

namespace _07_Ejercicios;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new PaginaTabbed();
	}
}