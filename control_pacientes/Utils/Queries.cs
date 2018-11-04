﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace control_pacientes.Utils
{
    class Queries
    {
        public string GET_USERS = "SELECT u.usuarioID, u.nombre as Nombre, u.fechaNacimiento as 'Fecha de Nacimiento', u.dui as DUI, u.nit as NIT, u.telefono_1 as 'Tel. 1', u.telefono_2 as 'Tel. 2', u.email as Email, u.rolID, u.foto, r.nombre as Rol FROM Usuarios u inner join Roles r on u.rolID = r.rolID";
        public string ADD_USER = "insert into Usuarios (nombre, fechaNacimiento, dui, nit, telefono_1, telefono_2, email, foto, password, rolID) values(@nombre, @fechaNacimiento, @dui, @nit, @telefono_1, @telefono_2, @email, @foto, @password, @rolID)";
        public string EDIT_USER_NO_PASSWORD = "update Usuarios set nombre=@nombre, fechaNacimiento=@fechaNacimiento, dui=@dui, nit=@nit, telefono_1=@telefono_1, telefono_2=@telefono_2, email=@email, foto=@foto, rolID=@rolID where usuarioID=@usuarioID";
        public string EDIT_USER = "update Usuarios set nombre=@nombre, fechaNacimiento=@fechaNacimiento, dui=@dui, nit=@nit, telefono_1=@telefono_1, telefono_2=@telefono_2, email=@email, foto=@foto, password=@password, rolID=@rolID where usuarioID=@usuarioID";
        public string DELETE_USER = "delete from Usuarios where usuarioID=@usuarioID";
    }
}
