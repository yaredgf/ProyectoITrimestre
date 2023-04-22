using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class PermisoET
    {
        private int _id;
        private int _idOpcion;
        private int _idTipoColaborador;
        private bool _permitido;
        private bool _estado;

        public int Id { get => _id; set => _id = value; }
        public int IdOpcion { get => _idOpcion; set => _idOpcion = value; }
        public int IdTipoColaborador { get => _idTipoColaborador; set => _idTipoColaborador = value; }
        public bool Permitido { get => _permitido; set => _permitido = value; }
        public bool Estado { get => _estado; set => _estado = value; }
    }
}
