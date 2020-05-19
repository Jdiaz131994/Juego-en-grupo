using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                P.ImageLocation = @"C:\Users\Win10\source\repos\Juego-en-grupo2\cero.jpg";
                turno = 1;
            }
            else
            {
                P.ImageLocation = @"C:\Users\Win10\source\repos\Juego-en-grupo2\x.jpg";
                turno = 0;
            }
            //P.ImageLocation = Path.GetDirectoryName(Application.ExecutablePath) + "\0.jpg";
            //MessageBox.Show(P.ImageLocation);
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
    }
}
