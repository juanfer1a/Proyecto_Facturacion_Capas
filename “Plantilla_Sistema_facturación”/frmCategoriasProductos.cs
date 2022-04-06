using System;
using System.Data;
using System.Windows.Forms;
using Capa_LogicaDeNegocios;


namespace _Plantilla_Sistema_facturación_
{
    public partial class frmCategoriasProductos : Form
    {
        public int IdCategoria { get; set; }
        public frmCategoriasProductos()
        {
            InitializeComponent();
        }
        private void frmCategoriasProductos_Load(object sender, EventArgs e)
        {
            Llenar_Categoria();
        }

        DataTable dt = new DataTable(); // CREAMOS EL OBJETO DE TIPO DATATABLE PARA ALMACENAR LO CONSULTADO
        Cls_Categoria categoria = new Cls_Categoria();



        private void btnActualizarCatProduc_Click(object sender, EventArgs e)
        {
            Guardar();

        }

        public void Llenar_Categoria()
        {
            if (IdCategoria == 0)
            {//Registro nuevo
                lblCatProduc.Text = "INGRESO NUEVO PRODUCTO";
            }
            else
            {//Actulizar cliente
             //ACTUALIZAR EL REGISTRO CON EL ID PASADO
                dt = categoria.Consulta_Categoria(IdCategoria); // CONSULTO REGISTRO DEL iDcLIENTE

                // dt = Acceso.EjecutarComandoDatos(sentencia);
                foreach (DataRow row in dt.Rows)
                {
                    // LLENAMOS LOS CAMPOS CON EL REGISTRO CONSULTADO

                    txtNombreCategoria.Text = row[1].ToString();

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
                    categoria.C_IdCategoria = IdCategoria;
                    categoria.C_StrDescripcion = txtNombreCategoria.Text;
                    categoria.C_DtmFechaModifica = DateTime.Now.ToShortDateString();
                    categoria.C_StrUsuarioModifico = "Juan";
                    mensaje = categoria.Actualizar_Categoria();
                    MessageBox.Show(mensaje);
                    txtNombreCategoria.Clear();

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

            if (txtNombreCategoria.Text == string.Empty)
            {
                MensajeError.SetError(txtNombreCategoria, "Debe ingresar el nombre del producto");
                txtNombreCategoria.Focus();
                errorCampos = false;
            }
            else { MensajeError.SetError(txtNombreCategoria, string.Empty); }


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

        private void btnSalirCatProduc_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
