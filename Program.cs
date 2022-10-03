using Clases;
using System.Security.Cryptography.X509Certificates;

namespace alonso_nicolas_primer_parcial_labo
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Login());
        }
    }
}