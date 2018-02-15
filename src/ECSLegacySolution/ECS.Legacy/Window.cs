using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECS.Legacy
{
    public class Window : IWindow
    {
        public int Threshold { private get; set; }
        public bool WindowOpen { get; private set; } = false;

        public Window(int threshold = 0)
        {
            Threshold = threshold;
        }

        public void WindowCtrl(int temp)
        {
            WindowOpen = temp >= Threshold;
        }
    }
}
