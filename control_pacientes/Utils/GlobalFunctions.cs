﻿using System;
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
            try
            {
                var con = new Conexion();
                con.SqlCon.Open();
                command.Connection = con.SqlCon;
                command.ExecuteNonQuery();
                con.SqlCon.Close();
                return true;
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.ToString());
                return false;
            }
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