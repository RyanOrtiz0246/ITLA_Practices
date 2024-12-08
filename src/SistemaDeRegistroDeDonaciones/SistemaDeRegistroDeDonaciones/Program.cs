using System;
using System.Windows.Forms;
using SistemaDeRegistroDeDonaciones;

namespace SistemaDonaciones
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new HomeForm());
        }
    }
}