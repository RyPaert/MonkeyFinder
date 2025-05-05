﻿using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Debug;
using MonkeyFinder.Services;
using MonkeyFinder.View;

namespace MonkeyFinder;

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

#if DEBUG
		builder.Logging.AddDebug();
		builder.Services.AddSingleton<MainPage>();

		builder.Services.AddSingleton<MonkeyService>();

		builder.Services.AddSingleton<MonkeysViewModel>();
#endif
		return builder.Build();
	}
}
