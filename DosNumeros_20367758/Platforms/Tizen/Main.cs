using System;
using Microsoft.Maui;
using Microsoft.Maui.Hosting;

namespace DosNumeros_20367758;

class Program : MauiApplication
{
	protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();

	static void Main(string[] args)
	{
		var app = new Program();
		app.Run(args);
	}
}
