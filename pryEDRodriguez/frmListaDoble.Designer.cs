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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.rbAscendente = new System.Windows.Forms.RadioButton();
            this.rbDescendente = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.mcrNuevo.SuspendLayout();
            this.mcrEliminado.SuspendLayout();
            this.mcrListaDoble.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lstLista
            // 
            this.lstLista.FormattingEnabled = true;
            this.lstLista.Location = new System.Drawing.Point(7, 42);
            this.lstLista.Name = "lstLista";
            this.lstLista.Size = new System.Drawing.Size(206, 186);
            this.lstLista.TabIndex = 0;
            // 
            // Tramite
            // 
            this.Tramite.HeaderText = "Trámite";
            this.Tramite.Name = "Tramite";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 150;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(103, 91);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(125, 22);
            this.txtNombre.TabIndex = 5;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(137, 39);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(91, 22);
            this.txtCodigo.TabIndex = 4;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Código";
            this.Codigo.Name = "Codigo";
            // 
            // txtTramite
            // 
            this.txtTramite.Location = new System.Drawing.Point(103, 143);
            this.txtTramite.Name = "txtTramite";
            this.txtTramite.Size = new System.Drawing.Size(125, 22);
            this.txtTramite.TabIndex = 6;
            // 
            // dgvLista
            // 
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.Tramite});
            this.dgvLista.Location = new System.Drawing.Point(267, 42);
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.Size = new System.Drawing.Size(454, 170);
            this.dgvLista.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvLista);
            this.groupBox1.Controls.Add(this.lstLista);
            this.groupBox1.Location = new System.Drawing.Point(17, 269);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(794, 256);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Listado en una Lista y una Grilla";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Enabled = false;
            this.btnAgregar.Location = new System.Drawing.Point(10, 184);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(218, 42);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // cboEliminar
            // 
            this.cboEliminar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEliminar.FormattingEnabled = true;
            this.cboEliminar.Location = new System.Drawing.Point(99, 39);
            this.cboEliminar.Name = "cboEliminar";
            this.cboEliminar.Size = new System.Drawing.Size(125, 24);
            this.cboEliminar.TabIndex = 8;
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
            this.mcrNuevo.Location = new System.Drawing.Point(317, 13);
            this.mcrNuevo.Name = "mcrNuevo";
            this.mcrNuevo.Size = new System.Drawing.Size(238, 250);
            this.mcrNuevo.TabIndex = 13;
            this.mcrNuevo.TabStop = false;
            this.mcrNuevo.Text = "Nuevo Elemento";
            // 
            // lblTramite
            // 
            this.lblTramite.AutoSize = true;
            this.lblTramite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTramite.Location = new System.Drawing.Point(6, 146);
            this.lblTramite.Name = "lblTramite";
            this.lblTramite.Size = new System.Drawing.Size(64, 16);
            this.lblTramite.TabIndex = 2;
            this.lblTramite.Text = "Trámite:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(7, 97);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(66, 16);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(7, 45);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(61, 16);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código:";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(7, 81);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(218, 42);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // lblCodigoE
            // 
            this.lblCodigoE.AutoSize = true;
            this.lblCodigoE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoE.Location = new System.Drawing.Point(6, 43);
            this.lblCodigoE.Name = "lblCodigoE";
            this.lblCodigoE.Size = new System.Drawing.Size(61, 16);
            this.lblCodigoE.TabIndex = 0;
            this.lblCodigoE.Text = "Código:";
            // 
            // mcrEliminado
            // 
            this.mcrEliminado.Controls.Add(this.cboEliminar);
            this.mcrEliminado.Controls.Add(this.btnEliminar);
            this.mcrEliminado.Controls.Add(this.lblCodigoE);
            this.mcrEliminado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mcrEliminado.Location = new System.Drawing.Point(580, 13);
            this.mcrEliminado.Name = "mcrEliminado";
            this.mcrEliminado.Size = new System.Drawing.Size(231, 161);
            this.mcrEliminado.TabIndex = 14;
            this.mcrEliminado.TabStop = false;
            this.mcrEliminado.Text = "Elemento Eliminado";
            // 
            // mcrListaDoble
            // 
            this.mcrListaDoble.Controls.Add(this.rbDescendente);
            this.mcrListaDoble.Controls.Add(this.rbAscendente);
            this.mcrListaDoble.Location = new System.Drawing.Point(580, 181);
            this.mcrListaDoble.Name = "mcrListaDoble";
            this.mcrListaDoble.Size = new System.Drawing.Size(231, 81);
            this.mcrListaDoble.TabIndex = 17;
            this.mcrListaDoble.TabStop = false;
            this.mcrListaDoble.Text = "Listar Datos";
            // 
            // rbAscendente
            // 
            this.rbAscendente.AutoSize = true;
            this.rbAscendente.Location = new System.Drawing.Point(6, 31);
            this.rbAscendente.Name = "rbAscendente";
            this.rbAscendente.Size = new System.Drawing.Size(82, 17);
            this.rbAscendente.TabIndex = 0;
            this.rbAscendente.TabStop = true;
            this.rbAscendente.Text = "Ascendente";
            this.rbAscendente.UseVisualStyleBackColor = true;
            // 
            // rbDescendente
            // 
            this.rbDescendente.AutoSize = true;
            this.rbDescendente.Location = new System.Drawing.Point(6, 59);
            this.rbDescendente.Name = "rbDescendente";
            this.rbDescendente.Size = new System.Drawing.Size(89, 17);
            this.rbDescendente.TabIndex = 1;
            this.rbDescendente.TabStop = true;
            this.rbDescendente.Text = "Descendente";
            this.rbDescendente.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::pryEDRodriguez.Properties.Resources.lista_doble;
            this.pictureBox1.Location = new System.Drawing.Point(17, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(294, 250);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // frmListaDoble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 537);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.mcrListaDoble);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.mcrNuevo);
            this.Controls.Add(this.mcrEliminado);
            this.Name = "frmListaDoble";
            this.Text = "frmListaDoble";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.mcrNuevo.ResumeLayout(false);
            this.mcrNuevo.PerformLayout();
            this.mcrEliminado.ResumeLayout(false);
            this.mcrEliminado.PerformLayout();
            this.mcrListaDoble.ResumeLayout(false);
            this.mcrListaDoble.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.GroupBox groupBox1;
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
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}