using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    class ButtonBB8 : IDecorator
    {
        public IDecorator ActualButton { get; set; }

        public ButtonBB8(IDecorator actualButton)
        {
            this.ActualButton = actualButton;
        }

        public int GetFontSize()
        {
            return ActualButton.GetFontSize() + 1;
        }

        public int GetHeigth()
        {
            return ActualButton.GetHeigth();
        }

        public int GetWidth()
        {
            return ActualButton.GetWidth();
        }
    }
}
