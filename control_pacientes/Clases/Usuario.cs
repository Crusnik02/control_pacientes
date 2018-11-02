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
        public Tuple<bool, Usuario> logIn()
        {
            bool isValid = false;
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
                while (dataReader.Read())
                {
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
                    users.Add(us);
                }
                con.SqlCon.Close();
            }
            catch(SqlException e)
            {
                MessageBox.Show(e.ToString());
            }
            return Tuple.Create(isValid, us);
        }

        static string ComputeSha256Hash(string rawData)
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
    }
}
