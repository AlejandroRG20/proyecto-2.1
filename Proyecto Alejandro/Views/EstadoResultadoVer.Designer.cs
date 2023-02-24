namespace Proyecto_Alejandro.Views
{
    partial class EstadoResultadoVer
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
            this.DgvEstados = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DgvEstados)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvEstados
            // 
            this.DgvEstados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvEstados.Location = new System.Drawing.Point(26, 20);
            this.DgvEstados.Name = "DgvEstados";
            this.DgvEstados.Size = new System.Drawing.Size(749, 411);
            this.DgvEstados.TabIndex = 1;
            // 
            // EstadoResultadoVer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DgvEstados);
            this.Name = "EstadoResultadoVer";
            this.Text = "Ver Estado de Resultado";
            ((System.ComponentModel.ISupportInitialize)(this.DgvEstados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvEstados;
    }
}