using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        String cedula, nombre, apellido, telefono, email;

        public Form1()
        {
            InitializeComponent();
        }

        private void BotonInsertar_Click(object sender, EventArgs e)
        {


            if (TextBoxCedula.Text != "") cedula = TextBoxCedula.Text;
            if (TextBoxNombre.Text != "") nombre = TextBoxNombre.Text;
            if (TextBoxApellido.Text != "") apellido = TextBoxApellido.Text;
            if (TextBoxTelefono.Text != "") telefono = TextBoxTelefono.Text;
            if (TextBoxEmail.Text != "") email = TextBoxEmail.Text;

            MySqlConnection conexion;
            MySqlCommand comando;
            try
            {

                conexion = new MySqlConnection(
                   "server=127.0.0.1;" +
                   "userid=root;" +
                   "password=negritoBD123;" +
                   "database=personita"
                );
                conexion.Open();

                comando = new MySqlCommand();
                comando.Connection = conexion;
                comando.CommandText = "INSERT INTO persona VALUES(@cedula,@nombre,@apellido,@telefono,@email)";
                comando.Parameters.AddWithValue("@cedula", cedula);
                comando.Parameters.AddWithValue("@nombre", nombre);
                comando.Parameters.AddWithValue("@apellido", apellido);
                comando.Parameters.AddWithValue("@telefono", telefono);
                comando.Parameters.AddWithValue("@email", email);
                comando.Prepare();

                comando.ExecuteNonQuery();
                MessageBox.Show("Insertado");
            }
            catch(MySqlException ex)
            {
                // Hacer la magia aca!!!
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error");
            }

        }
    }
}
