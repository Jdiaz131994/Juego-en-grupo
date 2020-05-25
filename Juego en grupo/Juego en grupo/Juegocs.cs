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
                puntuacion_1();
            }
            else
            {
                P.ImageLocation = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + @"\Images\x.jpg";
                turno = 0;
                puntuacion_2();

            }
                                    
            if (Evalauate() == 1)
             {
                 MessageBox.Show("Felicidades gano");
                  Clean();
             }
                
            
            


            if (pPlayer1.Value == pPlayer1.Maximum)
            {
                MessageBox.Show("Gano posicion O");
                Clean();
            }
        }


        public void ganar()
        {
            
        }

        public int Evalauate()
        {
            int Gano = 0;

            if (pBox1.ImageLocation != (Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + @"\Images\blanco.jpeg") && pBox1.ImageLocation == pBox2.ImageLocation && pBox2.ImageLocation==pBox3.ImageLocation) Gano = 1;
            if (pBox4.ImageLocation != (Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + @"\Images\blanco.jpeg") && pBox4.ImageLocation == pBox5.ImageLocation && pBox5.ImageLocation == pBox6.ImageLocation) Gano = 1;
            if (pBox7.ImageLocation != (Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + @"\Images\blanco.jpeg") && pBox7.ImageLocation == pBox8.ImageLocation && pBox8.ImageLocation == pBox9.ImageLocation) Gano = 1;
            if (pBox1.ImageLocation != (Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + @"\Images\blanco.jpeg") && pBox1.ImageLocation == pBox4.ImageLocation && pBox4.ImageLocation==pBox7.ImageLocation) Gano = 1;
            if (pBox2.ImageLocation != (Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + @"\Images\blanco.jpeg") && pBox2.ImageLocation == pBox5.ImageLocation && pBox5.ImageLocation == pBox8.ImageLocation) Gano = 1;
            if (pBox3.ImageLocation != (Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + @"\Images\blanco.jpeg") && pBox3.ImageLocation == pBox6.ImageLocation && pBox6.ImageLocation == pBox9.ImageLocation) Gano = 1;
            if (pBox1.ImageLocation != (Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + @"\Images\blanco.jpeg") && pBox1.ImageLocation == pBox5.ImageLocation && pBox5.ImageLocation == pBox9.ImageLocation) Gano = 1;
            if (pBox7.ImageLocation != (Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + @"\Images\blanco.jpeg") && pBox7.ImageLocation == pBox5.ImageLocation && pBox5.ImageLocation == pBox3.ImageLocation) Gano = 1;
            return Gano;
        }

        public int Evalauate_2()
        {
            int Gana = 0;
            if (pBox1.ImageLocation != (Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + @"\Images\blanco.jpeg" + @"\Images\cero.jpeg") && pBox1.ImageLocation == pBox2.ImageLocation && pBox2.ImageLocation == pBox3.ImageLocation) Gana = 1;
            if (pBox4.ImageLocation != (Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + @"\Images\blanco.jpeg" + @"\Images\cero.jpeg") && pBox4.ImageLocation == pBox5.ImageLocation && pBox5.ImageLocation == pBox6.ImageLocation) Gana = 1;
            if (pBox7.ImageLocation != (Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + @"\Images\blanco.jpeg" + @"\Images\cero.jpeg") && pBox7.ImageLocation == pBox8.ImageLocation && pBox8.ImageLocation == pBox9.ImageLocation) Gana = 1;
            if (pBox1.ImageLocation != (Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + @"\Images\blanco.jpeg" + @"\Images\cero.jpeg") && pBox1.ImageLocation == pBox4.ImageLocation && pBox4.ImageLocation == pBox7.ImageLocation) Gana = 1;
            if (pBox2.ImageLocation != (Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + @"\Images\blanco.jpeg" + @"\Images\cero.jpeg") && pBox2.ImageLocation == pBox5.ImageLocation && pBox5.ImageLocation == pBox8.ImageLocation) Gana = 1;
            if (pBox3.ImageLocation != (Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + @"\Images\blanco.jpeg" + @"\Images\cero.jpeg") && pBox3.ImageLocation == pBox6.ImageLocation && pBox6.ImageLocation == pBox9.ImageLocation) Gana = 1;
            if (pBox1.ImageLocation != (Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + @"\Images\blanco.jpeg" + @"\Images\cero.jpeg") && pBox1.ImageLocation == pBox5.ImageLocation && pBox5.ImageLocation == pBox9.ImageLocation) Gana = 1;
            if (pBox7.ImageLocation != (Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + @"\Images\blanco.jpeg" + @"\Images\cero.jpeg") && pBox7.ImageLocation == pBox5.ImageLocation && pBox5.ImageLocation == pBox3.ImageLocation) Gana = 1;
            return Gana;
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
           pPlayer1.Value = pPlayer1.Minimum;
           pPlayer2.Value = pPlayer2.Minimum;
           Clean();
        }

        private void XO_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            inicio frm = new inicio();
            frm.Show();
        }

        private void pPlayer1_Click(object sender, EventArgs e)
        {

        }

        private void XO_Load(object sender, EventArgs e)
        {

        }

        private void pPlayer2_Click(object sender, EventArgs e)
        {

        }

        public void puntuacion_1()
        {      if (pBox1.ImageLocation != (Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + @"\Images\blanco.jpeg" + @"\Images\x.jpeg") && pBox1.ImageLocation == pBox2.ImageLocation && pBox2.ImageLocation == pBox3.ImageLocation)
                    try
                {
                    MessageBox.Show("Gana posicion O ");
                    pPlayer1.Value++;
                    Clean();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }    
            
        }

        public void puntuacion_2()
        {
            if (pBox1.ImageLocation != (Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + @"\Images\blanco.jpeg" + @"\Images\cero.jpeg") && pBox1.ImageLocation == pBox2.ImageLocation && pBox2.ImageLocation == pBox3.ImageLocation)
                try
                {
                    pPlayer2.Value++;
                    MessageBox.Show("Gana posicion X ");
                    Clean();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            

        }

    }

    }


