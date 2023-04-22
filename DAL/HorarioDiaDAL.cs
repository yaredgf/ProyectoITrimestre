using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ET;

namespace DAL
{
    public class HorarioDiaDAL : ConnectionToSql
    {
        public bool Guardar(HorarioDiaET horario)
        {
            bool retVal = false;
            using (var conexion = GetConnection())
            {
                try
                {
                    using (var cmd = new SqlCommand("spGuardarHorarioDia", conexion))
                    {
                        cmd.Connection = conexion;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@horaEntrada", horario.HoraEntrada));
                        cmd.Parameters.Add(new SqlParameter("@horaSalida", horario.HoraSalida));
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

        public HorarioDiaET Buscar(int id)
        {
            HorarioDiaET horario = null;
            bool retornoNulo = true;

            DataTable dt = new DataTable();
            using (var conexion = GetConnection())
            {
                try
                {
                    conexion.Open();
                    using (var cmd = new SqlCommand("spBuscarHorarioDia", conexion))
                    {
                        SqlDataAdapter da = new SqlDataAdapter();
                        cmd.Connection = conexion;
                        cmd.CommandType = CommandType.StoredProcedure;
                        SqlParameter idOutput = new SqlParameter("@id", SqlDbType.Int);
                        idOutput.Direction = ParameterDirection.Output;
                        cmd.Parameters.Add(idOutput);

                        SqlDataReader reader = cmd.ExecuteReader();
                        if (idOutput.Value != DBNull.Value)
                        {
                            id = Convert.ToInt32(idOutput.Value);
                            retornoNulo = false;
                        }

                        da.Fill(dt);
                        if (id != 0 && !retornoNulo)
                        {
                            horario.Id = Convert.ToInt32(dt.Rows[0]["id"]);
                            horario.HoraEntrada = TimeOnly.Parse(Convert.ToString(dt.Rows[0]["horaEntrada"]));
                            horario.HoraSalida = TimeOnly.Parse(Convert.ToString(dt.Rows[0]["horaSalida"]));
                            horario.Estado = Convert.ToBoolean(dt.Rows[0]["estado"]);
                        }

                        return horario;
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
                    using (var cmd = new SqlCommand("spBuscarTHorarioDia", conexion))
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


        public bool Actualizar(HorarioDiaET horario)
        {
            bool retVal = false;
            using (var conexion = GetConnection())
            {
                try
                {
                    using (var cmd = new SqlCommand("spActualizarHorarioDia", conexion))
                    {
                        cmd.Connection = conexion;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@id", horario.Id));
                        cmd.Parameters.Add(new SqlParameter("@horaEntrada", horario.HoraEntrada));
                        cmd.Parameters.Add(new SqlParameter("@horaSalida", horario.HoraSalida));
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
                    using (var cmd = new SqlCommand("spEliminarHorarioDia", conexion))
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
