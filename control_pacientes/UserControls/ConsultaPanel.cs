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

using control_pacientes.Clases;
namespace control_pacientes
{
    public partial class ConsultaPanel : UserControl
    {
        public ConsultaPanel()
        {
            InitializeComponent();
        }
        public void resetForm(bool status = false)
        {
            btnAgregar.Enabled = true;
            btnCancelar.Enabled = status;
            btnGuardar.Enabled = status;

            cmbDoctores.Enabled = status;
            cmbPacientes.Enabled = status;
            cmbTiposVacuna.Enabled = status;
            cmbEnfermedades.Enabled = status;
            cmbMedicamentos.Enabled = status;

            dtpCita.Enabled = status;
            dtpCita.Value = DateTime.Now;

            dtpFechaVacuna.Enabled = status;
            dtpFechaVacuna.Value = DateTime.Now;

            btnAgregarCita.Enabled = status;
            btnAgregarEnfermedad.Enabled = status;
            btnAgregarMedicamento.Enabled = status;
            btnAgregarVacuna.Enabled = status;

            dgvCitas.Rows.Clear();
            dgvCitas.Refresh();

            dgvEnfermedades.Rows.Clear();
            dgvEnfermedades.Refresh();

            dgvMedicamentos.Rows.Clear();
            dgvMedicamentos.Refresh();

            dgvVacunas.Rows.Clear();
            dgvVacunas.Refresh();


        }
        private void ConsultaPanel_Load(object sender, EventArgs e)
        {
            resetForm();
            var utils = new Utils.GlobalFunctions();
            var queries = new Utils.Queries();

            utils.fillCombo(cmbDoctores, queries.GET_DOCTORES);
            cmbDoctores.DisplayMember = "nombre";

            utils.fillCombo(cmbPacientes, queries.GET_PACIENTES_COMBO);
            cmbPacientes.DisplayMember = "nombre";

            utils.fillCombo(cmbEnfermedades, queries.GET_ENFERMEDADES);
            cmbEnfermedades.DisplayMember = "nombre";

            utils.fillCombo(cmbMedicamentos, queries.GET_MEDICAMENTOS);
            cmbMedicamentos.DisplayMember = "nombre";

            utils.fillCombo(cmbTiposVacuna, queries.GET_TIPOS_VACUNA);
            cmbTiposVacuna.DisplayMember = "nombre";

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            resetForm(true);
            btnAgregar.Enabled = false;

        }

        private void btnAgregarCita_Click(object sender, EventArgs e)
        {
            int rowIndex = this.dgvCitas.Rows.Add();
            var row = this.dgvCitas.Rows[rowIndex];
            row.Cells["txtFechaCita"].Value = dtpCita.Value;
        }

        private void btnAgregarEnfermedad_Click(object sender, EventArgs e)
        {
            int rowIndex = this.dgvEnfermedades.Rows.Add();
            var row = this.dgvEnfermedades.Rows[rowIndex];
            var selectedItem = (DataRowView)cmbEnfermedades.SelectedItem;

            row.Cells["enfermedadID"].Value = selectedItem["enfermedadID"].ToString();
            row.Cells["nombreEnfermedad"].Value = selectedItem["nombre"].ToString();
        }

        private void btnAgregarMedicamento_Click(object sender, EventArgs e)
        {
            int rowIndex = this.dgvMedicamentos.Rows.Add();
            var row = this.dgvMedicamentos.Rows[rowIndex];
            var selectedItem = (DataRowView)cmbMedicamentos.SelectedItem;

            row.Cells["medicamentoID"].Value = selectedItem["medicamentoID"].ToString();
            row.Cells["nombreMedicamento"].Value = selectedItem["nombre"].ToString();
        }

