using Microsoft.AspNetCore.Components.WebView.Maui;
//using CookingBuddy.Data;

namespace CookingBuddy;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
			});

		builder.Services.AddMauiBlazorWebView();
		#if DEBUG
		builder.Services.AddBlazorWebViewDeveloperTools();
		#endif

		//// Set path to SQLite database (it will be created if it does not exist)
		//var dbPath = Path.Combine(
		//	Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
		//	@"CookingBuddy.db");
		//// Register UserService and the SQLite database
		
		//// Register RecipeService and the SQLite database
		//builder.Services.AddSingleton<RecipeService>(
		//	s => ActivatorUtilities.CreateInstance<RecipeService>(s, dbPath));
		return builder.Build();
	}
}

