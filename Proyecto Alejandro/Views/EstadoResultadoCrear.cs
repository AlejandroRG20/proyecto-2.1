using Proyecto_Alejandro.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Alejandro.Views
{
    public partial class EstadoResultadoCrear : Form
    {
        public EstadoResultadoCrear()
        {
            InitializeComponent();
            foreach (MaskedTextBox T in GBDatos.Controls.OfType<MaskedTextBox>())
            {
                T.Mask = "999999999999999";
            }
        }

        private void Limpiar()
        {
            foreach (MaskedTextBox MT in GBDatos.Controls.OfType<MaskedTextBox>())
            {
                MT.Clear();
            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(Conexión.Cn))
                {
                    using (SqlCommand sqlCommand = new SqlCommand("Añadir Estado Resultado", sqlConnection))
                    {
                        float UtilidadBruta = float.Parse(TxtVentas.Text) - float.Parse(TxtCostoVentas.Text);
                        float UtilidadAImpuestos = UtilidadBruta - float.Parse(TxtGastosAdmin.Text);
                        float IR = UtilidadAImpuestos * (float)0.3;
                        float UtilidadNeta = UtilidadAImpuestos - IR;

                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        sqlCommand.Parameters.Add(new SqlParameter("@Ventas", (TxtVentas.Text)));
                        sqlCommand.Parameters.Add(new SqlParameter("CostoVentas", (TxtCostoVentas.Text)));
                        sqlCommand.Parameters.Add(new SqlParameter("@UtilidadBruta", UtilidadBruta));
                        sqlCommand.Parameters.Add(new SqlParameter("@GastosAdministrativos", (TxtGastosAdmin.Text)));
                        sqlCommand.Parameters.Add(new SqlParameter("@UtilidadAImpuestos", UtilidadAImpuestos));
                        sqlCommand.Parameters.Add(new SqlParameter("@IR", IR));
                        sqlCommand.Parameters.Add(new SqlParameter("@UtilidadNeta", UtilidadNeta));
                        sqlConnection.Open();
                        sqlCommand.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Se guardó con éxito!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("ESTA SEGURO DE SALIR",
                                            "ESTADO DE RESULTADO",
                                            MessageBoxButtons.YesNo,
                                            MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
                this.Close();
        }

        private void EstadoResultadoCrear_Load(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Today.Date.ToShortDateString();
            lblHora.Text = DateTime.Now.ToShortTimeString();
        }
    }
}