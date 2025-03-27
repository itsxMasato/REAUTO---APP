using Capa_Entidad;
using Capa_Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Capa_Negocio.CN_Empleado;

namespace REAUTO_APP
{
    public partial class txtIDSolicitante : Form
    {
        // Instancias de las clases necesarias para manejar empleados y usuarios.
        // Documentado por: Astrid Gonzales
        CN_Empleados nempleados = new CN_Empleados();
        CE_Empleado e_Empleado = new CE_Empleado();
        CE_Usuarios E_Usuarios = new CE_Usuarios();
        CN_Usuarios n_Usuarios = new CN_Usuarios();

        // Constructor del formulario, inicializa los componentes y asocia eventos de cambio de texto.
        // Documentado por: Astrid Gonzales
        public txtIDSolicitante()
        {
            InitializeComponent();
            txtIdentidad.TextChanged += txtIdentidad_TextChanged;
            txtRTN.TextChanged += txtRTN_TextChanged;
        }

        // Evento que limpia el campo de ID del puesto cuando recibe foco.
        // Documentado por: Astrid Gonzales
        private void txtIDPuesto_Enter(object sender, EventArgs e)
        {
            if (txtIDSolicitantes.Text == "ID Solicitante")
            {
                txtIDSolicitantes.Text = "";
                txtIDSolicitantes.ForeColor = Color.Black;
            }
        }

        // Evento que restaura el placeholder del ID del Puesto cuando pierde foco.
        // Documentado por: Astrid Gonzales
        private void txtIDPuesto_Leave(object sender, EventArgs e)
        {
            if (txtIDSolicitantes.Text == "")
            {
                txtIDSolicitantes.Text = "ID Solicitante";
                txtIDSolicitantes.ForeColor = Color.Silver;
            }
        }

        // Evento que Limpia el placeholder del Nombre cuando pierde foco.
        // Documentado por: Astrid Gonzales
        private void txtNombre_Enter(object sender, EventArgs e)
        {
            if(txtNombre.Text == "Nombre")
            {
                txtNombre.Text = "";
                txtNombre.ForeColor = Color.Black;
            }
        }

