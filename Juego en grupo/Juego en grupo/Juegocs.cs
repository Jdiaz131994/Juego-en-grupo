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
        int turno = 1;
        int[,] x_o;
        bool YaHayGanador;

        public XO()
        {
            InitializeComponent();
            IniciarJuego();
        }

        public void IniciarJuego()
        {
            // Iniciar Valores en Juego
            turno = 1;
            x_o = new int[3, 3];
            YaHayGanador = false;

            pictureBox3.Image = Properties.Resources.f_0;
            tablax_o.Controls.Clear();

            // Arreglos para mostrar imagenes y meter valores en una matriz
            for (var i = 0; i < 3; i++)
            {
                for (var j = 0; j < 3; j++)
                {
                    var FichaJuego = new PictureBox();
                    FichaJuego.Image = Properties.Resources.f_0;
                    FichaJuego.Name = string.Format("{0}", i + "_" + j);
                    FichaJuego.Dock = DockStyle.Fill;
                    FichaJuego.Cursor = Cursors.Hand;
                    FichaJuego.SizeMode = PictureBoxSizeMode.StretchImage;
                    FichaJuego.Click += Jugar;
                    tablax_o.Controls.Add(FichaJuego, j, i);
                    x_o[i, j] = 0;


                }
            }

        }

        private void Jugar(object sender, EventArgs e)
        {

            var FichaSeleccionadaUsuario = (PictureBox)sender;
            FichaSeleccionadaUsuario.Enabled = false;
            FichaSeleccionadaUsuario.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject("f_" + turno);
            string[] Posicion = FichaSeleccionadaUsuario.Name.Split("_".ToCharArray());
            int Fila = Convert.ToInt32(Posicion[0]);
            int Columna = Convert.ToInt32(Posicion[1]);
            x_o[Fila, Columna] = turno;
            VerificarJuego(Fila, Columna);
            turno = (turno == 1) ? 2 : 1;

        }

        public void VerificarJuego(int Fila, int Columna)
        {
            // Contador imagenes filas y columnas del x_o
            int x_oFilas = 0;
            int x_oColumnas = 0;
            int DiagonalPrincipal = 0;
            int DiagonalInversa = 0;
            int Tamaniox_o = 3;

            for (var i = 0; i < Tamaniox_o; i++)
            {
                for (var j = 0; j < Tamaniox_o; j++)
                {

                    if (i == Fila)
                    {
                        if (x_o[i, j] == turno)
                        {
                            x_oFilas++;
                        }
                    }
                    if (j == Columna)
                    {
                        if (x_o[i, j] == turno)
                        {
                            x_oColumnas++;
                        }
                    }
                    if (i == j) // Diagonal principal
                    {
                        if (x_o[i, j] == turno)
                        {
                            DiagonalPrincipal++;
                        }
                    }

                    if ((i + j) == (Tamaniox_o - 1)) // Diagonal Inversa
                    {
                        if (x_o[i, j] == turno)
                        {
                            DiagonalInversa++;

                        }
                    }



                }
            }

            if ((x_oFilas == Tamaniox_o) || (x_oColumnas == Tamaniox_o) || (DiagonalInversa == Tamaniox_o) || (DiagonalPrincipal == Tamaniox_o))
            {
                YaHayGanador = true;
            }
            else
            {
                bool Empate = true;
                for (var i = 0; i < Tamaniox_o; i++)
                {
                    for (var j = 0; j < Tamaniox_o; j++)
                    {
                        if (x_o[i, j] == 0)
                        {
                            Empate = false;
                        }

                    }
                }
                if (Empate)
                {
                    MessageBox.Show("Esto es un empate ¡Reinicia el juego!");
                    IniciarJuego();
                }

            }
            if (YaHayGanador)
            {

                MessageBox.Show("Ya hay ganador");

                if (turno == 1)
                {
                    try
                    {
                        pPlayer1.Value++;

                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    IniciarJuego();
                }
                else
                {
                    
                    try
                    {
                        pPlayer2.Value++;

                       
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    IniciarJuego();
                }

                

            }

            if (pPlayer1.Value == pPlayer1.Maximum || pPlayer2.Value == pPlayer2.Maximum)
            {
                MessageBox.Show("Ganador final");
            }


        }

        private void X0_Load(object sender, EventArgs e)
        {

            //MessageBox.Show(Path.GetDirectoryName(Application.ExecutablePath));

        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void Clean()
        {
            pPlayer1.Value = pPlayer1.Minimum;
            pPlayer2.Value = pPlayer2.Minimum;
            IniciarJuego();
        }

        private void binicio_Click(object sender, EventArgs e)
        {
            Clean(); //limpiar tabla y marcador
            
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
        {
        }

        public void puntuacion_2()
        {

        }

    }

}




    


/*
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

      /*if (Evalauate() == 1)
       {
           MessageBox.Show("Felicidades gano");
            Clean();
       }*/




/*
    if (pPlayer1.Value == pPlayer1.Maximum)
    {
        MessageBox.Show("Gano posicion O");

    }
}


/*  public void ganar()
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



    private void pBox1_Click(object sender, EventArgs e)
    {
        PictureBoxChangeValue(ref pBox1);
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
    }*/
    

    

    