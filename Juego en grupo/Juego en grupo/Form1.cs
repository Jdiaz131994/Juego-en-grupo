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
    public partial class inicio : Form
    {
        public inicio()
        {
            InitializeComponent();
        }

        private void binicio_Click(object sender, EventArgs e)
        {
            Juego frm = new Juego();

            frm.Show();

            this.Hide();
        }
    }
}
