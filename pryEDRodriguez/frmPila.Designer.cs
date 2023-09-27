namespace pryEDRodriguez
{
    partial class frmPila
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
            this.lstPila = new System.Windows.Forms.ListBox();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPila = new System.Windows.Forms.DataGridView();
            this.Tramite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mcrListado = new System.Windows.Forms.GroupBox();
            this.lblTra = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblCod = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.TrámiteE = new System.Windows.Forms.Label();
            this.NombreE = new System.Windows.Forms.Label();
            this.lblCodigoE = new System.Windows.Forms.Label();
            this.txtTramite = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblTramite = new System.Windows.Forms.Label();
            this.mcrEliminado = new System.Windows.Forms.GroupBox();
            this.mcrNuevo = new System.Windows.Forms.GroupBox();
            this.pbImagen = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPila)).BeginInit();
            this.mcrListado.SuspendLayout();
            this.mcrEliminado.SuspendLayout();
            this.mcrNuevo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // lstPila
            // 
            this.lstPila.FormattingEnabled = true;
            this.lstPila.ItemHeight = 16;
            this.lstPila.Location = new System.Drawing.Point(9, 52);
            this.lstPila.Margin = new System.Windows.Forms.Padding(4);
            this.lstPila.Name = "lstPila";
            this.lstPila.Size = new System.Drawing.Size(273, 228);
            this.lstPila.TabIndex = 0;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 150;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Código";
            this.Codigo.MinimumWidth = 6;
            this.Codigo.Name = "Codigo";
            this.Codigo.Width = 125;
            // 
            // dgvPila
            // 
            this.dgvPila.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPila.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.Tramite});
            this.dgvPila.Location = new System.Drawing.Point(356, 52);
            this.dgvPila.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPila.Name = "dgvPila";
            this.dgvPila.RowHeadersWidth = 51;
            this.dgvPila.Size = new System.Drawing.Size(635, 219);
            this.dgvPila.TabIndex = 1;
            // 
            // Tramite
            // 
            this.Tramite.HeaderText = "Trámite";
            this.Tramite.MinimumWidth = 6;
            this.Tramite.Name = "Tramite";
            this.Tramite.Width = 125;
            // 
            // mcrListado
            // 
            this.mcrListado.Controls.Add(this.dgvPila);
            this.mcrListado.Controls.Add(this.lstPila);
            this.mcrListado.Location = new System.Drawing.Point(31, 297);
            this.mcrListado.Margin = new System.Windows.Forms.Padding(4);
            this.mcrListado.Name = "mcrListado";
            this.mcrListado.Padding = new System.Windows.Forms.Padding(4);
            this.mcrListado.Size = new System.Drawing.Size(1021, 311);
            this.mcrListado.TabIndex = 7;
            this.mcrListado.TabStop = false;
            this.mcrListado.Text = "Listado en una Lista y una Grilla";
            // 
            // lblTra
            // 
            this.lblTra.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTra.Location = new System.Drawing.Point(172, 154);
            this.lblTra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTra.Name = "lblTra";
            this.lblTra.Size = new System.Drawing.Size(127, 27);
            this.lblTra.TabIndex = 10;
            // 
            // lblNom
            // 
            this.lblNom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.Location = new System.Drawing.Point(172, 100);
            this.lblNom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(127, 27);
            this.lblNom.TabIndex = 9;
            // 
            // lblCod
            // 
            this.lblCod.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCod.Location = new System.Drawing.Point(172, 48);
            this.lblCod.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(85, 27);
            this.lblCod.TabIndex = 8;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(9, 107);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(80, 20);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(9, 53);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(73, 20);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código:";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(8, 203);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(291, 52);
            this.btnEliminar.TabIndex = 0;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // TrámiteE
            // 
            this.TrámiteE.AutoSize = true;
            this.TrámiteE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TrámiteE.Location = new System.Drawing.Point(9, 161);
            this.TrámiteE.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TrámiteE.Name = "TrámiteE";
            this.TrámiteE.Size = new System.Drawing.Size(79, 20);
            this.TrámiteE.TabIndex = 2;
            this.TrámiteE.Text = "Trámite:";
            // 
            // NombreE
            // 
            this.NombreE.AutoSize = true;
            this.NombreE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreE.Location = new System.Drawing.Point(8, 107);
            this.NombreE.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NombreE.Name = "NombreE";
            this.NombreE.Size = new System.Drawing.Size(80, 20);
            this.NombreE.TabIndex = 1;
            this.NombreE.Text = "Nombre:";
            // 
            // lblCodigoE
            // 
            this.lblCodigoE.AutoSize = true;
            this.lblCodigoE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoE.Location = new System.Drawing.Point(8, 53);
            this.lblCodigoE.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigoE.Name = "lblCodigoE";
            this.lblCodigoE.Size = new System.Drawing.Size(73, 20);
            this.lblCodigoE.TabIndex = 0;
            this.lblCodigoE.Text = "Código:";
            // 
            // txtTramite
            // 
            this.txtTramite.Location = new System.Drawing.Point(137, 154);
            this.txtTramite.Margin = new System.Windows.Forms.Padding(4);
            this.txtTramite.Name = "txtTramite";
            this.txtTramite.Size = new System.Drawing.Size(165, 26);
            this.txtTramite.TabIndex = 2;
            this.txtTramite.TextChanged += new System.EventHandler(this.txtTramite_TextChanged_1);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(137, 100);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(165, 26);
            this.txtNombre.TabIndex = 1;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(183, 48);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(120, 26);
            this.txtCodigo.TabIndex = 0;
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Enabled = false;
            this.btnAgregar.Location = new System.Drawing.Point(13, 204);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(291, 52);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblTramite
            // 
            this.lblTramite.AutoSize = true;
            this.lblTramite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTramite.Location = new System.Drawing.Point(9, 161);
            this.lblTramite.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTramite.Name = "lblTramite";
            this.lblTramite.Size = new System.Drawing.Size(79, 20);
            this.lblTramite.TabIndex = 2;
            this.lblTramite.Text = "Trámite:";
            // 
            // mcrEliminado
            // 
            this.mcrEliminado.Controls.Add(this.lblTra);
            this.mcrEliminado.Controls.Add(this.lblNom);
            this.mcrEliminado.Controls.Add(this.lblCod);
            this.mcrEliminado.Controls.Add(this.btnEliminar);
            this.mcrEliminado.Controls.Add(this.TrámiteE);
            this.mcrEliminado.Controls.Add(this.NombreE);
            this.mcrEliminado.Controls.Add(this.lblCodigoE);
            this.mcrEliminado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mcrEliminado.Location = new System.Drawing.Point(744, 15);
            this.mcrEliminado.Margin = new System.Windows.Forms.Padding(4);
            this.mcrEliminado.Name = "mcrEliminado";
            this.mcrEliminado.Padding = new System.Windows.Forms.Padding(4);
            this.mcrEliminado.Size = new System.Drawing.Size(308, 262);
            this.mcrEliminado.TabIndex = 6;
            this.mcrEliminado.TabStop = false;
            this.mcrEliminado.Text = "Elemento Eliminado";
            // 
            // mcrNuevo
            // 
            this.mcrNuevo.Controls.Add(this.txtTramite);
            this.mcrNuevo.Controls.Add(this.txtNombre);
            this.mcrNuevo.Controls.Add(this.txtCodigo);
            this.mcrNuevo.Controls.Add(this.btnAgregar);
            this.mcrNuevo.Controls.Add(this.lblTramite);
            this.mcrNuevo.Controls.Add(this.lblNombre);
            this.mcrNuevo.Controls.Add(this.lblCodigo);
            this.mcrNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mcrNuevo.Location = new System.Drawing.Point(373, 15);
            this.mcrNuevo.Margin = new System.Windows.Forms.Padding(4);
            this.mcrNuevo.Name = "mcrNuevo";
            this.mcrNuevo.Padding = new System.Windows.Forms.Padding(4);
            this.mcrNuevo.Size = new System.Drawing.Size(312, 262);
            this.mcrNuevo.TabIndex = 5;
            this.mcrNuevo.TabStop = false;
            this.mcrNuevo.Text = "Nuevo Elemento";
            // 
            // pbImagen
            // 
            this.pbImagen.BackgroundImage = global::pryEDRodriguez.Properties.Resources.pila;
            this.pbImagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbImagen.Location = new System.Drawing.Point(31, 21);
            this.pbImagen.Margin = new System.Windows.Forms.Padding(4);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(313, 256);
            this.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbImagen.TabIndex = 8;
            this.pbImagen.TabStop = false;
            this.pbImagen.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frmPila
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 618);
            this.Controls.Add(this.pbImagen);
            this.Controls.Add(this.mcrListado);
            this.Controls.Add(this.mcrEliminado);
            this.Controls.Add(this.mcrNuevo);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPila";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estructura de Datos Lineal -Pila";
            this.Load += new System.EventHandler(this.frmPila_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPila)).EndInit();
            this.mcrListado.ResumeLayout(false);
            this.mcrEliminado.ResumeLayout(false);
            this.mcrEliminado.PerformLayout();
            this.mcrNuevo.ResumeLayout(false);
            this.mcrNuevo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstPila;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridView dgvPila;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tramite;
        private System.Windows.Forms.GroupBox mcrListado;
        private System.Windows.Forms.Label lblTra;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblCod;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label TrámiteE;
        private System.Windows.Forms.Label NombreE;
        private System.Windows.Forms.Label lblCodigoE;
        private System.Windows.Forms.TextBox txtTramite;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblTramite;
        private System.Windows.Forms.GroupBox mcrEliminado;
        private System.Windows.Forms.GroupBox mcrNuevo;
        private System.Windows.Forms.PictureBox pbImagen;
    }
}