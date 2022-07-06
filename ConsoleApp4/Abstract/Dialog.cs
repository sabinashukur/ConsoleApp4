using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.Abstract
{
    public abstract class Dialog : IButton
    {
        public void OnClick()
        {
            Console.WriteLine("OnClick");
        }

        public void Render()
        {
            Console.WriteLine("Render");

        }
        public abstract IButton CreateButton();
    }
}
