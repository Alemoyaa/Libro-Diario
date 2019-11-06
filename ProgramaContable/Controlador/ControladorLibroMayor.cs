using ProgramaContable.Vista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramaContable.Controlador
{
    public class ControladorLibroMayor
    {
        Form vistaAnterior;
        LibroMayor vistaLibroMayor;

        public ControladorLibroMayor(Form vista)
        {
            vistaAnterior = vista;
            vistaLibroMayor = new LibroMayor(this);
            vistaLibroMayor.Visible = true;
        }

    }
}
