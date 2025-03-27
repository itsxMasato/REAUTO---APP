using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Entidad;
using Capa_Negocio;
using static iText.StyledXmlParser.Jsoup.Select.Evaluator;

namespace REAUTO_APP
{
    public partial class Editar_Fecha_V : Form
    {
        // Instancias de las clases que gestionan las solicitudes de vacaciones
        //Documentado por: Astrid Gonzales
        CN_SolicitudVacaciones nvaca = new CN_SolicitudVacaciones();
        CE_Solicitud_Vacaciones evaca =new CE_Solicitud_Vacaciones();


        // Constructor que recibe el ID de la solicitud
        // Inicializa los componentes y carga los datos de la solicitud para editar las fechas.
        //Documentado por: Astrid Gonzales
        public Editar_Fecha_V(int id)
        {
            InitializeComponent();
            idSolicitud = id;
            CargarDatosSolicitud();
        }

        // Variable que almacena el ID de la solicitud a editar
        private int idSolicitud;

        // Evento que se ejecuta al cargar el formulario de edición de fechas
        // Actualmente no realiza ninguna acción, pero se puede utilizar para inicializar otros elementos si es necesario.
        //Documentado por: Astrid Gonzales
        private void Editar_Fecha_V_Load(object sender, EventArgs e)
        {
            
            
        }

        // Método que carga las fechas de la solicitud en los controles del formulario (DateTimePicker)
        // Verifica que las fechas de inicio y final no sean valores predeterminados (DateTime.MinValue).
        //Documentado por: Astrid Gonzales
        private void CargarDatosSolicitud()
        {
            var fechas = nvaca.ObtenerFechasSolicitud(idSolicitud);

            if (fechas.fechaInicio != DateTime.MinValue && fechas.fechaFinal != DateTime.MinValue)
            {
                dateTimePicker1.Value = fechas.fechaInicio;
                dateTimePicker2.Value = fechas.fechaFinal;
            }
            else
            {
                MessageBox.Show("No se encontraron datos para esta solicitud.");
            }
        }

        // Evento que se ejecuta cuando se hace clic en el botón de editar solicitud
        // Valida las fechas ingresadas y luego actualiza la solicitud en la base de datos.
        //Documentado por: Astrid Gonzales
        private void btnEditar_Click(object sender, EventArgs e)
        {
            // Validar que las fechas no estén vacías
            if (textBox1.Text == ""|| dateTimePicker1.Value == DateTime.MinValue || dateTimePicker2.Value == DateTime.MinValue)
            {
                MessageBox.Show("Debe seleccionar ambas fechas.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar que la fecha de inicio no sea mayor que la fecha final
            if (dateTimePicker1.Value > dateTimePicker2.Value)
            {
                MessageBox.Show("La fecha de inicio no puede ser mayor que la fecha final.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obtener las nuevas fechas
            DateTime nuevaFechaInicio = dateTimePicker1.Value;
            DateTime nuevaFechaFinal = dateTimePicker2.Value;

            // Llamar al método para actualizar la solicitud
            int filasAfectadas = nvaca.EditarSolicitud(idSolicitud, nuevaFechaInicio, nuevaFechaFinal);

            if (filasAfectadas > 0)
            {
                MessageBox.Show("Solicitud actualizada correctamente.");
                this.Close(); // Cierra el formulario después de editar
            }
            else
            {
                MessageBox.Show("Error al actualizar la solicitud.");
            }
        }

        // Evento que se ejecuta cuando se hace clic en el botón de cerrar (X) en la esquina del formulario
        // Redirige al usuario al formulario de solicitudes de vacaciones y cierra el formulario actual.
        //Documentado por: Astrid Gonzales
        private void x_Click(object sender, EventArgs e)
        {
            Solicitudes_Vacaciones solicitudes_Vacaciones = new Solicitudes_Vacaciones();
            solicitudes_Vacaciones.Show();
            this.Close();
        }
    }
}
