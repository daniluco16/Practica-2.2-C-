using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_2_2_Evaluacion
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]

        /*********************************
         Autor: Daniel de la Rosa Romero
         Fecha creación: 20/02/2018
         Última modificación: xx/xx/xxxx
         Versión: x.xx
        ***********************************/

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
