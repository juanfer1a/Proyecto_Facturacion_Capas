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
    public partial class frmRolEmpleados : Form
    {
        public int IdRol { get; set; }
        public frmRolEmpleados()
        {
            InitializeComponent();
        }
        private void frmRolEmpleados_Load(object sender, EventArgs e)
        {
            

        }



        private void btnActualizarRol_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        // *************************************** ACTUALIZACIONES ********* ********************
        // ------- funciones que permiten el ingreso , retiro y actualización de la información de Clientes en la base de datos
        public bool Guardar()
        {
            Boolean actualizado = false;
            if (validar())
            {
                try
                {
                    Acceso_datos Acceso = new Acceso_datos();
                    string sentencia = $"Exec actualizar_Rol '{IdRol}','{txtNombreRol.Text}'";
                    MessageBox.Show(Acceso.EjecutarComando(sentencia));
                    actualizado = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("falló inserción: " + ex);
                    actualizado = false;
                }
            }
            return actualizado;
        }
        //FUNCIÓN QE PERMITE VALIDAR LOS CAMPOS DEL FORMULARIO
        private Boolean validar()
        {
            Boolean errorCampos = true;

            if (txtNombreRol.Text == string.Empty)
            {
                MensajeError.SetError(txtNombreRol, "Debe ingresar el nombre del producto");
                txtNombreRol.Focus();
                errorCampos = false;
            }
            else { MensajeError.SetError(txtNombreRol, string.Empty); }

            
            return errorCampos;
        }


        private void lblSalirRol_Click(object sender, EventArgs e)
        {
            this.Close();
        }



    }
}
