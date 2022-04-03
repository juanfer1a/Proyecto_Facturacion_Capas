
namespace _Plantilla_Sistema_facturación_
{
    partial class frmListaEmpleados
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
            this.dgvListaEmpleados = new System.Windows.Forms.DataGridView();
            this.intIdEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strNameEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strDireccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strRol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strFechaIngreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strFechaRetiro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEditar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnBorrar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lblAdminEmpleados = new MaterialSkin.Controls.MaterialLabel();
            this.txtBuscarEmpleado = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnEmpleadoNuevo = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnBuscarEmpleado = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnSalirListEmpleado = new MaterialSkin.Controls.MaterialRaisedButton();
            this.MensajeError = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MensajeError)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListaEmpleados
            // 
            this.dgvListaEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.intIdEmpleado,
            this.strNameEmpleado,
            this.intDocumento,
            this.strDireccion,
            this.intTelefono,
            this.strEmail,
            this.strRol,
            this.strFechaIngreso,
            this.strFechaRetiro,
            this.btnEditar,
            this.btnBorrar});
            this.dgvListaEmpleados.Location = new System.Drawing.Point(25, 183);
            this.dgvListaEmpleados.Name = "dgvListaEmpleados";
            this.dgvListaEmpleados.Size = new System.Drawing.Size(890, 177);
            this.dgvListaEmpleados.TabIndex = 0;
            this.dgvListaEmpleados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaEmpleados_CellContentClick_1);
            // 
            // intIdEmpleado
            // 
            this.intIdEmpleado.HeaderText = "ID";
            this.intIdEmpleado.Name = "intIdEmpleado";
            // 
            // strNameEmpleado
            // 
            this.strNameEmpleado.HeaderText = "NOMBRE";
            this.strNameEmpleado.Name = "strNameEmpleado";
            // 
            // intDocumento
            // 
            this.intDocumento.HeaderText = "DOCUMENTO";
            this.intDocumento.Name = "intDocumento";
            // 
            // strDireccion
            // 
            this.strDireccion.HeaderText = "DIRECCION";
            this.strDireccion.Name = "strDireccion";
            // 
            // intTelefono
            // 
            this.intTelefono.HeaderText = "TELEFONO";
            this.intTelefono.Name = "intTelefono";
            // 
            // strEmail
            // 
            this.strEmail.HeaderText = "EMAIL";
            this.strEmail.Name = "strEmail";
            // 
            // strRol
            // 
            this.strRol.HeaderText = "ROL";
            this.strRol.Name = "strRol";
            // 
            // strFechaIngreso
            // 
            this.strFechaIngreso.HeaderText = "F. INGRESO";
            this.strFechaIngreso.Name = "strFechaIngreso";
            // 
            // strFechaRetiro
            // 
            this.strFechaRetiro.HeaderText = "F.RETIRO";
            this.strFechaRetiro.Name = "strFechaRetiro";
            // 
            // btnEditar
            // 
            this.btnEditar.HeaderText = "EDITAR";
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseColumnTextForButtonValue = true;
            // 
            // btnBorrar
            // 
            this.btnBorrar.HeaderText = "BORRAR";
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btnBorrar.Text = "BORRAR";
            this.btnBorrar.UseColumnTextForButtonValue = true;
            // 
            // lblAdminEmpleados
            // 
            this.lblAdminEmpleados.AutoSize = true;
            this.lblAdminEmpleados.Depth = 0;
            this.lblAdminEmpleados.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblAdminEmpleados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblAdminEmpleados.Location = new System.Drawing.Point(364, 52);
            this.lblAdminEmpleados.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblAdminEmpleados.Name = "lblAdminEmpleados";
            this.lblAdminEmpleados.Size = new System.Drawing.Size(224, 19);
            this.lblAdminEmpleados.TabIndex = 1;
            this.lblAdminEmpleados.Text = "ADMINISTRACION EMPLEADOS";
            // 
            // txtBuscarEmpleado
            // 
            this.txtBuscarEmpleado.Depth = 0;
            this.txtBuscarEmpleado.Hint = "Buscar Empleado";
            this.txtBuscarEmpleado.Location = new System.Drawing.Point(39, 151);
            this.txtBuscarEmpleado.MaxLength = 32767;
            this.txtBuscarEmpleado.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBuscarEmpleado.Name = "txtBuscarEmpleado";
            this.txtBuscarEmpleado.PasswordChar = '\0';
            this.txtBuscarEmpleado.SelectedText = "";
            this.txtBuscarEmpleado.SelectionLength = 0;
            this.txtBuscarEmpleado.SelectionStart = 0;
            this.txtBuscarEmpleado.Size = new System.Drawing.Size(241, 23);
            this.txtBuscarEmpleado.TabIndex = 5;
            this.txtBuscarEmpleado.TabStop = false;
            this.txtBuscarEmpleado.UseSystemPasswordChar = false;
            // 
            // btnEmpleadoNuevo
            // 
            this.btnEmpleadoNuevo.AutoSize = true;
            this.btnEmpleadoNuevo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEmpleadoNuevo.Depth = 0;
            this.btnEmpleadoNuevo.Icon = null;
            this.btnEmpleadoNuevo.Location = new System.Drawing.Point(849, 138);
            this.btnEmpleadoNuevo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEmpleadoNuevo.Name = "btnEmpleadoNuevo";
            this.btnEmpleadoNuevo.Primary = true;
            this.btnEmpleadoNuevo.Size = new System.Drawing.Size(66, 36);
            this.btnEmpleadoNuevo.TabIndex = 19;
            this.btnEmpleadoNuevo.Text = "NUEVO";
            this.btnEmpleadoNuevo.UseVisualStyleBackColor = true;
            this.btnEmpleadoNuevo.Click += new System.EventHandler(this.btnEmpleadoNuevo_Click);
            // 
            // btnBuscarEmpleado
            // 
            this.btnBuscarEmpleado.AutoSize = true;
            this.btnBuscarEmpleado.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBuscarEmpleado.Depth = 0;
            this.btnBuscarEmpleado.Icon = null;
            this.btnBuscarEmpleado.Location = new System.Drawing.Point(315, 138);
            this.btnBuscarEmpleado.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBuscarEmpleado.Name = "btnBuscarEmpleado";
            this.btnBuscarEmpleado.Primary = true;
            this.btnBuscarEmpleado.Size = new System.Drawing.Size(74, 36);
            this.btnBuscarEmpleado.TabIndex = 18;
            this.btnBuscarEmpleado.Text = "BUSCAR";
            this.btnBuscarEmpleado.UseVisualStyleBackColor = true;
            this.btnBuscarEmpleado.Click += new System.EventHandler(this.btnBuscarProducto_Click);
            // 
            // btnSalirListEmpleado
            // 
            this.btnSalirListEmpleado.AutoSize = true;
            this.btnSalirListEmpleado.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSalirListEmpleado.Depth = 0;
            this.btnSalirListEmpleado.Icon = null;
            this.btnSalirListEmpleado.Location = new System.Drawing.Point(857, 366);
            this.btnSalirListEmpleado.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalirListEmpleado.Name = "btnSalirListEmpleado";
            this.btnSalirListEmpleado.Primary = true;
            this.btnSalirListEmpleado.Size = new System.Drawing.Size(58, 36);
            this.btnSalirListEmpleado.TabIndex = 20;
            this.btnSalirListEmpleado.Text = "SALIR";
            this.btnSalirListEmpleado.UseVisualStyleBackColor = true;
            this.btnSalirListEmpleado.Click += new System.EventHandler(this.btnSalirCliente_Click);
            // 
            // MensajeError
            // 
            this.MensajeError.ContainerControl = this;
            // 
            // frmListaEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 487);
            this.Controls.Add(this.btnSalirListEmpleado);
            this.Controls.Add(this.btnEmpleadoNuevo);
            this.Controls.Add(this.btnBuscarEmpleado);
            this.Controls.Add(this.txtBuscarEmpleado);
            this.Controls.Add(this.lblAdminEmpleados);
            this.Controls.Add(this.dgvListaEmpleados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmListaEmpleados";
            this.Text = "frmListaEmpleados";
            this.Load += new System.EventHandler(this.frmListaEmpleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaEmpleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MensajeError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListaEmpleados;
        private MaterialSkin.Controls.MaterialLabel lblAdminEmpleados;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBuscarEmpleado;
        private MaterialSkin.Controls.MaterialRaisedButton btnEmpleadoNuevo;
        private MaterialSkin.Controls.MaterialRaisedButton btnBuscarEmpleado;
        private MaterialSkin.Controls.MaterialRaisedButton btnSalirListEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn intIdEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn strNameEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn intDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn strDireccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn intTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn strEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn strRol;
        private System.Windows.Forms.DataGridViewTextBoxColumn strFechaIngreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn strFechaRetiro;
        private System.Windows.Forms.DataGridViewButtonColumn btnEditar;
        private System.Windows.Forms.DataGridViewButtonColumn btnBorrar;
        private System.Windows.Forms.ErrorProvider MensajeError;
    }
}