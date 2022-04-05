using System;
using System.Collections.Generic;
using Capa_AccesoDatos;
using System.Data;

namespace Capa_LogicaDeNegocios
{
    public class Cls_Clientes
    {
        public int C_IdCliente { get; set; }
        public string C_StrNombre { get; set; }
        public double C_NumDocumento { get; set; }
        public string C_StrDireccion { get; set; }
        public string C_StrTelefono { get; set; }
        public string C_StrEmail { get; set; }
        public string C_DtmFechaModifica { get; set; }
        public string C_StrUsuarioModifica { get; set; }

        Cls_Acceso_Datos acceso = new Cls_Acceso_Datos();
        DataTable dt = new DataTable();

        public DataTable Consulta_Clientes()
        {
            string Sentencia;
            try
            {
                Sentencia = "SELECT * FROM TBLCLIENTES";
                DataTable dt = new DataTable();
                dt = acceso.EjecutarConsulta(Sentencia);
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public DataTable Consulta_Clientes(int IdCliente)
        {
            string Sentencia;
            try
            {
                Sentencia = $"SELECT * FROM TBLCLIENTES WHERE IdCliente = '{IdCliente}'";
                DataTable dt = new DataTable();
                dt = acceso.EjecutarConsulta(Sentencia);
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public DataTable Filtrar_Cliente(string filtro)
        {
            string Sentencia;
            try
            {
                Sentencia = $"SELECT * FROM TBLCLIENTES WHERE StrNombre LIKE '%{filtro}%'";
                DataTable dt = new DataTable();
                dt = acceso.EjecutarConsulta(Sentencia);
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        //public DataTable Consulta_Rol()
        //{
        //    string Sentencia;
        //    try
        //    {
        //        Sentencia = "SELECT * FROM TBLROLES";
        //        DataTable dt = new DataTable();
        //        dt = acceso.EjecutarConsulta(Sentencia);
        //        return dt;
        //    }
        //    catch (Exception ex)
        //    {
        //        return null;
        //    }
        //}

        public string Eliminar_Cliente()
        {
            string mensaje = string.Empty;
            try
            {
                //estructura tipo lista para los parametros que necesitan el procedimiento almacenado 
                List<Cls_parametros> lst = new List<Cls_parametros>();

                //
                lst.Add(new Cls_parametros("@IdCliente", C_IdCliente));


                mensaje = acceso.EjecutarProcedimiento("Eliminar_Cliente", lst);


            }
            catch (Exception ex)
            {

                mensaje = "FALLO BORRADO EMPLEADO" + ex.Message;
            }


            return mensaje;
        }

        public string Actualizar_Cliente()
        {
            string mensaje = string.Empty;

            try
            {
                List<Cls_parametros> lst = new List<Cls_parametros>();

                lst.Add(new Cls_parametros("@IdCliente", C_IdCliente));
                lst.Add(new Cls_parametros("@StrNombre", C_StrNombre));
                lst.Add(new Cls_parametros("@NumDocumento", C_NumDocumento));
                lst.Add(new Cls_parametros("@StrDireccion", C_StrDireccion));
                lst.Add(new Cls_parametros("@StrTelefono", C_StrTelefono));
                lst.Add(new Cls_parametros("@StrEmail", C_StrEmail));
                lst.Add(new Cls_parametros("@StrUsuarioModifica", C_StrUsuarioModifica));
                lst.Add(new Cls_parametros("@DtmFechaModifica", C_DtmFechaModifica));

                mensaje = acceso.EjecutarProcedimiento("actualizar_Cliente", lst);

            }
            catch (Exception ex)
            {

                mensaje = "FALLO ACTULIZACION DEL CLIENTE" + ex.Message;
            }


            return mensaje;
        }

    }

}
