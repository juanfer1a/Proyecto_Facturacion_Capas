
namespace _Plantilla_Sistema_facturación_
{
    partial class frmListaCategoria
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
            this.btnSalirCategoria = new MaterialSkin.Controls.MaterialRaisedButton();
            this.dgvCategoria = new System.Windows.Forms.DataGridView();
            this.id_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strcliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEditar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnBorrar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnNuevoCategoria = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnBuscarCategoria = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtBuscarCategoria = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblAdminCategorias = new MaterialSkin.Controls.MaterialLabel();
            this.MensajeError = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MensajeError)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalirCategoria
            // 
            this.btnSalirCategoria.AutoSize = true;
            this.btnSalirCategoria.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSalirCategoria.Depth = 0;
            this.btnSalirCategoria.Icon = null;
            this.btnSalirCategoria.Location = new System.Drawing.Point(595, 369);
            this.btnSalirCategoria.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalirCategoria.Name = "btnSalirCategoria";
            this.btnSalirCategoria.Primary = true;
            this.btnSalirCategoria.Size = new System.Drawing.Size(58, 36);
            this.btnSalirCategoria.TabIndex = 14;
            this.btnSalirCategoria.Text = "SALIR";
            this.btnSalirCategoria.UseVisualStyleBackColor = true;
            this.btnSalirCategoria.Click += new System.EventHandler(this.btnSalirCategoria_Click);
            // 
            // dgvCategoria
            // 
            this.dgvCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategoria.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_Cliente,
            this.strcliente,
            this.btnEditar,
            this.btnBorrar});
            this.dgvCategoria.Location = new System.Drawing.Point(193, 213);
            this.dgvCategoria.Name = "dgvCategoria";
            this.dgvCategoria.Size = new System.Drawing.Size(460, 150);
            this.dgvCategoria.TabIndex = 13;
            this.dgvCategoria.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCategoria_CellContentClick);
            // 
            // id_Cliente
            // 
            this.id_Cliente.HeaderText = "CODIGO";
            this.id_Cliente.Name = "id_Cliente";
            // 
            // strcliente
            // 
            this.strcliente.HeaderText = "CATEGORIA";
            this.strcliente.Name = "strcliente";
            this.strcliente.Width = 150;
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
            // btnNuevoCategoria
            // 
            this.btnNuevoCategoria.AutoSize = true;
            this.btnNuevoCategoria.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNuevoCategoria.Depth = 0;
            this.btnNuevoCategoria.Icon = null;
            this.btnNuevoCategoria.Location = new System.Drawing.Point(587, 171);
            this.btnNuevoCategoria.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNuevoCategoria.Name = "btnNuevoCategoria";
            this.btnNuevoCategoria.Primary = true;
            this.btnNuevoCategoria.Size = new System.Drawing.Size(66, 36);
            this.btnNuevoCategoria.TabIndex = 12;
            this.btnNuevoCategoria.Text = "NUEVO";
            this.btnNuevoCategoria.UseVisualStyleBackColor = true;
            this.btnNuevoCategoria.Click += new System.EventHandler(this.btnNuevoCategoria_Click);
            // 
            // btnBuscarCategoria
            // 
            this.btnBuscarCategoria.AutoSize = true;
            this.btnBuscarCategoria.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBuscarCategoria.Depth = 0;
            this.btnBuscarCategoria.Icon = null;
            this.btnBuscarCategoria.Location = new System.Drawing.Point(447, 171);
            this.btnBuscarCategoria.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBuscarCategoria.Name = "btnBuscarCategoria";
            this.btnBuscarCategoria.Primary = true;
            this.btnBuscarCategoria.Size = new System.Drawing.Size(74, 36);
            this.btnBuscarCategoria.TabIndex = 11;
            this.btnBuscarCategoria.Text = "BUSCAR";
            this.btnBuscarCategoria.UseVisualStyleBackColor = true;
            this.btnBuscarCategoria.Click += new System.EventHandler(this.btnBuscarCategoria_Click);
            // 
            // txtBuscarCategoria
            // 
            this.txtBuscarCategoria.Depth = 0;
            this.txtBuscarCategoria.Hint = "Buscar Categoria";
            this.txtBuscarCategoria.Location = new System.Drawing.Point(193, 184);
            this.txtBuscarCategoria.MaxLength = 32767;
            this.txtBuscarCategoria.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBuscarCategoria.Name = "txtBuscarCategoria";
            this.txtBuscarCategoria.PasswordChar = '\0';
            this.txtBuscarCategoria.SelectedText = "";
            this.txtBuscarCategoria.SelectionLength = 0;
            this.txtBuscarCategoria.SelectionStart = 0;
            this.txtBuscarCategoria.Size = new System.Drawing.Size(233, 23);
            this.txtBuscarCategoria.TabIndex = 10;
            this.txtBuscarCategoria.TabStop = false;
            this.txtBuscarCategoria.UseSystemPasswordChar = false;
            // 
            // lblAdminCategorias
            // 
            this.lblAdminCategorias.AutoSize = true;
            this.lblAdminCategorias.Depth = 0;
            this.lblAdminCategorias.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblAdminCategorias.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblAdminCategorias.Location = new System.Drawing.Point(315, 56);
            this.lblAdminCategorias.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblAdminCategorias.Name = "lblAdminCategorias";
            this.lblAdminCategorias.Size = new System.Drawing.Size(227, 19);
            this.lblAdminCategorias.TabIndex = 9;
            this.lblAdminCategorias.Text = "ADMINISTRACION CATEGORIAS";
            // 
            // MensajeError
            // 
            this.MensajeError.ContainerControl = this;
            // 
            // frmListaCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalirCategoria);
            this.Controls.Add(this.dgvCategoria);
            this.Controls.Add(this.btnNuevoCategoria);
            this.Controls.Add(this.btnBuscarCategoria);
            this.Controls.Add(this.txtBuscarCategoria);
            this.Controls.Add(this.lblAdminCategorias);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmListaCategoria";
            this.Text = "frmListaCategoria";
            this.Load += new System.EventHandler(this.frmListaCategoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MensajeError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton btnSalirCategoria;
        private System.Windows.Forms.DataGridView dgvCategoria;
        private MaterialSkin.Controls.MaterialRaisedButton btnNuevoCategoria;
        private MaterialSkin.Controls.MaterialRaisedButton btnBuscarCategoria;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBuscarCategoria;
        private MaterialSkin.Controls.MaterialLabel lblAdminCategorias;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn strcliente;
        private System.Windows.Forms.DataGridViewButtonColumn btnEditar;
        private System.Windows.Forms.DataGridViewButtonColumn btnBorrar;
        private System.Windows.Forms.ErrorProvider MensajeError;
    }
}