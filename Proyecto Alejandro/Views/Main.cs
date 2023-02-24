using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Alejandro.Views
{
    public partial class Main : Form
    {
        public Main(string Rol)
        {
            InitializeComponent();
            this.Text = $"{Rol}";

            if (Rol == "Contador Auxiliar")
            {
                crearToolStripMenuItem.Enabled = false;
            }
        }

        //Utilizamos el método protegido OnClosed para cerrar en su totalidad el sistema
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            Application.Exit();
        }

        private void balanceGeneralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BalanceGeneralCrear Form = new BalanceGeneralCrear();
            Form.MdiParent = this;
            Form.Show();
        }

        private void estadoDeResultadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EstadoResultadoCrear Form = new EstadoResultadoCrear();
            Form.MdiParent = this;
            Form.Show();
        }

        private void balanceGeneralToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            BalanceGeneralVer Form = new BalanceGeneralVer();
            Form.MdiParent = this;
            Form.Show();
        }

        private void estadoDeResultadoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            EstadoResultadoVer Form = new EstadoResultadoVer();
            Form.MdiParent = this;
            Form.Show();
        }
    }
}