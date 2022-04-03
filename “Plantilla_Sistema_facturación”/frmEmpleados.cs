using System;
using System.Data;
using System.Windows.Forms;
using Capa_LogicaDeNegocios;

namespace _Plantilla_Sistema_facturación_
{
    public partial class frmEmpleados : Form
    {
        public int IdEmpleado { get; set; }
        public frmEmpleados()
        {
            InitializeComponent();
        }
        private void frmEmpleados_Load(object sender, EventArgs e)
        {
            Cargar_ComboRol();
            Llenar_Categoria();
        }

        DataTable dt = new DataTable(); // CREAMOS EL OBJETO DE TIPO DATATABLE PARA ALMACENAR LO CONSULTADO
        Cls_Empleados empleado = new Cls_Empleados();

        public void Llenar_Categoria()
        {
            if (IdEmpleado == 0)
            {//Registro nuevo
                lblAdminEmpleados.Text = "INGRESO NUEVO PRODUCTO";
            }
            else
            {
                //ACTUALIZAR EL REGISTRO CON EL ID PASADO
                lblAdminEmpleados.Text = "MODIFICAR PRODUCTO";
                empleado.C_IdEmpleado = IdEmpleado;
                dt = empleado.Consulta_Empleado();
              

                foreach (DataRow row in dt.Rows)
                {
                    // LLENAMOS LOS CAMPOS CON EL REGISTRO CONSULTADO

                    txtNombreEmpleado.Text = row[1].ToString();
                    txtDocumentoEmpleado.Text = row[2].ToString();
                    txtDireccionEmpleado.Text = row[3].ToString();
                    txtTelefonoEmpleado.Text = row[4].ToString();
                    txtEmailEmpleado.Text = row[5].ToString();
                    cboRolEmpleado.SelectedValue = row[6].ToString(); 
                    dtpFechaIngreso.Text = row[7].ToString();
                    dtpFechaRetiro.Text = row[8].ToString();
                    txtDatosAdicionales.Text = row[9].ToString();
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
                    empleado.C_IdEmpleado = IdEmpleado;
                    empleado.C_strNombre = txtNombreEmpleado.Text;
                    empleado.C_NumDocumento = double.Parse(txtDocumentoEmpleado.Text);
                    empleado.C_StrDireccion = txtDireccionEmpleado.Text;
                    empleado.C_StrTelefono = txtTelefonoEmpleado.Text;
                    empleado.C_StrEmail = txtEmailEmpleado.Text;
                    empleado.C_IdRolEmpleado = int.Parse(cboRolEmpleado.SelectedValue.ToString());
                    empleado.C_DtmIngreso = dtpFechaIngreso.Text;
                    empleado.C_DtmRetiro = dtpFechaRetiro.Text;
                    empleado.C_strDatosAdicionales = txtDatosAdicionales.Text;
                    empleado.C_DtmFechaModifica = DateTime.Now.ToShortDateString();
                    empleado.C_StrUsuarioModifico = "Juan";
                    mensaje = empleado.Actulizar_Empleado();
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

            if (txtNombreEmpleado.Text == string.Empty)
            {
                MensajeError.SetError(txtNombreEmpleado, "Debe ingresar el nombre del empleado");
                txtNombreEmpleado.Focus();
                errorCampos = false;
            }
            else { MensajeError.SetError(txtDocumentoEmpleado, string.Empty); }

            if (txtDocumentoEmpleado.Text == string.Empty)
            {
                MensajeError.SetError(txtDocumentoEmpleado, "Debe ingresar numero documento del empleado");
                txtDocumentoEmpleado.Focus();
                errorCampos = false;
            }
            else if (!esNumerico(txtDocumentoEmpleado.Text))
            {

                MensajeError.SetError(txtDocumentoEmpleado, "El numero de documento es un valor numerico");
                txtDocumentoEmpleado.Focus();
                errorCampos = false;
            }
            else { MensajeError.SetError(txtDocumentoEmpleado, string.Empty); }
                     

            if (txtDireccionEmpleado.Text == string.Empty)
            {
                MensajeError.SetError(txtDireccionEmpleado, "Debe ingresar direccion para el empleado");
                txtDocumentoEmpleado.Focus();
                errorCampos = false;
            }
            else { MensajeError.SetError(txtDireccionEmpleado, string.Empty); }

            if (txtTelefonoEmpleado.Text == string.Empty)
            {
                MensajeError.SetError(txtTelefonoEmpleado, "Debe ingresar un numero de telefono para el empleado");
                txtTelefonoEmpleado.Focus();
                errorCampos = false;
            }
            else if (!esNumerico(txtTelefonoEmpleado.Text))
            {

                MensajeError.SetError(txtTelefonoEmpleado, "El numero de telefono debe ser numerico");
                txtDocumentoEmpleado.Focus();
                errorCampos = false;
            }
            else { MensajeError.SetError(txtTelefonoEmpleado, string.Empty); }

            if (txtEmailEmpleado.Text == string.Empty)
            {
                MensajeError.SetError(txtEmailEmpleado, "Debe ingresar un email para el empleado");
                txtEmailEmpleado.Focus();
                errorCampos = false;
            }
            else { MensajeError.SetError(txtEmailEmpleado, string.Empty); }
            return errorCampos;
        }

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

        public void Cargar_ComboRol()
        {            
            dt = empleado.Consulta_Rol();
            cboRolEmpleado.DataSource = dt;
            cboRolEmpleado.DisplayMember = "StrDescripcion";
            cboRolEmpleado.ValueMember = "IdRolEmpleado";            
        }


        private void btnActuliazarEmpleado_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void btnSalirEmpleado_Click(object sender, EventArgs e)
        {
            DialogResult Rta;
            Rta = MessageBox.Show("Desea salir de la edicion?", "MENSAJE DE ADVERTENCIA", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning);
            if (Rta == DialogResult.OK)
            {
                this.Close(); 
            }
        }

    }
}
