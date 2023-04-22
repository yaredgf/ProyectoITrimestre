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
    public class EspecieDAL : ConnectionToSql
    {

        public bool Guardar(EspecieET especie)
        {
            bool retVal = false;
            using (var conexion = GetConnection())
            {
                try
                {
                    using (var cmd = new SqlCommand("spGuardarEspecie", conexion))
                    {
                        cmd.Connection = conexion;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@especie", especie.Nombre));
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

        public EspecieET Buscar(int id)
        {
            EspecieET especie = null;
            bool retornoNulo = true;

            DataTable dt = new DataTable();
            using (var conexion = GetConnection())
            {
                try
                {
                    conexion.Open();
                    using (var cmd = new SqlCommand("spBuscarEspecie", conexion))
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
                            especie.Id = Convert.ToInt32(dt.Rows[0]["id"]);
                            especie.Nombre = Convert.ToString(dt.Rows[0]["especie"]);
                            especie.Estado = Convert.ToBoolean(dt.Rows[0]["estado"]);
                        }

                        return especie;
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
                    using (var cmd = new SqlCommand("spBuscarTEspecie", conexion))
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


        public bool Actualizar(EspecieET especie)
        {
            bool retVal = false;
            using (var conexion = GetConnection())
            {
                try
                {
                    using (var cmd = new SqlCommand("spActualizarEspecie", conexion))
                    {
                        cmd.Connection = conexion;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@id", especie.Id));
                        cmd.Parameters.Add(new SqlParameter("@especie", especie.Nombre));
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
                    using (var cmd = new SqlCommand("spEliminarEspecie", conexion))
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
