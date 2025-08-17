using Microsoft.Extensions.Logging;

namespace MauiAppPrimeiro
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {            MainPage = new NavigationPage(new View.ListaProduto());
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });
                        MainPage = new NavigationPage(new View.ListaProduto());
#if DEBUG
    		builder.Logging.AddDebug();
#endif
                        MainPage = new NavigationPage(new View.ListaProduto());
            return builder.Build();
        }

    }
}
