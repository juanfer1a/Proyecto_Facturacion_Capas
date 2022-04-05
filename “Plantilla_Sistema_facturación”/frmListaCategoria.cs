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
    public partial class frmListaCategoria : Form
    {
        public frmListaCategoria()
        {
            InitializeComponent();
        }

        private void frmListaCategoria_Load(object sender, EventArgs e)
        {
            llenar_grid();
        }

        DataTable dt = new DataTable(); // CREAMOS EL OBJETO DE TIPO DATATABLE PARA ALMACENAR LO CONSULTADO
        //Acceso_datos Acceso = new Acceso_datos(); // creamos un objeto con la clase Acceso_datos


        public void llenar_grid()
        {
            //ACTUALIZAR EL REGISTRO CON EL ID PASADO
            string sentencia = $"select IdCategoria,StrDescripcion from TBLCATEGORIA_PROD"; // CONSULTO REGISTRO DEL iDcLIENTE

            //dt = Acceso.EjecutarComandoDatos(sentencia);
            foreach (DataRow row in dt.Rows)
            {
                // LLENAMOS LOS CAMPOS CON EL REGISTRO CONSULTADO
                dgvCategoria.Rows.Add(row[0], row[1]);
            }
        }

        private void btnBuscarCategoria_Click(object sender, EventArgs e)
        {
            validar();
        }

        private void btnNuevoCategoria_Click(object sender, EventArgs e)
        {
            frmCategoriasProductos Categorias = new frmCategoriasProductos();
            Categorias.IdCategoria = 0;
            Categorias.ShowDialog();
        }

        private void btnSalirCategoria_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvCategoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCategoria.Columns[e.ColumnIndex].Name == "btnBorrar")//Obtenemos el nombre de la columna para comparar
            {
                int posActual = dgvCategoria.CurrentRow.Index;//Obtenemos el numero de la fila
                if (MessageBox.Show("Esta seguro de borrar", "CONFIRMACION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    MessageBox.Show($"BORRANDO indice{e.RowIndex} ID{dgvCategoria[0, posActual].Value.ToString()}");//Mostramos mensaje
                int IdCategoria = Convert.ToInt32(dgvCategoria[0, posActual].Value.ToString());
                string sentencia = $"EXEC Eliminar_CategoriaProducto {IdCategoria}";
                //string mensaje = Acceso.EjecutarComando(sentencia);
                dgvCategoria.Rows.Clear();
                llenar_grid();
            }

            if (dgvCategoria.Columns[e.ColumnIndex].Name == "btnEditar")//Obtenemos el nombre de la columna para comparar
            {
                int posActual = dgvCategoria.CurrentRow.Index;//Obtenemos el numero de la fila
                frmCategoriasProductos Categoria = new frmCategoriasProductos();
                Categoria.IdCategoria = int.Parse(dgvCategoria[0, posActual].Value.ToString());//pasamos al formulario el id del cliente seleccionado
                Categoria.ShowDialog();//muestra el formulario de forma modal
            }
        }

        public void consultar()
        {
            string sentencia = $"select *  from TBLCATEGORIA_PROD where StrDescripcion ='{txtBuscarCategoria.Text}'"; // CONSULTO REGISTRO DEL iDcLIENTE
            //dt = Acceso.EjecutarComandoDatos(sentencia);


            if (dt.Rows.Count > 0)
            {
                dgvCategoria.Rows.Clear();
                txtBuscarCategoria.Clear();

                foreach (DataRow row in dt.Rows)
                {
                    // LLENAMOS LOS CAMPOS CON EL REGISTRO CONSULTADO
                    dgvCategoria.Rows.Add(row[0], row[1]);
                }
            }
            else
            {
                MessageBox.Show("No se encuentra una categoria con el nombre ingresado");
                llenar_grid();

            }
        }

        private Boolean validar()
        {
            Boolean errorCampos = true;
            if (txtBuscarCategoria.Text == string.Empty)
            {
                MensajeError.SetError(txtBuscarCategoria, "Debe ingresar el nombre de la categoria a buscar");
                txtBuscarCategoria.Focus();
                errorCampos = false;
            }
            else
            {
                MensajeError.SetError(txtBuscarCategoria, string.Empty);
                consultar();
            }

            return errorCampos;
        }

    }
}
