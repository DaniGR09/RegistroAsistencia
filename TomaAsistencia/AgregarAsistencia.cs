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
    public partial class AgregarAsistencia: Form
    {
        public AgregarAsistencia()
        {
            InitializeComponent();

            dtpFecha.Format = DateTimePickerFormat.Custom;
            dtpFecha.CustomFormat = "yyyy-MM-dd";
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

            string nombre = txtNombre.Text;
            string fecha = dtpFecha.Value.ToString("yyyy-MM-dd");
            string horaEntrada = txtHoraE.Text;
            string horaSalida = txtHoraS.Text;


            string consulta = "INSERT INTO asistencias (nombre, fecha, hora_entrada, hora_salida) VALUES ('" + nombre + "','" + fecha + "','" + horaEntrada + "', '" + horaSalida + "')";

            MySqlCommand comando = new MySqlCommand(consulta, conexionDB);

            try
            {
                int filasAfectadas = comando.ExecuteNonQuery();
                if (filasAfectadas > 0)
                {
                    MessageBox.Show("Datos ingresados correctamente");
                    txtNombre.Clear();
                    txtHoraE.Clear();
                    txtHoraS.Clear();
                    txtNombre.Focus();
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Menu llamar = new Menu();
            llamar.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
