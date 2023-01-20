using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Windows.Forms;
using FormUI.Forms;

namespace FormUI
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var host = CreateHostBuilder().Build();
            ServiceProvider = host.Services;

            Application.Run(ServiceProvider.GetRequiredService<LoginPage>());

        }
        public static IServiceProvider ServiceProvider { get; private set; }
        static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) =>
                {
                    services.AddTransient<IAuthService, AuthManager>();
                    services.AddTransient<LoginPage>();

                    services.AddTransient<IUserService, UserManager>();
                    services.AddTransient<IUserDal, EfUserDal>();

                    services.AddTransient<IUserOperationClaimService, UserOperationClaimManager>();
                    services.AddTransient<IUserOperationClaimDal, EfUserOperationClaimDal>();
                    
                    services.AddTransient<IOperationClaimService, OperationClaimManager>();
                    services.AddTransient<IOperationClaimDal, EfOperationClaimDal>();

                    services.AddTransient<IRecordService, RecordManager>();
                    services.AddTransient<IRecordDal, EfRecordDal>();


                });
        }
    }
}