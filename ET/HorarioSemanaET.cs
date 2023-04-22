using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class HorarioSemanaET
    {
        private int _id;
        private int[] _horarioDia;
        private bool _estado;

        public int Id { get => _id; set => _id = value; }
        public int[] HorarioDia { get => _horarioDia; set => _horarioDia = value; }
        public bool Estado { get => _estado; set => _estado = value; }
    }
}
