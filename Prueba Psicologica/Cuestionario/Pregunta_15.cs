﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba_Psicologica.Cuestionario
{
    public partial class Pregunta_15 : Form
    {
        public Pregunta_15()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Principal.Puntuacion += 1;
            Visible = false;
            Cuestionario.Pregunta_16 P16 = new Cuestionario.Pregunta_16();
            P16.ShowDialog();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            Visible = false;
            Cuestionario.Pregunta_16 P16 = new Cuestionario.Pregunta_16();
            P16.ShowDialog();
        }
    }
}