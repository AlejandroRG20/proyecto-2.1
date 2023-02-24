using Proyecto_Alejandro.Controller;
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
    public partial class BalanceGeneralVer : Form
    {
        public BalanceGeneralVer()
        {
            InitializeComponent();
            //Inserción de datos de la BD al DataGridView
            DgvBalances.DataSource = CBalanceGeneral.BalanceGeneral();
            //Se quita la visibilidad de la columna ID
            DgvBalances.Columns["IdBalanceGeneral"].Visible = false;
            DgvBalances.ReadOnly = true;
        }
    }
}
