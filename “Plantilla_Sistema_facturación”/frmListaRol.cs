using System;
using System.Data;
using System.Windows.Forms;
using Capa_LogicaDeNegocios;

namespace _Plantilla_Sistema_facturación_
{
    public partial class frmListaRol : Form
    {
        public int IdRol { get; set; }
        public frmListaRol()
        {
            InitializeComponent();
        }


        private void frmListaRol_Load(object sender, EventArgs e)
        {
            llenar_grid();
        }
        DataTable dt = new DataTable(); // CREAMOS EL OBJETO DE TIPO DATATABLE PARA ALMACENAR LO CONSULTADO
        Cls_Roles rol = new Cls_Roles();// creamos un objeto de la clase Cls seguridad de la capa logica de negocios


        public void llenar_grid()
        {
            //ACTUALIZAR EL REGISTRO CON EL ID PASADO
            dgvRol.Rows.Clear();
            dt = rol.Consulta_Rol();

            foreach (DataRow row in dt.Rows)
            {
                // LLENAMOS LOS CAMPOS CON EL REGISTRO CONSULTADO
                dgvRol.Rows.Add(row[0], row[1]);
            }
        }

        private void dgvRol_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvRol.Columns[e.ColumnIndex].Name == "btnBorrar")//Obtenemos el nombre de la columna para comparar
            {
                int posActual = dgvRol.CurrentRow.Index;//Obtenemos el numero de la fila
                if (MessageBox.Show("Esta seguro de borrar", "CONFIRMACION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    MessageBox.Show($"BORRANDO indice{e.RowIndex} ID{dgvRol[0, posActual].Value.ToString()}");//Mostramos mensaje
                rol.C_IdRol = Convert.ToInt32(dgvRol[0, posActual].Value.ToString());
                MessageBox.Show(rol.Eliminar_Rol());
                dgvRol.Rows.Clear();
                llenar_grid();

            }

            if (dgvRol.Columns[e.ColumnIndex].Name == "btnEditar")//Obtenemos el nombre de la columna para comparar
            {
                int posActual = dgvRol.CurrentRow.Index;//Obtenemos el numero de la fila
                frmRolEmpleados Rol = new frmRolEmpleados();
                Rol.IdRol = int.Parse(dgvRol[0, posActual].Value.ToString());//pasamos al formulario el id del cliente seleccionado
                Rol.ShowDialog();//muestra el formulario de forma modal
            }
        }

        public void consultar()
        {
           dt = rol.Filtrar_Rol(txtBuscarRol.Text); // CONSULTO REGISTRO
            

            if (dt.Rows.Count > 0)
            {
                dgvRol.Rows.Clear();
                txtBuscarRol.Clear();
                               
                foreach (DataRow row in dt.Rows)
                {
                    // LLENAMOS LOS CAMPOS CON EL REGISTRO CONSULTADO
                    dgvRol.Rows.Add(row[0], row[1]);
                }
            }
            else
            {
                MessageBox.Show("No se encuentra un usuario con el nuemero de documento ingresado");
                llenar_grid();

            }
        }
        private void btnRolNuevo_Click(object sender, EventArgs e)
        {
            frmRolEmpleados Rol = new frmRolEmpleados();
            Rol.IdRol = 0;
            Rol.ShowDialog();
        }



        private void btnBuscarRol_Click(object sender, EventArgs e)
        {
            consultar();
        }

        private void btnSalirRol_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
