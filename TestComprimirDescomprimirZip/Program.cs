using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TestComprimirDescomprimirZip
{

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Sistema._isMaster = false;
            Sistema._IdSucursal = "";

            var r01 = Helpers.Utilitis.CargarXml();
            if (r01.Result != Enumerados.EnumResult.isError )
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                var _gestion = new GestionFTP();
                _gestion.Inicia();

                //Application.EnableVisualStyles();
                //Application.SetCompatibleTextRenderingDefault(false);
                //Application.Run(new Form1());
            }
            else 
            {
                Helpers.Msg.Error(r01.Mensaje);
                Application.Exit();
            }
        }
    }

}