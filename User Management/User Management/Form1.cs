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

namespace User_Management
{
    public partial class Form1 : Form
    {
        MySqlConnection con = new MySqlConnection("server=localhost;username=root;password=1234;database=db_topicos");
        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            con.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM user WHERE username='" + textBox1.Text + "'AND password='" + textBox2.Text + "' ", con);
            MySqlDataReader leer = cmd.ExecuteReader();
            if (leer.Read()){ //Si el usuario es correcto nos abrira la otra ventana.
                //MessageBox.Show("Succes - Inicio de Sesión Completado");
                con.Close();
                this.Hide();
                Form2 ss = new Form2();
                ss.Show();
            }
            else
                MessageBox.Show("Error - Ingrese sus datos correctamente");
            con.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
