using Microsoft.Maui;
using Microsoft.Maui.Hosting;

namespace MyApp
{
    public class Program : MauiApplication
    {
        public static void Main(string[] args) =>
            MauiApplication.CreateBuilder().UseMauiApp<App>().Build().Run(args);

        protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();
    }
}
