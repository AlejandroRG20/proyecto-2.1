using Proyecto_Alejandro.Controller;
using Proyecto_Alejandro.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proyecto_Alejandro
{
    public partial class InicioSesion : Form
    {
        string Rol;
        int Count = 0;
        Main main;
        BackgroundWorker bg = new BackgroundWorker();
        public InicioSesion()
        {
            InitializeComponent();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            Count++;
            if (Count == 3)
            {
                TxtUsuario.Enabled = false;
                TxtContraseña.Enabled = false;
                BtnAceptar.Enabled = false;
                MessageBox.Show("Cometiste muchos errores, espera 10 segundos!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Thread.Sleep(10000);
                TxtUsuario.Enabled = true;
                TxtContraseña.Enabled = true;
                BtnAceptar.Enabled = true;
                Count = 0;
            }
            else
            {
                try
                {
                    ValidarTextBox(TxtUsuario.Text, TxtContraseña.Text);
                    DataTable dt = CValidarAcceso.Validar_Acceso(TxtUsuario.Text, TxtContraseña.Text);

                    if (dt != null)
                    {
                        if (dt.Rows.Count > 0)
                        {
                            if (dt.Rows[0][0].ToString() == "Acceso Exitoso")
                            {
                                Rol = dt.Rows[0][1].ToString();
                                BtnAceptar.Enabled = false;
                                TxtUsuario.Enabled = false;
                                TxtContraseña.Enabled = false;
                                bg.WorkerReportsProgress = true;
                                bg.ProgressChanged += bg_ProgressChanged;
                                bg.DoWork += bg_DoWork;
                                bg.RunWorkerCompleted += bg_RunWorkerCompleted;
                                bg.RunWorkerAsync();
                                LblProgresoBarra.Visible = true;
                                PBInicio.Visible = true;
                                
                                Count = 0;
                            }
                            else
                            {
                                MessageBox.Show("Acceso denegado al sistema", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("No hay conexión con la BD", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }

        private void ValidarTextBox(string Usuario, string Contraseña)
        {
            if (String.IsNullOrEmpty(Usuario))
            {
                throw new ArgumentException("El usuario no puede ser nulo");
            }
            if (String.IsNullOrEmpty(Contraseña))
            {
                throw new ArgumentException("La contraseña no puede ser nula");
            }
        }


        private void bg_DoWork(object sender, EventArgs e)
        {
            int progreso = 0;


            for (int i = 0; i <= 100; i++)
            {
                progreso++;
                Thread.Sleep(50);
                bg.ReportProgress(i);
            }
        }

        private void bg_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            PBInicio.Value = e.ProgressPercentage;
            PBInicio.Style = ProgressBarStyle.Continuous;


            if (e.ProgressPercentage > 100)
            {
                LblProgresoBarra.Text = "100%";
                PBInicio.Value = PBInicio.Maximum;
            }
            else
            {
                LblProgresoBarra.Text = Convert.ToString(e.ProgressPercentage) + "%";
                PBInicio.Value = e.ProgressPercentage;
            }
        }

        private void bg_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show($"Acceso exitoso al sistema, iniciaste sesión como {Rol}", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Visible = false;

            main = new Main(Rol);

            main.Show();
            this.Hide();

            PBInicio.Value = 0;
            LblProgresoBarra.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}