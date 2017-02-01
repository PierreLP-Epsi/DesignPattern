using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    class ButtonR2D2 : IDecorator
    {
        public IDecorator ActualButton { get; set; }

        public ButtonR2D2(IDecorator actualButton)
        {
            this.ActualButton = actualButton;
        }

        public int GetFontSize()
        {
            return ActualButton.GetFontSize();
        }

        public int GetHeigth()
        {
            return ActualButton.GetHeigth();
        }

        public int GetWidth()
        {
            return ActualButton.GetWidth() + 20;
        }
    }
}
