using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace control_pacientes.UserControls
{
    public partial class Paciente : UserControl
    {
        public Paciente()
        {
            InitializeComponent();
        }
        #region  Local Variables
        bool Editando = false;
        bool Agregando = false;
        #endregion

        private void Paciente_Load(object sender, EventArgs e)
        {
            ControlBarra();
            fillGrid();
        }
        #region Custom Functions
        private bool ValidarFormulario()
        {
            bool estado = true;

            epError.Clear();

            if (string.IsNullOrEmpty(txtNombrePaciente.Text))
            {
                estado = false;
                epError.SetError(txtNombrePaciente, "Este valor es requerido");
            }
            if (string.IsNullOrEmpty(txtTelefono1.Text))
            {
                estado = false;
                epError.SetError(txtTelefono1, "Este valor es requerido");
            }

            return estado;
        }
        public void CleanValues()
        {
            txtDireccionPaciente.Clear();
            txtDuiPaciente.Clear();
            txtEdad.Clear();
            txtNitPaciente.Clear();
            txtNombrePaciente.Clear();
            txtPacienteID.Clear();
            txtTelefono1.Clear();
            txtTelefono2.Clear();
            dtpFechaNacimiento.Value = DateTime.Now;
        }

        public void fillGrid()
        {
            try
            {
                var utils = new Utils.GlobalFunctions();
                var Queries = new Utils.Queries();
                utils.fillGrid(dgvPacientes, Queries.GET_PACIENTES);
                dgvPacientes.Columns["foto"].Visible = false;
                for (int i = 0; i < dgvPacientes.Columns.Count - 1; i++)
                {
                    dgvPacientes.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }
                dgvPacientes.Columns[dgvPacientes.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                for (int i = 0; i < dgvPacientes.Columns.Count; i++)
                {
                    int colw = 140;
                    dgvPacientes.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                    dgvPacientes.Columns[i].Width = colw;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
        void ControlBarra()
        {
            if (dgvPacientes.RowCount == 0)
            {
                btnAgregar.Enabled = true; btnEditar.Enabled = false;
                btnEliminar.Enabled = true; btnCancelar.Enabled = false;
                btnGuardar.Enabled = false;
            }
            else
            {
                btnAgregar.Enabled = true; btnEditar.Enabled = true;
                btnEliminar.Enabled = true; btnCancelar.Enabled = false;
                btnGuardar.Enabled = false;
            }
            if (Agregando == true || Editando == true)
            {
                btnAgregar.Enabled = false;
                btnEditar.Enabled = false;
                btnEliminar.Enabled = false;
                btnCancelar.Enabled = true;
                btnGuardar.Enabled = true;
            }
        }
        #endregion
        #region Control Buttons
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            CleanValues();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarFormulario())
            {
                var utils = new Utils.GlobalFunctions();
                var queries = new Utils.Queries();
                SqlCommand cmd = new SqlCommand();
                if (Agregando)
                {
                    cmd = new SqlCommand(queries.ADD_PACIENTE);
                }
                else if (Editando)
                {
                    //var passwordModified = !string.IsNullOrEmpty(txtPassword.Text);
                    //cmd = new SqlCommand(passwordModified ? queries.EDIT_USER : queries.EDIT_USER_NO_PASSWORD);
                }

                var nombre = new SqlParameter("@nombre", SqlDbType.NVarChar, 50);
                nombre.Value = txtNombrePaciente.Text.Trim();
                cmd.Parameters.Add(nombre);

                var fechaNacimiento = new SqlParameter("@fechaNacimiento", SqlDbType.Date, 50);
                fechaNacimiento.Value = dtpFechaNacimiento.Value.ToString();
                cmd.Parameters.Add(fechaNacimiento);

                var dui = new SqlParameter("@dui", SqlDbType.NVarChar, 50);
                dui.Value = txtDuiPaciente.Text.Trim();
                cmd.Parameters.Add(dui);

                var nit = new SqlParameter("@nit", SqlDbType.NVarChar, 50);
                nit.Value = txtNitPaciente.Text.Trim();
                cmd.Parameters.Add(nit);

                var telefono_1 = new SqlParameter("@tel1", SqlDbType.NVarChar, 50);
                telefono_1.Value = txtTelefono1.Text.Trim();
                cmd.Parameters.Add(telefono_1);

                var telefono_2 = new SqlParameter("@tel2", SqlDbType.NVarChar, 50);
                telefono_2.Value = txtTelefono2.Text.Trim();
                cmd.Parameters.Add(telefono_2);

                var domicilio = new SqlParameter("@domicilio", SqlDbType.NVarChar,100);
                domicilio.Value = txtDireccionPaciente.Text.Trim();
                cmd.Parameters.Add(domicilio);

                var pediatria = new SqlParameter("@pediatria", SqlDbType.Bit);
                if (chkPediatria.Checked)
                {
                    pediatria.Value = true;
                }
                else
                {
                    pediatria.Value = false;
                }
                cmd.Parameters.Add(pediatria);

                //MessageBox.Show(cmd.Parameters.ToString());
                if (utils.executeCommand(cmd))
                {
                    CleanValues();
                    ControlBarra();
                    fillGrid();
                    MessageBox.Show("Registro insertado correctamente",
                        "Validacion", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvPacientes.RowCount > 0)
            {
                if (MessageBox.Show("Desea eliminar el registro seleccionado?",
                    "Validacion",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    var utils = new Utils.GlobalFunctions();
                    var queries = new Utils.Queries();
                    SqlCommand cmd = new SqlCommand(queries.DELETE_PACIENTE);
                    var usuarioID = new SqlParameter("@pacienteid", SqlDbType.Int);
                    usuarioID.Value = txtPacienteID.Text;
                    cmd.Parameters.Add(usuarioID);
                    utils.executeCommand(cmd);
                    fillGrid();
                    if (utils.executeCommand(cmd))
                    {
                        CleanValues();
                        ControlBarra();
                        fillGrid();
                        MessageBox.Show("Registro eliminado correctamente",
                            "Validacion", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Agregando = false;
            Editando = true;
            ControlBarra();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Agregando = true;
            Editando = false;
            ControlBarra();
        }
        #endregion

        private void dgvPacientes_Click(object sender, EventArgs e)
        {
            if (dgvPacientes.RowCount > 0)
            {
                txtPacienteID.Text = dgvPacientes.Rows[dgvPacientes.CurrentRow.Index].
                          Cells["ID PACIENTE"].Value.ToString();

                txtNombrePaciente.Text = dgvPacientes.Rows[dgvPacientes.CurrentRow.Index].Cells["NOMBRE"].Value.ToString();
                //txtDireccionPaciente.Text = dgvPacientes.Rows[dgvPacientes.CurrentRow.Index].Cells["DIRECCION"].Value.ToString();
                //cmbGenero.Text = dgvPacientes.Rows[dgvPacientes.CurrentRow.Index].Cells["GENERO"].Value.ToString();
            }
        }
        
       
    }
}
