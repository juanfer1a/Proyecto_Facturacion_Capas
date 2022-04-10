using System;
using System.Data;
using Capa_LogicaDeNegocios;
using System.Windows.Forms;

namespace _Plantilla_Sistema_facturación_
{
    public partial class frmListaFacturas : Form
    {
        public frmListaFacturas()
        {
            InitializeComponent();
        }
        private void frmListaFacturas_Load(object sender, EventArgs e)
        {
            Llenar_grid();

        }


        DataTable dt = new DataTable(); // CREAMOS EL OBJETO DE TIPO DATATABLE PARA ALMACENAR LO CONSULTADO
        ClsFactura factura = new ClsFactura();


        public void Llenar_grid()
        {
            //ACTUALIZAR EL REGISTRO CON EL ID PASADO
            dt = factura.Consulta_Factura();

            foreach (DataRow row in dt.Rows)
            {
                // LLENAMOS LOS CAMPOS CON EL REGISTRO CONSULTADO
                dgvFacturas.Rows.Add(row[0], row[1], row[2], row[3], row[4]);
            }
        }

        private void btnProductoNuevo_Click(object sender, EventArgs e)
        {
            frmFacturas Facturas = new frmFacturas();
            Facturas.NroFactura = 0;
            Facturas.ShowDialog();
        }



        private void btnBuscarFactura_Click(object sender, EventArgs e)
        {
            validar();
        }


        private void dgvFacturas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvFacturas.Columns[e.ColumnIndex].Name == "btnBorrar")//Obtenemos el nombre de la columna para comparar
            {
                int posActual = dgvFacturas.CurrentRow.Index;//Obtenemos el numero de la fila
                if (MessageBox.Show("Esta seguro de borrar", "CONFIRMACION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    MessageBox.Show($"BORRANDO indice{e.RowIndex} ID{dgvFacturas[0, posActual].Value.ToString()}");//Mostramos mensaje
                
                factura.C_IdFactura = Convert.ToInt32(dgvFacturas[0, posActual].Value.ToString());
                string mensaje = factura.Eliminar_Factura();
                MessageBox.Show(mensaje);
                dgvFacturas.Rows.Clear();
                Llenar_grid();
            }

            if (dgvFacturas.Columns[e.ColumnIndex].Name == "btnEditar")//Obtenemos el nombre de la columna para comparar
            {
                int posActual = dgvFacturas.CurrentRow.Index;//Obtenemos el numero de la fila
                frmFacturas Facturas = new frmFacturas();
                Facturas.NroFactura = int.Parse(dgvFacturas[0, posActual].Value.ToString());//pasamos al formulario el id del cliente seleccionado
                Facturas.ShowDialog();//muestra el formulario de forma modal
            }
        }


        public void consultar()
        {

            bool bandera = false;
            dt = factura.Consulta_Factura();

            if (dt.Rows.Count > 0)
            {

                foreach (DataRow row in dt.Rows)
                {
                    if (row[2].Equals(txtBuscarFactura.Text))
                    {
                        bandera = true;
                        dgvFacturas.Rows.Clear();
                        txtBuscarFactura.Clear();

                        // LLENAMOS LOS CAMPOS CON EL REGISTRO CONSULTADO
                        dgvFacturas.Rows.Add(row[0], row[1], row[2], row[3], row[4]);
                    }
                }

                if (!bandera)
                {
                    MessageBox.Show($"No se encuentra ninguna factura asociada al Cliente {txtBuscarFactura.Text}");
                    txtBuscarFactura.Clear();
                }
            }
        }
        private Boolean validar()
        {
            Boolean errorCampos = true;
            //campo nombre
            if (txtBuscarFactura.Text == string.Empty)
            {
                MensajeError.SetError(txtBuscarFactura, "Debe ingresar el nombre del cliente");
                txtBuscarFactura.Focus();
                errorCampos = false;
            }
            else
            {
                consultar();
                MensajeError.SetError(txtBuscarFactura, string.Empty);
            }

            return errorCampos;
        }

        private void btnSalirProducto_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
