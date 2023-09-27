namespace pryEDRodriguez
{
    partial class frmDatosDesarrollador
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
            this.lblDni = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblMateria = new System.Windows.Forms.Label();
            this.lblDocumento = new System.Windows.Forms.Label();
            this.lblDario = new System.Windows.Forms.Label();
            this.lblEstructura = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDni.Location = new System.Drawing.Point(33, 303);
            this.lblDni.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(50, 24);
            this.lblDni.TabIndex = 3;
            this.lblDni.Text = "DNI:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(33, 374);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(91, 24);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblMateria
            // 
            this.lblMateria.AutoSize = true;
            this.lblMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMateria.Location = new System.Drawing.Point(33, 449);
            this.lblMateria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMateria.Name = "lblMateria";
            this.lblMateria.Size = new System.Drawing.Size(84, 24);
            this.lblMateria.TabIndex = 5;
            this.lblMateria.Text = "Materia:";
            // 
            // lblDocumento
            // 
            this.lblDocumento.AutoSize = true;
            this.lblDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocumento.Location = new System.Drawing.Point(146, 303);
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.Size = new System.Drawing.Size(117, 29);
            this.lblDocumento.TabIndex = 6;
            this.lblDocumento.Text = "45594512";
            // 
            // lblDario
            // 
            this.lblDario.AutoSize = true;
            this.lblDario.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDario.Location = new System.Drawing.Point(146, 374);
            this.lblDario.Name = "lblDario";
            this.lblDario.Size = new System.Drawing.Size(188, 29);
            this.lblDario.TabIndex = 7;
            this.lblDario.Text = "Dario Rodriguez";
            // 
            // lblEstructura
            // 
            this.lblEstructura.AutoSize = true;
            this.lblEstructura.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstructura.Location = new System.Drawing.Point(146, 449);
            this.lblEstructura.Name = "lblEstructura";
            this.lblEstructura.Size = new System.Drawing.Size(222, 29);
            this.lblEstructura.TabIndex = 8;
            this.lblEstructura.Text = "Estructura de Datos";
            // 
            // frmDatosDesarrollador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 503);
            this.Controls.Add(this.lblEstructura);
            this.Controls.Add(this.lblDario);
            this.Controls.Add(this.lblDocumento);
            this.Controls.Add(this.lblMateria);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblDni);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDatosDesarrollador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datos del Desarrollador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblMateria;
        private System.Windows.Forms.Label lblDocumento;
        private System.Windows.Forms.Label lblDario;
        private System.Windows.Forms.Label lblEstructura;
    }
}