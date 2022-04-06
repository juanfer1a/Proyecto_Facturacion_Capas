using System;
using System.Collections.Generic;
using System.Data;
using Capa_AccesoDatos;

namespace Capa_LogicaDeNegocios
{
    public class Cls_Categoria
    {

        public int C_IdCategoria { get; set; }
        public string C_StrDescripcion { get; set; }
        public string C_DtmFechaModifica { get; set; }
        public string C_StrUsuarioModifico { get; set; }

        Cls_Acceso_Datos acceso = new Cls_Acceso_Datos();

        public DataTable Consulta_Categoria()
        {
            string Sentencia;
            try
            {
                Sentencia = "SELECT * FROM TBLCATEGORIA_PROD";
                DataTable dt = new DataTable();
                dt = acceso.EjecutarConsulta(Sentencia);
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public DataTable Consulta_Categoria(int IdCategoria)
        {
            string Sentencia;
            try
            {
                Sentencia = $"SELECT * FROM TBLCATEGORIA_PROD WHERE IdCategoria = '{IdCategoria}'";
                DataTable dt = new DataTable();
                dt = acceso.EjecutarConsulta(Sentencia);
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public DataTable Filtrar_Categoria(string filtro)
        {
            string Sentencia;
            try
            {
                Sentencia = $"SELECT * FROM TBLCATEGORIA_PROD WHERE StrDescripcion LIKE '%{filtro}%'";
                DataTable dt = new DataTable();
                dt = acceso.EjecutarConsulta(Sentencia);
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
        }



        public string Eliminar_Categoria()
        {
            string mensaje = string.Empty;
            try
            {
                //estructura tipo lista para los parametros que necesitan el procedimiento almacenado 
                List<Cls_parametros> lst = new List<Cls_parametros>();

                //
                lst.Add(new Cls_parametros("@IdCategoria", C_IdCategoria));


                mensaje = acceso.EjecutarProcedimiento("Eliminar_CategoriaProducto", lst);


            }
            catch (Exception ex)
            {

                mensaje = "FALLO BORRADO CATEGORIA" + ex.Message;
            }


            return mensaje;
        }

        public string Actualizar_Categoria()
        {
            string mensaje = string.Empty;

            try
            {
                List<Cls_parametros> lst = new List<Cls_parametros>();

                lst.Add(new Cls_parametros("@IdCategoria", C_IdCategoria));
                lst.Add(new Cls_parametros("@StrDescripcion", C_StrDescripcion));
                lst.Add(new Cls_parametros("@DtmFechaModifica", C_DtmFechaModifica));
                lst.Add(new Cls_parametros("@StrUsuarioModifico", C_StrUsuarioModifico));

                mensaje = acceso.EjecutarProcedimiento("actualizar_CategoriaProducto", lst);

            }
            catch (Exception ex)
            {

                mensaje = "FALLO ACTULIZACION DE LA CATEGORIA" + ex.Message;
            }


            return mensaje;
        }

    }

}
