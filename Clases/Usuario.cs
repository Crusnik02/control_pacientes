using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
namespace control_pacientes.Clases
{
    public class Usuario
    {
        public int usuarioID;
        public string nombre;
        public DateTime fechaNacimiento;
        public string dui;
        public string nit;
        public string foto;
        public string telefono_1;
        public string telefono_2;
        public string email;
        public string password;
        public Rol rol;

        public string toString()
        {
            return this.nombre + " " + this.email;
        }
        public Tuple<bool, Usuario, string> logIn()
        {
            bool isValid = false;
            string error = "Database error";
            Usuario us = new Usuario();
            try
            {
                Conexion con = new Conexion();
                con.SqlCon.Open();
                SqlCommand command = new SqlCommand(null, con.SqlCon);
                command.CommandText =
                    "select u.*, r.nombre as roleNombre  from Usuarios u inner join Roles r on r.rolID = u.rolID where email = @email";
                SqlParameter idParam = new SqlParameter("@email", SqlDbType.NVarChar, 100);
                idParam.Value = email;
                command.Parameters.Add(idParam);
                SqlDataReader dataReader = command.ExecuteReader();
                List<Usuario> users = new List<Usuario>();
                int counter = 0;
                if (dataReader.Read())
                {
                    counter ++;
                    Rol rol = new Rol();
                    rol.rolID = int.Parse(dataReader["rolID"].ToString());
                    rol.nombre = dataReader["roleNombre"].ToString();
                    us.usuarioID = int.Parse(dataReader["usuarioID"].ToString());
                    us.email = dataReader["email"].ToString();
                    us.password = dataReader["password"].ToString();
                    us.nombre = dataReader["nombre"].ToString();
                    us.dui = dataReader["dui"].ToString();
                    us.nit = dataReader["nit"].ToString();
                    us.telefono_1 = dataReader["telefono_2"].ToString();
                    us.foto = dataReader["foto"].ToString();
                    us.rol = rol;
                    if (us.password == ComputeSha256Hash(password))
                    {
                        isValid = true;
                    }
                    else
                    {
                        error = "Contraseña incorrecta";
                    }
                    users.Add(us);
                }
                con.SqlCon.Close();
                if (counter == 0)
                {
                    error = "Usuario no encontrado";
                }
                con.SqlCon.Close();
            }
            catch(SqlException e)
            {
                MessageBox.Show(e.ToString());
            }
            return Tuple.Create(isValid, us, error);
        }

        public string ComputeSha256Hash(string rawData)
        {
            // Create a SHA256   
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash - returns byte array  
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                // Convert byte array to a string   
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        public List<Usuario> getUsers()
        {
            List<Usuario> users = new List<Usuario>();
            try
            {
                Usuario us = new Usuario();
                int counter = 0;
                Conexion con = new Conexion();
                con.SqlCon.Open();
                SqlCommand command = new SqlCommand(null, con.SqlCon);
                command.CommandText = "select u.*, r.nombre as roleNombre  from Usuarios u inner join Roles r on r.rolID = u.rolID";
                SqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    counter++;
                    Rol rol = new Rol();
                    rol.rolID = int.Parse(dataReader["rolID"].ToString());
                    rol.nombre = dataReader["roleNombre"].ToString();
                    us.usuarioID = int.Parse(dataReader["usuarioID"].ToString());
                    us.email = dataReader["email"].ToString();
                    us.password = dataReader["password"].ToString();
                    us.nombre = dataReader["nombre"].ToString();
                    us.dui = dataReader["dui"].ToString();
                    us.nit = dataReader["nit"].ToString();
                    us.telefono_1 = dataReader["telefono_2"].ToString();
                    us.foto = dataReader["foto"].ToString();
                    us.rol = rol;
                    users.Add(us);
                }
                con.SqlCon.Close();
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.ToString());
            }
            return users;
        }
        public byte[] getImage(int id)
        {
            byte[] bytes = { };
            var con = new Conexion();
            con.SqlCon.Open();
            var command = new SqlCommand("select foto from Usuarios where usuarioID=@id", con.SqlCon);
            var parameter = new SqlParameter("@id", SqlDbType.Int);
            parameter.Value = id;
            command.Parameters.Add(parameter);
            object value = command.ExecuteScalar();
            if (value != null)
            {
                bytes = (byte[])value;
            }
            con.SqlCon.Close();
            return bytes;
        }
        public void fillGrid(DataGridView dgv)
        {
            List<Usuario> users = new List<Usuario>();
            try
            {
                Usuario us = new Usuario();
                int counter = 0;
                Conexion con = new Conexion();
                con.SqlCon.Open();
                SqlCommand command = new SqlCommand(null, con.SqlCon);
                command.CommandText = "select u.*, r.nombre as roleNombre  from Usuarios u inner join Roles r on r.rolID = u.rolID";
                SqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    counter++;
                    Rol rol = new Rol();
                    rol.rolID = int.Parse(dataReader["rolID"].ToString());
                    rol.nombre = dataReader["roleNombre"].ToString();
                    us.usuarioID = int.Parse(dataReader["usuarioID"].ToString());
                    us.email = dataReader["email"].ToString();
                    us.password = dataReader["password"].ToString();
                    us.nombre = dataReader["nombre"].ToString();
                    us.dui = dataReader["dui"].ToString();
                    us.nit = dataReader["nit"].ToString();
                    us.telefono_1 = dataReader["telefono_2"].ToString();
                    us.foto = dataReader["foto"].ToString();
                    us.rol = rol;
                    users.Add(us);
                }
                con.SqlCon.Close();
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.ToString());
            }
        }
    }
}
