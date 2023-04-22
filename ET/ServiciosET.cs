using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class ServiciosET
    {
        private int _id;
        private string _nombre;
        private string _descripcion;
        private int _duracionMin;
        private float _precio;
        private bool _estado;

        public int Id { get => _id; set => _id = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
        public int DuracionMin { get => _duracionMin; set => _duracionMin = value; }
        public float Precio { get => _precio; set => _precio = value; }
        public bool Estado { get => _estado; set => _estado = value; }
    }
}
