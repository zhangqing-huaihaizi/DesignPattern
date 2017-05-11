using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Director director = new Director();
            Builder b1 = new ConcretBuilder1();
            Builder b2 = new ConcreteBulider2();

            director.Construct(b1);
            Product p1 = b1.GetResult();
            p1.Show();

            director.Construct(b2);
            Product p2 = b2.GetResult();
            p2.Show();
        }
    }
    class Product
    {
        IList<string> parts = new List<string>();
        public void Add(string part)
        {
            parts.Add(part);
        }

        public void Show()
        {
            Console.WriteLine("\n产品 创建-----");
            foreach (string part in parts)
            {
                Console.WriteLine(part);
            }
        }
    }

    abstract class Builder
    {
        public abstract void BuildPartA();
        public abstract void BuildPartB();
        public abstract Product GetResult();
    }

    class ConcretBuilder1 : Builder
    {
        private Product product = new Product();

        public override void BuildPartA()
        {
            product.Add("部件A");
        }

        public override void BuildPartB()
        {
            product.Add("部件B");
        }

        public override Product GetResult()
        {
            return product;
        }
    }

    class ConcreteBulider2 : Builder
    {
        private Product product = new Product();
        public override void BuildPartA()
        {
            product.Add("部件X");
        }

        public override void BuildPartB()
        {

            product.Add("部件Y");
        }
        public override Product GetResult()
        {
            return product;
        }
    }

    class Director
    {
        public void Construct(Builder builder)
        {
            builder.BuildPartA();
            builder.BuildPartB();
        }
    }
}
