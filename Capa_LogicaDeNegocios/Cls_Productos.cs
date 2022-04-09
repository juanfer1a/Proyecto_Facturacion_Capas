using System;
using System.Collections.Generic;
using System.Data;
using Capa_AccesoDatos;


namespace Capa_LogicaDeNegocios
{
    public class Cls_Productos
    {
        public int C_IdProducto { get; set; }
        public string C_StrNombre { get; set; }
        public string C_StrCodigo { get; set; }
        public int C_NumPrecioCompra { get; set; }
        public int C_NumPrecioVenta { get; set; }
        public int C_IdCategoria { get; set; }
        public string C_StrDetalle { get; set; }
        public string C_strFoto { get; set; }
        public int C_NumStock { get; set; }
        public string C_DtmFechaModifica { get; set; }
        public string C_StrUsuarioModifica { get; set; }

        Cls_Acceso_Datos acceso = new Cls_Acceso_Datos();

        public DataTable Consulta_Producto()
        {
            string Sentencia;
            try
            {
                Sentencia = "SELECT * FROM TBLPRODUCTO";
                DataTable dt = new DataTable();
                dt = acceso.EjecutarConsulta(Sentencia);
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public DataTable Consulta_Producto(int IdProducto)
        {
            string Sentencia;
            try
            {
                Sentencia = $"SELECT * FROM TBLPRODUCTO WHERE IdProducto = '{IdProducto}'";
                DataTable dt = new DataTable();
                dt = acceso.EjecutarConsulta(Sentencia);
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public DataTable Filtrar_Producto(string filtro)
        {
            string Sentencia;
            try
            {
                Sentencia = $"SELECT * FROM TBLPRODUCTO WHERE StrNombre LIKE '%{filtro}%'";
                DataTable dt = new DataTable();
                dt = acceso.EjecutarConsulta(Sentencia);
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

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

        public string Eliminar_Producto()
        {
            string mensaje = string.Empty;
            try
            {
                //estructura tipo lista para los parametros que necesitan el procedimiento almacenado 
                List<Cls_parametros> lst = new List<Cls_parametros>();

                //
                lst.Add(new Cls_parametros("@IdProducto", C_IdProducto));


                mensaje = acceso.EjecutarProcedimiento("Eliminar_Producto", lst);


            }
            catch (Exception ex)
            {

                mensaje = "FALLO ELIMINACION PRODUCTO" + ex.Message;
            }


            return mensaje;
        }

        public string Actualizar_Producto()
        {
            string mensaje = string.Empty;

            try
            {
                List<Cls_parametros> lst = new List<Cls_parametros>();

                lst.Add(new Cls_parametros("@IdProducto ", C_IdProducto));
                lst.Add(new Cls_parametros("@StrNombre", C_StrNombre));
                lst.Add(new Cls_parametros("@StrCodigo", C_StrCodigo));
                lst.Add(new Cls_parametros("@NumPrecioCompra", C_NumPrecioCompra));
                lst.Add(new Cls_parametros("@NumPrecioVenta", C_NumPrecioVenta));
                lst.Add(new Cls_parametros("@IdCategoria", C_IdCategoria));
                lst.Add(new Cls_parametros("@StrDetalle", C_StrDetalle));
                lst.Add(new Cls_parametros("@strFoto", C_strFoto));
                lst.Add(new Cls_parametros("@NumStock", C_NumStock));
                lst.Add(new Cls_parametros("@DtmFechaModifica", C_DtmFechaModifica));
                lst.Add(new Cls_parametros("@StrUsuarioModifica", C_StrUsuarioModifica));

                mensaje = acceso.EjecutarProcedimiento("actualizar_Producto", lst);

            }
            catch (Exception ex)
            {

                mensaje = "FALLO ACTULIZACION DEL PRODUCTO" + ex.Message;
            }


            return mensaje;
        }


    }
}
