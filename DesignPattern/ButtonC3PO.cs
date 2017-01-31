using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    class ButtonC3PO : IButton
    {
        public IButton ActualButton { get; set; }

        public ButtonC3PO(IButton actualButton)
        {
            this.ActualButton = actualButton;
        }

        public int GetFontSize()
        {
            return ActualButton.GetFontSize();
        }

        public int GetHeigth()
        {
            return ActualButton.GetHeigth() + 20;
        }

        public int GetWidth()
        {
            return ActualButton.GetWidth();
        }
    }
}
