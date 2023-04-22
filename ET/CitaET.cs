using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class CitaET
    {
        private int _id;
        private int _idServicio;
        private int _idColaborador;
        private int _idMascota;
        private DateTime _fechaCita;
        private DateTime _fechaEmision;
        private bool _asistencia;
        private bool _estado;

        public int Id { get => _id; set => _id = value; }
        public int IdServicio { get => _idServicio; set => _idServicio = value; }
        public int IdColaborador { get => _idColaborador; set => _idColaborador = value; }
        public int IdMascota { get => _idMascota; set => _idMascota = value; }
        public DateTime FechaCita { get => _fechaCita; set => _fechaCita = value; }
        public DateTime FechaEmision { get => _fechaEmision; set => _fechaEmision = value; }
        public bool Asistencia { get => _asistencia; set => _asistencia = value; }
        public bool Estado { get => _estado; set => _estado = value; }
    }
}
