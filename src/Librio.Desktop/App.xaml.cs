using System;
using System.IO;
using System.Windows;
using Librio.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Librio.Desktop
{
    public partial class App : System.Windows.Application
    {
        public static IServiceProvider ServiceProvider { get; private set; } = null!;

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            // Створюємо конфігурацію (appsettings.json)
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();

            // Налаштування DI
            var services = new ServiceCollection();
            ConfigureServices(services, configuration);

            ServiceProvider = services.BuildServiceProvider();

            // Показуємо головне вікно
            var mainWindow = ServiceProvider.GetRequiredService<MainWindow>();
            mainWindow.Show();
        }

        private void ConfigureServices(IServiceCollection services, IConfiguration configuration)
        {
            // Реєстрація DbContext з конфігурацією підключення
            services.AddDbContext<LibrioDbContext>(options =>
                options.UseNpgsql(configuration.GetConnectionString("DefaultConnection")));

            // Головне вікно WPF
            services.AddSingleton<MainWindow>();

            // Додаткові сервіси (за потреби)
            // services.AddScoped<IMyService, MyService>();
        }
    }
}
