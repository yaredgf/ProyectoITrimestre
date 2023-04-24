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
    public class EspecieBL
    {
        public bool Guardar(EspecieET especie)
        {
            EspecieDAL dal = new EspecieDAL();
            return dal.Guardar(especie);
        }

        public DataTable Buscar(int id)
        {
            EspecieDAL dal = new EspecieDAL();
            return dal.Buscar(id);
        }

        public DataTable BuscarTodos()
        {
            EspecieDAL dal = new EspecieDAL();
            return dal.BuscarTodos();
        }

        public bool Actualizar(EspecieET especie)
        {
            EspecieDAL dal = new EspecieDAL();
            return dal.Actualizar(especie);
        }

        public bool Borrar(int id)
        {
            EspecieDAL dal = new EspecieDAL();
            return dal.Borrar(id);
        }
    }
}
