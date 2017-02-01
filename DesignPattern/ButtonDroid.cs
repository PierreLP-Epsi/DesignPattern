using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    class ButtonDroid : IDecorator
    {
        int heigth;
        int width;
        int fontSize;

        public ButtonDroid (int heigth, int width, int fontSize)
        {
            this.heigth = heigth;
            this.width = width;
            this.fontSize = fontSize;
        }

        public int GetFontSize()
        {
            return fontSize;
        }

        public int GetHeigth()
        {
            return heigth;
        }

        public int GetWidth()
        {
            return width;
        }
    }
}
