using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using control_pacientes.Clases;
namespace control_pacientes
{
    public partial class Login : Form
    {
        Conexion con = new Conexion();
        public Login()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            con.testConnection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Usuario user = new Usuario();
            user.email = txtEmail.Text.Trim();
            user.password = txtPassword.Text.Trim();
            Tuple<bool, Usuario> res = user.logIn();
            if (res.Item1)
            {
                user.password = "";
                Menu menu = new Menu(res.Item2);
                menu.Show();
                this.Hide();
            }


        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            validateButton();
        }
        public void validateButton()
        {
            if (!string.IsNullOrEmpty(txtEmail.Text) && !string.IsNullOrEmpty(txtPassword.Text))
            {
                btnLogin.Enabled = true;
            }
            else
            {
                btnLogin.Enabled = false;
            }
        }
        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtPassword_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            validateButton();
        }
    }
}
