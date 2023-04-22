using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class HorarioDiaET
    {
        private int _id;
        private TimeOnly _horaEntrada;
        private TimeOnly _horaSalida;
        private bool _estado;

        public int Id { get => _id; set => _id = value; }
        public TimeOnly HoraEntrada { get => _horaEntrada; set => _horaEntrada = value; }
        public TimeOnly HoraSalida { get => _horaSalida; set => _horaSalida = value; }
        public bool Estado { get => _estado; set => _estado = value; }
    }
}
