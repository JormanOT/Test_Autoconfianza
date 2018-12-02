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
    public partial class A_un_paso_Del_Triunfo : Form
    {
        public A_un_paso_Del_Triunfo()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Environment.Exit(-1);
        }
    }
}
