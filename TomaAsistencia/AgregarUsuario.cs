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
    public partial class AgregarUsuario: Form
    {
        public AgregarUsuario()
        {
            InitializeComponent();
        }
        MySqlConnection conexionDB = Conexion.conexion();

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                conexionDB.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            string nombre = txtNomCompleto.Text;
            string usuario = txtUsuario.Text;
            string contrasena = txtContrasena.Text;

            string consulta = "INSERT INTO usuarios (nombreCompleto, nombreUsuario, contrasena) VALUES ('" + nombre + "','" + usuario + "','" + contrasena + "')";

            MySqlCommand comando = new MySqlCommand(consulta, conexionDB);

            try
            {
                int filasAfectadas = comando.ExecuteNonQuery();
                if (filasAfectadas > 0)
                {
                    MessageBox.Show("Datos ingresados correctamente");
                    txtNomCompleto.Clear();
                    txtUsuario.Clear();
                    txtContrasena.Clear();
                    txtNomCompleto.Focus();
                }
                else
                {
                    Console.WriteLine("No se afectaron filas");
                    MessageBox.Show("No se afectaron filas", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar la consulta: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            conexionDB.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Menu llamar = new Menu();
            llamar.Show();
            this.Hide();
        }
    }
}
