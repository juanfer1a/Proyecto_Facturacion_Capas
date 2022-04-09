using System;
using System.Data;
using System.Windows.Forms;
using Capa_LogicaDeNegocios;

namespace _Plantilla_Sistema_facturación_
{
    public partial class frmProductos : Form
    {
        public int IdProducto { get; set; }
        public frmProductos()
        {
            InitializeComponent();
        }

        private void frmProductos_Load(object sender, EventArgs e)
        {
            llenar_combo_categoria();
            Llenar_Productos();
        }

        DataTable dt = new DataTable(); // CREAMOS EL OBJETO DE TIPO DATATABLE PARA ALMACENAR LO CONSULTADO
        Cls_Productos productos = new Cls_Productos();
        public void Llenar_Productos()
        {
            if (IdProducto == 0)
            {//Registro nuevo
                lblTituloProducto.Text = "INGRESO NUEVO PRODUCTO";
            }
            else
            {
                lblTituloProducto.Text = "MODIFICAR PRODUCTO";
                //ACTUALIZAR EL REGISTRO CON EL ID PASADO
                dt = productos.Consulta_Producto(IdProducto);

                //dt = Acceso.EjecutarComandoDatos(sentencia);
                foreach (DataRow row in dt.Rows)
                {
                    // LLENAMOS LOS CAMPOS CON EL REGISTRO CONSULTADO

                    txtNombreProducto.Text = row[1].ToString();
                    txtCodRef.Text = row[2].ToString();
                    txtPrecioCompra.Text = row[3].ToString();
                    txtPrecioVenta.Text = row[4].ToString();
                    txtCantStock.Text = row[8].ToString();
                    cboCategoria.SelectedValue = row[5].ToString();
                    txbDetalle.Text = row[6].ToString();
                }
            }
        }
        private void btnActualizar_Click(object sender, EventArgs e)
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
                        string sentencia = $"Exec actualizar_Producto {IdProducto},'{txtNombreProducto.Text}','{txtCodRef.Text}'," +
                        $"{txtPrecioCompra.Text},{txtPrecioVenta.Text},'{cboCategoria.SelectedValue}','{txbDetalle.Text}'," +
                        $"'Ninguna',{txtCantStock.Text},'Juan','{DateTime.Now.ToShortDateString()}'";

                    productos.C_IdProducto = IdProducto;
                    productos.C_StrNombre = txtNombreProducto.Text;
                    productos.C_StrCodigo = txtCodRef.Text;
                    productos.C_NumPrecioCompra = int.Parse(txtPrecioCompra.Text);
                    productos.C_NumPrecioVenta = int.Parse(txtPrecioVenta.Text);
                    productos.C_IdCategoria = int.Parse(cboCategoria.SelectedValue.ToString());
                    productos.C_StrDetalle = txbDetalle.Text;
                    productos.C_strFoto = "Ninguna";
                    productos.C_NumStock = int.Parse(txtCantStock.Text);
                    productos.C_DtmFechaModifica = DateTime.Now.ToShortDateString();
                    productos.C_StrUsuarioModifica = "Juan";
                    mensaje = productos.Actualizar_Producto();
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
           
            if (txtNombreProducto.Text == string.Empty)
            {
                MensajeError.SetError(txtNombreProducto, "Debe ingresar el nombre del producto");
                txtNombreProducto.Focus();
                errorCampos = false;
            }
            else { MensajeError.SetError(txtNombreProducto, string.Empty); }

            if (txtCodRef.Text == string.Empty)
            {
                MensajeError.SetError(txtCodRef, "Debe ingresar el codigo de referencia del producto");
                txtCodRef.Focus();
                errorCampos = false;
            }
            else { MensajeError.SetError(txtCodRef, string.Empty); }
            if (!esNumerico(txtPrecioCompra.Text))
            {
                MensajeError.SetError(txtPrecioCompra, "Debe ingresar valores numericos");
                txtPrecioCompra.Focus();
                return false;
            }
            else { MensajeError.SetError(txtPrecioCompra, string.Empty); }

            if (!esNumerico(txtPrecioVenta.Text))
            {
                MensajeError.SetError(txtPrecioVenta, "Debe ingresar valores numericos");
                txtPrecioVenta.Focus();
                return false;
            }
            else { MensajeError.SetError(txtPrecioVenta, string.Empty); }

            if (!esNumerico(txtCantStock.Text))
            {
                MensajeError.SetError(txtCantStock, "Debe ingresar valores numericos");
                txtCantStock.Focus();
                return false;
            }
            MensajeError.SetError(txtCantStock, string.Empty);
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

        private void llenar_combo_categoria()
        {
            DataTable dt = new DataTable();
            Cls_Categoria categoria = new Cls_Categoria(); // creamos un objeto con la clase categoria
            dt = categoria.Consulta_Categoria();
            cboCategoria.DataSource = dt;
            cboCategoria.DisplayMember = "StrDescripcion";
            cboCategoria.ValueMember = "IdCategoria";

           
        }


        private void lblSalir_Click(object sender, EventArgs e)
        {            
            this.Close();
        }

    }
}
