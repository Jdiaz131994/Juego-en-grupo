﻿using System;
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
    public partial class Juego : Form
    {
        public Juego()
        {
            InitializeComponent();
        }

        private void bfin_Click(object sender, EventArgs e)
        {
            inicio frm = new inicio();

            frm.Show();

            this.Hide();
        }

        private void bnumerico_ValueChanged(object sender, EventArgs e)
        {

        }
        

        int turno = 0;
        public X0()
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
                P.ImageLocation = @"C:\Users\luisl\Source\Repos\2020.2PO2\Hola Mundo\bin\Debug\0.jpg";
                turno = 1;
            }
            else
            {
                P.ImageLocation = @"C:\Users\luisl\Source\Repos\2020.2PO2\Hola Mundo\bin\Debug\X.jpg";
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
