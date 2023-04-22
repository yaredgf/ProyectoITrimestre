using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class RazaET
    {
        private int _id;
        private int _idEspecie;
        private string _nombre;
        private bool _estado;

        public int Id { get => _id; set => _id = value; }
        public int IdEspecie { get => _idEspecie; set => _idEspecie = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public bool Estado { get => _estado; set => _estado = value; }
    }
}
