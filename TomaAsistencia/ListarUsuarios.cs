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
    public partial class ListarUsuarios: Form
    {
        public ListarUsuarios()
        {
            InitializeComponent();
        }
        private void CargarDatos()
        {
            try
            {
                using (MySqlConnection conexionDB = Conexion.conexion())
                {
                    string consulta = "SELECT * FROM usuarios";
                    MySqlDataAdapter adaptador = new MySqlDataAdapter(consulta, conexionDB);
                    DataTable dt = new DataTable();
                    adaptador.Fill(dt);

                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void deshabilitarBotones()
        {
            btnActualizar.Enabled = false;
            btnEliminar.Enabled = false;
        }
        private void habilitarBotones()
        {
            btnActualizar.Enabled = true;
            btnEliminar.Enabled = true;
        }
        private void LimpiarTextos()
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox textbox)
                {
                    textbox.Clear();
                }
            }
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            Menu llamar = new Menu();
            llamar.Show();
            this.Hide();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }
        private void ListarUsuarios_Load(object sender, EventArgs e)
        {
            CargarDatos();
            deshabilitarBotones();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtNomCompleto.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtUsuario.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtContrasena.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();

            habilitarBotones();
        }


        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conexionDB = Conexion.conexion())
                {
                    conexionDB.Open();

                    int bandera = 0;

                    string id = txtId.Text;
                    string nombre = txtNomCompleto.Text;
                    string usuario = txtUsuario.Text;
                    string contrasena = txtContrasena.Text;
                    string consulta = "UPDATE usuarios SET nombreCompleto='" + nombre + "', contrasena='" + contrasena + "', nombreUsuario='" + usuario + "' WHERE id='" + id + "'";

                    MySqlCommand comando = new MySqlCommand(consulta, conexionDB);
                    bandera = comando.ExecuteNonQuery();
                    if (bandera == 1)
                    {
                        MessageBox.Show("Datos actualizados correctamente");
                        CargarDatos();
                    }
                    else
                    {
                        MessageBox.Show("Error al actualizar");
                    }
                    conexionDB.Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conexionDB = Conexion.conexion())
                {
                    conexionDB.Open();

                    int bandera = 0;

                    string id = txtId.Text;
                    string nombre = txtNomCompleto.Text;
                    string consulta = "DELETE FROM usuarios WHERE id='" + id + "'";

                    DialogResult respuesta = MessageBox.Show("Realmente desea eliminar el usuario '" + nombre + "'?", "ELIMINAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (respuesta == DialogResult.Yes)
                    {
                        MySqlCommand comando = new MySqlCommand(consulta, conexionDB);
                        bandera = comando.ExecuteNonQuery();

                        if (bandera == 1)
                        {
                            MessageBox.Show("Datos eliminados correctamente");
                            CargarDatos();
                            LimpiarTextos();
                            deshabilitarBotones();
                        }
                        else
                        {
                            MessageBox.Show("Error al eliminar");
                        }
                    }
                    conexionDB.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
