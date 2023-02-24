namespace Proyecto_Alejandro.Views
{
    partial class Main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.crearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.balanceGeneralToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.estadoDeResultadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.balanceGeneralToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.estadoDeResultadoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearToolStripMenuItem,
            this.verToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(850, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // crearToolStripMenuItem
            // 
            this.crearToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.balanceGeneralToolStripMenuItem,
            this.toolStripSeparator1,
            this.estadoDeResultadoToolStripMenuItem});
            this.crearToolStripMenuItem.Name = "crearToolStripMenuItem";
            this.crearToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.crearToolStripMenuItem.Text = "Crear";
            // 
            // verToolStripMenuItem
            // 
            this.verToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.balanceGeneralToolStripMenuItem1,
            this.toolStripSeparator2,
            this.estadoDeResultadoToolStripMenuItem1});
            this.verToolStripMenuItem.Name = "verToolStripMenuItem";
            this.verToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.verToolStripMenuItem.Text = "Ver";
            // 
            // balanceGeneralToolStripMenuItem
            // 
            this.balanceGeneralToolStripMenuItem.Name = "balanceGeneralToolStripMenuItem";
            this.balanceGeneralToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.balanceGeneralToolStripMenuItem.Text = "Balance General";
            this.balanceGeneralToolStripMenuItem.Click += new System.EventHandler(this.balanceGeneralToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // estadoDeResultadoToolStripMenuItem
            // 
            this.estadoDeResultadoToolStripMenuItem.Name = "estadoDeResultadoToolStripMenuItem";
            this.estadoDeResultadoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.estadoDeResultadoToolStripMenuItem.Text = "Estado de Resultado";
            this.estadoDeResultadoToolStripMenuItem.Click += new System.EventHandler(this.estadoDeResultadoToolStripMenuItem_Click);
            // 
            // balanceGeneralToolStripMenuItem1
            // 
            this.balanceGeneralToolStripMenuItem1.Name = "balanceGeneralToolStripMenuItem1";
            this.balanceGeneralToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.balanceGeneralToolStripMenuItem1.Text = "Balance General";
            this.balanceGeneralToolStripMenuItem1.Click += new System.EventHandler(this.balanceGeneralToolStripMenuItem1_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // estadoDeResultadoToolStripMenuItem1
            // 
            this.estadoDeResultadoToolStripMenuItem1.Name = "estadoDeResultadoToolStripMenuItem1";
            this.estadoDeResultadoToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.estadoDeResultadoToolStripMenuItem1.Text = "Estado de Resultado";
            this.estadoDeResultadoToolStripMenuItem1.Click += new System.EventHandler(this.estadoDeResultadoToolStripMenuItem1_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 433);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem crearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem balanceGeneralToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem estadoDeResultadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem balanceGeneralToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem estadoDeResultadoToolStripMenuItem1;
    }
}