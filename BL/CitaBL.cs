using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ET;
using DAL;
using System.Data;

namespace BL
{
    public class CitaBL
    {
        public bool Guardar(CitaET cita)
        {
            CitaDAL dal = new CitaDAL();
            return dal.Guardar(cita);
        }

        public DataTable Buscar(int id)
        {
            CitaDAL dal = new CitaDAL();
            return dal.Buscar(id);
        }

        public DataTable BuscarTodos()
        {
            CitaDAL dal = new CitaDAL();
            return dal.BuscarTodos();
        }

        public bool Actualizar(CitaET cita)
        {
            CitaDAL dal = new CitaDAL();
            return dal.Actualizar(cita);
        }

        public bool Borrar(int id)
        {
            CitaDAL dal = new CitaDAL();
            return dal.Borrar(id);
        }


    }
}
