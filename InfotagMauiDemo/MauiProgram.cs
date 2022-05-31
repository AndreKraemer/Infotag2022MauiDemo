using InfotagMauiDemo.Services;
using InfotagMauiDemo.ViewModels;
using InfotagMauiDemo.Views;

namespace InfotagMauiDemo;

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
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

		builder.Services.AddTransient<SessionsPage>();
		builder.Services.AddTransient<SessionDetailPage>();
        builder.Services.AddTransient<SessionsPageViewModel>();
        builder.Services.AddTransient<SessionDetailPageViewModel>();
        builder.Services.AddTransient<IDataService, StaticDataService>();

        return builder.Build();
	}
}
