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

namespace control_pacientes.Catalogos
{
    public partial class CatEnfermedadPanel : UserControl
    {
        public CatEnfermedadPanel()
        {
            InitializeComponent();
        }
        #region GLOBALES
        bool Agregando = false;
        bool Editando = false;
        int enfermedadID = 0;
        Utils.Queries query = new Utils.Queries();
        Utils.GlobalFunctions function = new Utils.GlobalFunctions();
        #endregion
        void fillGrid()
        {
            try
            {
                String sql = "SELECT enfermedadID,codigo,nombre FROM Enfermedades";                
                function.fillGrid(dgvEnfermedad,sql);
                dgvEnfermedad.Columns["enfermedadID"].Visible = false;
                for (int i = 0; i < dgvEnfermedad.ColumnCount-1; i++)
                {
                    dgvEnfermedad.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }
                dgvEnfermedad.Columns[dgvEnfermedad.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                for (int i = 0; i < dgvEnfermedad.ColumnCount; i++)
                {
                    int colw = 180;
                    dgvEnfermedad.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                    dgvEnfermedad.Columns[i].Width =colw;
                }
            }
            catch (Exception e)
            {

                MessageBox.Show(e.ToString());
            }
        }
        void Limpiar()
        {
            txtCodigo.Text = "";
            txtNombre.Text = "";
        }
        void Habilitar(bool estado=false)
        {
            txtCodigo.Enabled = estado;
            txtNombre.Enabled = estado;
        }
        public bool ValidarForm()
        {
            bool estado = true;
            epEnfermedad.Clear();
            if (String.IsNullOrEmpty(txtNombre.Text))
            {
                estado = false;
                epEnfermedad.SetError(txtNombre, "El campo no puede ser vacio");
            }
            if (String.IsNullOrEmpty(txtCodigo.Text))
            {
                estado = false;
                epEnfermedad.SetError(txtNombre, "El campo no puede ser vacio");
            }
            return estado;
        }
        void ControlBarra()
        {
            if (dgvEnfermedad.RowCount == 0)
            {
                btnAgregar.Enabled = true;
                btnCancelar.Enabled = false;
                btnEditar.Enabled = false;
                btnEliminar.Enabled = false;
                btnGuardar.Enabled = false;
            } else
            {
                btnAgregar.Enabled = true;
                btnEditar.Enabled = true;
                btnCancelar.Enabled = false;
                btnEliminar.Enabled = true;
                btnGuardar.Enabled = false;
            }
            if(Agregando==true || Editando == true)
            {
                btnAgregar.Enabled = false;
                btnEditar.Enabled = false;
                btnCancelar.Enabled = true;
                btnEliminar.Enabled = false;
                btnGuardar.Enabled = true;
            }
        }

        private void CatEnfermedadPanel_Load(object sender, EventArgs e)
        {
            Habilitar();
            fillGrid();
            ControlBarra();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvEnfermedad_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Habilitar(true);
            Limpiar();
            txtCodigo.Focus();
            Agregando = true;
            Editando = false;
            ControlBarra();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Habilitar(true);
            txtCodigo.Focus();
            Agregando = false;
            Editando = true;
            ControlBarra();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvEnfermedad.RowCount > 0)
            {
                if(MessageBox.Show("Desea Eliminar el registro?","Validacion",
                    MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    String sql = "DELETE FROM Enfermedades where enfermedadID=" + enfermedadID;
                    SqlCommand cmd = new SqlCommand(sql);
                    function.executeCommand(cmd);
                    fillGrid();
                    Habilitar(false);
                    Limpiar();
                    ControlBarra();
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarForm())
            {
                if(Agregando==true && Editando == false)
                {
                    String sql = "insert into Enfermedades values('"+txtCodigo.Text+"','"+txtNombre.Text+"')";
                    SqlCommand cmd = new SqlCommand(sql);
                    function.executeCommand(cmd);
                    MessageBox.Show("Registro Almacenado correctamente","Validacion",
                        MessageBoxButtons.YesNo,MessageBoxIcon.Information);
                }
                else
                {
                    String sql = "update Enfermedades set codigo='"+txtCodigo.Text+"', nombre='"+txtNombre.Text+"'";
                    SqlCommand cmd = new SqlCommand(sql);
                    function.executeCommand(cmd);
                    MessageBox.Show("Registro Actualizado correctamente","Validacion",
                        MessageBoxButtons.YesNo,MessageBoxIcon.Information);
                }
            }
            Limpiar();
            Habilitar(false);
            fillGrid();
            Agregando = false;
            Editando = false;
            ControlBarra();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Desea Cancelar la operacion","Validacion",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Limpiar();
                epEnfermedad.Clear();
                Habilitar(false);
                Agregando = false;
                Editando = false;
            }
        }

        private void dgvEnfermedad_Click(object sender, EventArgs e)
        {
            if (dgvEnfermedad.RowCount > 0)
            {
                enfermedadID = int.Parse(dgvEnfermedad.Rows[dgvEnfermedad.CurrentRow.Index].
                    Cells["enfermedadID"].Value.ToString());
                txtCodigo.Text = dgvEnfermedad.Rows[dgvEnfermedad.CurrentRow.Index].
                    Cells["codigo"].Value.ToString();
                txtNombre.Text = dgvEnfermedad.Rows[dgvEnfermedad.CurrentRow.Index].
                    Cells["nombre"].Value.ToString();
            }
        }
    }
}
