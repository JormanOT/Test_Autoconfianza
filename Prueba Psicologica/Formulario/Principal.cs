using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
namespace Prueba_Psicologica
{
    public partial class Principal : Form
    {
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr a, int b, int c, int d);

        public static int Puntuacion = 0;
        public Principal()
        {
            InitializeComponent();
        }

        private void salir_MouseEnter(object sender, EventArgs e)
        {
            salir.Image = Properties.Resources.adjust_reset_on;
        }

        private void salir_MouseLeave(object sender, EventArgs e)
        {
            salir.Image = Properties.Resources.adjust_reset_off;
        }

        private void salir_Click(object sender, EventArgs e)
        {
            DialogResult Mensaje = MessageBox.Show("Seguro que deseas Salir de la Prueba ?","Salir de la Prueba",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(Mensaje == DialogResult.Yes)
            {
                Environment.Exit(-1);
            }
            else
            {
                //
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle,0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Mensaje.Mensaje Mensaje = new Mensaje.Mensaje();
            Mensaje.ShowDialog();           
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            Puntuacion = 0;
        }
    }
}
