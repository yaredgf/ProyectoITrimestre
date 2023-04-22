using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class ClienteET
    {
        private int _id;
        private bool _estado;

        private string _nombre;
        private string _apellido1;
        private string _apellido2;
        private string _cedula;
        private string _telefono;

        public int Id { get => _id; set => _id = value; }
        public bool Estado { get => _estado; set => _estado = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellido1 { get => _apellido1; set => _apellido1 = value; }
        public string Apellido2 { get => _apellido2; set => _apellido2 = value; }
        public string Cedula { get => _cedula; set => _cedula = value; }
        public string Telefono { get => _telefono; set => _telefono = value; }
    }
}
