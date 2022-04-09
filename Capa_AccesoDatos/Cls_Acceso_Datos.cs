using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;

namespace Capa_AccesoDatos
{
    public class Cls_parametros
    {
        public string Nombre { get; set; }
        public object Valor { get; set; }
        public SqlDbType TipoDato { get; set; }
        public ParameterDirection DireccionParametro { get; set; }
        public Int32 Tamaño { get; set; }
        public Cls_parametros(string nombre, object valor)
        {
            Nombre = nombre;
            this.Valor = valor;

            DireccionParametro = ParameterDirection.Input;
        }

        public Cls_parametros(string nombre, SqlDbType tipoDato, Int32 objTamaño)
        {
            Nombre = nombre;
            TipoDato = tipoDato;
            Tamaño = objTamaño;
            DireccionParametro = ParameterDirection.Output;
        }


    }
    public class Cls_Acceso_Datos
    {
        SqlConnection conexion; // se define la variable para la conexión de tipo SqlConnection
        SqlCommand cmd; // se defie la variable para realizar comandos en la BD
        SqlDataReader LectorDatos = null;
        SqlDataAdapter da;
        DataTable dt;

        public void AbrirBd() // método para abrir la base de datos
        {
            string resultado = string.Empty;
            try // permite captura de un error en caso que se presente
            {

                // creamos un objeto de tipo conexión a la base de datos y se pasa como parámetro la cadena de conexión
                conexion = new SqlConnection("Data Source=DESKTOP-L4UOS2U\\SQLEXPRESSJUAN;Initial Catalog =FACTURAS; Integrated Security = True");
                conexion.Open(); // invocamos método para abrir la base de datos

            }
            catch (Exception ex)// si hay error presenta el siguiente mensaje
            {
                resultado = "falló conexión " + ex;
            }
        }
        public void CerrarBd() // método para cerrar la base de datos
        {
            string resultado = string.Empty;
            try // permite captura de un error en caso que se presente
            {
                conexion.Close(); // invocamos método para cerrar la base de datos
            }
            catch (Exception ex)// si hay error presenta el siguiente mensaje
            {
                resultado = "falló cerrar conexión " + ex;
            }
        }

        //permite ejecutar procedimientos almacenados y resive los procedimientos por medio de una list
        public string EjecutarProcedimiento(string Procedimiento, List<Cls_parametros> lst)
        {
            string Salida = string.Empty;
            try
            {
                int retornado;
                AbrirBd();
                //objeto command con el procedimiento almacenado y la conexion
                SqlCommand Comando = new SqlCommand(Procedimiento, conexion);
                //tipo de commando
                Comando.CommandType = CommandType.StoredProcedure;

                //asignamos al comando los valores de los parametros recibidos en la varible list
                if (lst != null)
                {
                    for (int i = 0; i < lst.Count; i++)//recorrer la lista
                    {
                        if (lst[i].DireccionParametro == ParameterDirection.Input)
                        {
                            Comando.Parameters.AddWithValue(lst[i].Nombre, lst[i].Valor);
                        }
                        if (lst[i].DireccionParametro == ParameterDirection.Output)
                        {
                            Comando.Parameters.Add(lst[i].Nombre, lst[i].TipoDato, lst[i].Tamaño).Direction = ParameterDirection.Output;
                        }
                    }
                }
                retornado = Comando.ExecuteNonQuery();//ejecutar el procedimiento
                CerrarBd();
                if (retornado > 0)
                {
                    Salida = "Datos actualizados correctamente";
                }
                else
                {
                    Salida = "No se actualizaron los datos";
                }
            }

            catch (Exception ex)
            {
                Salida = "ERROR: fallo la operacion " + ex;
            }
            return Salida;
        }

        public string EjecutarComando(string sentencia)// recibe una sentencia de para realizar acciones de actualizar, retirar y nuevo, solo retorna un valor numérico que indica cuantas filas fueron afectadas
        {
            string salida = "LOS DATOS SE ACTUALIZARON SATISFACTORIAMENTE!";
            try
            {
                int retornado;
                AbrirBd();
                cmd = new SqlCommand(sentencia, conexion);
                retornado = cmd.ExecuteNonQuery(); // UTILIZADO PARA UPDATE, INSERT y DELETE
                CerrarBd();
                if (retornado > 0)
                {
                    salida = "Los datos fueron Actualizados";
                }
                else
                {
                    salida = "Los datos no fueron Actualizados";
                }
            }
            catch (Exception ex)
            {
                salida = "falló inserción: " + ex;
            }
            return salida;

        }

        public DataTable EjecutarConsulta(string cmd)// Método que permite consultar con una sentencia(select) o invocar un procedimiento almacenado
        {
            try
            {
                AbrirBd();
                da = new SqlDataAdapter(cmd, conexion);
                dt = new DataTable();
                da.Fill(dt);
                CerrarBd();
                return dt;
            }
            catch (Exception ex)
            {
               
                return null;
            }

        }

    }
}
