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
    public class RazaBL
    {
        public bool Guardar(RazaET raza)
        {
            RazaDAL dal = new RazaDAL();
            return dal.Guardar(raza);
        }

        public RazaET Buscar(int id)
        {
            RazaDAL dal = new RazaDAL();
            return dal.Buscar(id);
        }

        public DataTable BuscarTodos()
        {
            RazaDAL dal = new RazaDAL();
            return dal.BuscarTodos();
        }

        public bool Actualizar(RazaET raza)
        {
            RazaDAL dal = new RazaDAL();
            return dal.Actualizar(raza);
        }

        public bool Borrar(int id)
        {
            RazaDAL dal = new RazaDAL();
            return dal.Borrar(id);
        }
    }
}
