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

namespace ProyectoChuyito
{
    public partial class ClienteDatos : Form
    {
        public SqlConnection ConexionBaseDatos;
        public bool Casado;
        public int PlanSug = 0;
        public ClienteDatos()
        {
            InitializeComponent();
            ConexionBaseDatos = new SqlConnection("server=MSI\\SQLEXPRESS; database=ProyectoChuy ; integrated security = true");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void TxtCurp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ConexionBaseDatos.Open();
                String SQL = $"SELECT Nombre, Domicilio FROM Personas WHERE CURP = '{TxtCurp.Text}'";
                try
                {
                    using (SqlCommand command = new SqlCommand(SQL, ConexionBaseDatos))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                TxtNombre.Text = Convert.ToString(reader.GetString(0));
                                TxtDomicilio.Text = Convert.ToString(reader.GetString(1));
                            }
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Curp no valida");
                }
                ConexionBaseDatos.Close();
            }
        }

        private void RdbCasado_CheckedChanged(object sender, EventArgs e)
        {
            label6.Visible = true;
            NupHijos.Visible = true;
            Casado = true;
            NupIngresosMen.Enabled = true;
        }

        private void RdbSoltero_CheckedChanged(object sender, EventArgs e)
        {
            label6.Visible = false;
            NupHijos.Visible = false;
            Casado = false;
            NupIngresosMen.Enabled = true;
        }

        private void NupIngresosMen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (Casado == false)
                {
                    LblIngresos.Visible = true;
                    LblPlanSug.Visible = true;
                    LblIngresos.Text = "INGRESOS ACUMULABLES: $" + ((Double)NupIngresosMen.Value * 0.80);
                    if ((Double)NupIngresosMen.Value * 0.80 <= 5000)
                    {
                        LblPlanSug.Text = "PLAN DE TARJETA DE CREDITO SUGERIDO: BASICO";
                        PlanSug = 1;
                    }
                    else if ((Double)NupIngresosMen.Value * 0.80 > 5000 && (Double)NupIngresosMen.Value * 0.80 <= 18000)
                    {

                        LblPlanSug.Text = "PLAN DE TARJETA DE CREDITO SUGERIDO: ORO";
                        PlanSug = 2;
                    }
                    else if ((Double)NupIngresosMen.Value * 0.80 > 18000)
                    {

                        LblPlanSug.Text = "PLAN DE TARJETA DE CREDITO SUGERIDO: PLATINUM";
                        PlanSug = 3;
                    }
                }
                else if (Casado == true && NupHijos.Value == 0)
                {
                    LblIngresos.Visible = true;
                    LblPlanSug.Visible = true;
                    LblIngresos.Text = "INGRESOS ACUMULABLES: $" + ((Double)NupIngresosMen.Value * 0.70);

                    if ((Double)NupIngresosMen.Value * 0.70 <= 5000)
                    {
                        LblPlanSug.Text = "PLAN DE TARJETA DE CREDITO SUGERIDO: BASICO";
                        PlanSug = 1;
                    }
                    else if ((Double)NupIngresosMen.Value * 0.70 > 5000 && (Double)NupIngresosMen.Value * 0.70 <= 18000)
                    {

                        LblPlanSug.Text = "PLAN DE TARJETA DE CREDITO SUGERIDO: ORO";
                        PlanSug = 2;
                    }
                    else if ((Double)NupIngresosMen.Value * 0.70 > 18000)
                    {

                        LblPlanSug.Text = "PLAN DE TARJETA DE CREDITO SUGERIDO: PLATINUM";
                        PlanSug = 3;
                    }
                }
                else if (Casado == true && NupHijos.Value == 1)
                {
                    LblIngresos.Visible = true;
                    LblPlanSug.Visible = true;
                    LblIngresos.Text = "INGRESOS ACUMULABLES: $" + ((Double)NupIngresosMen.Value * 0.60);
                    if ((Double)NupIngresosMen.Value * 0.60 <= 5000)
                    {
                        LblPlanSug.Text = "PLAN DE TARJETA DE CREDITO SUGERIDO: BASICO";
                        PlanSug = 1;
                    }
                    else if ((Double)NupIngresosMen.Value * 0.60 > 5000 && (Double)NupIngresosMen.Value * 0.60 <= 18000)
                    {

                        LblPlanSug.Text = "PLAN DE TARJETA DE CREDITO SUGERIDO: ORO";
                        PlanSug = 2;
                    }
                    else if ((Double)NupIngresosMen.Value * 0.60 > 18000)
                    {

                        LblPlanSug.Text = "PLAN DE TARJETA DE CREDITO SUGERIDO: PLATINUM";
                        PlanSug = 3;
                    }
                }
                else if (Casado == true && NupHijos.Value == 2)
                {
                    LblIngresos.Visible = true;
                    LblPlanSug.Visible = true;
                    LblIngresos.Text = "INGRESOS ACUMULABLES: $" + ((Double)NupIngresosMen.Value * 0.55);
                    if ((Double)NupIngresosMen.Value * 0.55 <= 5000)
                    {
                        LblPlanSug.Text = "PLAN DE TARJETA DE CREDITO SUGERIDO: BASICO";
                        PlanSug = 1;
                    }
                    else if ((Double)NupIngresosMen.Value * 0.55 > 5000 && (Double)NupIngresosMen.Value * 0.55 <= 18000)
                    {

                        LblPlanSug.Text = "PLAN DE TARJETA DE CREDITO SUGERIDO: ORO";
                        PlanSug = 2;
                    }
                    else if ((Double)NupIngresosMen.Value * 0.55 > 18000)
                    {

                        LblPlanSug.Text = "PLAN DE TARJETA DE CREDITO SUGERIDO: PLATINUM";
                        PlanSug = 3;
                    }
                }
                else if (Casado == true && NupHijos.Value > 2)
                {
                    LblIngresos.Visible = true;
                    LblPlanSug.Visible = true;
                    LblIngresos.Text = "INGRESOS ACUMULABLES: $" + ((Double)NupIngresosMen.Value * 0.50);
                    if ((Double)NupIngresosMen.Value * 0.50 <= 5000)
                    {
                        LblPlanSug.Text = "PLAN DE TARJETA DE CREDITO SUGERIDO: BASICO";
                        PlanSug = 1;
                    }
                    else if ((Double)NupIngresosMen.Value * 0.50 > 5000 && (Double)NupIngresosMen.Value * 0.50 <= 18000)
                    {

                        LblPlanSug.Text = "PLAN DE TARJETA DE CREDITO SUGERIDO: ORO";
                        PlanSug = 2;
                    }
                    else if ((Double)NupIngresosMen.Value * 0.50 > 18000)
                    {

                        LblPlanSug.Text = "PLAN DE TARJETA DE CREDITO SUGERIDO: PLATINUM";
                        PlanSug = 3;
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Simulador simulador = new Simulador(PlanSug);
            //this.Visible = false;
            simulador.ShowDialog();
            this.Close();
        }

        private void ClienteDatos_Load(object sender, EventArgs e)
        {
            NupIngresosMen.Enabled = false;
        }
    }
}
