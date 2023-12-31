﻿using Microsoft.Extensions.Logging;

namespace Maui18936AfterBlazorRenderApp
{
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
    		builder.Logging.AddDebug();
#endif

            // Register pages and services in the DI container
            builder.Services.AddTransient<MainPage>();
            builder.Services.AddSingleton<FirstRazorLayoutRenderedService>();

            return builder.Build();
        }
    }
}
