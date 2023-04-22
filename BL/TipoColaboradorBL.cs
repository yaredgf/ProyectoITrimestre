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
    public class TipoColaboradorBL
    {
        public bool Guardar(TipoColaboradorET tipo)
        {
            TipoColaboradorDAL dal = new TipoColaboradorDAL();
            return dal.Guardar(tipo);
        }

        public TipoColaboradorET Buscar(int id)
        {
            TipoColaboradorDAL dal = new TipoColaboradorDAL();
            return dal.Buscar(id);
        }

        public DataTable BuscarTodos()
        {
            TipoColaboradorDAL dal = new TipoColaboradorDAL();
            return dal.BuscarTodos();
        }

        public bool Actualizar(TipoColaboradorET tipo)
        {
            TipoColaboradorDAL dal = new TipoColaboradorDAL();
            return dal.Actualizar(tipo);
        }

        public bool Borrar(int id)
        {
            TipoColaboradorDAL dal = new TipoColaboradorDAL();
            return dal.Borrar(id);
        }
    }
}
