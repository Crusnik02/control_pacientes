using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace control_pacientes.Clases
{
    class Conexion
    {
        public SqlConnection SqlCon = new SqlConnection(Properties.Settings.Default.conexion);

        public void testConnection()
        {
            try
            {
                SqlCon.Open();
                SqlCon.Close();
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.ToString());
            }
        }
    }
}
