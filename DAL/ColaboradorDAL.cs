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
    public class ColaboradorDAL : ConnectionToSql
    {
        public bool Guardar(ColaboradorET colaborador)
        {
            bool retVal = false;
            using (var conexion = GetConnection())
            {
                try
                {
                    conexion.Open();
                    using (var cmd = new SqlCommand("spGuardarColaborador", conexion))
                    {
                        cmd.Connection = conexion;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@nombre", colaborador.Nombre));
                        cmd.Parameters.Add(new SqlParameter("@apellido1", colaborador.Apellido1));
                        cmd.Parameters.Add(new SqlParameter("@apellido2", colaborador.Apellido2));
                        cmd.Parameters.Add(new SqlParameter("@cedula", colaborador.Cedula));
                        cmd.Parameters.Add(new SqlParameter("@telefono", colaborador.Telefono));
                        cmd.Parameters.Add(new SqlParameter("@clave", colaborador.Clave));
                        cmd.Parameters.Add(new SqlParameter("@tipo", colaborador.Tipo));
                        cmd.Parameters.Add(new SqlParameter("@idHorarioSemana", colaborador.IdHorarioSemana));


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
            ColaboradorET colaborador = null;
            bool retornoNulo = true;

            DataTable dt = new DataTable();
            using (var conexion = GetConnection())
            {
                try
                {
                    conexion.Open();
                    using (var cmd = new SqlCommand("spBuscarColaborador", conexion))
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
                    using (var cmd = new SqlCommand("spBuscarTColaborador", conexion))
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


        public bool Actualizar(ColaboradorET colaborador)
        {
            bool retVal = false;
            using (var conexion = GetConnection())
            {
                try
                {
                    conexion.Open();
                    using (var cmd = new SqlCommand("spActualizarColaborador", conexion))
                    {
                        cmd.Connection = conexion;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@id", colaborador.Id));
                        cmd.Parameters.Add(new SqlParameter("@nombre", colaborador.Nombre));
                        cmd.Parameters.Add(new SqlParameter("@apellido1", colaborador.Apellido1));
                        cmd.Parameters.Add(new SqlParameter("@apellido2", colaborador.Apellido2));
                        cmd.Parameters.Add(new SqlParameter("@cedula", colaborador.Cedula));
                        cmd.Parameters.Add(new SqlParameter("@telefono", colaborador.Telefono));
                        cmd.Parameters.Add(new SqlParameter("@clave", colaborador.Clave));
                        cmd.Parameters.Add(new SqlParameter("@tipo", colaborador.Tipo));
                        cmd.Parameters.Add(new SqlParameter("@idHorarioSemana", colaborador.IdHorarioSemana));
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
                    using (var cmd = new SqlCommand("spEliminarColaborador", conexion))
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

        public int BuscarUsuario(string usuario, string contrasenna)
        {
            int retVal = 0;
            using (var conexion = GetConnection())
            {
                try
                {
                    conexion.Open();
                    using (var cmd = new SqlCommand("spBuscarUsuario", conexion))
                    {
                        cmd.Connection = conexion;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@usuario", usuario));
                        cmd.Parameters.Add(new SqlParameter("@contrasenna", contrasenna));
                        SqlParameter idOutput = new SqlParameter("@id", SqlDbType.Int);
                        idOutput.Direction = ParameterDirection.Output;
                        cmd.Parameters.Add(idOutput);

                        SqlDataReader reader = cmd.ExecuteReader();
                        if (idOutput.Value != DBNull.Value)
                        {
                            retVal = Convert.ToInt32(idOutput.Value);
                        }
                        reader.Close();
                    }
                }
                catch (Exception ex)
                {
                    retVal = -1;
                }
            }
            return retVal;
        }

    }
}
