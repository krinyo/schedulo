using Microsoft.Extensions.Configuration;
using schedulo.Data;
using System.Runtime.CompilerServices;

namespace schedulo;

static class Program
{

    [STAThread]
    static void Main()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

        IConfiguration configuration = builder.Build();

        ApplicationConfiguration.Initialize();

        var mainView = new Views.MainView();
        var mainPresenter = new Presenters.MainPresenter(mainView, configuration);

        Application.Run(mainView);
    }

}