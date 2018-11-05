using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace control_pacientes.UserControls
{
    public partial class HomePanel : UserControl
    {
        public HomePanel()
        {
            InitializeComponent();
        }

        private void btnAgregarConsulta_Click(object sender, EventArgs e)
        {
            pnlConsulta.BringToFront();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
           // pnlHome.BringToFront();
        }
    }
}
