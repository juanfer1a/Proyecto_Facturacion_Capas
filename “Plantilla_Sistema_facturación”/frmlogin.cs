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
                    Acceso_datos ad = new Acceso_datos();//Instanciamos la clase acceso a datos
                    Respuesta = ad.ValidarUsuario(txtUsuario.Text, txtPassword.Text);//metodo de la clase que devuelve el nombre del usuario 
                    if (Respuesta != string.Empty)
                    {
                        MessageBox.Show("Acceso concedido, Bienvenido " + Respuesta);
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
