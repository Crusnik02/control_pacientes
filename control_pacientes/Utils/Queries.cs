using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace control_pacientes.Utils
{
    class Queries
    {
        public string GET_USERS = "SELECT u.usuarioID, u.nombre as Nombre, u.fechaNacimiento as 'Fecha de Nacimiento', u.dui as DUI, u.nit as NIT, u.telefono_1 as 'Tel. 1', u.telefono_2 as 'Tel. 2', u.email as Email, u.rolID, u.foto, r.nombre as Rol FROM Usuarios u inner join Roles r on u.rolID = r.rolID";
    }
}
