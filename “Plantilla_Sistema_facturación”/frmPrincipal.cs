using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace _Plantilla_Sistema_facturación_
{
    public partial class frmPrincipal : MaterialForm
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        public void AbrirForm(Form formHijo)
        {
            if (this.pnlContenedor.Controls.Count > 0)
                this.pnlContenedor.Controls.RemoveAt(0);
            formHijo.TopLevel = false;
            formHijo.Dock = DockStyle.Fill;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;
            this.pnlContenedor.Controls.Add(formHijo);
            formHijo.Show();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            frmListaClientes ListaClientes = new frmListaClientes();
            AbrirForm(ListaClientes);
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            frmListaProductos productos = new frmListaProductos();
            AbrirForm(productos);
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
           frmListaCategoria Categorias = new frmListaCategoria();
            AbrirForm(Categorias);
        }

        private void btnFacturas_Click(object sender, EventArgs e)
        {
            frmListaFacturas Facturas = new frmListaFacturas();
            AbrirForm(Facturas);
        }

        private void btnInformes_Click(object sender, EventArgs e)
        {
            frmInformes Informes = new frmInformes();
            AbrirForm(Informes);
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
             frmListaEmpleados   Empleados = new frmListaEmpleados();
             AbrirForm(Empleados);
        }

        private void btnRoles_Click(object sender, EventArgs e)
        {
            frmListaRol Rol = new frmListaRol();
            AbrirForm(Rol);
        }

        private void btnSeguridad_Click(object sender, EventArgs e)
        {
            frmAdminSeguridad Seguridad = new frmAdminSeguridad();
            AbrirForm(Seguridad);
        }

        private void btnSalirPrincipal_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            frmAyuda ayuda = new frmAyuda();
            AbrirForm(ayuda);
        }

        private void btnAcercaDe_Click(object sender, EventArgs e)
        {
            frmAcercaDe acercaDe = new frmAcercaDe();
            AbrirForm(acercaDe);
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            //this.MaximumSize = SystemInformation.PrimaryMonitorMaximizedWindowSize;
            //this.WindowState = FormWindowState.Maximized;
            // pnlContenedor.MaximumSize
        }
    }
}
