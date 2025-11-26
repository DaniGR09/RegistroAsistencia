using MySql.Data.MySqlClient;
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
    public partial class InicionSesion: Form
    {
        public InicionSesion()
        {
            InitializeComponent();
        }
        MySqlConnection conexionDB = Conexion.conexion();
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                conexionDB.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            MySqlCommand codigo = new MySqlCommand();
            codigo.Connection = conexionDB;
            codigo.CommandText = ("SELECT * FROM usuarios WHERE nombreUsuario = '" + txtUsuario.Text + "' and contrasena='" + txtContrasena.Text + "'");
            MySqlDataReader leer = codigo.ExecuteReader();

            if (leer.Read())
            {
                Menu llamar = new Menu();
                llamar.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrecta", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsuario.Clear();
                txtContrasena.Clear();
                txtUsuario.Focus();
            }
            conexionDB.Close();
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registrarse llamar = new Registrarse();
            llamar.Show();
            this.Hide();
        }
    }
}
