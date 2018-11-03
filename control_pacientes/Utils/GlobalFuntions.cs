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
    class GlobalFuntions
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
    }
}
