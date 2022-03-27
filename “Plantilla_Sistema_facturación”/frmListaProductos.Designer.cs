
namespace _Plantilla_Sistema_facturación_
{
    partial class frmListaProductos
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
            this.btnSalirProducto = new MaterialSkin.Controls.MaterialRaisedButton();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.id_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strNombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intReferenciaProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intPrecioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intPrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEditarProducto = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnBorrar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnProductoNuevo = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnBuscarProducto = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtBuscarProductos = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblAdminProductos = new MaterialSkin.Controls.MaterialLabel();
            this.MensajeError = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MensajeError)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalirProducto
            // 
            this.btnSalirProducto.AutoSize = true;
            this.btnSalirProducto.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSalirProducto.Depth = 0;
            this.btnSalirProducto.Icon = null;
            this.btnSalirProducto.Location = new System.Drawing.Point(922, 369);
            this.btnSalirProducto.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalirProducto.Name = "btnSalirProducto";
            this.btnSalirProducto.Primary = true;
            this.btnSalirProducto.Size = new System.Drawing.Size(58, 36);
            this.btnSalirProducto.TabIndex = 14;
            this.btnSalirProducto.Text = "SALIR";
            this.btnSalirProducto.UseVisualStyleBackColor = true;
            this.btnSalirProducto.Click += new System.EventHandler(this.btnSalirProducto_Click);
            // 
            // dgvProductos
            // 
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_Cliente,
            this.strNombreProducto,
            this.intReferenciaProducto,
            this.intPrecioCompra,
            this.intPrecioVenta,
            this.intStock,
            this.btnEditarProducto,
            this.btnBorrar});
            this.dgvProductos.Location = new System.Drawing.Point(12, 213);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.Size = new System.Drawing.Size(968, 150);
            this.dgvProductos.TabIndex = 13;
            this.dgvProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellContentClick);
            // 
            // id_Cliente
            // 
            this.id_Cliente.HeaderText = "ID";
            this.id_Cliente.Name = "id_Cliente";
            this.id_Cliente.Width = 50;
            // 
            // strNombreProducto
            // 
            this.strNombreProducto.HeaderText = " NOMBRE PRODUCTO";
            this.strNombreProducto.Name = "strNombreProducto";
            this.strNombreProducto.Width = 300;
            // 
            // intReferenciaProducto
            // 
            this.intReferenciaProducto.HeaderText = "REFERENCIA";
            this.intReferenciaProducto.Name = "intReferenciaProducto";
            // 
            // intPrecioCompra
            // 
            this.intPrecioCompra.HeaderText = "PRECIO COMPRA";
            this.intPrecioCompra.Name = "intPrecioCompra";
            this.intPrecioCompra.Width = 130;
            // 
            // intPrecioVenta
            // 
            this.intPrecioVenta.HeaderText = "PRECIO VENTA";
            this.intPrecioVenta.Name = "intPrecioVenta";
            this.intPrecioVenta.Width = 110;
            // 
            // intStock
            // 
            this.intStock.HeaderText = "STOCK";
            this.intStock.Name = "intStock";
            this.intStock.Width = 70;
            // 
            // btnEditarProducto
            // 
            this.btnEditarProducto.HeaderText = "EDITAR";
            this.btnEditarProducto.Name = "btnEditarProducto";
            this.btnEditarProducto.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnEditarProducto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btnEditarProducto.Text = "EDITAR";
            this.btnEditarProducto.UseColumnTextForButtonValue = true;
            this.btnEditarProducto.Width = 80;
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
            // btnProductoNuevo
            // 
            this.btnProductoNuevo.AutoSize = true;
            this.btnProductoNuevo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnProductoNuevo.Depth = 0;
            this.btnProductoNuevo.Icon = null;
            this.btnProductoNuevo.Location = new System.Drawing.Point(914, 171);
            this.btnProductoNuevo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnProductoNuevo.Name = "btnProductoNuevo";
            this.btnProductoNuevo.Primary = true;
            this.btnProductoNuevo.Size = new System.Drawing.Size(66, 36);
            this.btnProductoNuevo.TabIndex = 12;
            this.btnProductoNuevo.Text = "NUEVO";
            this.btnProductoNuevo.UseVisualStyleBackColor = true;
            this.btnProductoNuevo.Click += new System.EventHandler(this.btnProductoNuevo_Click);
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.AutoSize = true;
            this.btnBuscarProducto.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBuscarProducto.Depth = 0;
            this.btnBuscarProducto.Icon = null;
            this.btnBuscarProducto.Location = new System.Drawing.Point(625, 171);
            this.btnBuscarProducto.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Primary = true;
            this.btnBuscarProducto.Size = new System.Drawing.Size(74, 36);
            this.btnBuscarProducto.TabIndex = 11;
            this.btnBuscarProducto.Text = "BUSCAR";
            this.btnBuscarProducto.UseVisualStyleBackColor = true;
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click);
            // 
            // txtBuscarProductos
            // 
            this.txtBuscarProductos.Depth = 0;
            this.txtBuscarProductos.Hint = "Buscar Producto";
            this.txtBuscarProductos.Location = new System.Drawing.Point(42, 184);
            this.txtBuscarProductos.MaxLength = 32767;
            this.txtBuscarProductos.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBuscarProductos.Name = "txtBuscarProductos";
            this.txtBuscarProductos.PasswordChar = '\0';
            this.txtBuscarProductos.SelectedText = "";
            this.txtBuscarProductos.SelectionLength = 0;
            this.txtBuscarProductos.SelectionStart = 0;
            this.txtBuscarProductos.Size = new System.Drawing.Size(475, 23);
            this.txtBuscarProductos.TabIndex = 10;
            this.txtBuscarProductos.TabStop = false;
            this.txtBuscarProductos.UseSystemPasswordChar = false;
            // 
            // lblAdminProductos
            // 
            this.lblAdminProductos.AutoSize = true;
            this.lblAdminProductos.Depth = 0;
            this.lblAdminProductos.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblAdminProductos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblAdminProductos.Location = new System.Drawing.Point(394, 72);
            this.lblAdminProductos.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblAdminProductos.Name = "lblAdminProductos";
            this.lblAdminProductos.Size = new System.Drawing.Size(223, 19);
            this.lblAdminProductos.TabIndex = 9;
            this.lblAdminProductos.Text = "ADMINISTRACION PRODUCTOS";
            // 
            // MensajeError
            // 
            this.MensajeError.ContainerControl = this;
            // 
            // frmListaProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 482);
            this.Controls.Add(this.btnSalirProducto);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.btnProductoNuevo);
            this.Controls.Add(this.btnBuscarProducto);
            this.Controls.Add(this.txtBuscarProductos);
            this.Controls.Add(this.lblAdminProductos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmListaProductos";
            this.Text = "frmListaProductos";
            this.Load += new System.EventHandler(this.frmListaProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MensajeError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton btnSalirProducto;
        private System.Windows.Forms.DataGridView dgvProductos;
        private MaterialSkin.Controls.MaterialRaisedButton btnProductoNuevo;
        private MaterialSkin.Controls.MaterialRaisedButton btnBuscarProducto;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBuscarProductos;
        private MaterialSkin.Controls.MaterialLabel lblAdminProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn strNombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn intReferenciaProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn intPrecioCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn intPrecioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn intStock;
        private System.Windows.Forms.DataGridViewButtonColumn btnEditarProducto;
        private System.Windows.Forms.DataGridViewButtonColumn btnBorrar;
        private System.Windows.Forms.ErrorProvider MensajeError;
    }
}