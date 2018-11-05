using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using control_pacientes.Clases;
using control_pacientes.Utils;
using System.Net;
using System.Data.SqlClient;
using System.Data;
using System.IO;
namespace control_pacientes
{
    public partial class UsersPanel : UserControl
    {
        bool agregando = false;
        bool editando = false;
        string selectedFile = null;
        int userId;

        public UsersPanel()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
                
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel2_PaddingChanged(object sender, EventArgs e)
        {

        }

        public void refreshGrid()
        {
            var user = new Usuario();
        }

        public void fillGrid()
        {
            try
            {
                var utils = new Utils.GlobalFunctions();
                var Queries = new Utils.Queries();
                utils.fillGrid(dgvUsers, Queries.GET_USERS);
                dgvUsers.Columns["rolID"].Visible = false;
                dgvUsers.Columns["usuarioID"].Visible = false;
                dgvUsers.Columns["foto"].Visible = false;
                for (int i = 0; i < dgvUsers.Columns.Count - 1; i++)
                {
                    dgvUsers.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }
                dgvUsers.Columns[dgvUsers.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                for (int i = 0; i < dgvUsers.Columns.Count; i++)
                {
                    int colw = 140;
                    dgvUsers.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                    dgvUsers.Columns[i].Width = colw;
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public void setUserToForm()
        {
            if(dgvUsers.RowCount > 0)
            {
                var i = dgvUsers.CurrentRow.Index;
                txtNombre.Text = dgvUsers.Rows[i].Cells["Nombre"].Value.ToString();
                txtDui.Text = dgvUsers.Rows[i].Cells["DUI"].Value.ToString();
                txtNit.Text = dgvUsers.Rows[i].Cells["NIT"].Value.ToString();
                txtTelefono.Text = dgvUsers.Rows[i].Cells["Tel. 1"].Value.ToString();
                txtTelefono2.Text = dgvUsers.Rows[i].Cells["Tel. 2"].Value.ToString();
                dtpFechaNacimiento.Value = Convert.ToDateTime(dgvUsers.Rows[i].Cells["Fecha de Nacimiento"].Value.ToString());
                txtEmail.Text = dgvUsers.Rows[i].Cells["Email"].Value.ToString();
                rdbAdmin.Checked = dgvUsers.Rows[i].Cells["rolID"].Value.ToString() == "1";
                rdbDoctor.Checked = dgvUsers.Rows[i].Cells["rolID"].Value.ToString() == "2";
                rdbAsistente.Checked = dgvUsers.Rows[i].Cells["rolID"].Value.ToString() == "3";
                userId = int.Parse(dgvUsers.Rows[i].Cells["usuarioID"].Value.ToString());
                if (!string.IsNullOrEmpty(dgvUsers.Rows[i].Cells["foto"].Value.ToString()))
                {
                    try
                    {
                        selectedFile = dgvUsers.Rows[i].Cells["foto"].Value.ToString();
                        WebClient client = new WebClient();
                        byte[] bytes = client.DownloadData(selectedFile);
                        MemoryStream ms = new MemoryStream(bytes);
                        Image img = Image.FromStream(ms);
                        pnlUsuarioFoto.BackgroundImage = img;
                    }
                    catch(WebException e)
                    {
                        MessageBox.Show(e.ToString());
                    }
                }
            }
        }

        public void cleanInputs()
        {
            txtNombre.Text = "";
            txtDui.Text = "";
            txtNit.Text = "";
            txtTelefono.Text = "";
            txtTelefono2.Text = "";
            dtpFechaNacimiento.Value = DateTime.Now;
            txtEmail.Text = "";
            txtPassword.Text = "";
            rdbAdmin.Checked = false;
            rdbDoctor.Checked = false;
            rdbAsistente.Checked = false;
            pnlUsuarioFoto.BackgroundImage = null;
        }

        public void setFormStatus(bool status = false)
        {
            if(!status)
            {
                cleanInputs();
            }
            txtNombre.Enabled = status;
            txtDui.Enabled = status;
            txtNit.Enabled = status;
            txtTelefono.Enabled = status;
            txtTelefono2.Enabled = status;
            dtpFechaNacimiento.Enabled = status;
            txtEmail.Enabled = status;
            txtPassword.Enabled = status;
            rdbAdmin.Enabled = status;
            rdbAsistente.Enabled = status;
            rdbDoctor.Enabled = status;
            btnSubirFoto.Enabled = status;
        }

        public void resetBarra(bool status = false)
        {
            agregando = false;
            editando = false;
            btnAgregar.Enabled = status;
            btnEditar.Enabled = status;
            btnEliminar.Enabled = status;
            btnCancelar.Enabled = status;
            btnGuardar.Enabled = status;
        }

        public string RandomString(int length)
        {
            var random = new Random();
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private void UsersPanel_Load(object sender, EventArgs e)
        {
            fillGrid();
            resetBarra();
            setFormStatus(false);
            btnAgregar.Enabled = true;
        }
        
        private void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!agregando)
            {
                btnAgregar.Enabled = false;
                btnEditar.Enabled = true;
                btnEliminar.Enabled = true;
                btnCancelar.Enabled = true; 
                setUserToForm();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            agregando = true;
            editando = false;
            btnAgregar.Enabled = false;
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            setFormStatus(true);
            txtPassword.Text = RandomString(6);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            setFormStatus(false);
            resetBarra();
            btnAgregar.Enabled = true;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            editando = true;
            agregando = false;
            setFormStatus(true);
            btnCancelar.Enabled = true;
            btnEliminar.Enabled = false;
            btnGuardar.Enabled = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (fldImagen.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                selectedFile = fldImagen.FileName;
            }
            if (!string.IsNullOrEmpty(selectedFile))
            {
                Image img = Image.FromFile(selectedFile);
                pnlUsuarioFoto.BackgroundImage = img;
            }
        }

        public int getRol()
        {
            if (rdbAdmin.Checked) return 1;
            if (rdbDoctor.Checked) return 2;
            if (rdbAsistente.Checked) return 3;
            return 3;
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var utils = new Utils.GlobalFunctions();
            var queries = new Utils.Queries();
            var user = new Usuario();
            SqlCommand cmd = new SqlCommand();
            if (agregando)
            {
                cmd = new SqlCommand(queries.ADD_USER);
            }else if (editando)
            {
                var passwordModified = !string.IsNullOrEmpty(txtPassword.Text);
                cmd = new SqlCommand(passwordModified ? queries.EDIT_USER : queries.EDIT_USER_NO_PASSWORD);
            }

            var nombre = new SqlParameter("@nombre", SqlDbType.NVarChar, 50);
            nombre.Value = txtNombre.Text.Trim();
            cmd.Parameters.Add(nombre);

            var fechaNacimiento = new SqlParameter("@fechaNacimiento", SqlDbType.Date, 50);
            fechaNacimiento.Value = dtpFechaNacimiento.Value.ToString();
            cmd.Parameters.Add(fechaNacimiento);

            var dui = new SqlParameter("@dui", SqlDbType.NVarChar, 50);
            dui.Value = txtDui.Text.Trim();
            cmd.Parameters.Add(dui);

            var nit = new SqlParameter("@nit", SqlDbType.NVarChar, 50);
            nit.Value = txtNit.Text.Trim();
            cmd.Parameters.Add(nit);

            var telefono_1 = new SqlParameter("@telefono_1", SqlDbType.NVarChar, 50);
            telefono_1.Value = txtTelefono.Text.Trim();
            cmd.Parameters.Add(telefono_1);

            var telefono_2 = new SqlParameter("@telefono_2", SqlDbType.NVarChar, 50);
            telefono_2.Value = txtTelefono2.Text.Trim();
            cmd.Parameters.Add(telefono_2);

            var email = new SqlParameter("@email", SqlDbType.NVarChar, 50);
            email.Value = txtEmail.Text.Trim();
            cmd.Parameters.Add(email);

            var foto = new SqlParameter("@foto", SqlDbType.NVarChar, 50);
            foto.Value = selectedFile;
            cmd.Parameters.Add(foto);

            var pass = new SqlParameter("@password", SqlDbType.NVarChar, 100);
            pass.Value = user.ComputeSha256Hash(txtPassword.Text);
            cmd.Parameters.Add(pass);

            var rolID = new SqlParameter("@rolID", SqlDbType.Int);
            rolID.Value = getRol();
            cmd.Parameters.Add(rolID);

            var usuarioID = new SqlParameter("@usuarioID", SqlDbType.Int);
            usuarioID.Value = userId;
            cmd.Parameters.Add(usuarioID);
            MessageBox.Show(cmd.Parameters.ToString());
            utils.executeCommand(cmd);
            fillGrid();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var utils = new Utils.GlobalFunctions();
            var queries = new Utils.Queries();
            SqlCommand cmd = new SqlCommand(queries.DELETE_USER);
            var usuarioID = new SqlParameter("@usuarioID", SqlDbType.Int);
            usuarioID.Value = userId;
            cmd.Parameters.Add(usuarioID);
            utils.executeCommand(cmd);
            fillGrid();
            setFormStatus(false);
            cleanInputs();
            resetBarra();
        }
    }
}
