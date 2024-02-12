using Microsoft.Extensions.Configuration;
using System.Runtime.CompilerServices;

namespace schedulo;

static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

        IConfiguration configuration = builder.Build();
        
        using (var dbContext = new MyDbContext(configuration))
        {
            dbContext.Initialize();
        }
        
        ApplicationConfiguration.Initialize();
        Application.Run(new MainWindow(configuration));

    }
}