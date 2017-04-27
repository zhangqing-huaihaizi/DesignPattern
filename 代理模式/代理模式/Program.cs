using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 代理模式
{
    //代理类和被代理的类都实现相同的接口
    //代理类中有被代理类的成员变量
    interface IGiveGift
    {
        void GiveDolls();
        void GiveFlowers();
        void GiveChocolate();
    }
    class SchoolGirl{
        private string name;
        public string Name{
            get {return name;}
            set {name = value;}
        }
    }
    //被代理类
    class Pursuit : IGiveGift
    {
        SchoolGirl mm;
        public Pursuit(SchoolGirl mm)
        {
            this.mm = mm;
        }
        public void GiveDolls()
        {
            Console.WriteLine(mm.Name + " 送你洋娃娃");
        }
        public void GiveFlowers()
        {
            Console.WriteLine(mm.Name + " 送你鲜花");
        }
        public void GiveChocolate()
        {
            Console.WriteLine(mm.Name + " 送你巧克力");
        }
    }
    class Proxy : IGiveGift
    {
        //确定被代理的类
        Pursuit gg;
        public Proxy(SchoolGirl mm)
        {
            gg = new Pursuit(mm);
        }

        public void GiveDolls()
        {
            gg.GiveDolls();
        }
        public void GiveFlowers()
        {
            gg.GiveFlowers();
        }
        public void GiveChocolate()
        {
            gg.GiveChocolate();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            SchoolGirl huahua = new SchoolGirl();
            huahua.Name = "花花";

            Proxy proxy1 = new Proxy(huahua);
            proxy1.GiveDolls();
            proxy1.GiveChocolate();
            proxy1.GiveFlowers();
            

            Console.Read();
        }
    }
}
