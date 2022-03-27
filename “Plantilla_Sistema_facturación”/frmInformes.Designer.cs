
namespace _Plantilla_Sistema_facturación_
{
    partial class frmInformes
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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbExcel = new MaterialSkin.Controls.MaterialRadioButton();
            this.rdbPdf = new MaterialSkin.Controls.MaterialRadioButton();
            this.rdbEnpantalla = new MaterialSkin.Controls.MaterialRadioButton();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.cxbFechaFin = new System.Windows.Forms.ComboBox();
            this.cxbSeleccionInforme = new System.Windows.Forms.ComboBox();
            this.lblFechaInicio = new MaterialSkin.Controls.MaterialLabel();
            this.lblOrdenar = new MaterialSkin.Controls.MaterialLabel();
            this.lblFechaFin = new MaterialSkin.Controls.MaterialLabel();
            this.lblSeleccionInforme = new MaterialSkin.Controls.MaterialLabel();
            this.btnGenerarInforme = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnSalir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtMostrarInforme = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(237, 33);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(324, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "GENERADOR DE INFORMES DE FACTURACION";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbExcel);
            this.groupBox1.Controls.Add(this.rdbPdf);
            this.groupBox1.Controls.Add(this.rdbEnpantalla);
            this.groupBox1.Controls.Add(this.dtpFechaFin);
            this.groupBox1.Controls.Add(this.dtpFechaInicio);
            this.groupBox1.Controls.Add(this.cxbFechaFin);
            this.groupBox1.Controls.Add(this.cxbSeleccionInforme);
            this.groupBox1.Controls.Add(this.lblFechaInicio);
            this.groupBox1.Controls.Add(this.lblOrdenar);
            this.groupBox1.Controls.Add(this.lblFechaFin);
            this.groupBox1.Controls.Add(this.lblSeleccionInforme);
            this.groupBox1.Location = new System.Drawing.Point(28, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(697, 175);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // rdbExcel
            // 
            this.rdbExcel.AutoSize = true;
            this.rdbExcel.Depth = 0;
            this.rdbExcel.Font = new System.Drawing.Font("Roboto", 10F);
            this.rdbExcel.Location = new System.Drawing.Point(437, 121);
            this.rdbExcel.Margin = new System.Windows.Forms.Padding(0);
            this.rdbExcel.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdbExcel.MouseState = MaterialSkin.MouseState.HOVER;
            this.rdbExcel.Name = "rdbExcel";
            this.rdbExcel.Ripple = true;
            this.rdbExcel.Size = new System.Drawing.Size(62, 30);
            this.rdbExcel.TabIndex = 10;
            this.rdbExcel.TabStop = true;
            this.rdbExcel.Text = "Excel";
            this.rdbExcel.UseVisualStyleBackColor = true;
            // 
            // rdbPdf
            // 
            this.rdbPdf.AutoSize = true;
            this.rdbPdf.Depth = 0;
            this.rdbPdf.Font = new System.Drawing.Font("Roboto", 10F);
            this.rdbPdf.Location = new System.Drawing.Point(341, 121);
            this.rdbPdf.Margin = new System.Windows.Forms.Padding(0);
            this.rdbPdf.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdbPdf.MouseState = MaterialSkin.MouseState.HOVER;
            this.rdbPdf.Name = "rdbPdf";
            this.rdbPdf.Ripple = true;
            this.rdbPdf.Size = new System.Drawing.Size(50, 30);
            this.rdbPdf.TabIndex = 9;
            this.rdbPdf.TabStop = true;
            this.rdbPdf.Text = "Pdf";
            this.rdbPdf.UseVisualStyleBackColor = true;
            // 
            // rdbEnpantalla
            // 
            this.rdbEnpantalla.AutoSize = true;
            this.rdbEnpantalla.Depth = 0;
            this.rdbEnpantalla.Font = new System.Drawing.Font("Roboto", 10F);
            this.rdbEnpantalla.Location = new System.Drawing.Point(213, 121);
            this.rdbEnpantalla.Margin = new System.Windows.Forms.Padding(0);
            this.rdbEnpantalla.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdbEnpantalla.MouseState = MaterialSkin.MouseState.HOVER;
            this.rdbEnpantalla.Name = "rdbEnpantalla";
            this.rdbEnpantalla.Ripple = true;
            this.rdbEnpantalla.Size = new System.Drawing.Size(97, 30);
            this.rdbEnpantalla.TabIndex = 8;
            this.rdbEnpantalla.TabStop = true;
            this.rdbEnpantalla.Text = "En pantalla";
            this.rdbEnpantalla.UseVisualStyleBackColor = true;
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFin.Location = new System.Drawing.Point(470, 77);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(140, 20);
            this.dtpFechaFin.TabIndex = 7;
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaInicio.Location = new System.Drawing.Point(121, 77);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(140, 20);
            this.dtpFechaInicio.TabIndex = 6;
            // 
            // cxbFechaFin
            // 
            this.cxbFechaFin.FormattingEnabled = true;
            this.cxbFechaFin.Location = new System.Drawing.Point(554, 34);
            this.cxbFechaFin.Name = "cxbFechaFin";
            this.cxbFechaFin.Size = new System.Drawing.Size(121, 21);
            this.cxbFechaFin.TabIndex = 5;
            // 
            // cxbSeleccionInforme
            // 
            this.cxbSeleccionInforme.FormattingEnabled = true;
            this.cxbSeleccionInforme.Location = new System.Drawing.Point(189, 34);
            this.cxbSeleccionInforme.Name = "cxbSeleccionInforme";
            this.cxbSeleccionInforme.Size = new System.Drawing.Size(230, 21);
            this.cxbSeleccionInforme.TabIndex = 4;
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.Depth = 0;
            this.lblFechaInicio.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblFechaInicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblFechaInicio.Location = new System.Drawing.Point(13, 77);
            this.lblFechaInicio.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(90, 19);
            this.lblFechaInicio.TabIndex = 3;
            this.lblFechaInicio.Text = "Fecha Inicio";
            // 
            // lblOrdenar
            // 
            this.lblOrdenar.AutoSize = true;
            this.lblOrdenar.Depth = 0;
            this.lblOrdenar.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblOrdenar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblOrdenar.Location = new System.Drawing.Point(460, 37);
            this.lblOrdenar.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblOrdenar.Name = "lblOrdenar";
            this.lblOrdenar.Size = new System.Drawing.Size(87, 19);
            this.lblOrdenar.TabIndex = 2;
            this.lblOrdenar.Text = "Ordenar por";
            // 
            // lblFechaFin
            // 
            this.lblFechaFin.AutoSize = true;
            this.lblFechaFin.Depth = 0;
            this.lblFechaFin.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblFechaFin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblFechaFin.Location = new System.Drawing.Point(382, 77);
            this.lblFechaFin.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFechaFin.Name = "lblFechaFin";
            this.lblFechaFin.Size = new System.Drawing.Size(73, 19);
            this.lblFechaFin.TabIndex = 1;
            this.lblFechaFin.Text = "Fecha Fin";
            // 
            // lblSeleccionInforme
            // 
            this.lblSeleccionInforme.AutoSize = true;
            this.lblSeleccionInforme.Depth = 0;
            this.lblSeleccionInforme.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblSeleccionInforme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblSeleccionInforme.Location = new System.Drawing.Point(6, 37);
            this.lblSeleccionInforme.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblSeleccionInforme.Name = "lblSeleccionInforme";
            this.lblSeleccionInforme.Size = new System.Drawing.Size(166, 19);
            this.lblSeleccionInforme.TabIndex = 0;
            this.lblSeleccionInforme.Text = "SELECCIONE INFORME";
            // 
            // btnGenerarInforme
            // 
            this.btnGenerarInforme.AutoSize = true;
            this.btnGenerarInforme.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGenerarInforme.Depth = 0;
            this.btnGenerarInforme.Icon = null;
            this.btnGenerarInforme.Location = new System.Drawing.Point(158, 279);
            this.btnGenerarInforme.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGenerarInforme.Name = "btnGenerarInforme";
            this.btnGenerarInforme.Primary = true;
            this.btnGenerarInforme.Size = new System.Drawing.Size(144, 36);
            this.btnGenerarInforme.TabIndex = 8;
            this.btnGenerarInforme.Text = "GENERAR INFORME";
            this.btnGenerarInforme.UseVisualStyleBackColor = true;
            this.btnGenerarInforme.Click += new System.EventHandler(this.btnGenerarInforme_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.AutoSize = true;
            this.btnSalir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSalir.Depth = 0;
            this.btnSalir.Icon = null;
            this.btnSalir.Location = new System.Drawing.Point(465, 279);
            this.btnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Primary = true;
            this.btnSalir.Size = new System.Drawing.Size(58, 36);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txtMostrarInforme
            // 
            this.txtMostrarInforme.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtMostrarInforme.Location = new System.Drawing.Point(28, 344);
            this.txtMostrarInforme.Multiline = true;
            this.txtMostrarInforme.Name = "txtMostrarInforme";
            this.txtMostrarInforme.Size = new System.Drawing.Size(697, 228);
            this.txtMostrarInforme.TabIndex = 10;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmInformes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 584);
            this.Controls.Add(this.txtMostrarInforme);
            this.Controls.Add(this.btnGenerarInforme);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.materialLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmInformes";
            this.Text = "frmInformes";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialLabel lblSeleccionInforme;
        private MaterialSkin.Controls.MaterialLabel lblFechaInicio;
        private MaterialSkin.Controls.MaterialLabel lblOrdenar;
        private MaterialSkin.Controls.MaterialLabel lblFechaFin;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.ComboBox cxbFechaFin;
        private System.Windows.Forms.ComboBox cxbSeleccionInforme;
        private MaterialSkin.Controls.MaterialRadioButton rdbExcel;
        private MaterialSkin.Controls.MaterialRadioButton rdbPdf;
        private MaterialSkin.Controls.MaterialRadioButton rdbEnpantalla;
        private MaterialSkin.Controls.MaterialRaisedButton btnGenerarInforme;
        private MaterialSkin.Controls.MaterialRaisedButton btnSalir;
        private System.Windows.Forms.TextBox txtMostrarInforme;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}