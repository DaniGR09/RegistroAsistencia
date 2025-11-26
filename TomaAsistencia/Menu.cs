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
    public partial class Menu: Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnAgregarU_Click(object sender, EventArgs e)
        {
            AgregarUsuario llamar = new AgregarUsuario();
            llamar.Show();
            this.Hide();
        }

        private void btnListarU_Click(object sender, EventArgs e)
        {
            ListarUsuarios llamar = new ListarUsuarios();
            llamar.Show();
            this.Hide();
        }

        private void btnAgregarA_Click(object sender, EventArgs e)
        {
            AgregarAsistencia llamar = new AgregarAsistencia();
            llamar.Show();
            this.Hide();
        }

        private void btnListarA_Click(object sender, EventArgs e)
        {
            ListarAsistencia llamar = new ListarAsistencia();
            llamar.Show();
            this.Hide();
        }
    }
}
