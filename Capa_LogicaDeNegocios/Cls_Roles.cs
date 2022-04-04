using System;
using System.Collections.Generic;
using Capa_AccesoDatos;
using System.Data;


namespace Capa_LogicaDeNegocios
{
    public class Cls_Roles
    {
        public int C_IdRol { get; set; }
        public string C_StrDescripcion { get; set; }

        Cls_Acceso_Datos acceso = new Cls_Acceso_Datos();

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

        public DataTable Consulta_Rol(string IdRol)
        {
            string Sentencia;
            try
            {
                Sentencia = $"SELECT * FROM TBLROLES WHERE IdRol = '{IdRol}'";
                DataTable dt = new DataTable();
                dt = acceso.EjecutarConsulta(Sentencia);
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public DataTable Filtrar_Rol(string filtro)
        {
            string Sentencia;
            try
            {
                Sentencia = $"SELECT * FROM TBLROLES WHERE StrDescripcion LIKE '%{filtro}%'";
                DataTable dt = new DataTable();
                dt = acceso.EjecutarConsulta(Sentencia);
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

       

        public string Eliminar_Rol()
        {
            string mensaje = string.Empty;
            try
            {
                //estructura tipo lista para los parametros que necesitan el procedimiento almacenado 
                List<Cls_parametros> lst = new List<Cls_parametros>();

                //
                lst.Add(new Cls_parametros("@IdRol", C_IdRol));


                mensaje = acceso.EjecutarProcedimiento("Eliminar_Rol", lst);


            }
            catch (Exception ex)
            {

                mensaje = "FALLO BORRADO ROL" + ex.Message;
            }


            return mensaje;
        }

        public string Actualizar_Rol()
        {
            string mensaje = string.Empty;

            try
            {
                List<Cls_parametros> lst = new List<Cls_parametros>();

                lst.Add(new Cls_parametros("@IdRol", C_IdRol));
                lst.Add(new Cls_parametros("@StrDescripcion", C_StrDescripcion));               

                mensaje = acceso.EjecutarProcedimiento("actualizar_Rol", lst);

            }
            catch (Exception ex)
            {

                mensaje = "FALLO ACTULIZACION DEL ROL" + ex.Message;
            }


            return mensaje;
        }

    }
}
