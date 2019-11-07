using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaContable.Modelo
{
    class MoviCuenta
    {
        private string nombreCuenta;
        private List<Movimiento> movimientosdebe;
        private List<Movimiento> movimientoshaber;
        public string NombreCuenta { get => nombreCuenta; set => nombreCuenta = value; }
        internal List<Movimiento> Movimientosdebe { get => movimientosdebe; set => movimientosdebe = value; }
        internal List<Movimiento> Movimientoshaber { get => movimientoshaber; set => movimientoshaber = value; }

        public MoviCuenta()
        {
            Movimientosdebe = new List<Movimiento>();
            Movimientoshaber = new List<Movimiento>();
        }
    }
}
