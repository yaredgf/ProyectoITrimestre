using DAL;
using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class PermisoBL
    {
        public bool Guardar(PermisoET permiso)
        {
            PermisoDAL dal = new PermisoDAL();
            return dal.Guardar(permiso);
        }

        public List<PermisoET> BuscarTodos(int id)
        {
            PermisoDAL dal = new PermisoDAL();
            return dal.BuscarTodos(id);
        }

        public bool Actualizar(PermisoET permiso)
        {
            PermisoDAL dal = new PermisoDAL();
            return dal.Actualizar(permiso);
        }
    }
}
