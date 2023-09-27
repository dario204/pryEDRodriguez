namespace pryEDRodriguez
{
    partial class frmListaDoble
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
            this.lstLista = new System.Windows.Forms.ListBox();
            this.Tramite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTramite = new System.Windows.Forms.TextBox();
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.mcrListado = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.cboEliminar = new System.Windows.Forms.ComboBox();
            this.mcrNuevo = new System.Windows.Forms.GroupBox();
            this.lblTramite = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblCodigoE = new System.Windows.Forms.Label();
            this.mcrEliminado = new System.Windows.Forms.GroupBox();
            this.mcrListaDoble = new System.Windows.Forms.GroupBox();
            this.rbDescendente = new System.Windows.Forms.RadioButton();
            this.rbAscendente = new System.Windows.Forms.RadioButton();
            this.pbImagen = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            this.mcrListado.SuspendLayout();
            this.mcrNuevo.SuspendLayout();
            this.mcrEliminado.SuspendLayout();
            this.mcrListaDoble.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // lstLista
            // 
            this.lstLista.FormattingEnabled = true;
            this.lstLista.ItemHeight = 16;
            this.lstLista.Location = new System.Drawing.Point(9, 52);
            this.lstLista.Margin = new System.Windows.Forms.Padding(4);
            this.lstLista.Name = "lstLista";
            this.lstLista.Size = new System.Drawing.Size(273, 228);
            this.lstLista.TabIndex = 0;
            // 
            // Tramite
            // 
            this.Tramite.HeaderText = "Trámite";
            this.Tramite.MinimumWidth = 6;
            this.Tramite.Name = "Tramite";
            this.Tramite.Width = 125;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 150;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(137, 112);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(165, 26);
            this.txtNombre.TabIndex = 5;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(183, 48);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(120, 26);
            this.txtCodigo.TabIndex = 4;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Código";
            this.Codigo.MinimumWidth = 6;
            this.Codigo.Name = "Codigo";
            this.Codigo.Width = 125;
            // 
            // txtTramite
            // 
            this.txtTramite.Location = new System.Drawing.Point(137, 176);
            this.txtTramite.Margin = new System.Windows.Forms.Padding(4);
            this.txtTramite.Name = "txtTramite";
            this.txtTramite.Size = new System.Drawing.Size(165, 26);
            this.txtTramite.TabIndex = 6;
            this.txtTramite.TextChanged += new System.EventHandler(this.txtTramite_TextChanged);
            // 
            // dgvLista
            // 
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.Tramite});
            this.dgvLista.Location = new System.Drawing.Point(356, 52);
            this.dgvLista.Margin = new System.Windows.Forms.Padding(4);
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.RowHeadersWidth = 51;
            this.dgvLista.Size = new System.Drawing.Size(605, 209);
            this.dgvLista.TabIndex = 1;
            // 
            // mcrListado
            // 
            this.mcrListado.Controls.Add(this.dgvLista);
            this.mcrListado.Controls.Add(this.lstLista);
            this.mcrListado.Location = new System.Drawing.Point(23, 331);
            this.mcrListado.Margin = new System.Windows.Forms.Padding(4);
            this.mcrListado.Name = "mcrListado";
            this.mcrListado.Padding = new System.Windows.Forms.Padding(4);
            this.mcrListado.Size = new System.Drawing.Size(1059, 315);
            this.mcrListado.TabIndex = 15;
            this.mcrListado.TabStop = false;
            this.mcrListado.Text = "Listado en una Lista y una Grilla";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Enabled = false;
            this.btnAgregar.Location = new System.Drawing.Point(13, 226);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(291, 52);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // cboEliminar
            // 
            this.cboEliminar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEliminar.FormattingEnabled = true;
            this.cboEliminar.Location = new System.Drawing.Point(132, 48);
            this.cboEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.cboEliminar.Name = "cboEliminar";
            this.cboEliminar.Size = new System.Drawing.Size(165, 28);
            this.cboEliminar.TabIndex = 8;
            this.cboEliminar.SelectedIndexChanged += new System.EventHandler(this.cboEliminar_SelectedIndexChanged);
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
            this.mcrNuevo.Location = new System.Drawing.Point(423, 16);
            this.mcrNuevo.Margin = new System.Windows.Forms.Padding(4);
            this.mcrNuevo.Name = "mcrNuevo";
            this.mcrNuevo.Padding = new System.Windows.Forms.Padding(4);
            this.mcrNuevo.Size = new System.Drawing.Size(317, 308);
            this.mcrNuevo.TabIndex = 13;
            this.mcrNuevo.TabStop = false;
            this.mcrNuevo.Text = "Nuevo Elemento";
            // 
            // lblTramite
            // 
            this.lblTramite.AutoSize = true;
            this.lblTramite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTramite.Location = new System.Drawing.Point(8, 180);
            this.lblTramite.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTramite.Name = "lblTramite";
            this.lblTramite.Size = new System.Drawing.Size(79, 20);
            this.lblTramite.TabIndex = 2;
            this.lblTramite.Text = "Trámite:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(9, 119);
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
            this.lblCodigo.Location = new System.Drawing.Point(9, 55);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(73, 20);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código:";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(9, 100);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(291, 52);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
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
            // mcrEliminado
            // 
            this.mcrEliminado.Controls.Add(this.cboEliminar);
            this.mcrEliminado.Controls.Add(this.btnEliminar);
            this.mcrEliminado.Controls.Add(this.lblCodigoE);
            this.mcrEliminado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mcrEliminado.Location = new System.Drawing.Point(773, 16);
            this.mcrEliminado.Margin = new System.Windows.Forms.Padding(4);
            this.mcrEliminado.Name = "mcrEliminado";
            this.mcrEliminado.Padding = new System.Windows.Forms.Padding(4);
            this.mcrEliminado.Size = new System.Drawing.Size(308, 198);
            this.mcrEliminado.TabIndex = 14;
            this.mcrEliminado.TabStop = false;
            this.mcrEliminado.Text = "Elemento Eliminado";
            // 
            // mcrListaDoble
            // 
            this.mcrListaDoble.Controls.Add(this.rbDescendente);
            this.mcrListaDoble.Controls.Add(this.rbAscendente);
            this.mcrListaDoble.Location = new System.Drawing.Point(773, 223);
            this.mcrListaDoble.Margin = new System.Windows.Forms.Padding(4);
            this.mcrListaDoble.Name = "mcrListaDoble";
            this.mcrListaDoble.Padding = new System.Windows.Forms.Padding(4);
            this.mcrListaDoble.Size = new System.Drawing.Size(308, 100);
            this.mcrListaDoble.TabIndex = 17;
            this.mcrListaDoble.TabStop = false;
            this.mcrListaDoble.Text = "Listar Datos";
            // 
            // rbDescendente
            // 
            this.rbDescendente.AutoSize = true;
            this.rbDescendente.Location = new System.Drawing.Point(8, 73);
            this.rbDescendente.Margin = new System.Windows.Forms.Padding(4);
            this.rbDescendente.Name = "rbDescendente";
            this.rbDescendente.Size = new System.Drawing.Size(109, 20);
            this.rbDescendente.TabIndex = 1;
            this.rbDescendente.TabStop = true;
            this.rbDescendente.Text = "Descendente";
            this.rbDescendente.UseVisualStyleBackColor = true;
            this.rbDescendente.CheckedChanged += new System.EventHandler(this.rbDescendente_CheckedChanged);
            // 
            // rbAscendente
            // 
            this.rbAscendente.AutoSize = true;
            this.rbAscendente.Location = new System.Drawing.Point(8, 38);
            this.rbAscendente.Margin = new System.Windows.Forms.Padding(4);
            this.rbAscendente.Name = "rbAscendente";
            this.rbAscendente.Size = new System.Drawing.Size(100, 20);
            this.rbAscendente.TabIndex = 0;
            this.rbAscendente.TabStop = true;
            this.rbAscendente.Text = "Ascendente";
            this.rbAscendente.UseVisualStyleBackColor = true;
            this.rbAscendente.CheckedChanged += new System.EventHandler(this.rbAscendente_CheckedChanged);
            // 
            // pbImagen
            // 
            this.pbImagen.BackgroundImage = global::pryEDRodriguez.Properties.Resources.lista_doble;
            this.pbImagen.Location = new System.Drawing.Point(23, 16);
            this.pbImagen.Margin = new System.Windows.Forms.Padding(4);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(367, 307);
            this.pbImagen.TabIndex = 2;
            this.pbImagen.TabStop = false;
            // 
            // frmListaDoble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 661);
            this.Controls.Add(this.pbImagen);
            this.Controls.Add(this.mcrListaDoble);
            this.Controls.Add(this.mcrListado);
            this.Controls.Add(this.mcrNuevo);
            this.Controls.Add(this.mcrEliminado);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmListaDoble";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estructura de Datos Lineal - Lista Doble";
            this.Load += new System.EventHandler(this.frmListaDoble_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            this.mcrListado.ResumeLayout(false);
            this.mcrNuevo.ResumeLayout(false);
            this.mcrNuevo.PerformLayout();
            this.mcrEliminado.ResumeLayout(false);
            this.mcrEliminado.PerformLayout();
            this.mcrListaDoble.ResumeLayout(false);
            this.mcrListaDoble.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox lstLista;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tramite;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.TextBox txtTramite;
        private System.Windows.Forms.DataGridView dgvLista;
        private System.Windows.Forms.GroupBox mcrListado;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ComboBox cboEliminar;
        private System.Windows.Forms.GroupBox mcrNuevo;
        private System.Windows.Forms.Label lblTramite;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblCodigoE;
        private System.Windows.Forms.GroupBox mcrEliminado;
        private System.Windows.Forms.GroupBox mcrListaDoble;
        private System.Windows.Forms.RadioButton rbDescendente;
        private System.Windows.Forms.RadioButton rbAscendente;
        private System.Windows.Forms.PictureBox pbImagen;
    }
}