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
    public partial class Login : Form
    {
        bool passwordHidden = true;
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (passwordHidden)
            {
                pictureBox1.Image = Image.FromFile("assets/view.png");
                txt_passwordlogin.PasswordChar = '\0';
                passwordHidden = false;
            }
            else
            {
                pictureBox1.Image = Image.FromFile("assets/hide.png");
                txt_passwordlogin.PasswordChar = '*';
                passwordHidden = true;

            }
        }

        private void txt_passwordlogin_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
