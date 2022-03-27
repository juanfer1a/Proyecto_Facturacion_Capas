using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _Plantilla_Sistema_facturación_
{
    public partial class frmListaEmpleados : Form
    {
        public frmListaEmpleados()
        {
            InitializeComponent();
        }

        private void frmListaEmpleados_Load(object sender, EventArgs e)
        {

            llenar_grid();
        }

        DataTable dt = new DataTable(); // CREAMOS EL OBJETO DE TIPO DATATABLE PARA ALMACENAR LO CONSULTADO
        Acceso_datos Acceso = new Acceso_datos(); // creamos un objeto con la clase Acceso_datos

       
        public void llenar_grid()
        {
            //ACTUALIZAR EL REGISTRO CON EL ID PASADO
            string sentencia = $"select IdEmpleado,strNombre,NumDocumento,StrDireccion,StrTelefono,StrEmail,IdRolEmpleado," +
                $"DtmIngreso,DtmRetiro from TBLEMPLEADO"; // CONSULTO REGISTRO DEL iDcLIENTE
            dt = Acceso.EjecutarComandoDatos(sentencia);

            foreach (DataRow row in dt.Rows)
            {
                // LLENAMOS LOS CAMPOS CON EL REGISTRO CONSULTADO
                dgvListaEmpleados.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5], row[6], row[7]);
            }
        }
       
        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            validar();
        }

        private void btnSalirCliente_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvListaEmpleados_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvListaEmpleados.Columns[e.ColumnIndex].Name == "btnBorrar")//Obtenemos el nombre de la columna para comparar
            {
                int posActual = dgvListaEmpleados.CurrentRow.Index;//Obtenemos el numero de la fila
                if (MessageBox.Show("Esta seguro de borrar", "CONFIRMACION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    MessageBox.Show($"BORRANDO indice{e.RowIndex} ID{dgvListaEmpleados[0, posActual].Value.ToString()}");//Mostramos mensaje
                int IdEmpleado = Convert.ToInt32(dgvListaEmpleados[0, posActual].Value.ToString());
                string sentencia = $"EXEC Eliminar_Empleado {IdEmpleado}";
                string mensaje = Acceso.EjecutarComando(sentencia);
                dgvListaEmpleados.Rows.Clear();
                llenar_grid();
            }

            if (dgvListaEmpleados.Columns[e.ColumnIndex].Name == "btnEditar")//Obtenemos el nombre de la columna para comparar
            {
                int posActual = dgvListaEmpleados.CurrentRow.Index;//Obtenemos el numero de la fila
                frmEmpleados empleados = new frmEmpleados();
                empleados.IdEmpleado = int.Parse(dgvListaEmpleados[0, posActual].Value.ToString());//pasamos al formulario el id del cliente seleccionado
                empleados.ShowDialog();//muestra el formulario de forma modal
            }
        }

        private void btnClienteNuevo_Click(object sender, EventArgs e)
        {
            frmEmpleados empleados = new frmEmpleados();
            empleados.IdEmpleado = 0;
            empleados.ShowDialog();
        }

        public void Consultar()//metodo que busca en la base de datos el cliente que coincide con el numero de documento
        {
            string sentencia = $"select IdEmpleado,strNombre,NumDocumento,StrDireccion,StrTelefono,StrEmail,IdRolEmpleado," +
                $"DtmIngreso,DtmRetiro from TBLEMPLEADO where NumDocumento = {txtBuscarEmpleado.Text}"; // CONSULTO REGISTRO DEL iDcLIENTE
            dt = Acceso.EjecutarComandoDatos(sentencia);

            if (dt.Rows.Count > 0)
            {
                dgvListaEmpleados.Rows.Clear();
                txtBuscarEmpleado.Clear();
                foreach (DataRow row in dt.Rows)
                {
                    // LLENAMOS LOS CAMPOS CON EL REGISTRO CONSULTADO
                    dgvListaEmpleados.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5], row[6], row[7]);
                }
            }
            else
            {
                MessageBox.Show("No se encuentra un usuario con el nuemero de documento ingresado");
                llenar_grid();

            }

        }

        //FUNCIÓN QE PERMITE VALIDAR LOS CAMPOS DEL FORMULARIO
        private Boolean validar()
        {
            Boolean errorCampos = true;
            if (txtBuscarEmpleado.Text == string.Empty)
            {
                MensajeError.SetError(txtBuscarEmpleado, "Debe ingresar el nuemero de documento");
                txtBuscarEmpleado.Focus();
                errorCampos = false;
            }
            else if (!esNumerico(txtBuscarEmpleado.Text))
            {

                MensajeError.SetError(txtBuscarEmpleado, "El numero de documento es un valor numerico");
                txtBuscarEmpleado.Focus();
                errorCampos = false;

            }
            else
            {
                MensajeError.SetError(txtBuscarEmpleado, string.Empty);
                Consultar();
            }

            return errorCampos;
        }

        private bool esNumerico(string num)
        {
            try
            {
                double x = Convert.ToDouble(num);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

    }
}
