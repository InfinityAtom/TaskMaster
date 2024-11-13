using Blazored.LocalStorage;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MudBlazor.Services;
using TaskMaster.Data.Model;


namespace TaskMaster
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
            builder.Services.AddMudServices();
            builder.Services.AddDbContext<TaskMasterContext>(options =>
            options.UseSqlServer("Server=tcp:task-master-sv.database.windows.net,1433;Initial Catalog=database;User ID=tmaster;Password=p@SSWORD;Encrypt=True;Connection Timeout=180;", sqlOptions =>
            sqlOptions.MigrationsAssembly("TaskMaster.Data")));
            builder.Services.AddBlazoredLocalStorage();

#if DEBUG
            builder.Services.AddBlazorWebViewDeveloperTools();
    		builder.Logging.AddDebug();
            



#endif

            return builder.Build();
        }
    }
}
