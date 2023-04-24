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
    public class ClienteBL
    {
        public bool Guardar(ClienteET cliente)
        {
            ClienteDAL dal = new ClienteDAL();
            return dal.Guardar(cliente);
        }

        public DataTable Buscar(int id)
        {
            ClienteDAL dal = new ClienteDAL();
            return dal.Buscar(id);
        }

        public DataTable BuscarTodos()
        {
            ClienteDAL dal = new ClienteDAL();
            return dal.BuscarTodos();
        }

        public bool Actualizar(ClienteET cliente)
        {
            ClienteDAL dal = new ClienteDAL();
            return dal.Actualizar(cliente);
        }

        public bool Borrar(int id)
        {
            ClienteDAL dal = new ClienteDAL();
            return dal.Borrar(id);
        }
        
    }
}
