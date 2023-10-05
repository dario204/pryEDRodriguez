namespace pryEDRodriguez
{
    partial class frmBaseDatos
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
            this.btnJuntar = new System.Windows.Forms.Button();
            this.btnProyeccionSimple = new System.Windows.Forms.Button();
            this.btnProyeccionMultiatributo = new System.Windows.Forms.Button();
            this.mcrWhere = new System.Windows.Forms.GroupBox();
            this.btnSeleccionMultiatributo = new System.Windows.Forms.Button();
            this.btnSeleccionSimple = new System.Windows.Forms.Button();
            this.btnSeleccionConvolucion = new System.Windows.Forms.Button();
            this.mcrAlgebraicas = new System.Windows.Forms.GroupBox();
            this.btnInterseccion = new System.Windows.Forms.Button();
            this.btnUnion = new System.Windows.Forms.Button();
            this.btnDiferencia = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaseDatos)).BeginInit();
            this.mcrSelect.SuspendLayout();
            this.mcrWhere.SuspendLayout();
            this.mcrAlgebraicas.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvBaseDatos
            // 
            this.dgvBaseDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBaseDatos.Location = new System.Drawing.Point(13, 13);
            this.dgvBaseDatos.Name = "dgvBaseDatos";
            this.dgvBaseDatos.Size = new System.Drawing.Size(977, 331);
            this.dgvBaseDatos.TabIndex = 0;
            // 
            // mcrSelect
            // 
            this.mcrSelect.Controls.Add(this.btnProyeccionMultiatributo);
            this.mcrSelect.Controls.Add(this.btnProyeccionSimple);
            this.mcrSelect.Controls.Add(this.btnJuntar);
            this.mcrSelect.Location = new System.Drawing.Point(13, 361);
            this.mcrSelect.Name = "mcrSelect";
            this.mcrSelect.Size = new System.Drawing.Size(296, 171);
            this.mcrSelect.TabIndex = 1;
            this.mcrSelect.TabStop = false;
            this.mcrSelect.Text = "Operaciones de Proyección - SELECT";
            // 
            // btnJuntar
            // 
            this.btnJuntar.Location = new System.Drawing.Point(7, 113);
            this.btnJuntar.Name = "btnJuntar";
            this.btnJuntar.Size = new System.Drawing.Size(283, 29);
            this.btnJuntar.TabIndex = 2;
            this.btnJuntar.Text = "Juntar";
            this.btnJuntar.UseVisualStyleBackColor = true;
            // 
            // btnProyeccionSimple
            // 
            this.btnProyeccionSimple.Location = new System.Drawing.Point(7, 19);
            this.btnProyeccionSimple.Name = "btnProyeccionSimple";
            this.btnProyeccionSimple.Size = new System.Drawing.Size(283, 29);
            this.btnProyeccionSimple.TabIndex = 3;
            this.btnProyeccionSimple.Text = "Proyeccion Simple";
            this.btnProyeccionSimple.UseVisualStyleBackColor = true;
            // 
            // btnProyeccionMultiatributo
            // 
            this.btnProyeccionMultiatributo.Location = new System.Drawing.Point(7, 65);
            this.btnProyeccionMultiatributo.Name = "btnProyeccionMultiatributo";
            this.btnProyeccionMultiatributo.Size = new System.Drawing.Size(283, 29);
            this.btnProyeccionMultiatributo.TabIndex = 4;
            this.btnProyeccionMultiatributo.Text = "Proyeccion Multiatributo";
            this.btnProyeccionMultiatributo.UseVisualStyleBackColor = true;
            // 
            // mcrWhere
            // 
            this.mcrWhere.Controls.Add(this.btnSeleccionMultiatributo);
            this.mcrWhere.Controls.Add(this.btnSeleccionSimple);
            this.mcrWhere.Controls.Add(this.btnSeleccionConvolucion);
            this.mcrWhere.Location = new System.Drawing.Point(352, 361);
            this.mcrWhere.Name = "mcrWhere";
            this.mcrWhere.Size = new System.Drawing.Size(296, 171);
            this.mcrWhere.TabIndex = 5;
            this.mcrWhere.TabStop = false;
            this.mcrWhere.Text = "Operaciones de Selección  - WHERE";
            // 
            // btnSeleccionMultiatributo
            // 
            this.btnSeleccionMultiatributo.Location = new System.Drawing.Point(7, 65);
            this.btnSeleccionMultiatributo.Name = "btnSeleccionMultiatributo";
            this.btnSeleccionMultiatributo.Size = new System.Drawing.Size(283, 29);
            this.btnSeleccionMultiatributo.TabIndex = 4;
            this.btnSeleccionMultiatributo.Text = "Seleccion Multiatributo";
            this.btnSeleccionMultiatributo.UseVisualStyleBackColor = true;
            // 
            // btnSeleccionSimple
            // 
            this.btnSeleccionSimple.Location = new System.Drawing.Point(7, 19);
            this.btnSeleccionSimple.Name = "btnSeleccionSimple";
            this.btnSeleccionSimple.Size = new System.Drawing.Size(283, 29);
            this.btnSeleccionSimple.TabIndex = 3;
            this.btnSeleccionSimple.Text = "Seleccion Simple";
            this.btnSeleccionSimple.UseVisualStyleBackColor = true;
            // 
            // btnSeleccionConvolucion
            // 
            this.btnSeleccionConvolucion.Location = new System.Drawing.Point(7, 113);
            this.btnSeleccionConvolucion.Name = "btnSeleccionConvolucion";
            this.btnSeleccionConvolucion.Size = new System.Drawing.Size(283, 29);
            this.btnSeleccionConvolucion.TabIndex = 2;
            this.btnSeleccionConvolucion.Text = "Seleccion por Convolución";
            this.btnSeleccionConvolucion.UseVisualStyleBackColor = true;
            // 
            // mcrAlgebraicas
            // 
            this.mcrAlgebraicas.Controls.Add(this.btnInterseccion);
            this.mcrAlgebraicas.Controls.Add(this.btnUnion);
            this.mcrAlgebraicas.Controls.Add(this.btnDiferencia);
            this.mcrAlgebraicas.Location = new System.Drawing.Point(694, 361);
            this.mcrAlgebraicas.Name = "mcrAlgebraicas";
            this.mcrAlgebraicas.Size = new System.Drawing.Size(296, 171);
            this.mcrAlgebraicas.TabIndex = 5;
            this.mcrAlgebraicas.TabStop = false;
            this.mcrAlgebraicas.Text = "Operaciones Algebraicas";
            // 
            // btnInterseccion
            // 
            this.btnInterseccion.Location = new System.Drawing.Point(7, 65);
            this.btnInterseccion.Name = "btnInterseccion";
            this.btnInterseccion.Size = new System.Drawing.Size(283, 29);
            this.btnInterseccion.TabIndex = 4;
            this.btnInterseccion.Text = "Intersección";
            this.btnInterseccion.UseVisualStyleBackColor = true;
            // 
            // btnUnion
            // 
            this.btnUnion.Location = new System.Drawing.Point(7, 19);
            this.btnUnion.Name = "btnUnion";
            this.btnUnion.Size = new System.Drawing.Size(283, 29);
            this.btnUnion.TabIndex = 3;
            this.btnUnion.Text = "Unión";
            this.btnUnion.UseVisualStyleBackColor = true;
            // 
            // btnDiferencia
            // 
            this.btnDiferencia.Location = new System.Drawing.Point(7, 113);
            this.btnDiferencia.Name = "btnDiferencia";
            this.btnDiferencia.Size = new System.Drawing.Size(283, 29);
            this.btnDiferencia.TabIndex = 2;
            this.btnDiferencia.Text = "Diferencia";
            this.btnDiferencia.UseVisualStyleBackColor = true;
            // 
            // frmBaseDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 546);
            this.Controls.Add(this.mcrAlgebraicas);
            this.Controls.Add(this.mcrWhere);
            this.Controls.Add(this.mcrSelect);
            this.Controls.Add(this.dgvBaseDatos);
            this.Name = "frmBaseDatos";
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
    }
}