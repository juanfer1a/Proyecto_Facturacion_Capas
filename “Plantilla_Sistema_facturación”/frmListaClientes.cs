using System;
using System.Data;
using System.Windows.Forms;
using Capa_LogicaDeNegocios;


namespace _Plantilla_Sistema_facturación_
{
    public partial class frmListaClientes : Form
    {

        public frmListaClientes()
        {
            InitializeComponent();
        }

        private void frmListaClientes_Load(object sender, EventArgs e)
        {
            Llenar_grid();
        }

        DataTable dt = new DataTable(); // CREAMOS EL OBJETO DE TIPO DATATABLE PARA ALMACENAR LO CONSULTADO
        Cls_Clientes clientes = new Cls_Clientes();

        public void Llenar_grid()
        {
            // Consultar los registros de la tabla cliente para mostrarlos en el datagrid            
            dt = clientes.Consulta_Clientes();

            foreach (DataRow row in dt.Rows)
            {
                // Llenamos el datagrid con los datos 
                dgClientes.Rows.Add(row[0], row[1], row[2], row[3]);
            }

        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            validar();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmClientes Cliente = new frmClientes();
            Cliente.IdCliente = 0;
            Cliente.NombreBtnActualizar("Crear");
            Cliente.ShowDialog();
        }

        private void dgClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgClientes.Columns[e.ColumnIndex].Name == "btnBorrar")//Obtenemos el nombre de la columna para comparar
            {
                int posActual = dgClientes.CurrentRow.Index;//Obtenemos el numero de la fila
                if (MessageBox.Show("Esta seguro de borrar", "CONFIRMACION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    MessageBox.Show($"BORRANDO indice {e.RowIndex} ID {dgClientes[0, posActual].Value.ToString()}");//Mostramos mensaje
                clientes.C_IdCliente = Convert.ToInt32(dgClientes[0, posActual].Value.ToString());
                string mensaje = clientes.Eliminar_Cliente();
                dgClientes.Rows.Clear();
                Llenar_grid();



            }

            if (dgClientes.Columns[e.ColumnIndex].Name == "btnEditarCliente")//Obtenemos el nombre de la columna para comparar
            {
                int posActual = dgClientes.CurrentRow.Index;//Obtenemos el numero de la fila
                frmClientes Cliente = new frmClientes();
                Cliente.IdCliente = int.Parse(dgClientes[0, posActual].Value.ToString());//pasamos al formulario el id del cliente seleccionado
                Cliente.ShowDialog();//muestra el formulario de forma modal
                dgClientes.Rows.Clear();
                Llenar_grid();
            }
        }

        public void Consultar()//metodo que busca en la base de datos el cliente que coincide con el numero de documento
        {

            dt = clientes.Filtrar_Cliente(txtBuscarClientes.Text);

            if (dt.Rows.Count > 0)
            {
                dgClientes.Rows.Clear();
                txtBuscarClientes.Clear();
                foreach (DataRow row in dt.Rows)
                {
                    // LLENAMOS LOS CAMPOS CON EL REGISTRO CONSULTADO
                    dgClientes.Rows.Add(row[0], row[1], row[2], row[3]);
                }
            }
            else
            {
                MessageBox.Show("No se encuentra en el sistema con ese nombre");
                Llenar_grid();

            }

        }

        //FUNCIÓN QE PERMITE VALIDAR LOS CAMPOS DEL FORMULARIO
        private Boolean validar()
        {
            Boolean errorCampos = true;
            if (txtBuscarClientes.Text == string.Empty)
            {
                MensajeError.SetError(txtBuscarClientes, "Debe ingresar el nuemero de documento");
                txtBuscarClientes.Focus();
                errorCampos = false;
            }
            else
            {
                MensajeError.SetError(txtBuscarClientes, string.Empty);
                Consultar();
            }

            return errorCampos;
        }

        //función para validar si un valor dado es numerico
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
