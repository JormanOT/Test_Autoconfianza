using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba_Psicologica.Mensaje
{
    public partial class El_mundo_a_sus_pies : Form
    {
        public El_mundo_a_sus_pies()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Environment.Exit(-1);
        }
    }
}
