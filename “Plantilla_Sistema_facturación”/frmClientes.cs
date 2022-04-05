using System;
using System.Data;
using System.Windows.Forms;
using Capa_LogicaDeNegocios;

namespace _Plantilla_Sistema_facturación_
{
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }
        private void frmEditarClientes_Load(object sender, EventArgs e)
        {
            Llenar_Cliente();
        }
        public int IdCliente { get; set; }// ATRIBUTO QUE PERMITE RECIBIR COMO PARAMETRO EL iDcLIENTE

        DataTable dt = new DataTable(); // CREAMOS EL OBJETO DE TIPO DATATABLE PARA ALMACENAR LO CONSULTADO
        Cls_Clientes clientes = new Cls_Clientes();

        public void Llenar_Cliente()
        {
            if (IdCliente == 0)
            {//Registro nuevo
                lblTitulo.Text = "INGRESO NUEVO CLIENTE";
            }
            else
            {//Actulizar cliente
                lblTitulo.Text = "EDITAR CLIENTE";
                dt = clientes.Consulta_Clientes(IdCliente); // CONSULTO REGISTRO DEL iDcLIENTE


                foreach (DataRow row in dt.Rows)
                {
                    // LLENAMOS LOS CAMPOS CON EL REGISTRO CONSULTADO

                    txtNombreCliente.Text = row[1].ToString();
                    txtDocumento.Text = row[2].ToString();
                    txtDireccion.Text = row[3].ToString();
                    txtTelefono.Text = row[4].ToString();
                    txtEmail.Text = row[5].ToString();
                }
            }
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
                    

                    clientes.C_IdCliente = IdCliente;
                    clientes.C_StrNombre = txtNombreCliente.Text;
                    clientes.C_NumDocumento = int.Parse(txtDocumento.Text);
                    clientes.C_StrDireccion = txtDireccion.Text;
                    clientes.C_StrTelefono = txtTelefono.Text;
                    clientes.C_StrEmail = txtEmail.Text;
                    clientes.C_DtmFechaModifica = DateTime.Now.ToShortDateString();
                    clientes.C_StrUsuarioModifica = "Juan";
                    mensaje = clientes.Actualizar_Cliente();
                    MessageBox.Show(mensaje);


                }
                catch (Exception ex)
                {
                    MessageBox.Show("falló inserción: " + ex);
                    
                }
            }
            
        }
        //FUNCIÓN QE PERMITE VALIDAR LOS CAMPOS DEL FORMULARIO
        private Boolean validar()
        {
            Boolean errorCampos = true;
            //campo nombre
            if (txtNombreCliente.Text == string.Empty)
            {
                MensajeError.SetError(txtNombreCliente, "Debe ingresar el nombre del Cliente");
                txtNombreCliente.Focus();
                errorCampos = false;
            }
            else { MensajeError.SetError(txtNombreCliente, string.Empty); }

            //campo email
            if (txtEmail.Text == string.Empty)
            {
                MensajeError.SetError(txtEmail, "Debe ingresar el email del cliente");
                txtEmail.Focus();
                errorCampos = false;
            }
            else { MensajeError.SetError(txtEmail, string.Empty); }

            //campo documento
            if (txtDocumento.Text == string.Empty)
            {
                MensajeError.SetError(txtDocumento, "Debe ingresar el documento");
                txtDocumento.Focus();
                errorCampos = false;
            }
            else if (!esNumerico(txtDocumento.Text))
            {
                MensajeError.SetError(txtDocumento, "El Documento debe ser numerico");
                txtDocumento.Focus();
                return false;
            }
            else { MensajeError.SetError(txtDocumento, string.Empty); }

            //campo direccion
            if (txtDireccion.Text == string.Empty)
            {
                MensajeError.SetError(txtDireccion, "Debe ingresar la direccion del cliente");
                txtDocumento.Focus();
                errorCampos = false;
            }
            else { MensajeError.SetError(txtDireccion, string.Empty); }


            //campo telefono
            if (txtTelefono.Text == string.Empty)//validar que el campo numero telefonico no este vacio 
            {
                MensajeError.SetError(txtTelefono, "Debe ingresar el telefono");
                txtDocumento.Focus();
                errorCampos = false;
            }
            else if (!esNumerico(txtTelefono.Text))//validar que el campo numero telefonico tenga valores nuemricos
            {
                MensajeError.SetError(txtTelefono, "El numero de telefono debe ser numerico");
                txtDocumento.Focus();
                return false;
            }
            else { MensajeError.SetError(txtTelefono, string.Empty); }

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

        public void NombreBtnActualizar(string nombre)
        {
            btnActualizar.Text = nombre;
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
