using CommunityToolkit.Maui;
using Finsculpt.Services;
using Finsculpt.ViewModels;
using Finsculpt.Views;
using Microsoft.Extensions.Logging;
using Syncfusion.Maui.Core.Hosting;

namespace Finsculpt

{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit()
                .ConfigureSyncfusionCore()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                    fonts.AddFont("open-iconic.ttf", "Icons");
                });
            builder.Services.AddSingleton<IServiceInterface, ServiceImplementation>();
            builder.Services.AddScoped<HomePageViewModel>();
            builder.Services.AddScoped<HomePage>();
            builder.Services.AddScoped<ManageExpensesPageViewModel>();
            builder.Services.AddScoped<ManageExpensesPage>();

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
