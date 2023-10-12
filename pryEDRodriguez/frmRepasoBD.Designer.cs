namespace pryEDRodriguez
{
    partial class frmRepasoBD
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
            this.cboConsulta = new System.Windows.Forms.ComboBox();
            this.btnListar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dgvOperaciones = new System.Windows.Forms.DataGridView();
            this.lblRepaso = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOperaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // cboConsulta
            // 
            this.cboConsulta.FormattingEnabled = true;
            this.cboConsulta.Items.AddRange(new object[] {
            "Diferencia",
            "Intersección",
            "Juntar",
            "Proyección Simple",
            "Proyección Multiatributo",
            "Selección Multiatributo con operador AND",
            "Selección Multiatributo con operador OR",
            "Selección Multiatributo por convolución",
            "Selección Simple",
            "Unión"});
            this.cboConsulta.Location = new System.Drawing.Point(271, 12);
            this.cboConsulta.Name = "cboConsulta";
            this.cboConsulta.Size = new System.Drawing.Size(424, 21);
            this.cboConsulta.TabIndex = 0;
            this.cboConsulta.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnListar
            // 
            this.btnListar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListar.Location = new System.Drawing.Point(701, 9);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(106, 24);
            this.btnListar.TabIndex = 1;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(12, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(257, 13);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Operaciones a realizar en la Base de Datos:";
            // 
            // dgvOperaciones
            // 
            this.dgvOperaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOperaciones.Location = new System.Drawing.Point(15, 174);
            this.dgvOperaciones.Name = "dgvOperaciones";
            this.dgvOperaciones.Size = new System.Drawing.Size(792, 272);
            this.dgvOperaciones.TabIndex = 3;
            // 
            // lblRepaso
            // 
            this.lblRepaso.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRepaso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepaso.Location = new System.Drawing.Point(15, 51);
            this.lblRepaso.Name = "lblRepaso";
            this.lblRepaso.Size = new System.Drawing.Size(792, 105);
            this.lblRepaso.TabIndex = 9;
            // 
            // frmRepasoBD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 458);
            this.Controls.Add(this.lblRepaso);
            this.Controls.Add(this.dgvOperaciones);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.cboConsulta);
            this.Name = "frmRepasoBD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRepasoBD";
            this.Load += new System.EventHandler(this.frmRepasoBD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOperaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboConsulta;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dgvOperaciones;
        private System.Windows.Forms.Label lblRepaso;
    }
}