using DAL;
using ET;
using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class ServiciosBL
    {
        public bool Guardar(ServiciosET servicios)
        {
            ServiciosDAL dal = new ServiciosDAL();
            return dal.Guardar(servicios);
        }

        public DataTable Buscar(int id)
        {
            ServiciosDAL dal = new ServiciosDAL();
            return dal.Buscar(id);
        }

        public DataTable BuscarTodos()
        {
            ServiciosDAL dal = new ServiciosDAL();
            return dal.BuscarTodos();
        }

        public bool Actualizar(ServiciosET servicios)
        {
            ServiciosDAL dal = new ServiciosDAL();
            return dal.Actualizar(servicios);
        }

        public bool Borrar(int id)
        {
            ServiciosDAL dal = new ServiciosDAL();
            return dal.Borrar(id);
        }
    }
}