        private void btnAgregarVacuna_Click(object sender, EventArgs e)
        {
            int rowIndex = this.dgvVacunas.Rows.Add();
            var row = this.dgvVacunas.Rows[rowIndex];
            var selectedItem = (DataRowView)cmbTiposVacuna.SelectedItem;
            var fecha = dtpFechaVacuna.Value.ToShortDateString();

            row.Cells["tipoVacunaID"].Value = selectedItem["tipoVacunaID"].ToString();
            row.Cells["tipoVacuna"].Value = selectedItem["nombre"].ToString();
            row.Cells["fechaVacuna"].Value = fecha;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            resetForm(false);
        }

        public void agregarCitas(int doctorID, int pacienteID)
        {
            var rows = dgvCitas.Rows;
            var queries = new Utils.Queries();
            var global = new Utils.GlobalFunctions();

            foreach (DataGridViewRow row in rows)
            {
                var cmd = new SqlCommand(queries.ADD_CITA);
                string fecha;

                fecha = row.Cells["txtFechaCita"].Value.ToString();

                var doctorIdParam = new SqlParameter("@doctorID", SqlDbType.Int);
                doctorIdParam.Value = pacienteID;
                cmd.Parameters.Add(doctorIdParam);

                var fechaParam = new SqlParameter("@fecha", SqlDbType.Date);
                fechaParam.Value = fecha;
                cmd.Parameters.Add(fechaParam);

                var pacienteIDParam = new SqlParameter("@pacienteID", SqlDbType.Int);
                pacienteIDParam.Value = pacienteID;
                cmd.Parameters.Add(pacienteIDParam);

                global.executeCommand(cmd);
            }
        }

        public void agregarDiagnostico(int consultaID)
        {
            var rows = dgvEnfermedades.Rows;
            var queries = new Utils.Queries();
            var global = new Utils.GlobalFunctions();

            foreach (DataGridViewRow row in rows)
            {
                var cmd = new SqlCommand(queries.ADD_CONSULTA_ENFERMEDAD);
                int enfermedadID = int.Parse(row.Cells["enfermedadID"].Value.ToString());

                var consultaIDParam = new SqlParameter("@consultaID", SqlDbType.Int);
                consultaIDParam.Value = consultaID;
                cmd.Parameters.Add(consultaIDParam);

                var enfermedadIDParam = new SqlParameter("@enfermedadID", SqlDbType.Int);
                enfermedadIDParam.Value = enfermedadID;
                cmd.Parameters.Add(enfermedadIDParam);

                global.executeCommand(cmd);
            }
        }

        public void agregarMedicamentos(int consultaID)
        {
            var rows = dgvMedicamentos.Rows;
            var queries = new Utils.Queries();
            var global = new Utils.GlobalFunctions();

            foreach (DataGridViewRow row in rows)
            {
                var cmd = new SqlCommand(queries.ADD_CONSULTA_MEDICAMENTOS);
                int medicamentoID = int.Parse(row.Cells["medicamentoID"].Value.ToString());

                var consultaIDParam = new SqlParameter("@consultaID", SqlDbType.Int);
                consultaIDParam.Value = consultaID;
                cmd.Parameters.Add(consultaIDParam);

                var medicamentoIDParam = new SqlParameter("@medicamentoID", SqlDbType.Int);
                medicamentoIDParam.Value = medicamentoID;
                cmd.Parameters.Add(medicamentoIDParam);

                global.executeCommand(cmd);
            }
        }

        public void agregarVacunas(int consultaID)
        {
            var rows = dgvVacunas.Rows;
            var queries = new Utils.Queries();
            var global = new Utils.GlobalFunctions();

            foreach (DataGridViewRow row in rows)
            {
                var cmd = new SqlCommand(queries.ADD_VACUNA);
                string fechaVacuna;
                int tipoVacunaID;

                tipoVacunaID = int.Parse(row.Cells["tipoVacunaID"].Value.ToString());
                fechaVacuna = row.Cells["fechaVacuna"].Value.ToString();

                var fecha = new SqlParameter("@fecha", SqlDbType.Date);
                fecha.Value = DateTime.Parse(fechaVacuna);
                cmd.Parameters.Add(fecha);

                var tipoVacunaParam = new SqlParameter("@tipoVacunaID", SqlDbType.Int);
                tipoVacunaParam.Value = tipoVacunaID;
                cmd.Parameters.Add(tipoVacunaParam);

                var pacienteID = new SqlParameter("@consultaID", SqlDbType.Int);
                pacienteID.Value = consultaID;
                cmd.Parameters.Add(pacienteID);


                global.executeCommand(cmd);
            }
        }

