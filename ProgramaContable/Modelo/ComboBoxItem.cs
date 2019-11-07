using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaContable.Modelo
{
    public class ComboBoxItem
    {
        string displayValue;
        int hiddenValue;

        public ComboBoxItem(string d, int h)
        {
            displayValue = d;
            hiddenValue = h;
        }
        public int HiddenValue
        {
            get { return hiddenValue; }
        }

        public override string ToString()
        {
            return displayValue;
        }
    }
}

