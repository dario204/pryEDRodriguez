namespace pryEDRodriguez
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.datosDelDesarrolladorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estructurasLinealesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pilaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.listaSimpleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDobleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estrcturasNoLinealesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arbolBinarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.baseDeDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operacionesConTablasDeBasesDeDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasEnLaBaseDeDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.repasoDeOperacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sistemaToolStripMenuItem,
            this.estructurasLinealesToolStripMenuItem,
            this.estrcturasNoLinealesToolStripMenuItem,
            this.baseDeDatosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(887, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.datosDelDesarrolladorToolStripMenuItem,
            this.toolStripMenuItem1,
            this.salirToolStripMenuItem});
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.sistemaToolStripMenuItem.Text = "Sistema";
            // 
            // datosDelDesarrolladorToolStripMenuItem
            // 
            this.datosDelDesarrolladorToolStripMenuItem.Name = "datosDelDesarrolladorToolStripMenuItem";
            this.datosDelDesarrolladorToolStripMenuItem.Size = new System.Drawing.Size(258, 26);
            this.datosDelDesarrolladorToolStripMenuItem.Text = "Datos del desarrollador...";
            this.datosDelDesarrolladorToolStripMenuItem.Click += new System.EventHandler(this.datosDelDesarrolladorToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(255, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(258, 26);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // estructurasLinealesToolStripMenuItem
            // 
            this.estructurasLinealesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colaToolStripMenuItem,
            this.pilaToolStripMenuItem,
            this.toolStripMenuItem2,
            this.listaSimpleToolStripMenuItem,
            this.listaDobleToolStripMenuItem});
            this.estructurasLinealesToolStripMenuItem.Name = "estructurasLinealesToolStripMenuItem";
            this.estructurasLinealesToolStripMenuItem.Size = new System.Drawing.Size(151, 24);
            this.estructurasLinealesToolStripMenuItem.Text = "Estructuras Lineales";
            this.estructurasLinealesToolStripMenuItem.Click += new System.EventHandler(this.estructurasLinealesToolStripMenuItem_Click);
            // 
            // colaToolStripMenuItem
            // 
            this.colaToolStripMenuItem.Name = "colaToolStripMenuItem";
            this.colaToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.colaToolStripMenuItem.Text = "Cola...";
            this.colaToolStripMenuItem.Click += new System.EventHandler(this.colaToolStripMenuItem_Click);
            // 
            // pilaToolStripMenuItem
            // 
            this.pilaToolStripMenuItem.Name = "pilaToolStripMenuItem";
            this.pilaToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.pilaToolStripMenuItem.Text = "Pila...";
            this.pilaToolStripMenuItem.Click += new System.EventHandler(this.pilaToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(178, 6);
            // 
            // listaSimpleToolStripMenuItem
            // 
            this.listaSimpleToolStripMenuItem.Name = "listaSimpleToolStripMenuItem";
            this.listaSimpleToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.listaSimpleToolStripMenuItem.Text = "Lista Simple...";
            this.listaSimpleToolStripMenuItem.Click += new System.EventHandler(this.listaSimpleToolStripMenuItem_Click);
            // 
            // listaDobleToolStripMenuItem
            // 
            this.listaDobleToolStripMenuItem.Name = "listaDobleToolStripMenuItem";
            this.listaDobleToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.listaDobleToolStripMenuItem.Text = "Lista Doble...";
            this.listaDobleToolStripMenuItem.Click += new System.EventHandler(this.listaDobleToolStripMenuItem_Click);
            // 
            // estrcturasNoLinealesToolStripMenuItem
            // 
            this.estrcturasNoLinealesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arbolBinarioToolStripMenuItem});
            this.estrcturasNoLinealesToolStripMenuItem.Name = "estrcturasNoLinealesToolStripMenuItem";
            this.estrcturasNoLinealesToolStripMenuItem.Size = new System.Drawing.Size(164, 24);
            this.estrcturasNoLinealesToolStripMenuItem.Text = "Estrcturas no Lineales";
            // 
            // arbolBinarioToolStripMenuItem
            // 
            this.arbolBinarioToolStripMenuItem.Name = "arbolBinarioToolStripMenuItem";
            this.arbolBinarioToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.arbolBinarioToolStripMenuItem.Text = "Arbol Binario";
            this.arbolBinarioToolStripMenuItem.Click += new System.EventHandler(this.arbolBinarioToolStripMenuItem_Click);
            // 
            // baseDeDatosToolStripMenuItem
            // 
            this.baseDeDatosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.operacionesConTablasDeBasesDeDatosToolStripMenuItem,
            this.consultasEnLaBaseDeDatosToolStripMenuItem,
            this.toolStripMenuItem3,
            this.repasoDeOperacionesToolStripMenuItem});
            this.baseDeDatosToolStripMenuItem.Name = "baseDeDatosToolStripMenuItem";
            this.baseDeDatosToolStripMenuItem.Size = new System.Drawing.Size(118, 24);
            this.baseDeDatosToolStripMenuItem.Text = "Base de Datos";
            // 
            // operacionesConTablasDeBasesDeDatosToolStripMenuItem
            // 
            this.operacionesConTablasDeBasesDeDatosToolStripMenuItem.Name = "operacionesConTablasDeBasesDeDatosToolStripMenuItem";
            this.operacionesConTablasDeBasesDeDatosToolStripMenuItem.Size = new System.Drawing.Size(380, 26);
            this.operacionesConTablasDeBasesDeDatosToolStripMenuItem.Text = "Operaciones con tablas de bases de datos...";
            this.operacionesConTablasDeBasesDeDatosToolStripMenuItem.Click += new System.EventHandler(this.operacionesConTablasDeBasesDeDatosToolStripMenuItem_Click);
            // 
            // consultasEnLaBaseDeDatosToolStripMenuItem
            // 
            this.consultasEnLaBaseDeDatosToolStripMenuItem.Name = "consultasEnLaBaseDeDatosToolStripMenuItem";
            this.consultasEnLaBaseDeDatosToolStripMenuItem.Size = new System.Drawing.Size(380, 26);
            this.consultasEnLaBaseDeDatosToolStripMenuItem.Text = "Consultas en la base de datos...";
            this.consultasEnLaBaseDeDatosToolStripMenuItem.Click += new System.EventHandler(this.consultasEnLaBaseDeDatosToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(377, 6);
            // 
            // repasoDeOperacionesToolStripMenuItem
            // 
            this.repasoDeOperacionesToolStripMenuItem.Name = "repasoDeOperacionesToolStripMenuItem";
            this.repasoDeOperacionesToolStripMenuItem.Size = new System.Drawing.Size(380, 26);
            this.repasoDeOperacionesToolStripMenuItem.Text = "Repaso de Operaciones...";
            this.repasoDeOperacionesToolStripMenuItem.Click += new System.EventHandler(this.repasoDeOperacionesToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::pryEDRodriguez.Properties.Resources.tres;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(887, 543);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmPrincipal";
            this.Text = "Estructura de Datos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem datosDelDesarrolladorToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estructurasLinealesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pilaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem listaSimpleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDobleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estrcturasNoLinealesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arbolBinarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem baseDeDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operacionesConTablasDeBasesDeDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasEnLaBaseDeDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem repasoDeOperacionesToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

