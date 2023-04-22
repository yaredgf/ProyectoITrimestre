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
    public class MascotaDAL : ConnectionToSql
    {

        public bool Guardar(MascotaET mascota)
        {
            bool retVal = false;
            using (var conexion = GetConnection())
            {
                try
                {
                    using (var cmd = new SqlCommand("spGuardarMascota", conexion))
                    {
                        cmd.Connection = conexion;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@idCliente", mascota.IdCliente));
                        cmd.Parameters.Add(new SqlParameter("@nombre", mascota.Nombre));
                        cmd.Parameters.Add(new SqlParameter("@idRaza", mascota.IdRaza));
                        cmd.Parameters.Add(new SqlParameter("@fechaNacimiento", mascota.FechaNacimiento));
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

        public MascotaET Buscar(int id)
        {
            MascotaET mascota = null;
            bool retornoNulo = true;

            DataTable dt = new DataTable();
            using (var conexion = GetConnection())
            {
                try
                {
                    conexion.Open();
                    using (var cmd = new SqlCommand("spBuscarMascota", conexion))
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
                            mascota.Id = Convert.ToInt32(dt.Rows[0]["id"]);
                            mascota.IdCliente = Convert.ToInt32(dt.Rows[0]["idCliente"]);
                            mascota.Nombre = Convert.ToString(dt.Rows[0]["nombre"]);
                            mascota.IdRaza = Convert.ToInt32(dt.Rows[0]["idRaza"]);
                            mascota.FechaNacimiento = DateOnly.Parse(Convert.ToString(dt.Rows[0]["fechaNacimiento"]));
                            mascota.Estado = Convert.ToBoolean(dt.Rows[0]["estado"]);
                        }

                        return mascota;
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
                    using (var cmd = new SqlCommand("spBuscarTMascota", conexion))
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


        public bool Actualizar(MascotaET mascota)
        {
            bool retVal = false;
            using (var conexion = GetConnection())
            {
                try
                {
                    using (var cmd = new SqlCommand("spActualizarMascota", conexion))
                    {
                        cmd.Connection = conexion;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@id", mascota.Id));
                        cmd.Parameters.Add(new SqlParameter("@idCliente", mascota.IdCliente));
                        cmd.Parameters.Add(new SqlParameter("@nombre", mascota.Nombre));
                        cmd.Parameters.Add(new SqlParameter("@idRaza", mascota.IdRaza));
                        cmd.Parameters.Add(new SqlParameter("@fechaNacimiento", mascota.FechaNacimiento));
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
                    using (var cmd = new SqlCommand("spEliminarMascota", conexion))
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
