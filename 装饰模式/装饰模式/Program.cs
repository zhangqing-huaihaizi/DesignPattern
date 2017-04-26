using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 装饰模式
{
    class Person
    {
        public Person() { }

        private string name;
        public Person(string name)
        {
            this.name = name;
        }

        public virtual void show()
        {
            Console.WriteLine("装扮的{0}",  name);
        }
    }
    //抽象服饰类
    class Finery : Person
    {
        protected Person component;

        public void Decorate(Person component)
        {
            this.component = component;
        }
        public override void show()
        {
            if (component != null)
            {
                component.show();
            }
        }
    }

    //具体服饰类
    class TShirts : Finery
    {
        public override void show()
        {
            Console.Write("大T恤 ");
            base.show();
        }
    }
    class BigTrouser : Finery
    {
        public override void show()
        {
            Console.Write("垮裤 ");
            base.show();
        }
    }
    class Sneakers : Finery
    {
        public override void show()
        {
            Console.Write("破球鞋 ");
            base.show();
        }
    }
    class LeatherShoes : Finery
    {
        public override void show()
        {
            Console.Write("皮鞋 ");
            base.show();
        }
    }
    class Tie : Finery
    {
        public override void show()
        {
            Console.Write("领带 ");
            base.show();
        }
    }
    class Suit : Finery
    {
        public override void show()
        {
            Console.Write("西装 ");
            base.show();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person zq = new Person("huaihaizi");

            Console.WriteLine("第一种装扮：");

            Sneakers sNeak = new Sneakers();
            BigTrouser bTr = new BigTrouser();
            TShirts tSh = new TShirts();

            sNeak.Decorate(zq); //用破球鞋装置huaihaizi
            bTr.Decorate(sNeak);
            tSh.Decorate(bTr);
            tSh.show();
        }
    }
}
