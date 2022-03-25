using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace MessageExchanger
{
    /// <summary>
    /// Основной класс программы.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Точка входа.
        /// </summary>
        /// <param name="args">Входные параметры.</param>
        public static void Main(string[] args)
        {
            
            CreateHostBuilder(args).Build().Run();
        }
        
        /// <summary>
        /// Метод создания хоста.
        /// </summary>
        /// <param name="args">Входные параметры.</param>
        /// <returns>Хост.</returns>
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder => { webBuilder.UseStartup<Startup>(); });
    }
}