﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    public class RebelleTheme : IThemeFactory
    {
        ButtonRebelle button = new ButtonRebelle();

        public string ChangeTheme()
        {
            return button.GetColor();
        }
    }
}
