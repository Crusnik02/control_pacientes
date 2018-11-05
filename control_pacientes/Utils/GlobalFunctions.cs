using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using control_pacientes.Clases;
using System.Data;
using System.Data.SqlClient;

namespace control_pacientes.Utils
{
    class GlobalFunctions
    {
        public void fillGrid(DataGridView dgv, string sqlString)
        {
            List<Usuario> users = new List<Usuario>();
            try
            {
                Usuario us = new Usuario();
                Conexion con = new Conexion();
                con.SqlCon.Open();
                var adapter = new SqlDataAdapter(sqlString, con.SqlCon);
                var dataTable = new DataTable();
                adapter.Fill(dataTable);
                dgv.DataSource = dataTable;
                con.SqlCon.Close();
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public bool executeCommand(SqlCommand command)
        {
           bool estado = true;
            try
            {
                var con = new Conexion();
                con.SqlCon.Open();
                command.Connection = con.SqlCon;
                command.ExecuteNonQuery();
                con.SqlCon.Close();
                estado = true;
            }
            catch (SqlException e)
            {
                estado = false;
                MessageBox.Show(e.ToString());
            }
            return estado;
        }
        public void FillCombo(System.Windows.Forms.ComboBox ComboBoxName, string campoID, string nombre)
        {
            var con = new Conexion();
            con.SqlCon.Open();
            SqlCommand sc = new SqlCommand("select * from Tipos_Vacuna", con.SqlCon);
            SqlDataReader reader;

            reader = sc.ExecuteReader();
            DataTable dt = new DataTable();

            dt.Columns.Add(campoID, typeof(string));
            dt.Columns.Add(nombre, typeof(string));
            dt.Load(reader);

            ComboBoxName.ValueMember = campoID;
            ComboBoxName.DisplayMember = nombre;
            ComboBoxName.DataSource = dt;
            ComboBoxName.SelectedIndex = -1;

            con.SqlCon.Close();
        }

        public void FillComboBox(System.Windows.Forms.ComboBox ComboBoxName, string campoID, string nombre)
        {
            var con = new Conexion();
            DataRow dataRow;

            SqlCommand cmd = new SqlCommand("sp_tblPaciente_get", con.SqlCon);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.SqlCon.Close();
            dataRow = dt.NewRow();
            dataRow.ItemArray = new object[] { 0, "Seleccione un Paciente" };
            dt.Rows.InsertAt(dataRow, 0);
            ComboBoxName.ValueMember = campoID;
            ComboBoxName.DisplayMember = nombre;
            ComboBoxName.DataSource = dt;
            ComboBoxName.SelectedIndex = 0;
        }

        public void BindComboExpediente(int pacienteId, System.Windows.Forms.ComboBox ComboBoxName, string campoID, string nombre)
        {
            var con = new Conexion();
            con.SqlCon.Open();

            SqlCommand cmd = new SqlCommand("sp_tblExpediente_get", con.SqlCon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Pacienteid", pacienteId);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.SqlCon.Close();
            ComboBoxName.ValueMember = campoID;
            ComboBoxName.DisplayMember = nombre;
            ComboBoxName.DataSource = dt;
            ComboBoxName.SelectedIndex = 0;
        }

        public void BindComboConsulta(int expedienteid, System.Windows.Forms.ComboBox ComboBoxName, string campoID, string nombre)
        {
            var con = new Conexion();
            DataRow dataRow;
            con.SqlCon.Open();

            SqlCommand cmd = new SqlCommand("sp_tblConsulta_get", con.SqlCon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Expedienteid", expedienteid);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.SqlCon.Close();
            dataRow = dt.NewRow();
            dt.Rows.InsertAt(dataRow, 0);
            ComboBoxName.ValueMember = campoID;
            ComboBoxName.DisplayMember = nombre;
            ComboBoxName.DataSource = dt;
        }

        public void BindComboDoctor(int consultaid, System.Windows.Forms.ComboBox ComboBoxName, string campoID, string nombre)
        {
            var con = new Conexion();
            con.SqlCon.Open();

            SqlCommand cmd = new SqlCommand("sp_tblDoctor_get", con.SqlCon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@consultaid", consultaid);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.SqlCon.Close();
            ComboBoxName.ValueMember = campoID;
            ComboBoxName.DisplayMember = nombre;
            ComboBoxName.DataSource = dt;
            ComboBoxName.SelectedIndex = 0;
        }


        public Tuple<bool, int> executeCommandReturningId(string query)
        {
            int id = 0;
            bool error = false;
            try
            {
                var con = new Conexion();
                con.SqlCon.Open();
                var command = new SqlCommand(query, con.SqlCon);
                id = (int)command.ExecuteScalar();
                con.SqlCon.Close();
                error = false;
            }
            catch (SqlException e)
            {
                error = true;
                MessageBox.Show(e.ToString());
            }
            return Tuple.Create<bool, int>(error, id);
        }
    }
}
