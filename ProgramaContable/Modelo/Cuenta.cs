using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaContable.Modelo
{
    class Cuenta
    {
        private int idCuenta;
        private String nombreCuenta;
        private TipodeCuenta tipocuenta;

        public int IdCuenta { get => idCuenta; set => idCuenta = value; }
        public string NombreCuenta { get => nombreCuenta; set => nombreCuenta = value; }
        internal TipodeCuenta Tipocuenta { get => tipocuenta; set => tipocuenta = value; }

        public Cuenta(int id, string nombre, TipodeCuenta tipo)
        {
            IdCuenta = id;
            NombreCuenta = nombre;
            Tipocuenta = tipo;
        }
    }
}
