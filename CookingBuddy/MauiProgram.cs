using Microsoft.AspNetCore.Components.WebView.Maui;
using CookingBuddy.Services;

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

		var dbPath =
			Path.Combine(
				Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
				@"CookingBuddy.db");

		builder.Services.AddSingleton<RecipeService>(
			s => ActivatorUtilities.CreateInstance<RecipeService>(s, dbPath));

		builder.Services.AddSingleton<UserService>();
		builder.Services.AddSingleton<LessonService>();

		#if DEBUG
		builder.Services.AddBlazorWebViewDeveloperTools();
		#endif
		return builder.Build();
	}
}

