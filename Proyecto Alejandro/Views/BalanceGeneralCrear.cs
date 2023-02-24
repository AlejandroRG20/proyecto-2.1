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
    public partial class BalanceGeneralCrear : Form
    {
        public BalanceGeneralCrear()
        {
            InitializeComponent();
            foreach (GroupBox GB in this.Controls.OfType<GroupBox>())
            {
                foreach (MaskedTextBox T in GB.Controls.OfType<MaskedTextBox>())
                {
                    T.Mask = "999999999999999";
                }
            }
        }

        private void Limpiar()
        {
            foreach (GroupBox GB in this.Controls.OfType<GroupBox>())
            {
                foreach (MaskedTextBox T in GB.Controls.OfType<MaskedTextBox>())
                {
                    T.Clear();
                }
            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            double UtB, ing, egr;
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(Conexión.Cn))
                {
                    using (SqlCommand sqlCommand = new SqlCommand("Añadir Balance General", sqlConnection))
                    {
                        float TotalActivosCirculantes = 0, TotalActivosNoCirculantes = 0, TotalOtrosActivos = 0, TotalPasivosCirculantes = 0, TotalCapital = 0;

                        //Foreach encargado de sumar todos los MaskedTextBox dentro del GroupBox Activos Circulantes
                        foreach (MaskedTextBox MT in GBActivosCirculantes.Controls.OfType<MaskedTextBox>())
                        {
                            TotalActivosCirculantes += float.Parse(MT.Text);
                        }
                        //Foreach encargado de sumar todos los MaskedTextBox dentro del GroupBox Activos No Circulantes
                        foreach (MaskedTextBox MT in GBActivosNoCirculantes.Controls.OfType<MaskedTextBox>())
                        {
                            TotalActivosNoCirculantes += float.Parse(MT.Text);
                        }
                        //Foreach encargado de sumar todos los MaskedTextBox dentro del GroupBox Otros Activos
                        foreach (MaskedTextBox MT in GBOtrosActivos.Controls.OfType<MaskedTextBox>())
                        {
                            TotalOtrosActivos += float.Parse(MT.Text);
                        }
                        //Foreach encargado de sumar todos los MaskedTextBox dentro del GroupBox Pasivos Circulantes
                        foreach (MaskedTextBox MT in GBPasivosCirculantes.Controls.OfType<MaskedTextBox>())
                        {
                            TotalPasivosCirculantes += float.Parse(MT.Text);
                        }
                        //Foreach encargado de sumar todos los MaskedTextBox dentro del GroupBox Capital
                        foreach (MaskedTextBox MT in GBCapital.Controls.OfType<MaskedTextBox>())
                        {
                            TotalCapital += float.Parse(MT.Text);
                        }
                        ing = Convert.ToDouble(txtIngresos.Text);
                        egr = Convert.ToDouble(txtEgresos.Text);

                        if (egr <= ing)
                        {
                            UtB = ing - egr;
                            txtUB.Text = UtB.ToString();

                        }
                        else
                        {
                            MessageBox.Show("El egreso no puede ser mayor al ingreso");
                        }
                            float TotalActivos = TotalActivosCirculantes + TotalActivosNoCirculantes + TotalOtrosActivos;
                        float TotalPasivosCapital = TotalPasivosCirculantes + TotalCapital;
                        if (TotalActivos < TotalPasivosCapital)
                        {
                            MessageBox.Show("El total pasivos no puede ser mayor que el total de activos:\nTOTAL ACTIVOS: " + TotalActivos + "TOTAL PASIVOS: " + TotalPasivosCirculantes);
                        }
                        else
                        {
                            txtTA.Text=TotalActivos.ToString();
                            txtTPC.Text=TotalPasivosCapital.ToString();

                            sqlCommand.CommandType = CommandType.StoredProcedure;
                            sqlCommand.Parameters.Add(new SqlParameter("@Caja", (TxtCaja.Text)));
                            sqlCommand.Parameters.Add(new SqlParameter("@Banco", (TxtBanco.Text)));
                            sqlCommand.Parameters.Add(new SqlParameter("@Clientes", (TxtCliente.Text)));
                            sqlCommand.Parameters.Add(new SqlParameter("@Mercancías", (TxtMercancía.Text)));
                            sqlCommand.Parameters.Add(new SqlParameter("@TotalActivosCirculantes", TotalActivosCirculantes));
                            sqlCommand.Parameters.Add(new SqlParameter("@Terreno", (TxtTerreno.Text)));
                            sqlCommand.Parameters.Add(new SqlParameter("@Edificio", (TxtEdificio.Text)));
                            sqlCommand.Parameters.Add(new SqlParameter("@MobEquip", (TxtMobEquipo.Text)));
                            sqlCommand.Parameters.Add(new SqlParameter("@TotalActivosNoCirculantes", TotalActivosNoCirculantes));
                            sqlCommand.Parameters.Add(new SqlParameter("@Salarios", (TxtSalario.Text)));
                            sqlCommand.Parameters.Add(new SqlParameter("@ImpAlcal", (TxtImpAlcaldía.Text)));
                            sqlCommand.Parameters.Add(new SqlParameter("@PropPublic", (TxtPropPublic.Text)));
                            sqlCommand.Parameters.Add(new SqlParameter("@GastosAdmin", (TxtGastosAdmin.Text)));
                            sqlCommand.Parameters.Add(new SqlParameter("@GastosVentas", (TxtGastosVentas.Text)));
                            sqlCommand.Parameters.Add(new SqlParameter("@TotalOtrosActivos", TotalOtrosActivos));
                            sqlCommand.Parameters.Add(new SqlParameter("@TotalActivos", TotalActivos));
                            sqlCommand.Parameters.Add(new SqlParameter("@DocPagar", (TxtDocPagar.Text)));
                            sqlCommand.Parameters.Add(new SqlParameter("@CuentasPagar", (TxtCuentasPagar.Text)));
                            sqlCommand.Parameters.Add(new SqlParameter("@TotalPasivosCirculantes", TotalPasivosCirculantes));
                            sqlCommand.Parameters.Add(new SqlParameter("@CapitalSocial", (TxtCapitalSocial.Text)));
                            sqlCommand.Parameters.Add(new SqlParameter("@CapitalContribuido", (TxtCapitalContribuido.Text)));
                            sqlCommand.Parameters.Add(new SqlParameter("@TotalCapital", TotalCapital));
                            sqlCommand.Parameters.Add(new SqlParameter("@TotalPasivosCapital", TotalPasivosCapital));
                            //Se abre la conexión
                            sqlConnection.Open();
                            //Se ejecuta la consulta
                            sqlCommand.ExecuteNonQuery();
                        }
                    }
                }
                //Se manda un mensaje que se guardó los datos en la BD
                MessageBox.Show("Se guardó con éxito!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void BalanceGeneralCrear_Load(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Today.Date.ToShortDateString();
            lblHora.Text = DateTime.Now.ToShortTimeString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("ESTA SEGURO DE SALIR",
                                            "BALANCE GENERAL",
                                            MessageBoxButtons.YesNo,
                                            MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
                this.Close();
        }
    }
}