using System;
using System.Data;
using System.Windows.Forms;
using Capa_LogicaDeNegocios;

namespace _Plantilla_Sistema_facturación_
{
    public partial class frmAdminSeguridad : Form
    {
        public frmAdminSeguridad()
        {
            InitializeComponent();
        }

        DataTable dt = new DataTable();
        Cls_Seguridad seguridad = new Cls_Seguridad();

        private void frmAdminSeguridad_Load_1(object sender, EventArgs e)
        {
            llenar_combo_Empleados();
        }

        private void llenar_combo_Empleados()
        {

            dt = seguridad.Consulta_Empleados();
            cboEmpleadoUsuario.DataSource = dt;
            cboEmpleadoUsuario.DisplayMember = "strNombre";
            cboEmpleadoUsuario.ValueMember = "IdEmpleado";

        }

        private Boolean validar()
        {
            Boolean errorCampos = true;
            if (txtUsuario.Text == string.Empty)
            {
                MensajeError.SetError(txtUsuario, "debe ingresar un valor de Usuario");
                txtUsuario.Focus();
                errorCampos = false;
            }
            else { MensajeError.SetError(txtUsuario, string.Empty); }
            if (txtUsuario.Text == "")
            {
                MensajeError.SetError(txtClave, "Debe ingresar un valor de cédula");
                txtClave.Focus();
                errorCampos = false;
            }
            else { MensajeError.SetError(txtClave, string.Empty); }
            return errorCampos;
        }

        //metodo para validar si los valores son numericos
        private bool IsNumeric(string num)
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


        // función que permite guardar los datos de ingreso a un usuario
        public void Guardar()
        {
            string mensaje = string.Empty;

            if (validar())
            {
                try
                {


                    seguridad.C_IdEmpleado = int.Parse(cboEmpleadoUsuario.SelectedValue.ToString());
                    seguridad.C_StrUsuario = txtUsuario.Text;
                    seguridad.C_StrClave = txtClave.Text;
                    seguridad.C_StrUsuarioModifico = "Juan";
                    mensaje = seguridad.Actulizar_SeguridadEmpleado();
                    MessageBox.Show(mensaje);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("falló inserción: " + ex);
                }

                txtClave.Text = string.Empty;
                txtUsuario.Text = string.Empty;
            }

        }
        // función que permite eliminar los datos de ingreso de un usuario
        public void Eliminar()
        {
            if(MessageBox.Show($"ESTA SEGURO DE ELIMINAR EL REGISTRO DE:\n{cboEmpleadoUsuario.Text}","CONFIRMACION",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                seguridad.C_IdEmpleado = int.Parse(cboEmpleadoUsuario.SelectedValue.ToString());

                string mensaje = seguridad.Eliminar_SeguridadEmpleado();
                if (mensaje!=string.Empty)
                {
                    MessageBox.Show(mensaje);
                }
                else
                {
                    MessageBox.Show("BORRANDO EL REGISTRO");
                }
            }

                
            txtUsuario.Text = string.Empty;
            txtClave.Text = string.Empty;
        }
        // función que permite consultar los datos de ingreso de un usuario
        public void Consultar()
        {
            int IdEmpleado = int.Parse(cboEmpleadoUsuario.SelectedValue.ToString());
            dt = seguridad.Consulta_SeguridadEmpleado(IdEmpleado);

            if (dt.Rows.Count > 0)
            {
                txtUsuario.Text = dt.Rows[0]["StrUsuario"].ToString();
                txtClave.Text = dt.Rows[0]["StrClave"].ToString();
            }
            else
            {
                MessageBox.Show("El usuario no dispone de datos de ingreso");
                txtUsuario.Text = string.Empty;
                txtClave.Text = string.Empty;
            }
        }


        private void btnNuevoUsuario_Click_1(object sender, EventArgs e)
        {

            Guardar();
        }

        private void btnActualizarUsuarioEmpleado_Click(object sender, EventArgs e)
        {
            Guardar();
        }
        private void cboEmpleadoUsuario_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Consultar();
        }

        private void btnEliminarUsuario_Click_1(object sender, EventArgs e)
        {
            Eliminar();
        }

        private void lblSalirAdminUsuario_Click(object sender, EventArgs e)
        {
            //verificamos si desea cerrar la ventana
            DialogResult Rta;
            Rta = MessageBox.Show("Desea salir de la edición ?", "MENSAJE DE ADVERTENCIA", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (Rta == DialogResult.OK)
            {
                this.Close();
            }
        }

    }
}
