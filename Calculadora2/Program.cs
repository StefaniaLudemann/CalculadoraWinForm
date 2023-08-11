using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora2
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main() //metodo estatico principal (aqui arranca todo el sistema)
        {
            Application.EnableVisualStyles(); //se activan los estilos visuales
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1()); // el new form es la instancia de una clase. crea un formulario (objetoanonimo porq no tiene nombre)
        }
    }
}
