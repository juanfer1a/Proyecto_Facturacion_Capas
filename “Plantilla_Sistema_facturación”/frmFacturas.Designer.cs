
namespace _Plantilla_Sistema_facturación_
{
    partial class frmFacturas
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
            this.grbAdminClientes = new System.Windows.Forms.GroupBox();
            this.dtpFechaFactura = new System.Windows.Forms.DateTimePicker();
            this.cboEstadoFactura = new System.Windows.Forms.ComboBox();
            this.cboEmpleadoFactura = new System.Windows.Forms.ComboBox();
            this.cboClienteFactura = new System.Windows.Forms.ComboBox();
            this.txtTotalIva = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtTotalFactura = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtDescuento = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblCliente = new MaterialSkin.Controls.MaterialLabel();
            this.lblEmpleado = new MaterialSkin.Controls.MaterialLabel();
            this.lblFechaRegistro = new MaterialSkin.Controls.MaterialLabel();
            this.lblEstadoFactura = new MaterialSkin.Controls.MaterialLabel();
            this.lblNroFactura = new MaterialSkin.Controls.MaterialLabel();
            this.txbNroFactura = new System.Windows.Forms.TextBox();
            this.lblEditarFactura = new MaterialSkin.Controls.MaterialLabel();
            this.grbDetalleFactura = new System.Windows.Forms.GroupBox();
            this.txtDetalleFactura = new System.Windows.Forms.TextBox();
            this.lblSalirFactura = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnActualizarFactura = new MaterialSkin.Controls.MaterialRaisedButton();
            this.MensajeError = new System.Windows.Forms.ErrorProvider(this.components);
            this.grbAdminClientes.SuspendLayout();
            this.grbDetalleFactura.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MensajeError)).BeginInit();
            this.SuspendLayout();
            // 
            // grbAdminClientes
            // 
            this.grbAdminClientes.Controls.Add(this.dtpFechaFactura);
            this.grbAdminClientes.Controls.Add(this.cboEstadoFactura);
            this.grbAdminClientes.Controls.Add(this.cboEmpleadoFactura);
            this.grbAdminClientes.Controls.Add(this.cboClienteFactura);
            this.grbAdminClientes.Controls.Add(this.txtTotalIva);
            this.grbAdminClientes.Controls.Add(this.txtTotalFactura);
            this.grbAdminClientes.Controls.Add(this.txtDescuento);
            this.grbAdminClientes.Controls.Add(this.lblCliente);
            this.grbAdminClientes.Controls.Add(this.lblEmpleado);
            this.grbAdminClientes.Controls.Add(this.lblFechaRegistro);
            this.grbAdminClientes.Controls.Add(this.lblEstadoFactura);
            this.grbAdminClientes.Controls.Add(this.lblNroFactura);
            this.grbAdminClientes.Controls.Add(this.txbNroFactura);
            this.grbAdminClientes.Location = new System.Drawing.Point(26, 64);
            this.grbAdminClientes.Name = "grbAdminClientes";
            this.grbAdminClientes.Size = new System.Drawing.Size(718, 311);
            this.grbAdminClientes.TabIndex = 0;
            this.grbAdminClientes.TabStop = false;
            // 
            // dtpFechaFactura
            // 
            this.dtpFechaFactura.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFactura.Location = new System.Drawing.Point(512, 72);
            this.dtpFechaFactura.Name = "dtpFechaFactura";
            this.dtpFechaFactura.Size = new System.Drawing.Size(163, 20);
            this.dtpFechaFactura.TabIndex = 33;
            // 
            // cboEstadoFactura
            // 
            this.cboEstadoFactura.FormattingEnabled = true;
            this.cboEstadoFactura.Location = new System.Drawing.Point(512, 148);
            this.cboEstadoFactura.Name = "cboEstadoFactura";
            this.cboEstadoFactura.Size = new System.Drawing.Size(163, 21);
            this.cboEstadoFactura.TabIndex = 32;
            // 
            // cboEmpleadoFactura
            // 
            this.cboEmpleadoFactura.FormattingEnabled = true;
            this.cboEmpleadoFactura.Location = new System.Drawing.Point(150, 114);
            this.cboEmpleadoFactura.Name = "cboEmpleadoFactura";
            this.cboEmpleadoFactura.Size = new System.Drawing.Size(305, 21);
            this.cboEmpleadoFactura.TabIndex = 31;
            // 
            // cboClienteFactura
            // 
            this.cboClienteFactura.FormattingEnabled = true;
            this.cboClienteFactura.Location = new System.Drawing.Point(150, 78);
            this.cboClienteFactura.Name = "cboClienteFactura";
            this.cboClienteFactura.Size = new System.Drawing.Size(305, 21);
            this.cboClienteFactura.TabIndex = 30;
            // 
            // txtTotalIva
            // 
            this.txtTotalIva.Depth = 0;
            this.txtTotalIva.Hint = "Total Iva";
            this.txtTotalIva.Location = new System.Drawing.Point(35, 209);
            this.txtTotalIva.MaxLength = 32767;
            this.txtTotalIva.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtTotalIva.Name = "txtTotalIva";
            this.txtTotalIva.PasswordChar = '\0';
            this.txtTotalIva.SelectedText = "";
            this.txtTotalIva.SelectionLength = 0;
            this.txtTotalIva.SelectionStart = 0;
            this.txtTotalIva.Size = new System.Drawing.Size(268, 23);
            this.txtTotalIva.TabIndex = 29;
            this.txtTotalIva.TabStop = false;
            this.txtTotalIva.UseSystemPasswordChar = false;
            // 
            // txtTotalFactura
            // 
            this.txtTotalFactura.Depth = 0;
            this.txtTotalFactura.Hint = "Total factura";
            this.txtTotalFactura.Location = new System.Drawing.Point(35, 259);
            this.txtTotalFactura.MaxLength = 32767;
            this.txtTotalFactura.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtTotalFactura.Name = "txtTotalFactura";
            this.txtTotalFactura.PasswordChar = '\0';
            this.txtTotalFactura.SelectedText = "";
            this.txtTotalFactura.SelectionLength = 0;
            this.txtTotalFactura.SelectionStart = 0;
            this.txtTotalFactura.Size = new System.Drawing.Size(268, 23);
            this.txtTotalFactura.TabIndex = 28;
            this.txtTotalFactura.TabStop = false;
            this.txtTotalFactura.UseSystemPasswordChar = false;
            // 
            // txtDescuento
            // 
            this.txtDescuento.Depth = 0;
            this.txtDescuento.Hint = "Descuento";
            this.txtDescuento.Location = new System.Drawing.Point(35, 167);
            this.txtDescuento.MaxLength = 32767;
            this.txtDescuento.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.PasswordChar = '\0';
            this.txtDescuento.SelectedText = "";
            this.txtDescuento.SelectionLength = 0;
            this.txtDescuento.SelectionStart = 0;
            this.txtDescuento.Size = new System.Drawing.Size(268, 23);
            this.txtDescuento.TabIndex = 27;
            this.txtDescuento.TabStop = false;
            this.txtDescuento.UseSystemPasswordChar = false;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Depth = 0;
            this.lblCliente.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCliente.Location = new System.Drawing.Point(29, 77);
            this.lblCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(56, 19);
            this.lblCliente.TabIndex = 26;
            this.lblCliente.Text = "Cliente";
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.Depth = 0;
            this.lblEmpleado.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblEmpleado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblEmpleado.Location = new System.Drawing.Point(29, 117);
            this.lblEmpleado.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(76, 19);
            this.lblEmpleado.TabIndex = 25;
            this.lblEmpleado.Text = "Empleado";
            // 
            // lblFechaRegistro
            // 
            this.lblFechaRegistro.AutoSize = true;
            this.lblFechaRegistro.Depth = 0;
            this.lblFechaRegistro.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblFechaRegistro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblFechaRegistro.Location = new System.Drawing.Point(509, 50);
            this.lblFechaRegistro.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFechaRegistro.Name = "lblFechaRegistro";
            this.lblFechaRegistro.Size = new System.Drawing.Size(125, 19);
            this.lblFechaRegistro.TabIndex = 21;
            this.lblFechaRegistro.Text = "Fecha de registro";
            // 
            // lblEstadoFactura
            // 
            this.lblEstadoFactura.AutoSize = true;
            this.lblEstadoFactura.Depth = 0;
            this.lblEstadoFactura.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblEstadoFactura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblEstadoFactura.Location = new System.Drawing.Point(509, 117);
            this.lblEstadoFactura.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblEstadoFactura.Name = "lblEstadoFactura";
            this.lblEstadoFactura.Size = new System.Drawing.Size(107, 19);
            this.lblEstadoFactura.TabIndex = 20;
            this.lblEstadoFactura.Text = "Estado factura";
            // 
            // lblNroFactura
            // 
            this.lblNroFactura.AutoSize = true;
            this.lblNroFactura.Depth = 0;
            this.lblNroFactura.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblNroFactura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblNroFactura.Location = new System.Drawing.Point(29, 39);
            this.lblNroFactura.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNroFactura.Name = "lblNroFactura";
            this.lblNroFactura.Size = new System.Drawing.Size(88, 19);
            this.lblNroFactura.TabIndex = 19;
            this.lblNroFactura.Text = "Nro Factura";
            // 
            // txbNroFactura
            // 
            this.txbNroFactura.Location = new System.Drawing.Point(150, 37);
            this.txbNroFactura.Name = "txbNroFactura";
            this.txbNroFactura.Size = new System.Drawing.Size(155, 20);
            this.txbNroFactura.TabIndex = 18;
            // 
            // lblEditarFactura
            // 
            this.lblEditarFactura.AutoSize = true;
            this.lblEditarFactura.Depth = 0;
            this.lblEditarFactura.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblEditarFactura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblEditarFactura.Location = new System.Drawing.Point(398, 26);
            this.lblEditarFactura.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblEditarFactura.Name = "lblEditarFactura";
            this.lblEditarFactura.Size = new System.Drawing.Size(203, 19);
            this.lblEditarFactura.TabIndex = 12;
            this.lblEditarFactura.Text = "ADMINISTRACION FACTURA";
            // 
            // grbDetalleFactura
            // 
            this.grbDetalleFactura.Controls.Add(this.txtDetalleFactura);
            this.grbDetalleFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDetalleFactura.Location = new System.Drawing.Point(27, 394);
            this.grbDetalleFactura.Name = "grbDetalleFactura";
            this.grbDetalleFactura.Size = new System.Drawing.Size(717, 187);
            this.grbDetalleFactura.TabIndex = 1;
            this.grbDetalleFactura.TabStop = false;
            this.grbDetalleFactura.Text = "Detalle de la factura";
            // 
            // txtDetalleFactura
            // 
            this.txtDetalleFactura.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtDetalleFactura.Location = new System.Drawing.Point(21, 21);
            this.txtDetalleFactura.Multiline = true;
            this.txtDetalleFactura.Name = "txtDetalleFactura";
            this.txtDetalleFactura.Size = new System.Drawing.Size(671, 150);
            this.txtDetalleFactura.TabIndex = 0;
            // 
            // lblSalirFactura
            // 
            this.lblSalirFactura.AutoSize = true;
            this.lblSalirFactura.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.lblSalirFactura.Depth = 0;
            this.lblSalirFactura.Icon = null;
            this.lblSalirFactura.Location = new System.Drawing.Point(789, 469);
            this.lblSalirFactura.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblSalirFactura.Name = "lblSalirFactura";
            this.lblSalirFactura.Primary = true;
            this.lblSalirFactura.Size = new System.Drawing.Size(58, 36);
            this.lblSalirFactura.TabIndex = 12;
            this.lblSalirFactura.Text = "SALIR";
            this.lblSalirFactura.UseVisualStyleBackColor = true;
            this.lblSalirFactura.Click += new System.EventHandler(this.lblSalir_Click);
            // 
            // btnActualizarFactura
            // 
            this.btnActualizarFactura.AutoSize = true;
            this.btnActualizarFactura.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnActualizarFactura.Depth = 0;
            this.btnActualizarFactura.Icon = null;
            this.btnActualizarFactura.Location = new System.Drawing.Point(789, 151);
            this.btnActualizarFactura.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnActualizarFactura.Name = "btnActualizarFactura";
            this.btnActualizarFactura.Primary = true;
            this.btnActualizarFactura.Size = new System.Drawing.Size(103, 36);
            this.btnActualizarFactura.TabIndex = 11;
            this.btnActualizarFactura.Text = "ACTUALIZAR";
            this.btnActualizarFactura.UseVisualStyleBackColor = true;
            this.btnActualizarFactura.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // MensajeError
            // 
            this.MensajeError.ContainerControl = this;
            // 
            // frmFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 607);
            this.Controls.Add(this.lblSalirFactura);
            this.Controls.Add(this.btnActualizarFactura);
            this.Controls.Add(this.grbDetalleFactura);
            this.Controls.Add(this.grbAdminClientes);
            this.Controls.Add(this.lblEditarFactura);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFacturas";
            this.Text = "frmFacturas";
            this.Load += new System.EventHandler(this.frmFacturas_Load);
            this.grbAdminClientes.ResumeLayout(false);
            this.grbAdminClientes.PerformLayout();
            this.grbDetalleFactura.ResumeLayout(false);
            this.grbDetalleFactura.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MensajeError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbAdminClientes;
        private MaterialSkin.Controls.MaterialLabel lblNroFactura;
        private System.Windows.Forms.TextBox txbNroFactura;
        private MaterialSkin.Controls.MaterialLabel lblEditarFactura;
        private System.Windows.Forms.GroupBox grbDetalleFactura;
        private MaterialSkin.Controls.MaterialLabel lblCliente;
        private MaterialSkin.Controls.MaterialLabel lblEmpleado;
        private MaterialSkin.Controls.MaterialLabel lblFechaRegistro;
        private MaterialSkin.Controls.MaterialLabel lblEstadoFactura;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtTotalIva;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtTotalFactura;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDescuento;
        private System.Windows.Forms.ComboBox cboClienteFactura;
        private System.Windows.Forms.DateTimePicker dtpFechaFactura;
        private System.Windows.Forms.ComboBox cboEstadoFactura;
        private System.Windows.Forms.ComboBox cboEmpleadoFactura;
        private System.Windows.Forms.TextBox txtDetalleFactura;
        private MaterialSkin.Controls.MaterialRaisedButton lblSalirFactura;
        private MaterialSkin.Controls.MaterialRaisedButton btnActualizarFactura;
        private System.Windows.Forms.ErrorProvider MensajeError;
    }
}