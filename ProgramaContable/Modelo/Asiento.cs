using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaContable.Modelo
{
    class Asiento
    {
        private int id;
        private int numero_asiento;
        private DateTime fecha_asiento;
        private String descripcion_asiento;

        public int Id { get => id; set => id = value; }
        public int Numero_asiento { get => numero_asiento; set => numero_asiento = value; }
        public DateTime Fecha_asiento { get => fecha_asiento; set => fecha_asiento = value; }
        public string Descripcion_asiento { get => descripcion_asiento; set => descripcion_asiento = value; }

        public Asiento(int id, int numero, DateTime fecha, string descrp)
        {
            Id = id;
            Numero_asiento = numero;
            Fecha_asiento = fecha;
            Descripcion_asiento = descrp;
        }
    }
}
