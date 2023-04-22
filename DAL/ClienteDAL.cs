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
    public class ClienteDAL : ConnectionToSql
    {
        public bool Guardar(ClienteET cliente)
        {
            bool retVal = false;
            using (var conexion = GetConnection())
            {
                try
                {
                    using (var cmd = new SqlCommand("spGuardarCliente", conexion))
                    {
                        cmd.Connection = conexion;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@nombre", cliente.Nombre));
                        cmd.Parameters.Add(new SqlParameter("@apellido1", cliente.Apellido1));
                        cmd.Parameters.Add(new SqlParameter("@apellido2", cliente.Apellido2));
                        cmd.Parameters.Add(new SqlParameter("@cedula", cliente.Cedula));
                        cmd.Parameters.Add(new SqlParameter("@telefono", cliente.Telefono));

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

        public ClienteET Buscar(int id)
        {
            ClienteET cliente = null;
            bool retornoNulo = true;

            DataTable dt = new DataTable();
            using (var conexion = GetConnection())
            {
                try
                {
                    conexion.Open();
                    using (var cmd = new SqlCommand("spBuscarCliente", conexion))
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
                            cliente.Id = Convert.ToInt32(dt.Rows[0]["id"]);
                            cliente.Nombre = Convert.ToString(dt.Rows[0]["nombre"]);
                            cliente.Apellido1 = Convert.ToString(dt.Rows[0]["apellido1"]);
                            cliente.Apellido2 = Convert.ToString(dt.Rows[0]["apellido2"]);
                            cliente.Cedula = Convert.ToString(dt.Rows[0]["cedula"]);
                            cliente.Telefono = Convert.ToString(dt.Rows[0]["telefono"]);
                            cliente.Estado = Convert.ToBoolean(dt.Rows[0]["estado"]);
                        }

                        return cliente;
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
                    using (var cmd = new SqlCommand("spBuscarTCliente", conexion))
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


        public bool Actualizar(ClienteET cliente)
        {
            bool retVal = false;
            using (var conexion = GetConnection())
            {
                try
                {
                    using (var cmd = new SqlCommand("spActualizarCliente", conexion))
                    {
                        cmd.Connection = conexion;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@id", cliente.Id));
                        cmd.Parameters.Add(new SqlParameter("@nombre", cliente.Nombre));
                        cmd.Parameters.Add(new SqlParameter("@apellido1", cliente.Apellido1));
                        cmd.Parameters.Add(new SqlParameter("@apellido2", cliente.Apellido2));
                        cmd.Parameters.Add(new SqlParameter("@cedula", cliente.Cedula));
                        cmd.Parameters.Add(new SqlParameter("@telefono", cliente.Telefono));
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
                    using (var cmd = new SqlCommand("spEliminarCliente", conexion))
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
