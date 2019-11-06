using ProgramaContable.Vista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramaContable.Controlador
{
    public class ControladorLibroDiario
    {
        Form vistaAnterior;
        LibroDiario vistaLibroDiario;

        public ControladorLibroDiario(Form vista)
        {
            vistaAnterior = vista;
            vistaLibroDiario= new LibroDiario(this);
            vistaLibroDiario.Visible = true;
        }

        public void Volver()
        {
            vistaAnterior.Visible = true;
            vistaLibroDiario.Dispose();
          
        }

        
    }
}
