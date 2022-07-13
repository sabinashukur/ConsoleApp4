using ConsoleApp4.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.Concrete
{
    public class WindowsButton : IButton
    {
        public void OnClick()
        {
            Console.WriteLine("Windows Button ONClick");

        }

        public void Render()
        {
            Console.WriteLine("Windows Button Render");

        }
    }
}
