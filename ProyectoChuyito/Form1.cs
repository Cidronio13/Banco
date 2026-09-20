using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProyectoChuyito
{
    public partial class Form1 : Form
    {
        bool ClickBasico = false, ClickOro = false, ClickPlat = false;
        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            ClienteDatos clienteDatos = new ClienteDatos();
            clienteDatos.ShowDialog();
        }
        public void AbrirFormulario(Form form)
        {

        }
        private void button1_MouseEnter(object sender, EventArgs e)
        {
            //label1.Visible = true;
            PicBasico.Visible = true;
            PicPlatinum.Visible = false;
            PicOro.Visible = false;

            ClickPlat = false;
            ClickOro = false;
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            if (ClickBasico == false)
                PicBasico.Visible = false;
            //label1.Visible = false;
            
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            PicOro.Visible = true;
            PicBasico.Visible = false;
            PicPlatinum.Visible = false;

            ClickBasico = false;
            ClickPlat = false;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            if (ClickOro == false)
                PicOro.Visible= false;

        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            PicPlatinum.Visible = true;
            PicBasico.Visible = false;
            PicOro.Visible = false;

            ClickBasico = false;
            ClickOro = false;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            if (ClickPlat == false)
                PicPlatinum.Visible= false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClickOro = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ClickPlat = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClickBasico = true;
        }
    }
}
