
namespace _Plantilla_Sistema_facturación_
{
    partial class frmCategoriasProductos
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
            this.txtIdCategoria = new System.Windows.Forms.TextBox();
            this.txtNombreCategoria = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblCatProduc = new MaterialSkin.Controls.MaterialLabel();
            this.btnSalirCatProduc = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnActualizarCatProduc = new MaterialSkin.Controls.MaterialRaisedButton();
            this.grbCategoriaProductos = new System.Windows.Forms.GroupBox();
            this.MensajeError = new System.Windows.Forms.ErrorProvider(this.components);
            this.grbCategoriaProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MensajeError)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIdCategoria
            // 
            this.txtIdCategoria.Location = new System.Drawing.Point(22, 34);
            this.txtIdCategoria.Name = "txtIdCategoria";
            this.txtIdCategoria.Size = new System.Drawing.Size(36, 20);
            this.txtIdCategoria.TabIndex = 14;
            // 
            // txtNombreCategoria
            // 
            this.txtNombreCategoria.Depth = 0;
            this.txtNombreCategoria.Hint = "Nombre Categoria";
            this.txtNombreCategoria.Location = new System.Drawing.Point(22, 70);
            this.txtNombreCategoria.MaxLength = 32767;
            this.txtNombreCategoria.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNombreCategoria.Name = "txtNombreCategoria";
            this.txtNombreCategoria.PasswordChar = '\0';
            this.txtNombreCategoria.SelectedText = "";
            this.txtNombreCategoria.SelectionLength = 0;
            this.txtNombreCategoria.SelectionStart = 0;
            this.txtNombreCategoria.Size = new System.Drawing.Size(343, 23);
            this.txtNombreCategoria.TabIndex = 13;
            this.txtNombreCategoria.TabStop = false;
            this.txtNombreCategoria.UseSystemPasswordChar = false;
            // 
            // lblCatProduc
            // 
            this.lblCatProduc.AutoSize = true;
            this.lblCatProduc.Depth = 0;
            this.lblCatProduc.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblCatProduc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCatProduc.Location = new System.Drawing.Point(140, 28);
            this.lblCatProduc.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCatProduc.Name = "lblCatProduc";
            this.lblCatProduc.Size = new System.Drawing.Size(180, 19);
            this.lblCatProduc.TabIndex = 12;
            this.lblCatProduc.Text = "CATEGORIA PRODUCTOS";
            // 
            // btnSalirCatProduc
            // 
            this.btnSalirCatProduc.AutoSize = true;
            this.btnSalirCatProduc.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSalirCatProduc.Depth = 0;
            this.btnSalirCatProduc.Icon = null;
            this.btnSalirCatProduc.Location = new System.Drawing.Point(291, 140);
            this.btnSalirCatProduc.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalirCatProduc.Name = "btnSalirCatProduc";
            this.btnSalirCatProduc.Primary = true;
            this.btnSalirCatProduc.Size = new System.Drawing.Size(58, 36);
            this.btnSalirCatProduc.TabIndex = 16;
            this.btnSalirCatProduc.Text = "SALIR";
            this.btnSalirCatProduc.UseVisualStyleBackColor = true;
            this.btnSalirCatProduc.Click += new System.EventHandler(this.btnSalirCatProduc_Click);
            // 
            // btnActualizarCatProduc
            // 
            this.btnActualizarCatProduc.AutoSize = true;
            this.btnActualizarCatProduc.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnActualizarCatProduc.Depth = 0;
            this.btnActualizarCatProduc.Icon = null;
            this.btnActualizarCatProduc.Location = new System.Drawing.Point(106, 140);
            this.btnActualizarCatProduc.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnActualizarCatProduc.Name = "btnActualizarCatProduc";
            this.btnActualizarCatProduc.Primary = true;
            this.btnActualizarCatProduc.Size = new System.Drawing.Size(103, 36);
            this.btnActualizarCatProduc.TabIndex = 15;
            this.btnActualizarCatProduc.Text = "ACTUALIZAR";
            this.btnActualizarCatProduc.UseVisualStyleBackColor = true;
            this.btnActualizarCatProduc.Click += new System.EventHandler(this.btnActualizarCatProduc_Click);
            // 
            // grbCategoriaProductos
            // 
            this.grbCategoriaProductos.Controls.Add(this.txtIdCategoria);
            this.grbCategoriaProductos.Controls.Add(this.btnSalirCatProduc);
            this.grbCategoriaProductos.Controls.Add(this.txtNombreCategoria);
            this.grbCategoriaProductos.Controls.Add(this.btnActualizarCatProduc);
            this.grbCategoriaProductos.Location = new System.Drawing.Point(12, 70);
            this.grbCategoriaProductos.Name = "grbCategoriaProductos";
            this.grbCategoriaProductos.Size = new System.Drawing.Size(453, 220);
            this.grbCategoriaProductos.TabIndex = 17;
            this.grbCategoriaProductos.TabStop = false;
            // 
            // MensajeError
            // 
            this.MensajeError.ContainerControl = this;
            this.MensajeError.RightToLeftChanged += new System.EventHandler(this.btnActualizarCatProduc_Click);
            // 
            // frmCategoriasProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 321);
            this.Controls.Add(this.grbCategoriaProductos);
            this.Controls.Add(this.lblCatProduc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCategoriasProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmCategoriasProductos_Load);
            this.grbCategoriaProductos.ResumeLayout(false);
            this.grbCategoriaProductos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MensajeError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIdCategoria;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNombreCategoria;
        private MaterialSkin.Controls.MaterialLabel lblCatProduc;
        private MaterialSkin.Controls.MaterialRaisedButton btnSalirCatProduc;
        private MaterialSkin.Controls.MaterialRaisedButton btnActualizarCatProduc;
        private System.Windows.Forms.GroupBox grbCategoriaProductos;
        private System.Windows.Forms.ErrorProvider MensajeError;
    }
}