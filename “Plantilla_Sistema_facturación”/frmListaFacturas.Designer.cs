
namespace _Plantilla_Sistema_facturación_
{
    partial class frmListaFacturas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnSalirFactura = new MaterialSkin.Controls.MaterialRaisedButton();
            this.dgvFacturas = new System.Windows.Forms.DataGridView();
            this.intNroFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strFechaRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEditar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnBorrar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnFacturaNuevo = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnBuscarFactura = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtBuscarFactura = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblAdminProductos = new MaterialSkin.Controls.MaterialLabel();
            this.MensajeError = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MensajeError)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalirFactura
            // 
            this.btnSalirFactura.AutoSize = true;
            this.btnSalirFactura.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSalirFactura.Depth = 0;
            this.btnSalirFactura.Icon = null;
            this.btnSalirFactura.Location = new System.Drawing.Point(862, 413);
            this.btnSalirFactura.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalirFactura.Name = "btnSalirFactura";
            this.btnSalirFactura.Primary = true;
            this.btnSalirFactura.Size = new System.Drawing.Size(58, 36);
            this.btnSalirFactura.TabIndex = 19;
            this.btnSalirFactura.Text = "SALIR";
            this.btnSalirFactura.UseVisualStyleBackColor = true;
            this.btnSalirFactura.Click += new System.EventHandler(this.btnSalirProducto_Click);
            // 
            // dgvFacturas
            // 
            this.dgvFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFacturas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.intNroFactura,
            this.strFechaRegistro,
            this.strCliente,
            this.strEmpleado,
            this.strEstado,
            this.btnEditar,
            this.btnBorrar});
            this.dgvFacturas.Location = new System.Drawing.Point(28, 257);
            this.dgvFacturas.Name = "dgvFacturas";
            this.dgvFacturas.Size = new System.Drawing.Size(892, 150);
            this.dgvFacturas.TabIndex = 18;
            this.dgvFacturas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFacturas_CellContentClick);
            // 
            // intNroFactura
            // 
            this.intNroFactura.HeaderText = "NRO. FACTURA";
            this.intNroFactura.Name = "intNroFactura";
            this.intNroFactura.Width = 80;
            // 
            // strFechaRegistro
            // 
            this.strFechaRegistro.HeaderText = "FECHA REGISTRO";
            this.strFechaRegistro.Name = "strFechaRegistro";
            this.strFechaRegistro.Width = 120;
            // 
            // strCliente
            // 
            this.strCliente.HeaderText = "CLIENTE";
            this.strCliente.Name = "strCliente";
            this.strCliente.Width = 250;
            // 
            // strEmpleado
            // 
            this.strEmpleado.HeaderText = "EMPLEADO";
            this.strEmpleado.Name = "strEmpleado";
            this.strEmpleado.Width = 220;
            // 
            // strEstado
            // 
            this.strEstado.HeaderText = "ESTADO FACTURA";
            this.strEstado.Name = "strEstado";
            // 
            // btnEditar
            // 
            this.btnEditar.HeaderText = "EDITAR";
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnEditar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseColumnTextForButtonValue = true;
            this.btnEditar.Width = 80;
            // 
            // btnBorrar
            // 
            this.btnBorrar.HeaderText = "BORRAR";
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnBorrar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btnBorrar.Text = "BORRAR";
            this.btnBorrar.UseColumnTextForButtonValue = true;
            this.btnBorrar.Width = 80;
            // 
            // btnFacturaNuevo
            // 
            this.btnFacturaNuevo.AutoSize = true;
            this.btnFacturaNuevo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFacturaNuevo.Depth = 0;
            this.btnFacturaNuevo.Icon = null;
            this.btnFacturaNuevo.Location = new System.Drawing.Point(854, 215);
            this.btnFacturaNuevo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnFacturaNuevo.Name = "btnFacturaNuevo";
            this.btnFacturaNuevo.Primary = true;
            this.btnFacturaNuevo.Size = new System.Drawing.Size(66, 36);
            this.btnFacturaNuevo.TabIndex = 17;
            this.btnFacturaNuevo.Text = "NUEVO";
            this.btnFacturaNuevo.UseVisualStyleBackColor = true;
            this.btnFacturaNuevo.Click += new System.EventHandler(this.btnProductoNuevo_Click);
            // 
            // btnBuscarFactura
            // 
            this.btnBuscarFactura.AutoSize = true;
            this.btnBuscarFactura.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBuscarFactura.Depth = 0;
            this.btnBuscarFactura.Icon = null;
            this.btnBuscarFactura.Location = new System.Drawing.Point(371, 215);
            this.btnBuscarFactura.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBuscarFactura.Name = "btnBuscarFactura";
            this.btnBuscarFactura.Primary = true;
            this.btnBuscarFactura.Size = new System.Drawing.Size(74, 36);
            this.btnBuscarFactura.TabIndex = 16;
            this.btnBuscarFactura.Text = "BUSCAR";
            this.btnBuscarFactura.UseVisualStyleBackColor = true;
            this.btnBuscarFactura.Click += new System.EventHandler(this.btnBuscarFactura_Click);
            // 
            // txtBuscarFactura
            // 
            this.txtBuscarFactura.Depth = 0;
            this.txtBuscarFactura.Hint = "Buscar Factura por Cliente";
            this.txtBuscarFactura.Location = new System.Drawing.Point(28, 228);
            this.txtBuscarFactura.MaxLength = 32767;
            this.txtBuscarFactura.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBuscarFactura.Name = "txtBuscarFactura";
            this.txtBuscarFactura.PasswordChar = '\0';
            this.txtBuscarFactura.SelectedText = "";
            this.txtBuscarFactura.SelectionLength = 0;
            this.txtBuscarFactura.SelectionStart = 0;
            this.txtBuscarFactura.Size = new System.Drawing.Size(321, 23);
            this.txtBuscarFactura.TabIndex = 15;
            this.txtBuscarFactura.TabStop = false;
            this.txtBuscarFactura.UseSystemPasswordChar = false;
            // 
            // lblAdminProductos
            // 
            this.lblAdminProductos.AutoSize = true;
            this.lblAdminProductos.Depth = 0;
            this.lblAdminProductos.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblAdminProductos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblAdminProductos.Location = new System.Drawing.Point(349, 78);
            this.lblAdminProductos.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblAdminProductos.Name = "lblAdminProductos";
            this.lblAdminProductos.Size = new System.Drawing.Size(212, 19);
            this.lblAdminProductos.TabIndex = 20;
            this.lblAdminProductos.Text = "ADMINISTRACION FACTURAS";
            // 
            // MensajeError
            // 
            this.MensajeError.ContainerControl = this;
            // 
            // frmListaFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 500);
            this.Controls.Add(this.lblAdminProductos);
            this.Controls.Add(this.btnSalirFactura);
            this.Controls.Add(this.dgvFacturas);
            this.Controls.Add(this.btnFacturaNuevo);
            this.Controls.Add(this.btnBuscarFactura);
            this.Controls.Add(this.txtBuscarFactura);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmListaFacturas";
            this.Text = "frmListaFacturas";
            this.Load += new System.EventHandler(this.frmListaFacturas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MensajeError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton btnSalirFactura;
        private System.Windows.Forms.DataGridView dgvFacturas;
        private MaterialSkin.Controls.MaterialRaisedButton btnFacturaNuevo;
        private MaterialSkin.Controls.MaterialRaisedButton btnBuscarFactura;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBuscarFactura;
        private MaterialSkin.Controls.MaterialLabel lblAdminProductos;
        private System.Windows.Forms.ErrorProvider MensajeError;
        private System.Windows.Forms.DataGridViewTextBoxColumn intNroFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn strFechaRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn strCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn strEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn strEstado;
        private System.Windows.Forms.DataGridViewButtonColumn btnEditar;
        private System.Windows.Forms.DataGridViewButtonColumn btnBorrar;
    }
}