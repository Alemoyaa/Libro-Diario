using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaContable.Modelo
{
    class TipodeCuenta
    {
        private int id;
        private string descripcionTipo;

        public string DescripcionTipo { get => descripcionTipo; set => descripcionTipo = value; }
        public int Id { get => id; set => id = value; }

        public TipodeCuenta(int id, string descripcion)
        {
            Id = id;
            DescripcionTipo = descripcion;
        }
    }



}
