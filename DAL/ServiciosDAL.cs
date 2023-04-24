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
                    conexion.Open();
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

        public DataTable Buscar(int id)
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
                    conexion.Open();
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
                    conexion.Open();
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
