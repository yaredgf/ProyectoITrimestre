﻿using ET;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class RazaDAL : ConnectionToSql
    {

        public bool Guardar(RazaET raza)
        {
            bool retVal = false;
            using (var conexion = GetConnection())
            {
                try
                {
                    conexion.Open();
                    using (var cmd = new SqlCommand("spGuardarRaza", conexion))
                    {
                        cmd.Connection = conexion;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@nombre", raza.Nombre));
                        cmd.Parameters.Add(new SqlParameter("@idEspecie", raza.IdEspecie));
                        SqlDataReader reader = cmd.ExecuteReader();
                        reader.Close();
                        retVal = true;
                    }
                }
                catch (Exception ex)
                {

                }
            }
            return retVal;
        }

        public DataTable Buscar(int id)
        {
            RazaET raza = null;
            bool retornoNulo = true;

            DataTable dt = new DataTable();
            using (var conexion = GetConnection())
            {
                try
                {
                    conexion.Open();
                    using (var cmd = new SqlCommand("spBuscarRaza", conexion))
                    {
                        SqlDataAdapter da = new SqlDataAdapter();
                        cmd.Connection = conexion;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@id", id));
                        da.SelectCommand = cmd;
                        da.Fill(dt);
                        return dt;
                    }
                }
                catch (Exception ex)
                {
                    return null;
                }
            }

        }


        public DataTable BuscarTodos()
        {
            DataTable dt = new DataTable();
            using (var conexion = GetConnection())
            {
                try
                {
                    conexion.Open();
                    using (var cmd = new SqlCommand("spBuscarTRaza", conexion))
                    {
                        SqlDataAdapter da = new SqlDataAdapter();
                        cmd.Connection = conexion;
                        cmd.CommandType = CommandType.StoredProcedure;
                        da.SelectCommand = cmd;

                        da.Fill(dt);
                        return dt;
                    }
                }
                catch (Exception ex)
                {
                    return null;
                }
            }
        }


        public bool Actualizar(RazaET raza)
        {
            bool retVal = false;
            using (var conexion = GetConnection())
            {
                try
                {
                    conexion.Open();
                    using (var cmd = new SqlCommand("spActualizarRaza", conexion))
                    {
                        cmd.Connection = conexion;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@id", raza.Id));
                        cmd.Parameters.Add(new SqlParameter("@nombre", raza.Nombre));
                        cmd.Parameters.Add(new SqlParameter("@idEspecie", raza.IdEspecie));
                        SqlDataReader reader = cmd.ExecuteReader();
                        reader.Close();
                        retVal = true;
                    }
                }
                catch (Exception ex)
                {

                }
            }
            return retVal;
        }


        public bool Borrar(int id)
        {
            bool retVal = false;
            using (var conexion = GetConnection())
            {
                try
                {
                    conexion.Open();
                    using (var cmd = new SqlCommand("spEliminarRaza", conexion))
                    {
                        cmd.Connection = conexion;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@id", id));
                        SqlDataReader reader = cmd.ExecuteReader();
                        reader.Close();
                        retVal = true;
                    }
                }
                catch (Exception ex)
                {

                }
            }
            return retVal;
        }


    }
}
