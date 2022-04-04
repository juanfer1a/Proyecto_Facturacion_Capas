using System;
using System.Data;
using System.Windows.Forms;
using Capa_LogicaDeNegocios;

namespace _Plantilla_Sistema_facturación_
{
    public partial class frmRolEmpleados : Form
    {
        public int IdRol { get; set; }
        public frmRolEmpleados()
        {
            InitializeComponent();
        }

        DataTable dt = new DataTable(); // CREAMOS EL OBJETO DE TIPO DATATABLE PARA ALMACENAR LO CONSULTADO
        Cls_Roles rol = new Cls_Roles();
        private void frmRolEmpleados_Load(object sender, EventArgs e)
        {
            Llenar_FrmRol();

        }

        private void btnActualizarRol_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        // *************************************** ACTUALIZACIONES ********* ********************
        // ------- funciones que permiten el ingreso , retiro y actualización de la información de Clientes en la base de datos
        public void Guardar()
        {
            string mensaje = string.Empty;
            if (validar())
            {
                try
                {
                    rol.C_StrDescripcion = txtRol.Text;
                    rol.C_IdRol = IdRol;                    
                    mensaje = rol.Actualizar_Rol();
                    MessageBox.Show(mensaje);
                    txtRol.Focus();
                    txtRol.Clear();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("falló inserción: " + ex);

                }
            }
        }

        public void Llenar_FrmRol()
        {
            if (IdRol == 0)
            {//Registro nuevo
                lblRolEmpleados.Text = "INGRESO NUEVO PRODUCTO";
            }
            else
            {
                //ACTUALIZAR EL REGISTRO CON EL ID PASADO
                lblRolEmpleados.Text = "MODIFICAR PRODUCTO";
                rol.C_IdRol = IdRol;
                dt = rol.Consulta_Rol();


                foreach (DataRow row in dt.Rows)
                {
                    // LLENAMOS LOS CAMPOS CON EL REGISTRO CONSULTADO

                    txtRol.Text = row[1].ToString();
                   
                }
            }
        }
        //FUNCIÓN QE PERMITE VALIDAR LOS CAMPOS DEL FORMULARIO
        private Boolean validar()
        {
            Boolean errorCampos = true;

            if (txtRol.Text == string.Empty)
            {
                MensajeError.SetError(txtRol, "Debe ingresar el nombre del producto");
                txtRol.Focus();
                errorCampos = false;
            }
            else { MensajeError.SetError(txtRol, string.Empty); }

            
            return errorCampos;
        }


        private void lblSalirRol_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
