using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Juego_en_grupo
{
    public partial class XO : Form
    {
        int turno = 0;
        public XO()
        {
            InitializeComponent();
        }

        private void pBox1_Click(object sender, EventArgs e)
        {
            PictureBoxChangeValue(ref pBox1);
        }
        public void PictureBoxChangeValue(ref PictureBox P)
        {
            if (turno == 0)
            {
                P.ImageLocation = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + @"\Images\cero.jpg";
                turno = 1;
            }
            else
            {
                P.ImageLocation = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + @"\Images\x.jpg";
                turno = 0;
            }

            if (Evalauate() == 1)
            {
                MessageBox.Show("Ya hubo un ganador");
                Clean();
            }
        }

        public int Evalauate()
        {
            int Gano = 0;
            if (pBox1.ImageLocation != (Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + @"\Images\blanco.jpeg") && pBox1.ImageLocation == pBox2.ImageLocation && pBox2.ImageLocation==pBox3.ImageLocation) Gano = 1;
            if (pBox4.ImageLocation != (Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + @"\Images\blanco.jpeg") && pBox4.ImageLocation == pBox5.ImageLocation && pBox2.ImageLocation == pBox6.ImageLocation) Gano = 1;
            if (pBox7.ImageLocation != (Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + @"\Images\blanco.jpeg") && pBox7.ImageLocation == pBox2.ImageLocation && pBox8.ImageLocation == pBox9.ImageLocation) Gano = 1;
            return Gano;
        }

        public void Clean()
        {
            pBox1.ImageLocation = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + @"\Images\blanco.jpeg";
            pBox2.ImageLocation = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + @"\Images\blanco.jpeg";
            pBox3.ImageLocation = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + @"\Images\blanco.jpeg";
            pBox4.ImageLocation = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + @"\Images\blanco.jpeg";
            pBox5.ImageLocation = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + @"\Images\blanco.jpeg";
            pBox6.ImageLocation = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + @"\Images\blanco.jpeg";
            pBox7.ImageLocation = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + @"\Images\blanco.jpeg";
            pBox8.ImageLocation = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + @"\Images\blanco.jpeg";
            pBox9.ImageLocation = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + @"\Images\blanco.jpeg";
        }

        private void X0_Load(object sender, EventArgs e)
        {

            //MessageBox.Show(Path.GetDirectoryName(Application.ExecutablePath));

        }

        private void pBox2_Click(object sender, EventArgs e)
        {
            PictureBoxChangeValue(ref pBox2);
        }

        private void pBox3_Click(object sender, EventArgs e)
        {
            PictureBoxChangeValue(ref pBox3);
        }

        private void pBox4_Click(object sender, EventArgs e)
        {
            PictureBoxChangeValue(ref pBox4);
        }

        private void pBox5_Click(object sender, EventArgs e)
        {
            PictureBoxChangeValue(ref pBox5);
        }

        private void pBox6_Click(object sender, EventArgs e)
        {
            PictureBoxChangeValue(ref pBox6);
        }

        private void pBox7_Click(object sender, EventArgs e)
        {
            PictureBoxChangeValue(ref pBox7);
        }

        private void pBox8_Click(object sender, EventArgs e)
        {
            PictureBoxChangeValue(ref pBox8);
        }

        private void pBox9_Click(object sender, EventArgs e)
        {
            PictureBoxChangeValue(ref pBox9);
        }

        private void button1_Click(object sender, EventArgs e)
        {
        
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void binicio_Click(object sender, EventArgs e)
        {
            try
            {
                pPlayer1.Value++;

                Clean();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void XO_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
