using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinProj_Interface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ICarnivore ILion;
            Lion aLion = new Lion();
            Antelope a = new Antelope();

            a.Sleep();

            ILion = aLion;
            //acrnivore-like behavior
            if (ILion.IsHungry) 
            {
                //傳入一個Animal的物件參考 是以ILion.Hunt()方式傳回來
                Animal victim = ILion.Hunt();
                if (victim != null) 
                {
                    ILion.Eat(victim);
                }
            }
            aLion.Sleep();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Lion[] a = { new Lion("A"), new Lion("C"), new Lion("B") };
            Array.Sort(a);
            foreach (Animal x in a)
                Console.WriteLine(x);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //因為WidescreenTV繼承 Television 所以型別為Television但是物件WidescreenTV可以被new出來
            Television tv = new WidescreenTV();
            Console.WriteLine(tv);
            tv.TrunOn();
            tv.TrunOff();
            tv.DecreaseVolume();
            tv.IncreaseVolume();
            tv.TrunOff();
        }
    }
}
