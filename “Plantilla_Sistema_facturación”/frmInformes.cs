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
    public partial class frmInformes : Form
    {
        public frmInformes()
        {
            InitializeComponent();
        }

       

        private void btnGenerarInforme_Click(object sender, EventArgs e)
        {
            errorProvider1.SetError(cxbFechaFin, "Seleccione un valor");
            errorProvider1.SetError(cxbSeleccionInforme, "Seleccione un valor");
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
