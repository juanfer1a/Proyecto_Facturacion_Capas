
namespace _Plantilla_Sistema_facturación_
{
    partial class frmRolEmpleados
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
            this.grbRolEmpleados = new System.Windows.Forms.GroupBox();
            this.txbDescripcionRol = new System.Windows.Forms.TextBox();
            this.lblDescripcionRol = new MaterialSkin.Controls.MaterialLabel();
            this.txbIdRolEmpleado = new System.Windows.Forms.TextBox();
            this.txtRol = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblSalirRol = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnActualizarRol = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lblRolEmpleados = new MaterialSkin.Controls.MaterialLabel();
            this.MensajeError = new System.Windows.Forms.ErrorProvider(this.components);
            this.grbRolEmpleados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MensajeError)).BeginInit();
            this.SuspendLayout();
            // 
            // grbRolEmpleados
            // 
            this.grbRolEmpleados.Controls.Add(this.txbDescripcionRol);
            this.grbRolEmpleados.Controls.Add(this.lblDescripcionRol);
            this.grbRolEmpleados.Controls.Add(this.txbIdRolEmpleado);
            this.grbRolEmpleados.Controls.Add(this.txtRol);
            this.grbRolEmpleados.Location = new System.Drawing.Point(39, 79);
            this.grbRolEmpleados.Name = "grbRolEmpleados";
            this.grbRolEmpleados.Size = new System.Drawing.Size(519, 306);
            this.grbRolEmpleados.TabIndex = 0;
            this.grbRolEmpleados.TabStop = false;
            // 
            // txbDescripcionRol
            // 
            this.txbDescripcionRol.Location = new System.Drawing.Point(56, 164);
            this.txbDescripcionRol.Multiline = true;
            this.txbDescripcionRol.Name = "txbDescripcionRol";
            this.txbDescripcionRol.Size = new System.Drawing.Size(420, 101);
            this.txbDescripcionRol.TabIndex = 21;
            // 
            // lblDescripcionRol
            // 
            this.lblDescripcionRol.AutoSize = true;
            this.lblDescripcionRol.Depth = 0;
            this.lblDescripcionRol.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblDescripcionRol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDescripcionRol.Location = new System.Drawing.Point(52, 128);
            this.lblDescripcionRol.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDescripcionRol.Name = "lblDescripcionRol";
            this.lblDescripcionRol.Size = new System.Drawing.Size(180, 19);
            this.lblDescripcionRol.TabIndex = 20;
            this.lblDescripcionRol.Text = "Descripcion detallada Rol";
            // 
            // txbIdRolEmpleado
            // 
            this.txbIdRolEmpleado.Location = new System.Drawing.Point(56, 36);
            this.txbIdRolEmpleado.Name = "txbIdRolEmpleado";
            this.txbIdRolEmpleado.Size = new System.Drawing.Size(36, 20);
            this.txbIdRolEmpleado.TabIndex = 19;
            // 
            // txtRol
            // 
            this.txtRol.Depth = 0;
            this.txtRol.Hint = "Rol";
            this.txtRol.Location = new System.Drawing.Point(56, 81);
            this.txtRol.MaxLength = 32767;
            this.txtRol.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtRol.Name = "txtRol";
            this.txtRol.PasswordChar = '\0';
            this.txtRol.SelectedText = "";
            this.txtRol.SelectionLength = 0;
            this.txtRol.SelectionStart = 0;
            this.txtRol.Size = new System.Drawing.Size(300, 23);
            this.txtRol.TabIndex = 18;
            this.txtRol.TabStop = false;
            this.txtRol.UseSystemPasswordChar = false;
            // 
            // lblSalirRol
            // 
            this.lblSalirRol.AutoSize = true;
            this.lblSalirRol.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.lblSalirRol.Depth = 0;
            this.lblSalirRol.Icon = null;
            this.lblSalirRol.Location = new System.Drawing.Point(364, 402);
            this.lblSalirRol.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblSalirRol.Name = "lblSalirRol";
            this.lblSalirRol.Primary = true;
            this.lblSalirRol.Size = new System.Drawing.Size(58, 36);
            this.lblSalirRol.TabIndex = 21;
            this.lblSalirRol.Text = "SALIR";
            this.lblSalirRol.UseVisualStyleBackColor = true;
            this.lblSalirRol.Click += new System.EventHandler(this.lblSalirRol_Click);
            // 
            // btnActualizarRol
            // 
            this.btnActualizarRol.AutoSize = true;
            this.btnActualizarRol.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnActualizarRol.Depth = 0;
            this.btnActualizarRol.Icon = null;
            this.btnActualizarRol.Location = new System.Drawing.Point(179, 402);
            this.btnActualizarRol.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnActualizarRol.Name = "btnActualizarRol";
            this.btnActualizarRol.Primary = true;
            this.btnActualizarRol.Size = new System.Drawing.Size(103, 36);
            this.btnActualizarRol.TabIndex = 20;
            this.btnActualizarRol.Text = "ACTUALIZAR";
            this.btnActualizarRol.UseVisualStyleBackColor = true;
            this.btnActualizarRol.Click += new System.EventHandler(this.btnActualizarRol_Click);
            // 
            // lblRolEmpleados
            // 
            this.lblRolEmpleados.AutoSize = true;
            this.lblRolEmpleados.Depth = 0;
            this.lblRolEmpleados.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblRolEmpleados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblRolEmpleados.Location = new System.Drawing.Point(246, 38);
            this.lblRolEmpleados.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblRolEmpleados.Name = "lblRolEmpleados";
            this.lblRolEmpleados.Size = new System.Drawing.Size(127, 19);
            this.lblRolEmpleados.TabIndex = 17;
            this.lblRolEmpleados.Text = "ROL EMPLEADOS";
            this.lblRolEmpleados.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MensajeError
            // 
            this.MensajeError.ContainerControl = this;
            // 
            // frmRolEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 469);
            this.Controls.Add(this.lblSalirRol);
            this.Controls.Add(this.btnActualizarRol);
            this.Controls.Add(this.lblRolEmpleados);
            this.Controls.Add(this.grbRolEmpleados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRolEmpleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRolEmpleados";
            this.Load += new System.EventHandler(this.frmRolEmpleados_Load);
            this.grbRolEmpleados.ResumeLayout(false);
            this.grbRolEmpleados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MensajeError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbRolEmpleados;
        private System.Windows.Forms.TextBox txbIdRolEmpleado;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtRol;
        private MaterialSkin.Controls.MaterialLabel lblRolEmpleados;
        private MaterialSkin.Controls.MaterialRaisedButton lblSalirRol;
        private MaterialSkin.Controls.MaterialRaisedButton btnActualizarRol;
        private System.Windows.Forms.TextBox txbDescripcionRol;
        private MaterialSkin.Controls.MaterialLabel lblDescripcionRol;
        private System.Windows.Forms.ErrorProvider MensajeError;
    }
}