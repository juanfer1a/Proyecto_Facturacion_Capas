
namespace _Plantilla_Sistema_facturación_
{
    partial class frmListaRol
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
            this.lblAdminRol = new MaterialSkin.Controls.MaterialLabel();
            this.btnSalirRol = new MaterialSkin.Controls.MaterialRaisedButton();
            this.dgvRol = new System.Windows.Forms.DataGridView();
            this.btnRolNuevo = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnBuscarRol = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtBuscarRol = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.intIdRol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strDescripcionRol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEditar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnBorrar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRol)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAdminRol
            // 
            this.lblAdminRol.AutoSize = true;
            this.lblAdminRol.Depth = 0;
            this.lblAdminRol.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblAdminRol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblAdminRol.Location = new System.Drawing.Point(261, 62);
            this.lblAdminRol.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblAdminRol.Name = "lblAdminRol";
            this.lblAdminRol.Size = new System.Drawing.Size(182, 19);
            this.lblAdminRol.TabIndex = 26;
            this.lblAdminRol.Text = "ADMINISTRACION ROLES";
            // 
            // btnSalirRol
            // 
            this.btnSalirRol.AutoSize = true;
            this.btnSalirRol.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSalirRol.Depth = 0;
            this.btnSalirRol.Icon = null;
            this.btnSalirRol.Location = new System.Drawing.Point(511, 374);
            this.btnSalirRol.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalirRol.Name = "btnSalirRol";
            this.btnSalirRol.Primary = true;
            this.btnSalirRol.Size = new System.Drawing.Size(58, 36);
            this.btnSalirRol.TabIndex = 25;
            this.btnSalirRol.Text = "SALIR";
            this.btnSalirRol.UseVisualStyleBackColor = true;
            this.btnSalirRol.Click += new System.EventHandler(this.btnSalirRol_Click);
            // 
            // dgvRol
            // 
            this.dgvRol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRol.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.intIdRol,
            this.strDescripcionRol,
            this.btnEditar,
            this.btnBorrar});
            this.dgvRol.Location = new System.Drawing.Point(23, 218);
            this.dgvRol.Name = "dgvRol";
            this.dgvRol.Size = new System.Drawing.Size(546, 150);
            this.dgvRol.TabIndex = 24;
            this.dgvRol.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRol_CellContentClick);
            // 
            // btnRolNuevo
            // 
            this.btnRolNuevo.AutoSize = true;
            this.btnRolNuevo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRolNuevo.Depth = 0;
            this.btnRolNuevo.Icon = null;
            this.btnRolNuevo.Location = new System.Drawing.Point(503, 176);
            this.btnRolNuevo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRolNuevo.Name = "btnRolNuevo";
            this.btnRolNuevo.Primary = true;
            this.btnRolNuevo.Size = new System.Drawing.Size(66, 36);
            this.btnRolNuevo.TabIndex = 23;
            this.btnRolNuevo.Text = "NUEVO";
            this.btnRolNuevo.UseVisualStyleBackColor = true;
            this.btnRolNuevo.Click += new System.EventHandler(this.btnRolNuevo_Click);
            // 
            // btnBuscarRol
            // 
            this.btnBuscarRol.AutoSize = true;
            this.btnBuscarRol.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBuscarRol.Depth = 0;
            this.btnBuscarRol.Icon = null;
            this.btnBuscarRol.Location = new System.Drawing.Point(366, 176);
            this.btnBuscarRol.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBuscarRol.Name = "btnBuscarRol";
            this.btnBuscarRol.Primary = true;
            this.btnBuscarRol.Size = new System.Drawing.Size(74, 36);
            this.btnBuscarRol.TabIndex = 22;
            this.btnBuscarRol.Text = "BUSCAR";
            this.btnBuscarRol.UseVisualStyleBackColor = true;
            this.btnBuscarRol.Click += new System.EventHandler(this.btnBuscarRol_Click);
            // 
            // txtBuscarRol
            // 
            this.txtBuscarRol.Depth = 0;
            this.txtBuscarRol.Hint = "Buscar Rol";
            this.txtBuscarRol.Location = new System.Drawing.Point(23, 189);
            this.txtBuscarRol.MaxLength = 32767;
            this.txtBuscarRol.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBuscarRol.Name = "txtBuscarRol";
            this.txtBuscarRol.PasswordChar = '\0';
            this.txtBuscarRol.SelectedText = "";
            this.txtBuscarRol.SelectionLength = 0;
            this.txtBuscarRol.SelectionStart = 0;
            this.txtBuscarRol.Size = new System.Drawing.Size(269, 23);
            this.txtBuscarRol.TabIndex = 21;
            this.txtBuscarRol.TabStop = false;
            this.txtBuscarRol.UseSystemPasswordChar = false;
            // 
            // intIdRol
            // 
            this.intIdRol.HeaderText = "ID";
            this.intIdRol.Name = "intIdRol";
            this.intIdRol.Width = 80;
            // 
            // strDescripcionRol
            // 
            this.strDescripcionRol.HeaderText = "DESCRIPCION";
            this.strDescripcionRol.Name = "strDescripcionRol";
            this.strDescripcionRol.Width = 250;
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
            // frmListaRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 450);
            this.Controls.Add(this.lblAdminRol);
            this.Controls.Add(this.btnSalirRol);
            this.Controls.Add(this.dgvRol);
            this.Controls.Add(this.btnRolNuevo);
            this.Controls.Add(this.btnBuscarRol);
            this.Controls.Add(this.txtBuscarRol);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmListaRol";
            this.Text = "frmRol";
            this.Load += new System.EventHandler(this.frmListaRol_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRol)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lblAdminRol;
        private MaterialSkin.Controls.MaterialRaisedButton btnSalirRol;
        private System.Windows.Forms.DataGridView dgvRol;
        private MaterialSkin.Controls.MaterialRaisedButton btnRolNuevo;
        private MaterialSkin.Controls.MaterialRaisedButton btnBuscarRol;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBuscarRol;
        private System.Windows.Forms.DataGridViewTextBoxColumn intIdRol;
        private System.Windows.Forms.DataGridViewTextBoxColumn strDescripcionRol;
        private System.Windows.Forms.DataGridViewButtonColumn btnEditar;
        private System.Windows.Forms.DataGridViewButtonColumn btnBorrar;
    }
}