        public void guardarConsulta()
        {

            try
            {
                var queries = new Utils.Queries();
                var cmd = new SqlCommand(queries.ADD_CONSULTA);
                var global = new Utils.GlobalFunctions();

                var doctor = (DataRowView)cmbDoctores.SelectedItem;
                var paciente = (DataRowView)cmbPacientes.SelectedItem;

                var pacienteId = int.Parse(paciente["pacienteID"].ToString());
                var doctorId = int.Parse(doctor["doctorID"].ToString());

                var doctorID = new SqlParameter("@doctorID", SqlDbType.Int);
                doctorID.Value = doctorId;
                cmd.Parameters.Add(doctorID);

                var pacienteID = new SqlParameter("@pacienteID", SqlDbType.Int);
                pacienteID.Value = pacienteId;
                cmd.Parameters.Add(pacienteID);

                Tuple<bool, int> tuple = global.executeCommandReturningId(cmd);
                bool error = tuple.Item1;
                int consultaID = tuple.Item2;
                if (!error)
                {
                    MessageBox.Show("Consulta " + consultaID + " agregada");
                    agregarCitas(doctorId, pacienteId);
                    agregarDiagnostico(consultaID);
                    agregarMedicamentos(consultaID);
                    agregarVacunas(consultaID);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            guardarConsulta();
            resetForm(false);
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            resetForm(true);
            btnAgregar.Enabled = false;
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            guardarConsulta();
            resetForm(false);
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            resetForm(false);
        }

        private void btnAgregarCita_Click_1(object sender, EventArgs e)
        {
            int rowIndex = this.dgvCitas.Rows.Add();
            var row = this.dgvCitas.Rows[rowIndex];
            row.Cells["txtFechaCita"].Value = dtpCita.Value;
        }

        private void btnAgregarEnfermedad_Click_1(object sender, EventArgs e)
        {
            int rowIndex = this.dgvEnfermedades.Rows.Add();
            var row = this.dgvEnfermedades.Rows[rowIndex];
            var selectedItem = (DataRowView)cmbEnfermedades.SelectedItem;

            row.Cells["enfermedadID"].Value = selectedItem["enfermedadID"].ToString();
            row.Cells["nombreEnfermedad"].Value = selectedItem["nombre"].ToString();
        }

        private void btnAgregarMedicamento_Click_1(object sender, EventArgs e)
        {
            int rowIndex = this.dgvMedicamentos.Rows.Add();
            var row = this.dgvMedicamentos.Rows[rowIndex];
            var selectedItem = (DataRowView)cmbMedicamentos.SelectedItem;

            row.Cells["medicamentoID"].Value = selectedItem["medicamentoID"].ToString();
            row.Cells["nombreMedicamento"].Value = selectedItem["nombre"].ToString();
        }

        private void btnAgregarVacuna_Click_1(object sender, EventArgs e)
        {
            int rowIndex = this.dgvVacunas.Rows.Add();
            var row = this.dgvVacunas.Rows[rowIndex];
            var selectedItem = (DataRowView)cmbTiposVacuna.SelectedItem;
            var fecha = dtpFechaVacuna.Value.ToShortDateString();

            row.Cells["tipoVacunaID"].Value = selectedItem["tipoVacunaID"].ToString();
            row.Cells["tipoVacuna"].Value = selectedItem["nombre"].ToString();
            row.Cells["fechaVacuna"].Value = fecha;
        }
    }
}
