using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;

using control_pacientes.Clases;
namespace control_pacientes
{
    public partial class Menu : Form
    {
        Usuario user;
        public Menu(Usuario user)
        {
            InitializeComponent();
            this.user = user;
            lblNombre.Text = user.nombre;
            lblRole.Text = user.rol.nombre;
            try
            {
                WebClient client = new WebClient();
                byte[] bytes = client.DownloadData(user.foto);
                MemoryStream ms = new MemoryStream(bytes);
                Image img = Image.FromStream(ms);
                pnlFotoUsuario.BackgroundImage = img;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            Login log = new Login();
            lblPageTitle.Text = "Inicio";
        }

        private void lblPageTitle_Click(object sender, EventArgs e)
        {

        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            lblPageTitle.Text = "Usuarios";
            usersPanel.BringToFront();
            usersPanel.refreshGrid();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            lblPageTitle.Text = "Inicio";
            homePanel.BringToFront();
            
        }

        private void homePanel_Load(object sender, EventArgs e)
        {

        }
    }
}
