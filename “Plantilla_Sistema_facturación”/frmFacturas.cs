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

        DataTable dt = new DataTable();
        ClsFactura factura = new ClsFactura();

        private void frmFacturas_Load(object sender, EventArgs e)
        {
            Llenar_Factura();
        }

        public void Llenar_Factura()
        {
            if (NroFactura == 0)
            {//Registro nuevo
                lblEditarFactura.Text = "INGRESO NUEVA FACTURA";
                llenar_combo_clientes();
                llenar_combo_empleado();
                llenar_combo_estadoFactura();
                label1.Text = cboClienteFactura.DisplayMember;
            }
            else
            {
                llenar_combo_clientes();
                llenar_combo_empleado();
                llenar_combo_estadoFactura();

                dt = factura.Consulta_Factura(NroFactura);


                //dt = Acceso.EjecutarComandoDatos(sentencia);
                foreach (DataRow row in dt.Rows)
                {

                    label1.Text = cboClienteFactura.DisplayMember;
                    txbNroFactura.Text = row[0].ToString();
                    txtDescuento.Text = row[4].ToString();
                    txtDetalleFactura.Text = "Ninguna";
                    txtTotalFactura.Text = row[6].ToString();
                    txtTotalIva.Text = row[5].ToString();
                    label1.Text = cboClienteFactura.SelectedText;
                    cboClienteFactura.Text = consultar_clientes(int.Parse(row[2].ToString()));
                    cboEmpleadoFactura.Text = consultar_empleado(int.Parse(row[3].ToString()));
                    cboEstadoFactura.Text = consultar_estadoFact(int.Parse(row[7].ToString()));
                    dtpFechaFactura.Text = row[1].ToString();

                }
            }
        }


        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        public void Guardar()
        {
            string mensaje = string.Empty;
            if (validar())
            {
                try
                {
                    if (txbNroFactura.Text == string.Empty)
                    {
                        txbNroFactura.Text = "0";
                    }

                    factura.C_IdFactura = int.Parse(txbNroFactura.Text);
                    factura.C_DtmFecha = dtpFechaFactura.Text;
                    factura.C_IdCliente = int.Parse(cboClienteFactura.SelectedValue.ToString());
                    factura.C_IdEmpleado = int.Parse(cboEmpleadoFactura.SelectedValue.ToString());
                    factura.C_NumDescuento = int.Parse(txtDescuento.Text);
                    factura.C_NumImpuesto = int.Parse(txtTotalIva.Text);
                    factura.C_NumValorTotal = int.Parse(txtTotalFactura.Text);
                    factura.C_IdEstado = int.Parse(cboEstadoFactura.SelectedValue.ToString());
                    factura.C_DtmFechaModifica = DateTime.Now.ToShortDateString();
                    factura.C_StrUsuarioModifica = "Juan";

                    mensaje = factura.Actulizar_Factura();
                    MessageBox.Show(mensaje);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("falló inserción: " + ex);

                }
            }

        }
        private void llenar_combo_empleado()
        {
            Cls_Empleados empleados = new Cls_Empleados();
            dt = empleados.Consulta_Empleado();
            cboEmpleadoFactura.DataSource = dt;
            cboEmpleadoFactura.DisplayMember = "strNombre";
            cboEmpleadoFactura.ValueMember = "IdEmpleado";

            //Acceso.CerrarBd();
        }

        private string consultar_empleado(int Id)
        {
            string empleado = string.Empty;
            Cls_Empleados empleados = new Cls_Empleados();
            dt = empleados.Consulta_Empleado(Id);
            foreach (DataRow row in dt.Rows)
            {
                empleado = row[1].ToString();
            }
            return empleado;

            //Acceso.CerrarBd();
        }
        private string consultar_clientes(int Id)
        {
            string cliente = string.Empty;
            Cls_Clientes clientes = new Cls_Clientes();
            dt = clientes.Consulta_Clientes(Id);
            foreach (DataRow row in dt.Rows)
            {
                cliente = row[1].ToString();
            }
            return cliente;

        }

        private void llenar_combo_clientes()
        {
            Cls_Clientes clientes = new Cls_Clientes();
            dt = clientes.Consulta_Clientes();
            cboClienteFactura.DataSource = dt;
            cboClienteFactura.DisplayMember = "StrNombre";
            cboClienteFactura.ValueMember = "IdCliente";

            //Acceso.CerrarBd();
        }

        private string consultar_estadoFact(int Id)
        {
            string estado = string.Empty;
            dt = factura.Consulta_EstadoFactura(Id);
            foreach (DataRow row in dt.Rows)
            {
                estado = row[1].ToString();
            }
            return estado;

        }

        private void llenar_combo_estadoFactura()
        {

            dt = factura.Consulta_EstadoFactura();
            cboEstadoFactura.DataSource = dt;
            cboEstadoFactura.DisplayMember = "StrDescripcion";
            cboEstadoFactura.ValueMember = "IdEstadoFactura";

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
