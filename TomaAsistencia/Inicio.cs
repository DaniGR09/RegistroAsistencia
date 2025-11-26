using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TomaAsistencia
{
    public partial class Inicio: Form
    {
        private int conteo = 0;
        public Inicio()
        {
            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            conteo = conteo + 5;
            label2.Text = conteo.ToString() + "%";
            progressBar1.Value = conteo;

            if (conteo == 100)
            {
                timer1.Enabled = false;
                InicionSesion llamar = new InicionSesion();
                llamar.Show();
                this.Hide();
            }
        }
    }
}
