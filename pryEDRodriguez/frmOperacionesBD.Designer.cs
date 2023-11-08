namespace pryEDRodriguez
{
    partial class frmOperacionesBD
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
            this.dgvBaseDatos = new System.Windows.Forms.DataGridView();
            this.mcrSelect = new System.Windows.Forms.GroupBox();
            this.btnProyeccionMultiatributo = new System.Windows.Forms.Button();
            this.btnProyeccionSimple = new System.Windows.Forms.Button();
            this.btnJuntar = new System.Windows.Forms.Button();
            this.mcrWhere = new System.Windows.Forms.GroupBox();
            this.btnSeleccionMultiatributo = new System.Windows.Forms.Button();
            this.btnSeleccionSimple = new System.Windows.Forms.Button();
            this.btnSeleccionConvolucion = new System.Windows.Forms.Button();
            this.mcrAlgebraicas = new System.Windows.Forms.GroupBox();
            this.btnInterseccion = new System.Windows.Forms.Button();
            this.btnUnion = new System.Windows.Forms.Button();
            this.btnDiferencia = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaseDatos)).BeginInit();
            this.mcrSelect.SuspendLayout();
            this.mcrWhere.SuspendLayout();
            this.mcrAlgebraicas.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvBaseDatos
            // 
            this.dgvBaseDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBaseDatos.Location = new System.Drawing.Point(17, 16);
            this.dgvBaseDatos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvBaseDatos.Name = "dgvBaseDatos";
            this.dgvBaseDatos.RowHeadersWidth = 51;
            this.dgvBaseDatos.Size = new System.Drawing.Size(1303, 407);
            this.dgvBaseDatos.TabIndex = 0;
            // 
            // mcrSelect
            // 
            this.mcrSelect.Controls.Add(this.btnProyeccionMultiatributo);
            this.mcrSelect.Controls.Add(this.btnProyeccionSimple);
            this.mcrSelect.Controls.Add(this.btnJuntar);
            this.mcrSelect.Location = new System.Drawing.Point(17, 444);
            this.mcrSelect.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mcrSelect.Name = "mcrSelect";
            this.mcrSelect.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mcrSelect.Size = new System.Drawing.Size(395, 210);
            this.mcrSelect.TabIndex = 1;
            this.mcrSelect.TabStop = false;
            this.mcrSelect.Text = "Operaciones de Proyección - SELECT";
            // 
            // btnProyeccionMultiatributo
            // 
            this.btnProyeccionMultiatributo.Location = new System.Drawing.Point(9, 80);
            this.btnProyeccionMultiatributo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnProyeccionMultiatributo.Name = "btnProyeccionMultiatributo";
            this.btnProyeccionMultiatributo.Size = new System.Drawing.Size(377, 36);
            this.btnProyeccionMultiatributo.TabIndex = 4;
            this.btnProyeccionMultiatributo.Text = "Proyeccion Multiatributo";
            this.btnProyeccionMultiatributo.UseVisualStyleBackColor = true;
            this.btnProyeccionMultiatributo.Click += new System.EventHandler(this.btnProyeccionMultiatributo_Click);
            // 
            // btnProyeccionSimple
            // 
            this.btnProyeccionSimple.Location = new System.Drawing.Point(9, 23);
            this.btnProyeccionSimple.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnProyeccionSimple.Name = "btnProyeccionSimple";
            this.btnProyeccionSimple.Size = new System.Drawing.Size(377, 36);
            this.btnProyeccionSimple.TabIndex = 3;
            this.btnProyeccionSimple.Text = "Proyeccion Simple";
            this.btnProyeccionSimple.UseVisualStyleBackColor = true;
            this.btnProyeccionSimple.Click += new System.EventHandler(this.btnProyeccionSimple_Click);
            // 
            // btnJuntar
            // 
            this.btnJuntar.Location = new System.Drawing.Point(9, 139);
            this.btnJuntar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnJuntar.Name = "btnJuntar";
            this.btnJuntar.Size = new System.Drawing.Size(377, 36);
            this.btnJuntar.TabIndex = 2;
            this.btnJuntar.Text = "Juntar";
            this.btnJuntar.UseVisualStyleBackColor = true;
            this.btnJuntar.Click += new System.EventHandler(this.btnJuntar_Click);
            // 
            // mcrWhere
            // 
            this.mcrWhere.Controls.Add(this.btnSeleccionMultiatributo);
            this.mcrWhere.Controls.Add(this.btnSeleccionSimple);
            this.mcrWhere.Controls.Add(this.btnSeleccionConvolucion);
            this.mcrWhere.Location = new System.Drawing.Point(469, 444);
            this.mcrWhere.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mcrWhere.Name = "mcrWhere";
            this.mcrWhere.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mcrWhere.Size = new System.Drawing.Size(395, 210);
            this.mcrWhere.TabIndex = 5;
            this.mcrWhere.TabStop = false;
            this.mcrWhere.Text = "Operaciones de Selección  - WHERE";
            // 
            // btnSeleccionMultiatributo
            // 
            this.btnSeleccionMultiatributo.Location = new System.Drawing.Point(9, 80);
            this.btnSeleccionMultiatributo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSeleccionMultiatributo.Name = "btnSeleccionMultiatributo";
            this.btnSeleccionMultiatributo.Size = new System.Drawing.Size(377, 36);
            this.btnSeleccionMultiatributo.TabIndex = 4;
            this.btnSeleccionMultiatributo.Text = "Seleccion Multiatributo";
            this.btnSeleccionMultiatributo.UseVisualStyleBackColor = true;
            this.btnSeleccionMultiatributo.Click += new System.EventHandler(this.btnSeleccionMultiatributo_Click);
            // 
            // btnSeleccionSimple
            // 
            this.btnSeleccionSimple.Location = new System.Drawing.Point(9, 23);
            this.btnSeleccionSimple.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSeleccionSimple.Name = "btnSeleccionSimple";
            this.btnSeleccionSimple.Size = new System.Drawing.Size(377, 36);
            this.btnSeleccionSimple.TabIndex = 3;
            this.btnSeleccionSimple.Text = "Seleccion Simple";
            this.btnSeleccionSimple.UseVisualStyleBackColor = true;
            this.btnSeleccionSimple.Click += new System.EventHandler(this.btnSeleccionSimple_Click);
            // 
            // btnSeleccionConvolucion
            // 
            this.btnSeleccionConvolucion.Location = new System.Drawing.Point(9, 139);
            this.btnSeleccionConvolucion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSeleccionConvolucion.Name = "btnSeleccionConvolucion";
            this.btnSeleccionConvolucion.Size = new System.Drawing.Size(377, 36);
            this.btnSeleccionConvolucion.TabIndex = 2;
            this.btnSeleccionConvolucion.Text = "Seleccion por Convolución";
            this.btnSeleccionConvolucion.UseVisualStyleBackColor = true;
            this.btnSeleccionConvolucion.Click += new System.EventHandler(this.btnSeleccionConvolucion_Click);
            // 
            // mcrAlgebraicas
            // 
            this.mcrAlgebraicas.Controls.Add(this.btnInterseccion);
            this.mcrAlgebraicas.Controls.Add(this.btnUnion);
            this.mcrAlgebraicas.Controls.Add(this.btnDiferencia);
            this.mcrAlgebraicas.Location = new System.Drawing.Point(925, 444);
            this.mcrAlgebraicas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mcrAlgebraicas.Name = "mcrAlgebraicas";
            this.mcrAlgebraicas.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mcrAlgebraicas.Size = new System.Drawing.Size(395, 210);
            this.mcrAlgebraicas.TabIndex = 5;
            this.mcrAlgebraicas.TabStop = false;
            this.mcrAlgebraicas.Text = "Operaciones Algebraicas";
            // 
            // btnInterseccion
            // 
            this.btnInterseccion.Location = new System.Drawing.Point(9, 80);
            this.btnInterseccion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnInterseccion.Name = "btnInterseccion";
            this.btnInterseccion.Size = new System.Drawing.Size(377, 36);
            this.btnInterseccion.TabIndex = 4;
            this.btnInterseccion.Text = "Intersección";
            this.btnInterseccion.UseVisualStyleBackColor = true;
            this.btnInterseccion.Click += new System.EventHandler(this.btnInterseccion_Click);
            // 
            // btnUnion
            // 
            this.btnUnion.Location = new System.Drawing.Point(9, 23);
            this.btnUnion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUnion.Name = "btnUnion";
            this.btnUnion.Size = new System.Drawing.Size(377, 36);
            this.btnUnion.TabIndex = 3;
            this.btnUnion.Text = "Unión";
            this.btnUnion.UseVisualStyleBackColor = true;
            this.btnUnion.Click += new System.EventHandler(this.btnUnion_Click);
            // 
            // btnDiferencia
            // 
            this.btnDiferencia.Location = new System.Drawing.Point(9, 139);
            this.btnDiferencia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDiferencia.Name = "btnDiferencia";
            this.btnDiferencia.Size = new System.Drawing.Size(377, 36);
            this.btnDiferencia.TabIndex = 2;
            this.btnDiferencia.Text = "Diferencia";
            this.btnDiferencia.UseVisualStyleBackColor = true;
            this.btnDiferencia.Click += new System.EventHandler(this.btnDiferencia_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(1206, 670);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(114, 42);
            this.btnVolver.TabIndex = 14;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // frmOperacionesBD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1336, 734);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.mcrAlgebraicas);
            this.Controls.Add(this.mcrWhere);
            this.Controls.Add(this.mcrSelect);
            this.Controls.Add(this.dgvBaseDatos);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmOperacionesBD";
            this.Text = "Base de Datos";
            this.Load += new System.EventHandler(this.frmBaseDatos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaseDatos)).EndInit();
            this.mcrSelect.ResumeLayout(false);
            this.mcrWhere.ResumeLayout(false);
            this.mcrAlgebraicas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBaseDatos;
        private System.Windows.Forms.GroupBox mcrSelect;
        private System.Windows.Forms.Button btnProyeccionMultiatributo;
        private System.Windows.Forms.Button btnProyeccionSimple;
        private System.Windows.Forms.Button btnJuntar;
        private System.Windows.Forms.GroupBox mcrWhere;
        private System.Windows.Forms.Button btnSeleccionMultiatributo;
        private System.Windows.Forms.Button btnSeleccionSimple;
        private System.Windows.Forms.Button btnSeleccionConvolucion;
        private System.Windows.Forms.GroupBox mcrAlgebraicas;
        private System.Windows.Forms.Button btnInterseccion;
        private System.Windows.Forms.Button btnUnion;
        private System.Windows.Forms.Button btnDiferencia;
        private System.Windows.Forms.Button btnVolver;
    }
}