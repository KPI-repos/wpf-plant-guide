using Microsoft.Extensions.DependencyInjection;
using System.Configuration;
using System.Data;
using System.Windows;
using wpf_plant_guide.Repository;

namespace wpf_plant_guide
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public IServiceProvider ServiceProvider { get; private set; }

        protected override void OnStartup(StartupEventArgs e)
        {
            var services = new ServiceCollection();

            // Register IPlantRepository scoped to PlantRepository
            services.AddScoped<IPlantRepository, PlantRepository>();

            ServiceProvider = services.BuildServiceProvider();

            base.OnStartup(e);

            // Start the main window
            var mainWindow = ServiceProvider.GetRequiredService<MainWindow>();
            mainWindow.Show();
        }
    }

}
