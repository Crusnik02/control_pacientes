using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace control_pacientes
{
    public partial class Home : UserControl
    {
        public Home()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {
            pnlHome.BringToFront();
        }

        private void btnAgregarConsulta_Click(object sender, EventArgs e)
        {
            pnlHome.BringToFront();

        }

        private void btnAgregarConsulta_Click_1(object sender, EventArgs e)
        {
            pnlConsulta.BringToFront();
        }
    }
}
