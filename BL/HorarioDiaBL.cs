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
    public class HorarioDiaBL
    {
        public bool Guardar(HorarioDiaET horarioDia)
        {
            HorarioDiaDAL dal = new HorarioDiaDAL();
            return dal.Guardar(horarioDia);
        }

        public DataTable Buscar(int id)
        {
            HorarioDiaDAL dal = new HorarioDiaDAL();
            return dal.Buscar(id);
        }

        public DataTable BuscarTodos()
        {
            HorarioDiaDAL dal = new HorarioDiaDAL();
            return dal.BuscarTodos();
        }

        public bool Actualizar(HorarioDiaET horarioDia)
        {
            HorarioDiaDAL dal = new HorarioDiaDAL();
            return dal.Actualizar(horarioDia);
        }

        public bool Borrar(int id)
        {
            HorarioDiaDAL dal = new HorarioDiaDAL();
            return dal.Borrar(id);
        }
    }
}
