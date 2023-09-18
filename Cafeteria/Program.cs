using System.Security.Cryptography.X509Certificates;

namespace Cafeteria
{
    internal static class Program
    {
        public static List<Pedido> ListaPedido = new List<Pedido>();

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new FrmInicio());

        }
    }
}