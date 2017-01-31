using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    class ButtonBB8 : IButton
    {
        public IButton ActualButton { get; set; }

        public ButtonBB8(IButton actualButton)
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
