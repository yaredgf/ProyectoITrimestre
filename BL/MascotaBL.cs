using DAL;
using ET;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class MascotaBL
    {
        public bool Guardar(MascotaET mascota)
        {
            MascotaDAL dal = new MascotaDAL();
            return dal.Guardar(mascota);
        }

        public DataTable Buscar(int id)
        {
            MascotaDAL dal = new MascotaDAL();
            return dal.Buscar(id);
        }

        public DataTable BuscarTodos()
        {
            MascotaDAL dal = new MascotaDAL();
            return dal.BuscarTodos();
        }

        public bool Actualizar(MascotaET mascota)
        {
            MascotaDAL dal = new MascotaDAL();
            return dal.Actualizar(mascota);
        }

        public bool Borrar(int id)
        {
            MascotaDAL dal = new MascotaDAL();
            return dal.Borrar(id);
        }
    }
}
