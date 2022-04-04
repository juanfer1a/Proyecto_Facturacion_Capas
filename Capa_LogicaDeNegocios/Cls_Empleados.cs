using System;
using System.Collections.Generic;
using Capa_AccesoDatos;
using System.Data;

namespace Capa_LogicaDeNegocios
{
    public class Cls_Empleados
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

        public string Eliminar_Empleado()
        {
            string mensaje = string.Empty;
            try
            {
                //estructura tipo lista para los parametros que necesitan el procedimiento almacenado 
                List<Cls_parametros> lst = new List<Cls_parametros>();

                //
                lst.Add(new Cls_parametros("@IdEmpleado",C_IdEmpleado));


                mensaje = acceso.EjecutarProcedimiento("Eliminar_Empleado", lst);


            }
            catch (Exception ex)
            {

                mensaje= "FALLO BORRADO EMPLEADO" + ex.Message;
            }


            return mensaje;
        }

        public string Actulizar_Empleado()
        {
            string mensaje = string.Empty;

            try
            {
                List<Cls_parametros> lst = new List<Cls_parametros>();

                lst.Add(new Cls_parametros("@IdEmpleado", C_IdEmpleado));
                lst.Add(new Cls_parametros("@strNombre", C_strNombre));
                lst.Add(new Cls_parametros("@NumDocumento", C_NumDocumento));
                lst.Add(new Cls_parametros("@StrDireccion", C_StrDireccion));
                lst.Add(new Cls_parametros("@StrTelefono", C_StrTelefono));
                lst.Add(new Cls_parametros("@StrEmail", C_StrEmail));
                lst.Add(new Cls_parametros("@IdRolEmpleado", C_IdRolEmpleado));
                lst.Add(new Cls_parametros("@DtmIngreso", C_DtmIngreso));
                lst.Add(new Cls_parametros("@DtmRetiro", C_DtmRetiro));
                lst.Add(new Cls_parametros("@strDatosAdicionales", C_strDatosAdicionales));
                lst.Add(new Cls_parametros("@DtmFechaModifica", C_DtmFechaModifica));
                lst.Add(new Cls_parametros("@StrUsuarioModifico", C_StrUsuarioModifico));

                mensaje = acceso.EjecutarProcedimiento("actualizar_Empleado", lst);

            }
            catch (Exception ex)
            {

                mensaje = "FALLO ACTULIZACION DEL EMPLEADO" + ex.Message;
            }


            return mensaje;
        }

    }
}
