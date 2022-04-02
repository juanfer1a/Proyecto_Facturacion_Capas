using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_AccesoDatos;
using System.Data;

namespace Capa_LogicaDeNegocios
{
    class Cls_Empleados
    {
        public int C_IdEmpleado { get; set; }
        public string C_strNombre { get; set; }
        public double C_NumDocumento { get; set; }
        public string C_StrDireccion { get; set; }
        public string C_StrTelefono { get; set; }
        public string C_StrEmail { get; set; }
        public int C_IdRolEmpleado { get; set; }
        public string C_DtmIngreso { get; set; }
        public string C_DtmRetiro { get; set; }
        public string C_strDatosAdicionales { get; set; }
        public string C_DtmFechaModifica { get; set; }
        public string C_StrUsuarioModifico { get; set; }

        Cls_Acceso_Datos acceso = new Cls_Acceso_Datos();

        public DataTable Consulta_Empleado()
        {
            string Sentencia;
            try
            {
                Sentencia = "SELECT * FROM TBLEMPLEADO";
                DataTable dt = new DataTable();
                dt = acceso.EjecutarConsulta(Sentencia);
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public DataTable Consulta_Empleado(string IdEmpleado)
        {
            string Sentencia;
            try
            {
                Sentencia = $"SELECT * FROM TBLEMPLEADO WHERE IdEmpleado = '{IdEmpleado}'";
                DataTable dt = new DataTable();
                dt = acceso.EjecutarConsulta(Sentencia);
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public DataTable Filtrar_Empleado(string filtro)
        {
            string Sentencia;
            try
            {
                Sentencia = $"SELECT * FROM TBLEMPLEADO WHERE strNombre LIKE '%{filtro}%'";
                DataTable dt = new DataTable();
                dt = acceso.EjecutarConsulta(Sentencia);
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public DataTable Consulta_Rol()
        {
            string Sentencia;
            try
            {
                Sentencia = "SELECT * FROM TBLROLES";
                DataTable dt = new DataTable();
                dt = acceso.EjecutarConsulta(Sentencia);
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
