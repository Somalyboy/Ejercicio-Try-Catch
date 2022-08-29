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
            conexion = new MySqlConnection(
                   "server=127.0.0.1;" +
                   "userid=root;" +
                   "password=;" +
                   "database=personita"
                );
            try
            {              
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
            catch
            {
                if (String.IsNullOrEmpty(TextBoxCedula.Text))
                {
                    MessageBox.Show("No puede dejar ningun campo vacio ");
                }
                if (String.IsNullOrEmpty(TextBoxNombre.Text))
                {
                    MessageBox.Show("No puede dejar ningun campo vacio ");
                }
                if (String.IsNullOrEmpty(TextBoxApellido.Text))
                {
                    MessageBox.Show("No puded dejar ningun campi vacio ");
                }
                if (String.IsNullOrEmpty(TextBoxTelefono.Text))
                {
                    MessageBox.Show("No puede dejar ningun campo vacio ");
                }
                if (String.IsNullOrEmpty(TextBoxEmail.Text))
                {
                    MessageBox.Show("No puede dejar ningun campo vacio ");
                }             
            }
           
            try
            {
                comando = new MySqlCommand();

                string query = "SELECT COUNT(cedula) FROM persona WHERE cedula = @cedula";

                comando.Connection = conexion;
                comando.CommandText = query;

                comando.Parameters.AddWithValue("@cedula", cedula);

                MySqlDataReader lector = comando.ExecuteReader();
                if (lector.Read()) MessageBox.Show("La cedula que intenta ingresar ya existe " + "ERROR: " );
            }
            catch (Exception ex)
            {
                Console.Write("Hubo un error" + ex);
            }
            catch
            {
                int n;
                bool EsEntero = Int32.TryParse(TextBoxCedula.Text, out n);
                if (!EsEntero)
                {
                    MessageBox.Show("Debe ingresar los 8 numeros de su cedula sin el digito separador");
                }
            }

        }
    }
}