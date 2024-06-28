using Autofac;
using Infraestrutura.Factory;
using Infraestrutura.Generic_DAL;
using Negocio.Bussines.Login;
using Negocio.Bussines.Login.DAL;
using Negocio.Bussines.Login.Model;
using Sistema.Infraestrutura.Dependency_Injection;

namespace PrincipalForm
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            DInjector.Configure();
            Application.Run(new LoginForm());
        }
    }
}