using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Capa_AccesoDatos;



namespace Capa_LogicaDeNegocios
{
    public class Validar_usuario
    {
        public string C_strNombre { get; set; }
        public string C_strClave { get; set; }
        public Int32 C_idEmpleado { get; set; }


        public void ValidarUsuario()
        {
            try
            {
                string Sentencia = $"SELECT idEmpleado FROM TBLSEGURIDAD WHERE StrUsuario = '{C_strNombre}' AND StrClave = '{C_strClave}'";
                DataTable dt = new DataTable();
                Cls_Acceso_Datos Acceso = new Cls_Acceso_Datos();
                dt = Acceso.EjecutarConsulta(Sentencia);

                foreach (DataRow row in dt.Rows)
                {
                    C_idEmpleado = int.Parse(row[0].ToString());
                }
            }
            catch (Exception ex)
            {

                throw new Exception("Error en la consulta" + ex);
            }
        }
    }
}
