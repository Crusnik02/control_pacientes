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
            WebClient client = new WebClient();
            byte[] bytes = client.DownloadData("https://wowsciencecamp.org/wp-content/uploads/2018/07/dummy-user-img-1-400x400_x_acf_cropped.png");
            MemoryStream ms = new MemoryStream(bytes);
            Image img = Image.FromStream(ms);
            pnlFotoUsuario.BackgroundImage = img;
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            Login log = new Login();
        }
    }
}
