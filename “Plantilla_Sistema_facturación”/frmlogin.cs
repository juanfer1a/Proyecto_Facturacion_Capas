using System;
using Capa_LogicaDeNegocios;
using System.Windows.Forms;

namespace _Plantilla_Sistema_facturación_
{
    public partial class frmlogin : Form
    {
        public frmlogin()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                string Respuesta = string.Empty;//variable para validar si la consulta devuelte un resultado

                if (txtUsuario.Text != string.Empty && txtPassword.Text != string.Empty)//Valida que los campos tengan informacion
                {
                    Validar_usuario obj_validar = new Validar_usuario(); ;//Instanciamos la clase acceso a datos
                    obj_validar.C_strNombre = txtUsuario.Text;
                    obj_validar.C_strClave = txtPassword.Text;
                    obj_validar.ValidarUsuario();

                    if (obj_validar.C_idEmpleado != 0)
                    {
                        MessageBox.Show("Acceso concedido, Bienvenido ");
                        frmPrincipal frmPpal = new frmPrincipal();//objeto tipo formPrincipal 
                        this.Hide();//Hacemos invisible el login
                        frmPpal.Show();//Mostramos el principal
                    }
                    else
                    {
                        MessageBox.Show("USUARIO O CONTRASEÑA INVALIDA INTENTELO DE NUEVO");
                        txtUsuario.Text = string.Empty;
                        txtPassword.Text = string.Empty;
                        txtUsuario.Focus();
                    }

                }
            }

        }
        private Boolean validar()
        {
            Boolean errorCampos = true;
            if (txtUsuario.Text == string.Empty)
            {
                MensajeError.SetError(txtUsuario, "Debe ingresar un nombre de usuario");
                txtUsuario.Focus();
                errorCampos = false;
            }

            else
            {
                MensajeError.SetError(txtUsuario, string.Empty);
                //Consultar();
            }

            if (txtPassword.Text == string.Empty)
            {
                MensajeError.SetError(txtPassword, "Debe ingresar una contraseña");
                txtPassword.Focus();
                errorCampos = false;
            }

            else
            {
                MensajeError.SetError(txtPassword, string.Empty);

            }
            return errorCampos;
        }
    }
}
