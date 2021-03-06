using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_AccesoDatos;
using System.Data;

namespace Capa_LogicaDeNegocios
{
    public class Cls_Seguridad
    {
        public int C_IdSeguridad { get; set; }
        public int C_IdEmpleado { get; set; }
        public string C_StrUsuario { get; set; }
        public string C_StrClave { get; set; }
        public string C_StrUsuarioModifico { get; set; }

        Cls_Acceso_Datos acceso = new Cls_Acceso_Datos();

        public DataTable Consulta_Empleados()
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

        public DataTable Consulta_SeguridadEmpleado(int IdEmpleado)
        {
            string Sentencia;
            try
            {
                Sentencia = $"SELECT * FROM TBLSEGURIDAD WHERE IdEmpleado = {IdEmpleado}";
                DataTable dt = new DataTable();
                dt = acceso.EjecutarConsulta(Sentencia);
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public string Eliminar_SeguridadEmpleado()
        {
            string mensaje = string.Empty;
            try
            {
                //estructura tipo lista para los parametros que necesitan el procedimiento almacenado 
                List<Cls_parametros> lst = new List<Cls_parametros>();

                //
                lst.Add(new Cls_parametros("@IdEmpleado", C_IdEmpleado));


                mensaje = acceso.EjecutarProcedimiento("Eliminar_Seguridad", lst);


            }
            catch (Exception ex)
            {
                mensaje = "FALLO BORRADO EMPLEADO" + ex.Message;
            }

            return mensaje;
        }

        public string Actulizar_SeguridadEmpleado()
        {
            string mensaje = string.Empty;

            try
            {
                List<Cls_parametros> lst = new List<Cls_parametros>();

                lst.Add(new Cls_parametros("@IdEmpleado", C_IdEmpleado));
                lst.Add(new Cls_parametros("@StrUsuario", C_StrUsuario));
                lst.Add(new Cls_parametros("@StrClave", C_StrClave));
                lst.Add(new Cls_parametros("@DtmFechaModifica", DateTime.Now));
                lst.Add(new Cls_parametros("@StrUsuarioModifico", C_StrUsuarioModifico));

                mensaje = acceso.EjecutarProcedimiento("actualizar_Seguridad", lst);

            }
            catch (Exception ex)
            {

                mensaje = "FALLO ACTULIZACION DEL EMPLEADO" + ex.Message;
            }


            return mensaje;
        }

    }
}
