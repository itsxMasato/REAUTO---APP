using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Negocio
{
    // Clase principal que inicia la ejecución del sistema.
    // Documentado por: Olman Martinez
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            // Habilita estilos visuales para mejorar la apariencia de los formularios.
            Application.EnableVisualStyles();

            // Configura la renderización de texto para garantizar compatibilidad con versiones antiguas de Windows.
            Application.SetCompatibleTextRenderingDefault(false);

            // Inicia la aplicación mostrando el formulario principal.
            //Application.Run(new Form1());
        }
    }
}
