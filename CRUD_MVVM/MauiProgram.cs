using CRUD_MVVM.Services;
using CRUD_MVVM.ViewModels;
using Microsoft.Extensions.Logging;
using CRUD_MVVM;
using CRUD_MVVM.Views;

namespace CRUD_MVVM;

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
