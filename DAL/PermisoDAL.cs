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
    public class PermisoDAL : ConnectionToSql
    {
        public bool Guardar(PermisoET permiso)
        {
            bool retVal = false;
            using (var conexion = GetConnection())
            {
                try
                {
                    conexion.Open();
                    using (var cmd = new SqlCommand("spGuardarPermiso", conexion))
                    {
                        cmd.Connection = conexion;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@idTipoColaborador", permiso.IdTipoColaborador));
                        cmd.Parameters.Add(new SqlParameter("@idOpcion", permiso.IdOpcion));
                        cmd.Parameters.Add(new SqlParameter("@permitido", permiso.Permitido));

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


        public List<PermisoET> BuscarTodos(int id)
        {
            DataTable dt = new DataTable();
            using (var conexion = GetConnection())
            {
                try
                {
                    conexion.Open();
                    using (var cmd = new SqlCommand("spBuscarPermisos", conexion))
                    {
                        SqlDataAdapter da = new SqlDataAdapter();
                        cmd.Connection = conexion;
                        cmd.CommandType = CommandType.StoredProcedure;
                        SqlParameter idRol = new SqlParameter("@id", SqlDbType.Int);
                        idRol.Direction = ParameterDirection.Output;
                        cmd.Parameters.Add(idRol);

                        SqlDataReader reader = cmd.ExecuteReader();
                        if (idRol.Value != DBNull.Value)
                            id = Convert.ToInt32(idRol.Value);


                        da.Fill(dt);
                        List<PermisoET> lista = (from row in dt.AsEnumerable()
                                                  select new PermisoET()
                                                  {
                                                      Id = int.Parse(row["id"].ToString()),
                                                      IdTipoColaborador = int.Parse(row["idTipoColaborador"].ToString()),
                                                      IdOpcion = int.Parse(row["idOpcion"].ToString()),
                                                      Permitido = bool.Parse(row["permitido"].ToString())
                                                  }).ToList();



                        return lista;
                    }
                }
                catch (Exception ex)
                {
                    return null;
                }
            }
        }


        public bool Actualizar(PermisoET permiso)
        {
            bool retVal = false;
            using (var conexion = GetConnection())
            {
                try
                {
                    conexion.Open();
                    using (var cmd = new SqlCommand("spActualizarPermiso", conexion))
                    {
                        cmd.Connection = conexion;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@id", permiso.Id));
                        cmd.Parameters.Add(new SqlParameter("@idOpcion", permiso.IdOpcion));
                        cmd.Parameters.Add(new SqlParameter("@permitido", permiso.Permitido));
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
