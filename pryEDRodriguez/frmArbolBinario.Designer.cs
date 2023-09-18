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
            this.label1 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnEquilibrar = new System.Windows.Forms.Button();
            this.mcrListado = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tramite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rbPost = new System.Windows.Forms.RadioButton();
            this.rbPre = new System.Windows.Forms.RadioButton();
            this.rbIn = new System.Windows.Forms.RadioButton();
            this.mcrElemento.SuspendLayout();
            this.mcrEliminar.SuspendLayout();
            this.mcrListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tvArchivos
            // 
            this.tvArchivos.Location = new System.Drawing.Point(13, 13);
            this.tvArchivos.Name = "tvArchivos";
            this.tvArchivos.Size = new System.Drawing.Size(204, 196);
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
            this.mcrElemento.Location = new System.Drawing.Point(236, 13);
            this.mcrElemento.Name = "mcrElemento";
            this.mcrElemento.Size = new System.Drawing.Size(208, 196);
            this.mcrElemento.TabIndex = 1;
            this.mcrElemento.TabStop = false;
            this.mcrElemento.Text = "Nuevo Elemento";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(112, 32);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(90, 20);
            this.txtCodigo.TabIndex = 6;
            // 
            // txtTramite
            // 
            this.txtTramite.Location = new System.Drawing.Point(81, 120);
            this.txtTramite.Name = "txtTramite";
            this.txtTramite.Size = new System.Drawing.Size(121, 20);
            this.txtTramite.TabIndex = 5;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(81, 76);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(121, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // lblTramite
            // 
            this.lblTramite.AutoSize = true;
            this.lblTramite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTramite.Location = new System.Drawing.Point(4, 120);
            this.lblTramite.Name = "lblTramite";
            this.lblTramite.Size = new System.Drawing.Size(56, 16);
            this.lblTramite.TabIndex = 3;
            this.lblTramite.Text = "Trámite:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(7, 154);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(195, 42);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(4, 76);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(59, 16);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(4, 38);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(54, 16);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código:";
            // 
            // mcrEliminar
            // 
            this.mcrEliminar.Controls.Add(this.label1);
            this.mcrEliminar.Controls.Add(this.btnEliminar);
            this.mcrEliminar.Controls.Add(this.comboBox1);
            this.mcrEliminar.Location = new System.Drawing.Point(470, 13);
            this.mcrEliminar.Name = "mcrEliminar";
            this.mcrEliminar.Size = new System.Drawing.Size(200, 121);
            this.mcrEliminar.TabIndex = 2;
            this.mcrEliminar.TabStop = false;
            this.mcrEliminar.Text = "Elemento a Eliminar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Código:";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(7, 76);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(187, 39);
            this.btnEliminar.TabIndex = 1;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(89, 30);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(111, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // btnEquilibrar
            // 
            this.btnEquilibrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEquilibrar.Location = new System.Drawing.Point(470, 167);
            this.btnEquilibrar.Name = "btnEquilibrar";
            this.btnEquilibrar.Size = new System.Drawing.Size(200, 42);
            this.btnEquilibrar.TabIndex = 3;
            this.btnEquilibrar.Text = "Equlibrar";
            this.btnEquilibrar.UseVisualStyleBackColor = true;
            // 
            // mcrListado
            // 
            this.mcrListado.Controls.Add(this.dataGridView1);
            this.mcrListado.Controls.Add(this.rbPost);
            this.mcrListado.Controls.Add(this.rbPre);
            this.mcrListado.Controls.Add(this.rbIn);
            this.mcrListado.Location = new System.Drawing.Point(13, 226);
            this.mcrListado.Name = "mcrListado";
            this.mcrListado.Size = new System.Drawing.Size(657, 180);
            this.mcrListado.TabIndex = 4;
            this.mcrListado.TabStop = false;
            this.mcrListado.Text = "Listado de Árbol";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.Tramite});
            this.dataGridView1.Location = new System.Drawing.Point(230, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(421, 125);
            this.dataGridView1.TabIndex = 3;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Tramite
            // 
            this.Tramite.HeaderText = "Tramite";
            this.Tramite.Name = "Tramite";
            // 
            // rbPost
            // 
            this.rbPost.AutoSize = true;
            this.rbPost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPost.Location = new System.Drawing.Point(46, 115);
            this.rbPost.Name = "rbPost";
            this.rbPost.Size = new System.Drawing.Size(93, 20);
            this.rbPost.TabIndex = 2;
            this.rbPost.TabStop = true;
            this.rbPost.Text = "Post-Orden";
            this.rbPost.UseVisualStyleBackColor = true;
            // 
            // rbPre
            // 
            this.rbPre.AutoSize = true;
            this.rbPre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPre.Location = new System.Drawing.Point(46, 71);
            this.rbPre.Name = "rbPre";
            this.rbPre.Size = new System.Drawing.Size(87, 20);
            this.rbPre.TabIndex = 1;
            this.rbPre.TabStop = true;
            this.rbPre.Text = "Pre-Orden";
            this.rbPre.UseVisualStyleBackColor = true;
            // 
            // rbIn
            // 
            this.rbIn.AutoSize = true;
            this.rbIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbIn.Location = new System.Drawing.Point(46, 28);
            this.rbIn.Name = "rbIn";
            this.rbIn.Size = new System.Drawing.Size(73, 20);
            this.rbIn.TabIndex = 0;
            this.rbIn.TabStop = true;
            this.rbIn.Text = "In-Order";
            this.rbIn.UseVisualStyleBackColor = true;
            // 
            // frmArbolBinario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 418);
            this.Controls.Add(this.mcrListado);
            this.Controls.Add(this.btnEquilibrar);
            this.Controls.Add(this.mcrEliminar);
            this.Controls.Add(this.mcrElemento);
            this.Controls.Add(this.tvArchivos);
            this.Name = "frmArbolBinario";
            this.Text = "Estructuras Ramificadas - Arbol Binario";
            this.Load += new System.EventHandler(this.frmArbolBinario_Load);
            this.mcrElemento.ResumeLayout(false);
            this.mcrElemento.PerformLayout();
            this.mcrEliminar.ResumeLayout(false);
            this.mcrEliminar.PerformLayout();
            this.mcrListado.ResumeLayout(false);
            this.mcrListado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnEquilibrar;
        private System.Windows.Forms.GroupBox mcrListado;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tramite;
        private System.Windows.Forms.RadioButton rbPost;
        private System.Windows.Forms.RadioButton rbPre;
        private System.Windows.Forms.RadioButton rbIn;
    }
}