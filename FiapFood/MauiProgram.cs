using FiapFood.View;
using FiapFood.ViewModel;
using Microsoft.Extensions.Logging;
using CommunityToolkit.Maui;
using FiapFood.Services;
using UraniumUI;

namespace FiapFood
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder.UseMauiApp<App>().ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                fonts.AddMaterialIconFonts();
            })
                .UseMauiCommunityToolkit()
                .UseUraniumUI()
                .UseUraniumUIMaterial()
                .UseMauiMaps();

#if DEBUG
            builder.Logging.AddDebug();
#endif
            builder.Services.AddSingleton<LoginViewModel>();
            builder.Services.AddSingleton<LoginPage>();

            builder.Services.AddSingleton<LojasViewModel>();
            builder.Services.AddSingleton<LojasPage>();

            builder.Services.AddSingleton<LojaDetalheViewModel>();
            builder.Services.AddSingleton<LojaDetalhePage>();

            builder.Services.AddScoped<IUsuarioService,UsuarioService>();
            builder.Services.AddScoped<ILojaService, LojaService>();

            return builder.Build();
        }
    }
}