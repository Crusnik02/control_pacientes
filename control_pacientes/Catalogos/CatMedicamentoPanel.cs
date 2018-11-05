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
    public partial class CatMedicamentoPanel : UserControl
    {
        public CatMedicamentoPanel()
        {
            InitializeComponent();
        }
        #region GLOBALES
        bool Agregando = false;
        bool Editando = false;
        int medicamentoID = 0;
        Utils.Queries query = new Utils.Queries();
        Utils.GlobalFunctions function = new Utils.GlobalFunctions();
        #endregion
        void fillGrid()
        {
            try
            {
                String sql = "SELECT medicamentoID,nombre from Medicamentos";
                function.fillGrid(dgvMedicamento, sql);
                dgvMedicamento.Columns["medicamentoID"].Visible = false;
                for (int i = 0; i < dgvMedicamento.Columns.Count-1; i++)
                {
                    dgvMedicamento.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }
                dgvMedicamento.Columns[dgvMedicamento.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                for (int i = 0; i < dgvMedicamento.Columns.Count; i++)
                {
                    int colw = 140;
                    dgvMedicamento.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                    dgvMedicamento.Columns[i].Width = 140;
                }
            }
            catch (Exception e)
            {

                MessageBox.Show(e.ToString());
            }
        }
        void Limpiar()
        {
            txtNombre.Text = "";
        }
        void Habilitar(bool estado=false)
        {
            txtNombre.Enabled = estado;
        }
        public bool ValidarForm()
        {
            bool estado = true;
            epMedicamento.Clear();
            if (String.IsNullOrEmpty(txtNombre.Text))
            {
                estado = false;
                epMedicamento.SetError(txtNombre, "Este campo es obligatorio");
            }
            return estado;
        }
        void ControlBarra()
        {
            if (dgvMedicamento.RowCount == 0)
            {
                btnAgregar.Enabled = true;
                btnCancelar.Enabled = false;
                btnEditar.Enabled = false;
                btnEliminar.Enabled = false;
                btnGuardar.Enabled = false;
            }
            else
            {
                btnAgregar.Enabled = true;
                btnCancelar.Enabled = false;
                btnEditar.Enabled = true;
                btnEliminar.Enabled = true;
                btnGuardar.Enabled = false;
            }
            if (Agregando==true || Editando==true)
            {
                btnAgregar.Enabled = false;
                btnCancelar.Enabled = true;
                btnEditar.Enabled = false;
                btnEliminar.Enabled = false;
                btnGuardar.Enabled = true;
            }
        }
        private void dgvMedicamento_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Habilitar(true);
            Limpiar();
            txtNombre.Focus();
            Agregando = true;
            Editando = false;
            ControlBarra();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Habilitar(true);
            txtNombre.Focus();
            Agregando = false;
            Editando = true;
            ControlBarra();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvMedicamento.RowCount > 0)
            {
                if(MessageBox.Show("Desea Eliminar este registro?","Validacion",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    String sql = "DELETE FROM Medicamentos where medicamentoID="+medicamentoID;
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
                    String sql = "insert into Medicamentos values('"+txtNombre.Text+"')";
                    SqlCommand cmd = new SqlCommand(sql);
                    function.executeCommand(cmd);
                    MessageBox.Show("Registro Almacenado correctamente","Validacion",
                        MessageBoxButtons.OK,MessageBoxIcon.Information);
                } else
                {
                    String sql = "update Medicamentos set nombre='"+txtNombre.Text+"'";
                    SqlCommand cmd = new SqlCommand(sql);
                    function.executeCommand(cmd);
                    MessageBox.Show("Registro Actualizado correctamente","Validacion",
                        MessageBoxButtons.OK,MessageBoxIcon.Information);
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
            if(MessageBox.Show("Desea cancelar la operacion?","Validacion",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Limpiar();
                epMedicamento.Clear();
                Habilitar(false);
                Agregando = false;
                Editando = false;
            }
        }

        private void dgvMedicamento_Click(object sender, EventArgs e)
        {
            if (dgvMedicamento.RowCount > 0)
            {
                medicamentoID = int.Parse(dgvMedicamento.Rows[dgvMedicamento.CurrentRow.Index]
                    .Cells["medicamentoID"].Value.ToString());
                txtNombre.Text = dgvMedicamento.Rows[dgvMedicamento.CurrentRow.Index]
                    .Cells["nombre"].Value.ToString();
            }
        }

        private void CatMedicamentoPanel_Load(object sender, EventArgs e)
        {
            Habilitar();
            fillGrid();
            ControlBarra();
        }
    }
}
