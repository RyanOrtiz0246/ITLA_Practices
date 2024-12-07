using System;
using System.Windows.Forms;

namespace SistemaDeRegistroDeDonaciones
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new HomeForm());
        }
    }
}