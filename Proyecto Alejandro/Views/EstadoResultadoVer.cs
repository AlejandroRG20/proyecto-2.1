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
    public partial class EstadoResultadoVer : Form
    {
        public EstadoResultadoVer()
        {
            InitializeComponent();
            DgvEstados.DataSource = CEstadoResultado.EstadoResultado();
            DgvEstados.Columns["IdEstadoResultado"].Visible = false;
            DgvEstados.ReadOnly = true;
        }
    }
}