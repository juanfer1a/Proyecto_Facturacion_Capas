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
        //Acceso_datos Acceso = new Acceso_datos(); // creamos un objeto con la clase Acceso_datos


        public void Llenar_grid()
        {
            //ACTUALIZAR EL REGISTRO CON EL ID PASADO
            string sentencia = $"EXEC SpConsultaFactura"; // CONSULTA TABLA DETALLE FACTURAS

            //dt = Acceso.EjecutarComandoDatos(sentencia);
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
                int IdFactura = Convert.ToInt32(dgvFacturas[0, posActual].Value.ToString());
                string sentencia = $"Delete TBLFACTURA WHERE IdFactura = {IdFactura}";
                //string mensaje = Acceso.EjecutarComando(sentencia);
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
            string sentencia = $"EXEC SpConsultaFactura";
            //dt = Acceso.EjecutarComandoDatos(sentencia);


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
                    MessageBox.Show($"No se encuentra ninguna factura asociada al usuario{txtBuscarFactura.Text}");
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
