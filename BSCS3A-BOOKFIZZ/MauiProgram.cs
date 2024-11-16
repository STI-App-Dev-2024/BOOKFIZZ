using Microsoft.Extensions.Logging;

namespace BSCS3A_BOOKFIZZ
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
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                    fonts.AddFont("IrishGrover-Regular.ttf", "IrishGrover");
                    fonts.AddFont("Lusitana-Bold.ttf", "Lusitana");
                    fonts.AddFont("Judson-Regular.ttf", "Judson");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
