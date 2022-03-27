
namespace _Plantilla_Sistema_facturación_
{
    partial class frmEmpleados
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
            this.btnActuliazarEmpleado = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnSalirEmpleado = new MaterialSkin.Controls.MaterialRaisedButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtIdEmpleados = new System.Windows.Forms.TextBox();
            this.txtNombreEmpleado = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtDocumentoEmpleado = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtEmailEmpleado = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtDireccionEmpleado = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtTelefonoEmpleado = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtDatosAdicionales = new System.Windows.Forms.TextBox();
            this.lblDatosAdicionales = new MaterialSkin.Controls.MaterialLabel();
            this.dtpFechaRetiro = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.cboRolEmpleado = new System.Windows.Forms.ComboBox();
            this.lblFechaIngreso = new MaterialSkin.Controls.MaterialLabel();
            this.lblRolEmpleado = new MaterialSkin.Controls.MaterialLabel();
            this.lblFechaRetiro = new MaterialSkin.Controls.MaterialLabel();
            this.lblAdminEmpleados = new MaterialSkin.Controls.MaterialLabel();
            this.MensajeError = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MensajeError)).BeginInit();
            this.SuspendLayout();
            // 
            // btnActuliazarEmpleado
            // 
            this.btnActuliazarEmpleado.AutoSize = true;
            this.btnActuliazarEmpleado.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnActuliazarEmpleado.Depth = 0;
            this.btnActuliazarEmpleado.Icon = null;
            this.btnActuliazarEmpleado.Location = new System.Drawing.Point(267, 536);
            this.btnActuliazarEmpleado.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnActuliazarEmpleado.Name = "btnActuliazarEmpleado";
            this.btnActuliazarEmpleado.Primary = true;
            this.btnActuliazarEmpleado.Size = new System.Drawing.Size(103, 36);
            this.btnActuliazarEmpleado.TabIndex = 12;
            this.btnActuliazarEmpleado.Text = "ACTUALIZAR";
            this.btnActuliazarEmpleado.UseVisualStyleBackColor = true;
            this.btnActuliazarEmpleado.Click += new System.EventHandler(this.btnActuliazarEmpleado_Click);
            // 
            // btnSalirEmpleado
            // 
            this.btnSalirEmpleado.AutoSize = true;
            this.btnSalirEmpleado.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSalirEmpleado.Depth = 0;
            this.btnSalirEmpleado.Icon = null;
            this.btnSalirEmpleado.Location = new System.Drawing.Point(560, 536);
            this.btnSalirEmpleado.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalirEmpleado.Name = "btnSalirEmpleado";
            this.btnSalirEmpleado.Primary = true;
            this.btnSalirEmpleado.Size = new System.Drawing.Size(58, 36);
            this.btnSalirEmpleado.TabIndex = 13;
            this.btnSalirEmpleado.Text = "SALIR";
            this.btnSalirEmpleado.UseVisualStyleBackColor = true;
            this.btnSalirEmpleado.Click += new System.EventHandler(this.btnSalirEmpleado_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtIdEmpleados);
            this.groupBox1.Controls.Add(this.txtNombreEmpleado);
            this.groupBox1.Controls.Add(this.txtDocumentoEmpleado);
            this.groupBox1.Controls.Add(this.txtEmailEmpleado);
            this.groupBox1.Controls.Add(this.txtDireccionEmpleado);
            this.groupBox1.Controls.Add(this.txtTelefonoEmpleado);
            this.groupBox1.Controls.Add(this.txtDatosAdicionales);
            this.groupBox1.Controls.Add(this.lblDatosAdicionales);
            this.groupBox1.Controls.Add(this.dtpFechaRetiro);
            this.groupBox1.Controls.Add(this.dtpFechaIngreso);
            this.groupBox1.Controls.Add(this.cboRolEmpleado);
            this.groupBox1.Controls.Add(this.lblFechaIngreso);
            this.groupBox1.Controls.Add(this.lblRolEmpleado);
            this.groupBox1.Controls.Add(this.lblFechaRetiro);
            this.groupBox1.Location = new System.Drawing.Point(52, 132);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(811, 381);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // txtIdEmpleados
            // 
            this.txtIdEmpleados.Location = new System.Drawing.Point(22, 34);
            this.txtIdEmpleados.Name = "txtIdEmpleados";
            this.txtIdEmpleados.Size = new System.Drawing.Size(36, 20);
            this.txtIdEmpleados.TabIndex = 17;
            // 
            // txtNombreEmpleado
            // 
            this.txtNombreEmpleado.Depth = 0;
            this.txtNombreEmpleado.Hint = "Nombre Empleado";
            this.txtNombreEmpleado.Location = new System.Drawing.Point(22, 70);
            this.txtNombreEmpleado.MaxLength = 32767;
            this.txtNombreEmpleado.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNombreEmpleado.Name = "txtNombreEmpleado";
            this.txtNombreEmpleado.PasswordChar = '\0';
            this.txtNombreEmpleado.SelectedText = "";
            this.txtNombreEmpleado.SelectionLength = 0;
            this.txtNombreEmpleado.SelectionStart = 0;
            this.txtNombreEmpleado.Size = new System.Drawing.Size(420, 23);
            this.txtNombreEmpleado.TabIndex = 12;
            this.txtNombreEmpleado.TabStop = false;
            this.txtNombreEmpleado.UseSystemPasswordChar = false;
            // 
            // txtDocumentoEmpleado
            // 
            this.txtDocumentoEmpleado.Depth = 0;
            this.txtDocumentoEmpleado.Hint = "Documento";
            this.txtDocumentoEmpleado.Location = new System.Drawing.Point(22, 110);
            this.txtDocumentoEmpleado.MaxLength = 32767;
            this.txtDocumentoEmpleado.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDocumentoEmpleado.Name = "txtDocumentoEmpleado";
            this.txtDocumentoEmpleado.PasswordChar = '\0';
            this.txtDocumentoEmpleado.SelectedText = "";
            this.txtDocumentoEmpleado.SelectionLength = 0;
            this.txtDocumentoEmpleado.SelectionStart = 0;
            this.txtDocumentoEmpleado.Size = new System.Drawing.Size(420, 23);
            this.txtDocumentoEmpleado.TabIndex = 13;
            this.txtDocumentoEmpleado.TabStop = false;
            this.txtDocumentoEmpleado.UseSystemPasswordChar = false;
            // 
            // txtEmailEmpleado
            // 
            this.txtEmailEmpleado.Depth = 0;
            this.txtEmailEmpleado.Hint = "Email";
            this.txtEmailEmpleado.Location = new System.Drawing.Point(22, 232);
            this.txtEmailEmpleado.MaxLength = 32767;
            this.txtEmailEmpleado.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtEmailEmpleado.Name = "txtEmailEmpleado";
            this.txtEmailEmpleado.PasswordChar = '\0';
            this.txtEmailEmpleado.SelectedText = "";
            this.txtEmailEmpleado.SelectionLength = 0;
            this.txtEmailEmpleado.SelectionStart = 0;
            this.txtEmailEmpleado.Size = new System.Drawing.Size(420, 23);
            this.txtEmailEmpleado.TabIndex = 16;
            this.txtEmailEmpleado.TabStop = false;
            this.txtEmailEmpleado.UseSystemPasswordChar = false;
            // 
            // txtDireccionEmpleado
            // 
            this.txtDireccionEmpleado.Depth = 0;
            this.txtDireccionEmpleado.Hint = "Direccion";
            this.txtDireccionEmpleado.Location = new System.Drawing.Point(22, 149);
            this.txtDireccionEmpleado.MaxLength = 32767;
            this.txtDireccionEmpleado.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDireccionEmpleado.Name = "txtDireccionEmpleado";
            this.txtDireccionEmpleado.PasswordChar = '\0';
            this.txtDireccionEmpleado.SelectedText = "";
            this.txtDireccionEmpleado.SelectionLength = 0;
            this.txtDireccionEmpleado.SelectionStart = 0;
            this.txtDireccionEmpleado.Size = new System.Drawing.Size(420, 23);
            this.txtDireccionEmpleado.TabIndex = 14;
            this.txtDireccionEmpleado.TabStop = false;
            this.txtDireccionEmpleado.UseSystemPasswordChar = false;
            // 
            // txtTelefonoEmpleado
            // 
            this.txtTelefonoEmpleado.Depth = 0;
            this.txtTelefonoEmpleado.Hint = "Telefono";
            this.txtTelefonoEmpleado.Location = new System.Drawing.Point(22, 190);
            this.txtTelefonoEmpleado.MaxLength = 32767;
            this.txtTelefonoEmpleado.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtTelefonoEmpleado.Name = "txtTelefonoEmpleado";
            this.txtTelefonoEmpleado.PasswordChar = '\0';
            this.txtTelefonoEmpleado.SelectedText = "";
            this.txtTelefonoEmpleado.SelectionLength = 0;
            this.txtTelefonoEmpleado.SelectionStart = 0;
            this.txtTelefonoEmpleado.Size = new System.Drawing.Size(420, 23);
            this.txtTelefonoEmpleado.TabIndex = 15;
            this.txtTelefonoEmpleado.TabStop = false;
            this.txtTelefonoEmpleado.UseSystemPasswordChar = false;
            // 
            // txtDatosAdicionales
            // 
            this.txtDatosAdicionales.Location = new System.Drawing.Point(490, 224);
            this.txtDatosAdicionales.Multiline = true;
            this.txtDatosAdicionales.Name = "txtDatosAdicionales";
            this.txtDatosAdicionales.Size = new System.Drawing.Size(296, 138);
            this.txtDatosAdicionales.TabIndex = 9;
            // 
            // lblDatosAdicionales
            // 
            this.lblDatosAdicionales.AutoSize = true;
            this.lblDatosAdicionales.Depth = 0;
            this.lblDatosAdicionales.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblDatosAdicionales.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDatosAdicionales.Location = new System.Drawing.Point(486, 176);
            this.lblDatosAdicionales.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDatosAdicionales.Name = "lblDatosAdicionales";
            this.lblDatosAdicionales.Size = new System.Drawing.Size(156, 19);
            this.lblDatosAdicionales.TabIndex = 8;
            this.lblDatosAdicionales.Text = "DATOS ADICIONALES";
            // 
            // dtpFechaRetiro
            // 
            this.dtpFechaRetiro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaRetiro.Location = new System.Drawing.Point(592, 125);
            this.dtpFechaRetiro.Name = "dtpFechaRetiro";
            this.dtpFechaRetiro.Size = new System.Drawing.Size(140, 20);
            this.dtpFechaRetiro.TabIndex = 7;
            // 
            // dtpFechaIngreso
            // 
            this.dtpFechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaIngreso.Location = new System.Drawing.Point(594, 81);
            this.dtpFechaIngreso.Name = "dtpFechaIngreso";
            this.dtpFechaIngreso.Size = new System.Drawing.Size(140, 20);
            this.dtpFechaIngreso.TabIndex = 6;
            // 
            // cboRolEmpleado
            // 
            this.cboRolEmpleado.FormattingEnabled = true;
            this.cboRolEmpleado.Location = new System.Drawing.Point(594, 34);
            this.cboRolEmpleado.Name = "cboRolEmpleado";
            this.cboRolEmpleado.Size = new System.Drawing.Size(121, 21);
            this.cboRolEmpleado.TabIndex = 5;
            // 
            // lblFechaIngreso
            // 
            this.lblFechaIngreso.AutoSize = true;
            this.lblFechaIngreso.Depth = 0;
            this.lblFechaIngreso.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblFechaIngreso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblFechaIngreso.Location = new System.Drawing.Point(486, 81);
            this.lblFechaIngreso.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFechaIngreso.Name = "lblFechaIngreso";
            this.lblFechaIngreso.Size = new System.Drawing.Size(75, 19);
            this.lblFechaIngreso.TabIndex = 3;
            this.lblFechaIngreso.Text = "F. Ingreso";
            // 
            // lblRolEmpleado
            // 
            this.lblRolEmpleado.AutoSize = true;
            this.lblRolEmpleado.Depth = 0;
            this.lblRolEmpleado.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblRolEmpleado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblRolEmpleado.Location = new System.Drawing.Point(486, 37);
            this.lblRolEmpleado.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblRolEmpleado.Name = "lblRolEmpleado";
            this.lblRolEmpleado.Size = new System.Drawing.Size(102, 19);
            this.lblRolEmpleado.TabIndex = 2;
            this.lblRolEmpleado.Text = "Rol Empleado";
            // 
            // lblFechaRetiro
            // 
            this.lblFechaRetiro.AutoSize = true;
            this.lblFechaRetiro.Depth = 0;
            this.lblFechaRetiro.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblFechaRetiro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblFechaRetiro.Location = new System.Drawing.Point(486, 125);
            this.lblFechaRetiro.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFechaRetiro.Name = "lblFechaRetiro";
            this.lblFechaRetiro.Size = new System.Drawing.Size(65, 19);
            this.lblFechaRetiro.TabIndex = 1;
            this.lblFechaRetiro.Text = "F. Retiro";
            // 
            // lblAdminEmpleados
            // 
            this.lblAdminEmpleados.AutoSize = true;
            this.lblAdminEmpleados.Depth = 0;
            this.lblAdminEmpleados.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblAdminEmpleados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblAdminEmpleados.Location = new System.Drawing.Point(335, 73);
            this.lblAdminEmpleados.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblAdminEmpleados.Name = "lblAdminEmpleados";
            this.lblAdminEmpleados.Size = new System.Drawing.Size(224, 19);
            this.lblAdminEmpleados.TabIndex = 10;
            this.lblAdminEmpleados.Text = "ADMINISTRACION EMPLEADOS";
            // 
            // MensajeError
            // 
            this.MensajeError.ContainerControl = this;
            // 
            // frmEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 586);
            this.Controls.Add(this.btnActuliazarEmpleado);
            this.Controls.Add(this.btnSalirEmpleado);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblAdminEmpleados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEmpleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEmpleados";
            this.Load += new System.EventHandler(this.frmEmpleados_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MensajeError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton btnActuliazarEmpleado;
        private MaterialSkin.Controls.MaterialRaisedButton btnSalirEmpleado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpFechaRetiro;
        private System.Windows.Forms.DateTimePicker dtpFechaIngreso;
        private System.Windows.Forms.ComboBox cboRolEmpleado;
        private MaterialSkin.Controls.MaterialLabel lblFechaIngreso;
        private MaterialSkin.Controls.MaterialLabel lblRolEmpleado;
        private MaterialSkin.Controls.MaterialLabel lblFechaRetiro;
        private MaterialSkin.Controls.MaterialLabel lblAdminEmpleados;
        private MaterialSkin.Controls.MaterialLabel lblDatosAdicionales;
        private System.Windows.Forms.TextBox txtDatosAdicionales;
        private System.Windows.Forms.TextBox txtIdEmpleados;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNombreEmpleado;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDocumentoEmpleado;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtEmailEmpleado;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDireccionEmpleado;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtTelefonoEmpleado;
        private System.Windows.Forms.ErrorProvider MensajeError;
    }
}