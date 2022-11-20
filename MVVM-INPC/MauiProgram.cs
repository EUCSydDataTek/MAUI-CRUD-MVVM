using Microsoft.Extensions.Logging;
using MVVM_INPC.Services;
using MVVM_INPC.ViewModels;
using MVVM_INPC.Views;

namespace MVVM_INPC;

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

		builder.Services.AddSingleton<IDataService, DataService>();

		builder.Services.AddSingleton<ListPage>();
		builder.Services.AddSingleton<ListPageViewModel>();

		builder.Services.AddTransient<DetailsPage>();
		builder.Services.AddTransient<DetailsPageViewModel>();

        builder.Services.AddTransient<AddEditPage>();
        builder.Services.AddTransient<AddEditPageViewModel>();

#if DEBUG
        builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
