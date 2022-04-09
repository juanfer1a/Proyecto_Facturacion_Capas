using System;
using System.Collections.Generic;
using System.Data;
using Capa_AccesoDatos;

namespace Capa_LogicaDeNegocios
{
    class ClsFactura
    {
        public int C_IdFactura { get; set; }
        public int C_DtmFecha { get; set; }
        public int C_IdCliente { get; set; }
        public int C_IdEmpleado { get; set; }
        public int C_NumDescuento { get; set; }
        public int C_NumImpuesto { get; set; }
        public int C_NumValorTotal { get; set; }
        public int C_IdEstado { get; set; }
        public int C_DtmFechaModifica { get; set; }
        public int C_StrUsuarioModifica { get; set; }

        Cls_Acceso_Datos acceso = new Cls_Acceso_Datos();

        public DataTable Consulta_factura()
        {
            string Sentencia;
            try
            {
                Sentencia = "SELECT * FROM TBLFACTURA";
                DataTable dt = new DataTable();
                dt = acceso.EjecutarConsulta(Sentencia);
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public DataTable Consulta_Factura(int IdFactura)
        {
            string Sentencia;
            try
            {
                Sentencia = $"SELECT * FROM TBLFACTURA WHERE IdFactura = '{IdFactura}'";
                DataTable dt = new DataTable();
                dt = acceso.EjecutarConsulta(Sentencia);
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public DataTable Filtrar_Factura(string filtro)
        {
            string Sentencia;
            try
            {
                Sentencia = $"SELECT * FROM TBLFACTURA WHERE strNombre LIKE '%{filtro}%'";
                DataTable dt = new DataTable();
                dt = acceso.EjecutarConsulta(Sentencia);
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

       
        public string Eliminar_Factura()
        {
            string mensaje = string.Empty;
            try
            {
                //estructura tipo lista para los parametros que necesitan el procedimiento almacenado 
                List<Cls_parametros> lst = new List<Cls_parametros>();
                
                lst.Add(new Cls_parametros("@IdFactura", C_IdFactura));

                mensaje = acceso.EjecutarProcedimiento("Eliminar_Producto", lst);

            }
            catch (Exception ex)
            {
                mensaje = "FALLO ELIMINACION DE LA FACTURA" + ex.Message;
            }

            return mensaje;
        }

        public string Actulizar_Factura()
        {
            string mensaje = string.Empty;

            try
            {
                List<Cls_parametros> lst = new List<Cls_parametros>();
                lst.Add(new Cls_parametros("@IdFactura", C_IdFactura));
                lst.Add(new Cls_parametros("@DtmFecha", C_DtmFecha));
                lst.Add(new Cls_parametros("@IdCliente ", C_IdCliente));
                lst.Add(new Cls_parametros("@dEmpleado ", C_IdEmpleado));
                lst.Add(new Cls_parametros("@NumDescuento", C_NumDescuento));
                lst.Add(new Cls_parametros("@NumImpuesto", C_NumImpuesto));
                lst.Add(new Cls_parametros("@NumValorTotal", C_NumValorTotal));
                lst.Add(new Cls_parametros("@IdEstado", C_IdEstado));
                lst.Add(new Cls_parametros("@DtmFechaModifica", C_DtmFechaModifica));
                lst.Add(new Cls_parametros("@StrUsuarioModifica", C_StrUsuarioModifica));

                mensaje = acceso.EjecutarProcedimiento("actualizar_Factura", lst);

            }
            catch (Exception ex)
            {

                mensaje = "FALLO ACTULIZACION DE LA FACTURA" + ex.Message;
            }


            return mensaje;
        }
    }
}
