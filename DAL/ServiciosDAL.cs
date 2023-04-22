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
    public class ServiciosDAL : ConnectionToSql
    {
        public bool Guardar(ServiciosET servicio)
        {
            bool retVal = false;
            using (var conexion = GetConnection())
            {
                try
                {
                    using (var cmd = new SqlCommand("spGuardarServicio", conexion))
                    {
                        cmd.Connection = conexion;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@nombre", servicio.Nombre));
                        cmd.Parameters.Add(new SqlParameter("@descripcion", servicio.Descripcion));
                        cmd.Parameters.Add(new SqlParameter("@duracionMin", servicio.DuracionMin));
                        cmd.Parameters.Add(new SqlParameter("@precio", servicio.Precio));
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

        public ServiciosET Buscar(int id)
        {
            ServiciosET servicio = null;
            bool retornoNulo = true;

            DataTable dt = new DataTable();
            using (var conexion = GetConnection())
            {
                try
                {
                    conexion.Open();
                    using (var cmd = new SqlCommand("spBuscarServicio", conexion))
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
                            servicio.Id = Convert.ToInt32(dt.Rows[0]["id"]);
                            servicio.Nombre = Convert.ToString(dt.Rows[0]["nombre"]);
                            servicio.Descripcion = Convert.ToString(dt.Rows[0]["descripcion"]);
                            servicio.DuracionMin = Convert.ToInt32(dt.Rows[0]["duracionMin"]);
                            servicio.Precio = float.Parse(Convert.ToString(dt.Rows[0]["precio"]));
                            servicio.Estado = Convert.ToBoolean(dt.Rows[0]["estado"]);
                        }
                            

                        return servicio;
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
                    using (var cmd = new SqlCommand("spBuscarTServicio", conexion))
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


        public bool Actualizar(ServiciosET servicio)
        {
            bool retVal = false;
            using (var conexion = GetConnection())
            {
                try
                {
                    using (var cmd = new SqlCommand("spActualizarServicio", conexion))
                    {
                        cmd.Connection = conexion;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@id", servicio.Id));
                        cmd.Parameters.Add(new SqlParameter("@nombre", servicio.Nombre));
                        cmd.Parameters.Add(new SqlParameter("@descripcion", servicio.Descripcion));
                        cmd.Parameters.Add(new SqlParameter("@duracionMin", servicio.DuracionMin));
                        cmd.Parameters.Add(new SqlParameter("@precio", servicio.Precio));
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
                    using (var cmd = new SqlCommand("spEliminarServicio", conexion))
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