        // Evento que restaura el placeholder del Nombre cuando pierde foco.
        // Documentado por: Astrid Gonzales
        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                txtNombre.Text = "Nombre";
                txtNombre.ForeColor = Color.Silver;
            }
        }

        // Evento que Limpia el placeholder de la formacion cuando pierde foco.
        // Documentado por: Astrid Gonzales
        private void txtFormacion_Enter(object sender, EventArgs e)
        {
            if (txtFormacion.Text == "Formación Académica")
            {
                txtFormacion.Text = "";
                txtFormacion.ForeColor = Color.Black;
            }
        }

        // Evento que restaura el placeholder de la formacion cuando pierde foco.
        // Documentado por: Astrid Gonzales
        private void txtFormacion_Leave(object sender, EventArgs e)
        {
            if (txtFormacion.Text == "")
            {
                txtFormacion.Text = "Formación Académica";
                txtFormacion.ForeColor = Color.Silver;
            }
        }

        // Evento que Limpia el placeholder de la identidad cuando pierde foco.
        // Documentado por: Astrid Gonzales
        private void txtIdentidad_Enter(object sender, EventArgs e)
        {
            if(txtIdentidad.Text == "Identidad")
            {
                txtIdentidad.Text = "";
                txtIdentidad.ForeColor = Color.Black;
            }
        }

        // Evento que restaura el placeholder del Identidad cuando pierde foco.
        // Documentado por: Astrid Gonzales
        private void txtIdentidad_Leave(object sender, EventArgs e)
        {
            if (txtIdentidad.Text == "")
            {
                txtIdentidad.Text = "Identidad";
                txtIdentidad.ForeColor = Color.Silver;
            }
        }

        // Evento que Limpia el placeholder del Apellido cuando pierde foco.
        // Documentado por: Astrid Gonzales
        private void txtApellido_Enter(object sender, EventArgs e)
        {
            if (txtApellido.Text == "Apellido")
            {
                txtApellido.Text = "";
                txtApellido.ForeColor = Color.Black;
            }
        }

        // Evento que restaura el placeholder del Apellido cuando pierde foco.
        // Documentado por: Astrid Gonzales
        private void txtApellido_Leave(object sender, EventArgs e)
        {
            if (txtApellido.Text == "")
            {
                txtApellido.Text = "Apellido";
                txtApellido.ForeColor = Color.Silver;
            }
        }

        // Evento que Limpia el placeholder del Experiencia cuando pierde foco.
        // Documentado por: Astrid Gonzales
        private void txtExperiencia_Enter(object sender, EventArgs e)
        {
            if(txtExperiencia.Text == "Experiencia Laboral")
            {
                txtExperiencia.Text = "";
                txtExperiencia.ForeColor = Color.Black;
            }
        }

        // Evento que restaura el placeholder de la experiencia cuando pierde foco.
        // Documentado por: Astrid Gonzales
        private void txtExperiencia_Leave(object sender, EventArgs e)
        {
            if (txtExperiencia.Text == "")
            {
                txtExperiencia.Text = "Experiencia Laboral";
                txtExperiencia.ForeColor = Color.Silver;
            }
        }

        // Evento que Limpia el placeholder del RTN cuando pierde foco.
        // Documentado por: Astrid Gonzales
        private void txtRTN_Enter(object sender, EventArgs e)
        {
            if(txtRTN.Text == "RTN")
            {
                txtRTN.Text = "";
                txtRTN.ForeColor = Color.Black;
            }
        }

        // Evento que restaura el placeholder del RTN cuando pierde foco.
        // Documentado por: Astrid Gonzales
        private void txtRTN_Leave(object sender, EventArgs e)
        {
            if (txtRTN.Text == "")
            {
                txtRTN.Text = "RTN";
                txtRTN.ForeColor = Color.Silver;
            }
        }

        // Evento que Limpia el placeholder de la fecha cuando pierde foco.
        // Documentado por: Astrid Gonzales
        private void txtFecha_Enter(object sender, EventArgs e)
        {
            if (txtFecha.Text == "Fecha de Nacimiento")
            {
                txtFecha.Text = "";
                txtFecha.ForeColor = Color.Black;
            }
        }

        // Evento que restaura el placeholder de la fecha cuando pierde foco.
        // Documentado por: Astrid Gonzales
        private void txtFecha_Leave(object sender, EventArgs e)
        {
            if (txtFecha.Text == "")
            {
                txtFecha.Text = "Fecha de Nacimiento";
                txtFecha.ForeColor = Color.Silver;
            }
        }

        // Evento que Limpia el placeholder del Idioma cuando pierde foco.
        // Documentado por: Astrid Gonzales
        private void txtidiomas_Enter(object sender, EventArgs e)
        {
            if (txtidiomas.Text == "Idiomas")
            {
                txtidiomas.Text = "";
                txtidiomas.ForeColor = Color.Black;
            }
        }

        // Evento que restaura el placeholder del Idioma cuando pierde foco.
        // Documentado por: Astrid Gonzales
        private void txtidiomas_Leave(object sender, EventArgs e)
        {
            if (txtidiomas.Text == "")
            {
                txtidiomas.Text = "Idiomas";
                txtidiomas.ForeColor = Color.Silver;
            }
        }

        // Evento que Limpia el placeholder de lso cursos cuando pierde foco.
        // Documentado por: Astrid Gonzales
        private void txtCursos_Enter(object sender, EventArgs e)
        {
            if (txtCursos.Text == "Cursos")
            {
                txtCursos.Text = "";
                txtCursos.ForeColor = Color.Black;
            }
        }

        // Evento que restaura el placeholder de los Cursos cuando pierde foco.
        // Documentado por: Astrid Gonzales
        private void txtCursos_Leave(object sender, EventArgs e)
        {
            if (txtCursos.Text == "")
            {
                txtCursos.Text = "Cursos";
                txtCursos.ForeColor = Color.Silver;
            }
        }

        // Evento que carga los solicitantes desde la base de datos y los muestra en el DataGridView.
        // Esto se hace para actualizar la lista después de realizar cambios en los datos.
        // Documentado por: Astrid Gonzales
        private void CargarSolicitante()
        {
            dtgvRegistrarSolicitante.SuspendLayout();
            dtgvRegistrarSolicitante.DataSource = nempleados.MostrarSolicitante();
            dtgvRegistrarSolicitante.ResumeLayout();


        }

        // Evento que se ejecuta al cargar el formulario para mostrar la lista de solicitantes.
        // Documentado por: Astrid Gonzales
        private void txtIDSolicitante_Load(object sender, EventArgs e)
        {
            CargarSolicitante();
        }

        // Evento que se ejecuta cuando se presiona el botón para guardar un nuevo solicitante.
        // Verifica que todos los datos estén completos, que la identidad y el RTN sean válidos,
        // que no exista un solicitante con los mismos datos y, finalmente, almacena el registro.
        // Documentado por: Astrid Gonzales
        private void btnGuardarRegistro_Click(object sender, EventArgs e)
        {
            if (txtApellido.Text == "Apellido" || txtCursos.Text == "Cursos" || txtExperiencia.Text == "Experiencia Laboral" || txtFecha.Text == "Fecha" || txtFormacion.Text == "Formacion Academica" || txtIdentidad.Text == "Identidad" || txtidiomas.Text == "Idiomas" || txtNombre.Text == "Nombre" || txtRTN.Text == "RTN" || txtIDSolicitantes.Text == "ID SOLICITANTE")
            {
                MessageBox.Show("Rellene todos los datos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                if (txtIdentidad.Text.Length != 13)
                {
                    MessageBox.Show("El número de identidad debe tener exactamente 13 caracteres.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // No guarda los datos si la longitud es incorrecta
                }

                if (txtRTN.Text.Length != 14)
                {
                    MessageBox.Show("El RTN debe tener exactamente 14 caracteres.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // No guarda los datos si la longitud es incorrecta
                }

                // Verificar si ya existe un solicitante con el mismo ID o identidad
                bool existe = nempleados.VerificarExistenciaSoli(int.Parse(txtIDSolicitantes.Text), txtIdentidad.Text);

                if (existe)
                {
                    MessageBox.Show("Ya existe un solicitante con ese ID o número de identidad.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // No guarda los datos si existe
                }

                E_Usuarios.USUARIO = VariableGlobal.variableusuario;
                E_Usuarios.ACCION = "Creacion de registro en Datos_Solicitante";
                n_Usuarios.GenerarAuditoria(E_Usuarios);

                // Si no existe, proceder a guardar el solicitante en la base de datos
                e_Empleado.ID_DATOS_SOLI = int.Parse(txtIDSolicitantes.Text);
                e_Empleado.NO_IDENTIDAD = txtIdentidad.Text;
                e_Empleado.RTN = txtRTN.Text;
                e_Empleado.NOMBRE = txtNombre.Text;
                e_Empleado.APELLIDO = txtApellido.Text;
                e_Empleado.FECHA_DE_NACIMIENTO = txtFecha.Text;
                e_Empleado.FORMACION_ACADEMICA = txtFormacion.Text;
                e_Empleado.EXPERIENCIA_LABORAL = txtExperiencia.Text;
                e_Empleado.IDIOMAS = txtidiomas.Text;
                e_Empleado.CURSOS = txtCursos.Text;
                e_Empleado.ESTADO = "Pendiente";

                if (nempleados.RegistrarSolicitante(e_Empleado) > 0)
                {
                    MessageBox.Show("Dato Almacenado");
                    CargarSolicitante();
                    limpiar();
                }
                else
                {
                    MessageBox.Show("Dato NO Almacenado");
                }
            }
        }


        // Método que limpia los campos de entrada después de registrar un solicitante.
        // Documentado por: Astrid Gonzales
        private void limpiar()
        {
            txtApellido.Text = "";
            txtCursos.Text = "";
            txtExperiencia.Text = "";
            txtFecha.Text = "";
            txtFormacion.Text = "";
            txtIdentidad.Text = "";
            txtidiomas.Text = "";
            txtNombre.Text = "";
            txtRTN.Text = "";
            txtIDSolicitantes.Text = "";
        }

        private void dtgvRegistrarSolicitante_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        // Método para obtener los datos del solicitante seleccionado en el DataGridView.
        // Documentado por: Astrid Gonzales
        public string[] ObtenerSolicitante()
        {
            string[] obtener = { dtgvRegistrarSolicitante.CurrentRow.Cells[1].Value.ToString(),
                dtgvRegistrarSolicitante.CurrentRow.Cells[3].Value.ToString(),
                dtgvRegistrarSolicitante.CurrentRow.Cells[4].Value.ToString(),
                dtgvRegistrarSolicitante.CurrentRow.Cells[0].Value.ToString() };
            return obtener;
        }

        private void dtgvRegistrarSolicitante_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        // Evento de doble clic en una celda del DataGridView.
        // Documentado por: Astrid Gonzales
        private void dtgvRegistrarSolicitante_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ObtenerSolicitante();
            this.Close();
        }

        // Evento que se dispara cuando el texto en el campo de identidad cambia.
        // Si el texto no es el valor por defecto (Indicación), procedemos con las modificaciones.
        // Filtramos solo los números del texto ingresado, eliminando cualquier otro carácter.
        // Limita la longitud del texto a 13 caracteres, que es el tamaño válido para una identidad.
        // Documentado por: Astrid Gonzales
        private void txtIdentidad_TextChanged(object sender, EventArgs e)
        {
            if (txtIdentidad.Text != "Identidad") // Evita borrar el texto de instrucción
            {
                // Filtrar solo números
                txtIdentidad.Text = new string(txtIdentidad.Text.Where(char.IsDigit).ToArray());

                // Limitar a 13 caracteres
                if (txtIdentidad.Text.Length > 13)
                {
                    txtIdentidad.Text = txtIdentidad.Text.Substring(0, 13);
                }

                txtIdentidad.SelectionStart = txtIdentidad.Text.Length; // Mantener cursor al final
            }
        }

        // Evento que se dispara cuando el texto en el campo de RTN cambia.
        // Filtramos solo los números del texto ingresado, eliminando cualquier otro carácter.
        // Limita la longitud del texto a 14 caracteres, que es el tamaño válido para un RTN.
        // Ajusta la posición del cursor al final del texto para mejorar la experiencia del usuario.
        // Documentado por: Astrid Gonzales
        private void txtRTN_TextChanged(object sender, EventArgs e)
        {
            if (txtRTN.Text != "RTN") // Evita borrar el texto de instrucción
            {
                // Filtrar solo números
                txtRTN.Text = new string(txtRTN.Text.Where(char.IsDigit).ToArray());

                // Limitar a 14 caracteres
                if (txtRTN.Text.Length > 14)
                {
                    txtRTN.Text = txtRTN.Text.Substring(0, 14);
                }

                txtRTN.SelectionStart = txtRTN.Text.Length; // Mantener cursor al final
            }
        }

        // Evento para abrir el formulario de registro de empleados.
        // Documentado por: Astrid Gonzales
        private void x_Click(object sender, EventArgs e)
        {
            Registrar_Empleado registrar_Empleado = new Registrar_Empleado();
            registrar_Empleado.Show();
            this.Hide();
        }

        private void txtFecha_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
