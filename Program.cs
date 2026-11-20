using System;
using System.Windows.Forms;

namespace Examen_Cafeteria_SuNombre
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new frmPedidos());
        }
    }
}
