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
    public class HorarioSemanaDAL : ConnectionToSql
    {
        public bool Guardar(HorarioSemanaET horario)
        {
            bool retVal = false;
            using (var conexion = GetConnection())
            {
                try
                {
                    using (var cmd = new SqlCommand("spGuardarHorarioSemana", conexion))
                    {
                        cmd.Connection = conexion;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@id", 0));
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

        public HorarioSemanaET Buscar(int id)
        {
            HorarioSemanaET horario = null;
            bool retornoNulo = true;

            DataTable dt = new DataTable();
            using (var conexion = GetConnection())
            {
                try
                {
                    conexion.Open();
                    using (var cmd = new SqlCommand("spBuscarHorarioSemana", conexion))
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
                            horario.Id = Convert.ToInt32(dt.Rows[0]["idHorarioSemana"]);
                            horario.HorarioDia[0] = Convert.ToInt32(dt.Rows[0]["idHorarioDia"]);
                            horario.HorarioDia[1] = Convert.ToInt32(dt.Rows[1]["idHorarioDia"]);
                            horario.HorarioDia[2] = Convert.ToInt32(dt.Rows[2]["idHorarioDia"]);
                            horario.HorarioDia[3] = Convert.ToInt32(dt.Rows[3]["idHorarioDia"]);
                            horario.HorarioDia[4] = Convert.ToInt32(dt.Rows[4]["idHorarioDia"]);
                            horario.HorarioDia[5] = Convert.ToInt32(dt.Rows[5]["idHorarioDia"]);
                            horario.HorarioDia[6] = Convert.ToInt32(dt.Rows[6]["idHorarioDia"]);
                            horario.Estado = true;
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



        public bool Actualizar(HorarioSemanaET horario)
        {
            bool retVal = false;
            using (var conexion = GetConnection())
            {
                try
                {
                    using (var cmd = new SqlCommand("spActualizarHorarioSemana", conexion))
                    {
                        cmd.Connection = conexion;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@id", horario.Id));
                        cmd.Parameters.Add(new SqlParameter("@lunes", horario.HorarioDia[0]));
                        cmd.Parameters.Add(new SqlParameter("@martes", horario.HorarioDia[1]));
                        cmd.Parameters.Add(new SqlParameter("@miercoles", horario.HorarioDia[2]));
                        cmd.Parameters.Add(new SqlParameter("@jueves", horario.HorarioDia[3]));
                        cmd.Parameters.Add(new SqlParameter("@viernes", horario.HorarioDia[4]));
                        cmd.Parameters.Add(new SqlParameter("@sabado", horario.HorarioDia[5]));
                        cmd.Parameters.Add(new SqlParameter("@domingo", horario.HorarioDia[6]));
                        cmd.Parameters.Add(new SqlParameter("@for",0));
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
                    using (var cmd = new SqlCommand("spEliminarHorarioSemana", conexion))
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
