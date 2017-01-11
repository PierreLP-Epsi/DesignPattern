using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    public class EmpireTheme : IThemeFactory
    {
        ButtonEmpire button = new ButtonEmpire();

        public string ChangeTheme()
        {
            return button.GetColor();
        }
    }
}
