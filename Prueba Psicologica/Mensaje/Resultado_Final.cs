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
    public partial class Resultado_Final : Form
    {
        int Total_Puntos;
        public Resultado_Final()
        {
            InitializeComponent();
        }

        private void Resultado_Final_Load(object sender, EventArgs e)
        {
            Total.Text = Principal.Puntuacion.ToString() + " " + "Puntos";
            Total_Puntos = Principal.Puntuacion;
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if(Total_Puntos < 5)
            {
                Visible = false;
                Falta_de_Autoestima FA = new Falta_de_Autoestima();
                FA.ShowDialog();
            }
            else if(Total_Puntos == 5 || Total_Puntos <= 10)
            {
                Visible = false;
                Timidez_e_Indecision TI = new Timidez_e_Indecision();
                TI.ShowDialog();
            }
            else if(Total_Puntos == 11 || Total_Puntos <= 16)
            {
                Visible = false;
                A_un_paso_Del_Triunfo PT = new A_un_paso_Del_Triunfo();
                PT.ShowDialog();
            }
            else if(Total_Puntos > 16)
            {
                Visible = false;
                El_mundo_a_sus_pies MP = new El_mundo_a_sus_pies();
                MP.ShowDialog();
            }
            else
            {
                MessageBox.Show("No evalua","error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
