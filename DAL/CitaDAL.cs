using ET;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CitaDAL : ConnectionToSql
    {

        public bool Guardar(CitaET cita)
        {
            bool retVal = false;
            using (var conexion = GetConnection())
            {
                try
                {
                    conexion.Open();
                    using (var cmd = new SqlCommand("spGuardarCita", conexion))
                    {
                        cmd.Connection = conexion;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@idServicio", cita.IdServicio));
                        cmd.Parameters.Add(new SqlParameter("@idColaborador", cita.IdColaborador));
                        cmd.Parameters.Add(new SqlParameter("@idMascota", cita.IdMascota));
                        cmd.Parameters.Add(new SqlParameter("@fechaCita", cita.FechaCita));
                        cmd.Parameters.Add(new SqlParameter("@fechaEmision", cita.FechaEmision));
                        cmd.Parameters.Add(new SqlParameter("@asistencia", cita.Asistencia));
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
            CitaET cita = null;
            bool retornoNulo = true;
            DataTable dt = new DataTable();
            using (var conexion = GetConnection())
            {
                try
                {
                    conexion.Open();
                    using (var cmd = new SqlCommand("spBuscarCita", conexion))
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
                    using (var cmd = new SqlCommand("spBuscarTCita", conexion))
                    {
                        SqlDataAdapter da = new SqlDataAdapter();
                        cmd.Connection = conexion;
                        cmd.CommandType = CommandType.StoredProcedure;
                        SqlDataReader reader = cmd.ExecuteReader();
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


        public bool Actualizar(CitaET cita)
        {
            bool retVal = false;
            using (var conexion = GetConnection())
            {
                try
                {
                    conexion.Open();
                    using (var cmd = new SqlCommand("spActualizarCita", conexion))
                    {
                        cmd.Connection = conexion;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@id", cita.Id));
                        cmd.Parameters.Add(new SqlParameter("@idServicio", cita.IdServicio));
                        cmd.Parameters.Add(new SqlParameter("@idColaborador", cita.IdColaborador));
                        cmd.Parameters.Add(new SqlParameter("@idMascota", cita.IdMascota));
                        cmd.Parameters.Add(new SqlParameter("@fechaCita", cita.FechaCita));
                        cmd.Parameters.Add(new SqlParameter("@fechaEmision", cita.FechaEmision));
                        cmd.Parameters.Add(new SqlParameter("@asistencia", cita.Asistencia));
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
                    using (var cmd = new SqlCommand("spEliminarCita", conexion))
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
