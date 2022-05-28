using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace exercise.PABD
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string usernametext = username.Text;
            string passwordtext = password.Text;

            if (usernametext == "rantoni" && passwordtext == "777") 
            {
                Menu f = new Menu();
                f.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login Gagal");
            }
        }
    }
}
