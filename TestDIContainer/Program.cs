using Microsoft.Extensions.DependencyInjection;
using TestDIContainer.Loggers;

namespace TestDIContainer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Створення сервіс-контейнера
            var services = new ServiceCollection();
            ConfigureServices(services);

            // Створення постачальника сервісів
            var serviceProvider = services.BuildServiceProvider();

            // Отримання екземпляра
            var controller = serviceProvider.GetRequiredService<Controller>();

            controller.Method();
        }
        private static void ConfigureServices(IServiceCollection services)
        {
            // Реєстрація сервісів у IoC контейнері
            services.AddSingleton<ILogger, ConsoleLogger>();
            services.AddSingleton<IService, Service>();
            services.AddTransient<Controller>();
        }
    }
}