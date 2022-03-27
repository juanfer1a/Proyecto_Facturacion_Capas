
namespace _Plantilla_Sistema_facturación_
{
    partial class frmProductos
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
            this.txbIdProducto = new System.Windows.Forms.TextBox();
            this.lblSalir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnActualizar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtCantStock = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtPrecioVenta = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtPrecioCompra = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtCodRef = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtNombreProducto = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.lblCategoria = new MaterialSkin.Controls.MaterialLabel();
            this.lblDetalleProduc = new MaterialSkin.Controls.MaterialLabel();
            this.txbDetalle = new System.Windows.Forms.TextBox();
            this.grbAdminProductos = new System.Windows.Forms.GroupBox();
            this.MensajeError = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblTituloProducto = new MaterialSkin.Controls.MaterialLabel();
            this.grbAdminProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MensajeError)).BeginInit();
            this.SuspendLayout();
            // 
            // txbIdProducto
            // 
            this.txbIdProducto.Location = new System.Drawing.Point(31, 26);
            this.txbIdProducto.Name = "txbIdProducto";
            this.txbIdProducto.Size = new System.Drawing.Size(36, 20);
            this.txbIdProducto.TabIndex = 20;
            // 
            // lblSalir
            // 
            this.lblSalir.AutoSize = true;
            this.lblSalir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.lblSalir.Depth = 0;
            this.lblSalir.Icon = null;
            this.lblSalir.Location = new System.Drawing.Point(495, 388);
            this.lblSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblSalir.Name = "lblSalir";
            this.lblSalir.Primary = true;
            this.lblSalir.Size = new System.Drawing.Size(58, 36);
            this.lblSalir.TabIndex = 19;
            this.lblSalir.Text = "SALIR";
            this.lblSalir.UseVisualStyleBackColor = true;
            this.lblSalir.Click += new System.EventHandler(this.lblSalir_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.AutoSize = true;
            this.btnActualizar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnActualizar.Depth = 0;
            this.btnActualizar.Icon = null;
            this.btnActualizar.Location = new System.Drawing.Point(310, 388);
            this.btnActualizar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Primary = true;
            this.btnActualizar.Size = new System.Drawing.Size(103, 36);
            this.btnActualizar.TabIndex = 18;
            this.btnActualizar.Text = "ACTUALIZAR";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // txtCantStock
            // 
            this.txtCantStock.Depth = 0;
            this.txtCantStock.Hint = "Cantidad Stock";
            this.txtCantStock.Location = new System.Drawing.Point(31, 224);
            this.txtCantStock.MaxLength = 32767;
            this.txtCantStock.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCantStock.Name = "txtCantStock";
            this.txtCantStock.PasswordChar = '\0';
            this.txtCantStock.SelectedText = "";
            this.txtCantStock.SelectionLength = 0;
            this.txtCantStock.SelectionStart = 0;
            this.txtCantStock.Size = new System.Drawing.Size(420, 23);
            this.txtCantStock.TabIndex = 17;
            this.txtCantStock.TabStop = false;
            this.txtCantStock.UseSystemPasswordChar = false;
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.Depth = 0;
            this.txtPrecioVenta.Hint = "Precio de venta";
            this.txtPrecioVenta.Location = new System.Drawing.Point(31, 182);
            this.txtPrecioVenta.MaxLength = 32767;
            this.txtPrecioVenta.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.PasswordChar = '\0';
            this.txtPrecioVenta.SelectedText = "";
            this.txtPrecioVenta.SelectionLength = 0;
            this.txtPrecioVenta.SelectionStart = 0;
            this.txtPrecioVenta.Size = new System.Drawing.Size(420, 23);
            this.txtPrecioVenta.TabIndex = 16;
            this.txtPrecioVenta.TabStop = false;
            this.txtPrecioVenta.UseSystemPasswordChar = false;
            // 
            // txtPrecioCompra
            // 
            this.txtPrecioCompra.Depth = 0;
            this.txtPrecioCompra.Hint = "Precio de compra";
            this.txtPrecioCompra.Location = new System.Drawing.Point(31, 141);
            this.txtPrecioCompra.MaxLength = 32767;
            this.txtPrecioCompra.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPrecioCompra.Name = "txtPrecioCompra";
            this.txtPrecioCompra.PasswordChar = '\0';
            this.txtPrecioCompra.SelectedText = "";
            this.txtPrecioCompra.SelectionLength = 0;
            this.txtPrecioCompra.SelectionStart = 0;
            this.txtPrecioCompra.Size = new System.Drawing.Size(420, 23);
            this.txtPrecioCompra.TabIndex = 15;
            this.txtPrecioCompra.TabStop = false;
            this.txtPrecioCompra.UseSystemPasswordChar = false;
            // 
            // txtCodRef
            // 
            this.txtCodRef.Depth = 0;
            this.txtCodRef.Hint = "Codigo Referencia";
            this.txtCodRef.Location = new System.Drawing.Point(31, 102);
            this.txtCodRef.MaxLength = 32767;
            this.txtCodRef.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCodRef.Name = "txtCodRef";
            this.txtCodRef.PasswordChar = '\0';
            this.txtCodRef.SelectedText = "";
            this.txtCodRef.SelectionLength = 0;
            this.txtCodRef.SelectionStart = 0;
            this.txtCodRef.Size = new System.Drawing.Size(420, 23);
            this.txtCodRef.TabIndex = 14;
            this.txtCodRef.TabStop = false;
            this.txtCodRef.UseSystemPasswordChar = false;
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Depth = 0;
            this.txtNombreProducto.Hint = "Nombre Producto";
            this.txtNombreProducto.Location = new System.Drawing.Point(31, 62);
            this.txtNombreProducto.MaxLength = 32767;
            this.txtNombreProducto.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.PasswordChar = '\0';
            this.txtNombreProducto.SelectedText = "";
            this.txtNombreProducto.SelectionLength = 0;
            this.txtNombreProducto.SelectionStart = 0;
            this.txtNombreProducto.Size = new System.Drawing.Size(420, 23);
            this.txtNombreProducto.TabIndex = 13;
            this.txtNombreProducto.TabStop = false;
            this.txtNombreProducto.UseSystemPasswordChar = false;
            // 
            // cboCategoria
            // 
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(630, 64);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(121, 21);
            this.cboCategoria.TabIndex = 21;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Depth = 0;
            this.lblCategoria.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCategoria.Location = new System.Drawing.Point(538, 66);
            this.lblCategoria.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(74, 19);
            this.lblCategoria.TabIndex = 22;
            this.lblCategoria.Text = "Categoria";
            // 
            // lblDetalleProduc
            // 
            this.lblDetalleProduc.AutoSize = true;
            this.lblDetalleProduc.Depth = 0;
            this.lblDetalleProduc.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblDetalleProduc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDetalleProduc.Location = new System.Drawing.Point(538, 146);
            this.lblDetalleProduc.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDetalleProduc.Name = "lblDetalleProduc";
            this.lblDetalleProduc.Size = new System.Drawing.Size(121, 19);
            this.lblDetalleProduc.TabIndex = 24;
            this.lblDetalleProduc.Text = "Detalle Producto";
            // 
            // txbDetalle
            // 
            this.txbDetalle.Location = new System.Drawing.Point(542, 177);
            this.txbDetalle.Multiline = true;
            this.txbDetalle.Name = "txbDetalle";
            this.txbDetalle.Size = new System.Drawing.Size(307, 78);
            this.txbDetalle.TabIndex = 25;
            // 
            // grbAdminProductos
            // 
            this.grbAdminProductos.Controls.Add(this.txtNombreProducto);
            this.grbAdminProductos.Controls.Add(this.txbDetalle);
            this.grbAdminProductos.Controls.Add(this.lblDetalleProduc);
            this.grbAdminProductos.Controls.Add(this.txtCodRef);
            this.grbAdminProductos.Controls.Add(this.txtPrecioCompra);
            this.grbAdminProductos.Controls.Add(this.cboCategoria);
            this.grbAdminProductos.Controls.Add(this.lblCategoria);
            this.grbAdminProductos.Controls.Add(this.txtPrecioVenta);
            this.grbAdminProductos.Controls.Add(this.txtCantStock);
            this.grbAdminProductos.Controls.Add(this.txbIdProducto);
            this.grbAdminProductos.Location = new System.Drawing.Point(26, 79);
            this.grbAdminProductos.Name = "grbAdminProductos";
            this.grbAdminProductos.Size = new System.Drawing.Size(873, 283);
            this.grbAdminProductos.TabIndex = 26;
            this.grbAdminProductos.TabStop = false;
            // 
            // MensajeError
            // 
            this.MensajeError.ContainerControl = this;
            this.MensajeError.RightToLeftChanged += new System.EventHandler(this.btnActualizar_Click);
            // 
            // lblTituloProducto
            // 
            this.lblTituloProducto.AutoSize = true;
            this.lblTituloProducto.Depth = 0;
            this.lblTituloProducto.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTituloProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTituloProducto.Location = new System.Drawing.Point(403, 38);
            this.lblTituloProducto.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTituloProducto.Name = "lblTituloProducto";
            this.lblTituloProducto.Size = new System.Drawing.Size(223, 19);
            this.lblTituloProducto.TabIndex = 27;
            this.lblTituloProducto.Text = "ADMINISTRACION PRODUCTOS";
            // 
            // frmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 446);
            this.Controls.Add(this.lblTituloProducto);
            this.Controls.Add(this.grbAdminProductos);
            this.Controls.Add(this.lblSalir);
            this.Controls.Add(this.btnActualizar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmProductos_Load);
            this.grbAdminProductos.ResumeLayout(false);
            this.grbAdminProductos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MensajeError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbIdProducto;
        private MaterialSkin.Controls.MaterialRaisedButton lblSalir;
        private MaterialSkin.Controls.MaterialRaisedButton btnActualizar;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCantStock;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPrecioVenta;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPrecioCompra;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCodRef;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNombreProducto;
        private System.Windows.Forms.ComboBox cboCategoria;
        private MaterialSkin.Controls.MaterialLabel lblCategoria;
        private MaterialSkin.Controls.MaterialLabel lblDetalleProduc;
        private System.Windows.Forms.TextBox txbDetalle;
        private System.Windows.Forms.GroupBox grbAdminProductos;
        private System.Windows.Forms.ErrorProvider MensajeError;
        private MaterialSkin.Controls.MaterialLabel lblTituloProducto;
    }
}