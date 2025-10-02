using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seminar3
{
    public partial class Register : Form
    {
        bool passwordHidden = true;
        public Register()
        {
            InitializeComponent();
        }

        private void txt_passwordregister_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txt_usernamereg_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (passwordHidden)
            {
                pictureBox1.Image = Image.FromFile("assets/view.png");
                txt_passwordregister.PasswordChar = '\0';
                passwordHidden = false;
            }
            else
            {
                pictureBox1.Image = Image.FromFile("assets/hide.png");
                txt_passwordregister.PasswordChar = '*';
                passwordHidden = true;

            }
        }
    }
}
