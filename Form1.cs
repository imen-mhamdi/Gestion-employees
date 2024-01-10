using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionEmplyee
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (AdminBox.Text == "" && passe.Text == "")
            {
                MessageBox.Show("Missing Information");

            }
            else if (AdminBox.Text == "Admin" && passe.Text == "password")
            {
                home obj = new home();
                obj.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please enter correct Username and password");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Login.Text = "";
            passe.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
