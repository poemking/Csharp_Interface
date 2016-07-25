using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WinProj_Interface
{
    class Class2
    {
    }
    abstract class Television 
    {
        public void TrunOn() 
        {
            Console.WriteLine("Television on.");
        }
        public void TrunOff()
        {
            Console.WriteLine("Television off.");
        }
        public abstract void IncreaseVolume();
        public abstract void DecreaseVolume();
    }

    class WidescreenTV : Television 
    {
        public override void IncreaseVolume()
        {
            Console.WriteLine("Volume increased (WidescreenTV.)");
        }

        public override void DecreaseVolume()
        {
            Console.WriteLine("Volume decreased (WidescreenTV.)");
        }
        public override string ToString()
        {
            return "This is Wide Screen TV";
        }
    }
}
