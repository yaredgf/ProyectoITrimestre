using DAL;
using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class HorarioSemanaBL
    {
        public bool Guardar(HorarioSemanaET horarioSemana)
        {
            HorarioSemanaDAL dal = new HorarioSemanaDAL();
            return dal.Guardar(horarioSemana);
        }

        public HorarioSemanaET Buscar(int id)
        {
            HorarioSemanaDAL dal = new HorarioSemanaDAL();
            return dal.Buscar(id);
        }

        public bool Actualizar(HorarioSemanaET horarioSemana)
        {
            HorarioSemanaDAL dal = new HorarioSemanaDAL();
            return dal.Actualizar(horarioSemana);
        }

        public bool Borrar(int id)
        {
            HorarioSemanaDAL dal = new HorarioSemanaDAL();
            return dal.Borrar(id);
        }
    }
}
