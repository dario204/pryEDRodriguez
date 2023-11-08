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
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOperaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // cboConsulta
            // 
            this.cboConsulta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboConsulta.FormattingEnabled = true;
            this.cboConsulta.Items.AddRange(new object[] {
            "Diferencia",
            "Interseccion",
            "Juntar",
            "Proyeccion Simple",
            "Proyeccion Multiatributo"});
            this.cboConsulta.Location = new System.Drawing.Point(361, 15);
            this.cboConsulta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboConsulta.Name = "cboConsulta";
            this.cboConsulta.Size = new System.Drawing.Size(564, 24);
            this.cboConsulta.TabIndex = 0;
            this.cboConsulta.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnListar
            // 
            this.btnListar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListar.Location = new System.Drawing.Point(935, 11);
            this.btnListar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(141, 30);
            this.btnListar.TabIndex = 1;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(16, 25);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(331, 17);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Operaciones a realizar en la Base de Datos:";
            // 
            // dgvOperaciones
            // 
            this.dgvOperaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOperaciones.Location = new System.Drawing.Point(20, 214);
            this.dgvOperaciones.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvOperaciones.Name = "dgvOperaciones";
            this.dgvOperaciones.RowHeadersWidth = 51;
            this.dgvOperaciones.Size = new System.Drawing.Size(1056, 335);
            this.dgvOperaciones.TabIndex = 3;
            // 
            // lblRepaso
            // 
            this.lblRepaso.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRepaso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepaso.Location = new System.Drawing.Point(20, 63);
            this.lblRepaso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRepaso.Name = "lblRepaso";
            this.lblRepaso.Size = new System.Drawing.Size(1056, 129);
            this.lblRepaso.TabIndex = 9;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(962, 557);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(114, 42);
            this.btnVolver.TabIndex = 14;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // frmRepasoBD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 608);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lblRepaso);
            this.Controls.Add(this.dgvOperaciones);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.cboConsulta);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.Button btnVolver;
    }
}