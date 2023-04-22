using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class MascotaET
    {
        private int _id;
        private int _idCliente;
        private string _nombre;
        private int _idRaza;
        private DateOnly _fechaNacimiento;
        private bool _estado;

        public int Id { get => _id; set => _id = value; }
        public int IdCliente { get => _idCliente; set => _idCliente = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public int IdRaza { get => _idRaza; set => _idRaza = value; }
        public DateOnly FechaNacimiento { get => _fechaNacimiento; set => _fechaNacimiento = value; }
        public bool Estado { get => _estado; set => _estado = value; }
    }
}
