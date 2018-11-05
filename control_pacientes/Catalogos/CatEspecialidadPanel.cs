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
    public partial class CatEspecialidadPanel : UserControl
    {


        public CatEspecialidadPanel()
        {
            InitializeComponent();
        }

        #region VARIABLES GLOBALES
        bool Agregando = false;
        bool Editando = false;
        int especialidadID = 0;
        Utils.Queries query = new Utils.Queries();
        Utils.GlobalFunctions function = new Utils.GlobalFunctions();
        #endregion

        void fillGrid()
        {
            try
            {
                String sql = "SELECT especialidadID,nombre from Especialidades";
                function.fillGrid(dgvEspecialidad,sql);
                dgvEspecialidad.Columns["especialidadID"].Visible=false;
                for (int i = 0; i < dgvEspecialidad.Columns.Count-1; i++)
                {
                    dgvEspecialidad.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }
                dgvEspecialidad.Columns[dgvEspecialidad.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                for (int i = 0; i < dgvEspecialidad.Columns.Count; i++)
                {
                    int colw = 240;
                    dgvEspecialidad.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                    dgvEspecialidad.Columns[i].Width = colw;
                }
            }
            catch (Exception e)
            {

                MessageBox.Show(e.ToString());
            }
        }

         void Limpiar()
        {
            txtEspecialidad.Text = "";
        }
         void habilitar(bool estado=false)
        {
            txtEspecialidad.Enabled = estado;
            dgvEspecialidad.Enabled = !estado;
        }
        public bool validarform()
        {
            bool estado = true;
            epEspecialidades.Clear();
            if (String.IsNullOrEmpty(txtEspecialidad.Text))
            {
                estado = false;
                epEspecialidades.SetError(txtEspecialidad, "El valor no puede ser vacio");
            }
            return estado;
        }
        void controlBarra()
        {
            if (dgvEspecialidad.RowCount == 0)
            {
                btnAgregar.Enabled = true;
                btnCancelar.Enabled = false;
                btnEditar.Enabled = false;
                btnEliminar.Enabled = false;
                btnGuardar.Enabled = false;
            } else
            {
                btnAgregar.Enabled = true;
                btnCancelar.Enabled = false;
                btnEditar.Enabled = true;
                btnEliminar.Enabled = true;
                btnGuardar.Enabled = false;
            }
            if(Agregando==true || Editando == true)
            {
                btnAgregar.Enabled = false;
                btnCancelar.Enabled = true;
                btnEditar.Enabled = false;
                btnEliminar.Enabled = false;
                btnGuardar.Enabled = true;
            }
        }
        private void CatEspecialidadPanel_Load(object sender, EventArgs e)
        {
            habilitar();
            fillGrid();
            controlBarra();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtEspecialidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            habilitar(true);
            Limpiar();
            txtEspecialidad.Focus();
            Agregando = true;
            Editando = false;
            controlBarra();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            habilitar(true);
            txtEspecialidad.Focus();
            Agregando = false;
            Editando = true;
            controlBarra();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvEspecialidad.RowCount > 0)
            {
                if(MessageBox.Show("Desea Eliminar el registro?","Validcacion",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    String sql ="DELETE FROM Especialidades WHERE especialidadID="+especialidadID;
                    SqlCommand cmd = new SqlCommand(sql);
                    function.executeCommand(cmd);
                    fillGrid();
                    habilitar(false);
                    Limpiar();
                    controlBarra();
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
 
            if (validarform())
            {
                if(Agregando==true && Editando == false)
                {
                    String sql = "insert into Especialidades values('"+txtEspecialidad.Text+"')";
                    SqlCommand cmd = new SqlCommand(sql);
                    function.executeCommand(cmd);                     
                    MessageBox.Show("Registro almacenado correctamente","Validacion"
                        ,MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
                    String sql = "update Especialidades set nombre='"+txtEspecialidad.Text+"'";
                    sql += "where especialidadID="+especialidadID;
                    SqlCommand cmd = new SqlCommand(sql);
                    function.executeCommand(cmd);
                    MessageBox.Show("Registro Editado Correctamente", "Validacion"
                        , MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                Limpiar();
                habilitar(false);
                fillGrid();
                Agregando = false;
                Editando = false;
                controlBarra();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Desea cancelar la operacion?","Validacion",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Limpiar();
                epEspecialidades.Clear();
                habilitar(false);
                Editando = false;
                Agregando = false;
            }
        }

        private void dgvEspecialidad_Click(object sender, EventArgs e)
        {
            if (dgvEspecialidad.RowCount > 0)
            {
                especialidadID = int.Parse(dgvEspecialidad.Rows[dgvEspecialidad.CurrentRow.Index].
                    Cells["especialidadID"].Value.ToString());
                txtEspecialidad.Text = dgvEspecialidad.Rows[dgvEspecialidad.CurrentRow.Index].
                    Cells["nombre"].Value.ToString();
            }
        }
    }
}
