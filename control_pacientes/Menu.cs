﻿using System;
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

        private void catEspecialidad_Click(object sender, EventArgs e)
        {
            lblPageTitle.Text="Especialides";
            Catalogos.CatEspecialidadPanel espe =new Catalogos.CatEspecialidadPanel();
            this.Controls.Add(espe);
            espe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            |System.Windows.Forms.AnchorStyles.Right)));
            espe.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            espe.Location = new System.Drawing.Point(222, 175);            
            espe.Size = new System.Drawing.Size(1140, 580);
            espe.TabIndex = 2;
            espe.BringToFront();
         }

        private void catEnfermedad_Click(object sender, EventArgs e)
        {
            lblPageTitle.Text = "Enfermedades";
            Catalogos.CatEnfermedadPanel enfe = new Catalogos.CatEnfermedadPanel();
            this.Controls.Add(enfe);
            enfe.Anchor=((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            enfe.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            enfe.Location = new System.Drawing.Point(222, 175);
            enfe.Size = new System.Drawing.Size(1140, 580);
            enfe.TabIndex = 2;
            enfe.BringToFront();
        }

        private void catMedicamento_Click(object sender, EventArgs e)
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
            med.BringToFront();
        }
    }
}
