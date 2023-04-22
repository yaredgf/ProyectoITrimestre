using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class OpcionET
    {
        private int _id;
        private int _idModulo;
        private string _nombre;
        private bool _estado;

        public int Id { get => _id; set => _id = value; }
        public int IdModulo { get => _idModulo; set => _idModulo = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public bool Estado { get => _estado; set => _estado = value; }
    }
}
