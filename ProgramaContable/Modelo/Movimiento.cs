using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaContable.Modelo
{
    class Movimiento
    {
        private int id;
        private Asiento asiento;
        private Cuenta cuenta;
        private float valor;
        private bool debe_haber;

        public int Id { get => id; set => id = value; }
        public float Valor { get => valor; set => valor = value; }
        public bool Debe_haber { get => debe_haber; set => debe_haber = value; }
        internal Asiento Asiento { get => asiento; set => asiento = value; }
        internal Cuenta Cuenta { get => cuenta; set => cuenta = value; }

        public Movimiento(int id, float valor, bool debehaber, Asiento asiento, Cuenta cuenta)
        {
            Id = id;
            Valor = valor;
            Debe_haber = debehaber;
            Asiento = asiento;
            Cuenta = cuenta;
        }
    }
}
