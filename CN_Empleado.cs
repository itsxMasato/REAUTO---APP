using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Entidad;
using Capa_Datos;
using System.Data.SqlClient;

namespace Capa_Negocio
{
    // Proporciona métodos para gestionar los empleados dentro del sistema.
    // Documentado por: Olman Martinez
    public class CN_Empleado
    {
        public class CN_Empleados 
        {
            // Instancia de la capa de datos para interactuar con la base de datos.
            // Documentado por: Olman Martinez
            CD_EMPLEADO nempleados = new CD_EMPLEADO();

            public int RegistrarSolicitante(CE_Empleado eempleado)
            {
                return nempleados.RegistrarSolicitante(eempleado);
            }

            // Obtiene la lista de solicitantes registrados.
            // Retorna un DataTable con la información de los solicitantes.
            // Documentado por: Olman Martinez
            public DataTable MostrarSolicitante()
            {
                nempleados.MostrarSolicitantes();
                return nempleados.MostrarSolicitantes();
            }

            // Verifica si un solicitante ya está registrado en la base de datos.
            // Retorna true si el solicitante existe, de lo contrario, false.
            // Documentado por: Olman Martinez
            public bool VerificarExistenciaSoli(int idSolicitante, string no_identidad)
            {
                return nempleados.VerificarExistenciaSoli(idSolicitante, no_identidad);
            }

            // Registra un nuevo empleado en la base de datos.
            // Retorna el identificador del empleado registrado.
            // Documentado por: Olman Martinez
            public int RegistrarEmpleado(CE_Empleado eempleado)
            {
                return nempleados.RegistrarEmpleados(eempleado);
            }

            // Obtiene la lista de empleados registrados en la base de datos.
            // Retorna un DataTable con la información de los empleados.
            // Documentado por: Olman Martinez
            public DataTable MostrarEmpleado()
            {
                nempleados.MostrarEmpleados();
                return nempleados.MostrarEmpleados();
            }

            // Filtra los empleados según su estado (activo/inactivo).
            // Retorna un DataTable con los empleados que coinciden con el estado especificado.
            // Documentado por: Olman Martinez
            public DataTable FiltrarEmpleados(string estado)
            {
                return nempleados.FiltrarEmpleados(estado);
            }

        }
    }
}
