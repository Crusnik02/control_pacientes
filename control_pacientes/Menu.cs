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
            usersPanel.Show();
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

        private void btnPaciente_Click(object sender, EventArgs e)
        {
            lblPageTitle.Text = "Paciente";
            paciente1.Show();
            paciente1.BringToFront();            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblPageTitle.Text = "Especialides";
            Catalogos.CatEspecialidadPanel espe = new Catalogos.CatEspecialidadPanel();
            this.Controls.Add(espe);
            espe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            espe.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            espe.Location = new System.Drawing.Point(222, 175);
            espe.Size = new System.Drawing.Size(1140, 580);
            espe.TabIndex = 2;
            usersPanel.Hide();
            paciente1.Hide();
            espe.BringToFront();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            lblPageTitle.Text = "Medicamentos";
            Catalogos.CatMedicamentoPanel med = new Catalogos.CatMedicamentoPanel();
            this.Controls.Add(med);
            med.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            med.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            med.Location = new System.Drawing.Point(222, 175);
            med.Size = new System.Drawing.Size(1140, 580);
            med.TabIndex = 2;
            this.paciente1.Hide();
            this.usersPanel.Hide();
            med.BringToFront();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            lblPageTitle.Text = "Enfermedades";
            Catalogos.CatEnfermedadPanel enfe = new Catalogos.CatEnfermedadPanel();
            this.Controls.Add(enfe);
            enfe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            enfe.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            enfe.Location = new System.Drawing.Point(222, 175);
            enfe.Size = new System.Drawing.Size(1140, 580);
            enfe.TabIndex = 2;
            this.paciente1.Hide();
            this.usersPanel.Hide();
            enfe.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            lblPageTitle.Text = "Vacunas";
            Catalogos.CatVacunasPanel v = new Catalogos.CatVacunasPanel();
            this.Controls.Add(v);
            v.Anchor= ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            v.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            v.Location = new System.Drawing.Point(222, 175);
            v.Size = new System.Drawing.Size(1140,580);
            v.TabIndex = 2;
            this.paciente1.Hide();
            this.usersPanel.Hide();
            v.BringToFront();
        }
    }
}
