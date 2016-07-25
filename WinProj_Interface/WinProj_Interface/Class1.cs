using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WinProj_Interface
{
    class Class1
    {
    }
    //介面宣告
    interface ICarnivore 
    {
        bool IsHungry { get; }
        Animal Hunt();
        void Eat(Animal victim);
    }

    public abstract class Animal 
    {
        public abstract void Sleep();
    }

    public class Antelope : Animal 
    {
        public string name;
        public override void Sleep() 
        {
            Console.WriteLine("Antelope Sleep");
        }
        public override string ToString()
        {
            return "Animal Antelope";
        }
        public Antelope() { }
        public Antelope(string n) { name = n; }
    }

    public class Lion : Animal, ICarnivore ,IComparable
    {
        private bool hungry;
        public string name;
        public Lion() 
        {
            hungry = true;
        }
        public Lion(string n) 
        {
            name = n;
        }
        public override string ToString()
        {
            return "Lion Name: " + name;
        }
        //ICarnivore implementation
        bool ICarnivore.IsHungry 
        {
            get { return hungry; } 
        }

        Animal ICarnivore.Hunt() 
        {
            //hunt and capture implementation
            return new Antelope();
        }
        void ICarnivore.Eat(Animal prey) 
        {
            //implementation
            Console.WriteLine("Lion ate the Prey" + prey);
        }

        //Inherited from base class
        public override void Sleep()
        {
            //sleeping
            Console.WriteLine("Lion Sleep");
        }

       #region IComparable Members

        public int CompareTo(object obj) 
        {
            Lion x = (Lion)obj;
            //我的名字相等 會傳0 大於會傳1 小於會傳-1
            return this.name.CompareTo(x.name);

            //return this.name.CompareTo(x.name)*-1
            //換變成C B A
        }
       #endregion

    }

}

