using System;
using System.Data;
using Capa_LogicaDeNegocios;
using System.Windows.Forms;

namespace _Plantilla_Sistema_facturación_
{
    public partial class frmFacturas : Form
    {
        public int NroFactura { get; set; }
        public frmFacturas()
        {
            InitializeComponent();
        }

        ClsFactura factura = new ClsFactura();

        private void frmFacturas_Load(object sender, EventArgs e)
        {
            llenar_combo_clientes();
            llenar_combo_empleado();
            llenar_combo_estadoFactura();            
        }


        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        public bool Guardar()
        {
            Boolean actualizado = false;
            if (validar())
            {
                try
                {
                    if (txbNroFactura.Text == string.Empty)
                    {
                        txbNroFactura.Text = "0";
                    }
                    
                    //Acceso_datos Acceso = new Acceso_datos();
                    string sentencia = $"Exec actualizar_Factura {txbNroFactura.Text},'{dtpFechaFactura.Text}','{cboClienteFactura.SelectedValue}','{cboEmpleadoFactura.SelectedValue}'," +
                        $"{txtDescuento.Text},{txtTotalIva.Text},'{txtTotalFactura.Text}','{cboEstadoFactura.SelectedValue}','{DateTime.Now.ToShortDateString()}'," +
                        $"'Juan'";
                    factura.C_IdFactura
                    factura.C_DtmFecha
                    factura.C_IdCliente
                    factura.C_IdEmpleado
                    factura.C_NumDescuento
                    factura.C_NumImpuesto
                    factura.C_NumValorTotal
                    factura.C_IdEstado
                    factura.C_DtmFechaModifica
                    factura.C_StrUsuarioModifica

                    //MessageBox.Show(Acceso.EjecutarComando(sentencia));
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
        private void llenar_combo_empleado()
        {
            DataTable dt = new DataTable();
            //Acceso_datos Acceso = new Acceso_datos(); // creamos un objeto con la clase Acceso_datos
            //dt = Acceso.cargartabla("TBLEMPLEADO", "");
            cboEmpleadoFactura.DataSource = dt;
            cboEmpleadoFactura.DisplayMember = "strNombre";
            cboEmpleadoFactura.ValueMember = "IdEmpleado";

            //Acceso.CerrarBd();
        }

        private void llenar_combo_clientes()
        {
            DataTable dt = new DataTable();
            //Acceso_datos Acceso = new Acceso_datos(); // creamos un objeto con la clase Acceso_datos
            //dt = Acceso.cargartabla("TBLCLIENTES", "");
            cboClienteFactura.DataSource = dt;
            cboClienteFactura.DisplayMember = "StrNombre";
            cboClienteFactura.ValueMember = "IdCliente";

            //Acceso.CerrarBd();
        }

        private void llenar_combo_estadoFactura()
        {
            DataTable dt = new DataTable();
            //Acceso_datos Acceso = new Acceso_datos(); // creamos un objeto con la clase Acceso_datos
            //dt = Acceso.cargartabla("TBLESTADO_FACTURA", "");
            cboEstadoFactura.DataSource = dt;
            cboEstadoFactura.DisplayMember = "StrDescripcion";
            cboEstadoFactura.ValueMember = "IdEstadoFactura";

            //Acceso.CerrarBd();
        }
        //FUNCIÓN QE PERMITE VALIDAR LOS CAMPOS DEL FORMULARIO
        private Boolean validar()
        {
            Boolean errorCampos = true;
            if (txtDescuento.Text == string.Empty)
            {
                MensajeError.SetError(txtDescuento, "Debe ingresar el valor a descontar");
                txtDescuento.Focus();
                errorCampos = false;
            }
            else { MensajeError.SetError(txtDescuento, string.Empty); }

            if (txtTotalIva.Text == string.Empty)
            {
                MensajeError.SetError(txtTotalIva, "Debe ingresar el total del iva");
                txtTotalIva.Focus();
                errorCampos = false;
            }
            else { MensajeError.SetError(txtTotalIva, string.Empty); }

            if (!esNumerico(txtTotalFactura.Text))
            {
                MensajeError.SetError(txtTotalFactura, "Debe ingresar el total de la factura");
                txtTotalFactura.Focus();
                return false;
            }
            else { MensajeError.SetError(txtTotalFactura, string.Empty); }

            
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

        private void lblSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
