namespace pryEDRodriguez
{
    partial class frmArbolBinario
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
            this.tvArchivos = new System.Windows.Forms.TreeView();
            this.mcrElemento = new System.Windows.Forms.GroupBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtTramite = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblTramite = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.mcrEliminar = new System.Windows.Forms.GroupBox();
            this.lblCodigoEliminar = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.cboEliminar = new System.Windows.Forms.ComboBox();
            this.btnEquilibrar = new System.Windows.Forms.Button();
            this.mcrListado = new System.Windows.Forms.GroupBox();
            this.btnExportar = new System.Windows.Forms.Button();
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tramite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rbPost = new System.Windows.Forms.RadioButton();
            this.rbPre = new System.Windows.Forms.RadioButton();
            this.rbIn = new System.Windows.Forms.RadioButton();
            this.mcrElemento.SuspendLayout();
            this.mcrEliminar.SuspendLayout();
            this.mcrListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            this.SuspendLayout();
            // 
            // tvArchivos
            // 
            this.tvArchivos.Location = new System.Drawing.Point(17, 16);
            this.tvArchivos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tvArchivos.Name = "tvArchivos";
            this.tvArchivos.Size = new System.Drawing.Size(271, 240);
            this.tvArchivos.TabIndex = 0;
            // 
            // mcrElemento
            // 
            this.mcrElemento.Controls.Add(this.txtCodigo);
            this.mcrElemento.Controls.Add(this.txtTramite);
            this.mcrElemento.Controls.Add(this.txtNombre);
            this.mcrElemento.Controls.Add(this.lblTramite);
            this.mcrElemento.Controls.Add(this.btnAgregar);
            this.mcrElemento.Controls.Add(this.lblNombre);
            this.mcrElemento.Controls.Add(this.lblCodigo);
            this.mcrElemento.Location = new System.Drawing.Point(315, 16);
            this.mcrElemento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mcrElemento.Name = "mcrElemento";
            this.mcrElemento.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mcrElemento.Size = new System.Drawing.Size(277, 241);
            this.mcrElemento.TabIndex = 1;
            this.mcrElemento.TabStop = false;
            this.mcrElemento.Text = "Nuevo Elemento";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(149, 39);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(119, 22);
            this.txtCodigo.TabIndex = 0;
            // 
            // txtTramite
            // 
            this.txtTramite.Location = new System.Drawing.Point(108, 148);
            this.txtTramite.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTramite.Name = "txtTramite";
            this.txtTramite.Size = new System.Drawing.Size(160, 22);
            this.txtTramite.TabIndex = 2;
            this.txtTramite.TextChanged += new System.EventHandler(this.txtTramite_TextChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(108, 94);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(160, 22);
            this.txtNombre.TabIndex = 1;
            // 
            // lblTramite
            // 
            this.lblTramite.AutoSize = true;
            this.lblTramite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTramite.Location = new System.Drawing.Point(5, 148);
            this.lblTramite.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTramite.Name = "lblTramite";
            this.lblTramite.Size = new System.Drawing.Size(71, 20);
            this.lblTramite.TabIndex = 3;
            this.lblTramite.Text = "Trámite:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Enabled = false;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(9, 190);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(260, 52);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(5, 94);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(73, 20);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(5, 47);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(66, 20);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código:";
            // 
            // mcrEliminar
            // 
            this.mcrEliminar.Controls.Add(this.lblCodigoEliminar);
            this.mcrEliminar.Controls.Add(this.btnEliminar);
            this.mcrEliminar.Controls.Add(this.cboEliminar);
            this.mcrEliminar.Location = new System.Drawing.Point(627, 16);
            this.mcrEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mcrEliminar.Name = "mcrEliminar";
            this.mcrEliminar.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mcrEliminar.Size = new System.Drawing.Size(267, 149);
            this.mcrEliminar.TabIndex = 2;
            this.mcrEliminar.TabStop = false;
            this.mcrEliminar.Text = "Elemento a Eliminar";
            // 
            // lblCodigoEliminar
            // 
            this.lblCodigoEliminar.AutoSize = true;
            this.lblCodigoEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoEliminar.Location = new System.Drawing.Point(8, 41);
            this.lblCodigoEliminar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigoEliminar.Name = "lblCodigoEliminar";
            this.lblCodigoEliminar.Size = new System.Drawing.Size(66, 20);
            this.lblCodigoEliminar.TabIndex = 7;
            this.lblCodigoEliminar.Text = "Código:";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(9, 94);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(249, 48);
            this.btnEliminar.TabIndex = 1;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // cboEliminar
            // 
            this.cboEliminar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEliminar.FormattingEnabled = true;
            this.cboEliminar.Location = new System.Drawing.Point(119, 37);
            this.cboEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboEliminar.Name = "cboEliminar";
            this.cboEliminar.Size = new System.Drawing.Size(147, 24);
            this.cboEliminar.TabIndex = 0;
            this.cboEliminar.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnEquilibrar
            // 
            this.btnEquilibrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEquilibrar.Location = new System.Drawing.Point(627, 206);
            this.btnEquilibrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEquilibrar.Name = "btnEquilibrar";
            this.btnEquilibrar.Size = new System.Drawing.Size(267, 52);
            this.btnEquilibrar.TabIndex = 3;
            this.btnEquilibrar.Text = "Equlibrar";
            this.btnEquilibrar.UseVisualStyleBackColor = true;
            this.btnEquilibrar.Click += new System.EventHandler(this.btnEquilibrar_Click);
            // 
            // mcrListado
            // 
            this.mcrListado.Controls.Add(this.btnExportar);
            this.mcrListado.Controls.Add(this.dgvLista);
            this.mcrListado.Controls.Add(this.rbPost);
            this.mcrListado.Controls.Add(this.rbPre);
            this.mcrListado.Controls.Add(this.rbIn);
            this.mcrListado.Location = new System.Drawing.Point(17, 278);
            this.mcrListado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mcrListado.Name = "mcrListado";
            this.mcrListado.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mcrListado.Size = new System.Drawing.Size(876, 222);
            this.mcrListado.TabIndex = 4;
            this.mcrListado.TabStop = false;
            this.mcrListado.Text = "Listado de Árbol";
            // 
            // btnExportar
            // 
            this.btnExportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportar.Location = new System.Drawing.Point(40, 162);
            this.btnExportar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(172, 52);
            this.btnExportar.TabIndex = 5;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // dgvLista
            // 
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.Tramite});
            this.dgvLista.Location = new System.Drawing.Point(307, 34);
            this.dgvLista.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.RowHeadersWidth = 51;
            this.dgvLista.Size = new System.Drawing.Size(561, 180);
            this.dgvLista.TabIndex = 1;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.MinimumWidth = 6;
            this.Codigo.Name = "Codigo";
            this.Codigo.Width = 125;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 125;
            // 
            // Tramite
            // 
            this.Tramite.HeaderText = "Tramite";
            this.Tramite.MinimumWidth = 6;
            this.Tramite.Name = "Tramite";
            this.Tramite.Width = 125;
            // 
            // rbPost
            // 
            this.rbPost.AutoSize = true;
            this.rbPost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPost.Location = new System.Drawing.Point(61, 122);
            this.rbPost.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbPost.Name = "rbPost";
            this.rbPost.Size = new System.Drawing.Size(116, 24);
            this.rbPost.TabIndex = 2;
            this.rbPost.TabStop = true;
            this.rbPost.Text = "Post-Orden";
            this.rbPost.UseVisualStyleBackColor = true;
            this.rbPost.CheckedChanged += new System.EventHandler(this.rbPost_CheckedChanged);
            // 
            // rbPre
            // 
            this.rbPre.AutoSize = true;
            this.rbPre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPre.Location = new System.Drawing.Point(61, 78);
            this.rbPre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbPre.Name = "rbPre";
            this.rbPre.Size = new System.Drawing.Size(108, 24);
            this.rbPre.TabIndex = 1;
            this.rbPre.TabStop = true;
            this.rbPre.Text = "Pre-Orden";
            this.rbPre.UseVisualStyleBackColor = true;
            this.rbPre.CheckedChanged += new System.EventHandler(this.rbPre_CheckedChanged);
            // 
            // rbIn
            // 
            this.rbIn.AutoSize = true;
            this.rbIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbIn.Location = new System.Drawing.Point(61, 34);
            this.rbIn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbIn.Name = "rbIn";
            this.rbIn.Size = new System.Drawing.Size(92, 24);
            this.rbIn.TabIndex = 0;
            this.rbIn.TabStop = true;
            this.rbIn.Text = "In-Order";
            this.rbIn.UseVisualStyleBackColor = true;
            this.rbIn.CheckedChanged += new System.EventHandler(this.rbIn_CheckedChanged);
            // 
            // frmArbolBinario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 520);
            this.Controls.Add(this.mcrListado);
            this.Controls.Add(this.btnEquilibrar);
            this.Controls.Add(this.mcrEliminar);
            this.Controls.Add(this.mcrElemento);
            this.Controls.Add(this.tvArchivos);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmArbolBinario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estructuras Ramificadas - Arbol Binario";
            this.Load += new System.EventHandler(this.frmArbolBinario_Load);
            this.mcrElemento.ResumeLayout(false);
            this.mcrElemento.PerformLayout();
            this.mcrEliminar.ResumeLayout(false);
            this.mcrEliminar.PerformLayout();
            this.mcrListado.ResumeLayout(false);
            this.mcrListado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tvArchivos;
        private System.Windows.Forms.GroupBox mcrElemento;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtTramite;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblTramite;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.GroupBox mcrEliminar;
        private System.Windows.Forms.Label lblCodigoEliminar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.ComboBox cboEliminar;
        private System.Windows.Forms.Button btnEquilibrar;
        private System.Windows.Forms.GroupBox mcrListado;
        private System.Windows.Forms.DataGridView dgvLista;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tramite;
        private System.Windows.Forms.RadioButton rbPost;
        private System.Windows.Forms.RadioButton rbPre;
        private System.Windows.Forms.RadioButton rbIn;
        private System.Windows.Forms.Button btnExportar;
    }
}