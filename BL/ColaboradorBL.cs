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
    public class ColaboradorBL
    {
        public bool Guardar(ColaboradorET colaborador)
        {
            ColaboradorDAL dal = new ColaboradorDAL();
            return dal.Guardar(colaborador);
        }

        public DataTable Buscar(int id)
        {
            ColaboradorDAL dal = new ColaboradorDAL();
            return dal.Buscar(id);
        }

        public DataTable BuscarTodos()
        {
            ColaboradorDAL dal = new ColaboradorDAL();
            return dal.BuscarTodos();
        }

        public bool Actualizar(ColaboradorET colaborador)
        {
            ColaboradorDAL dal = new ColaboradorDAL();
            return dal.Actualizar(colaborador);
        }

        public bool Borrar(int id)
        {
            ColaboradorDAL dal = new ColaboradorDAL();
            return dal.Borrar(id);
        }
        public int BuscarUsuario(string usuario, string contrasenna)
        {
            ColaboradorDAL dal = new ColaboradorDAL();
            return dal.BuscarUsuario(usuario, contrasenna);
        }
    }
}
