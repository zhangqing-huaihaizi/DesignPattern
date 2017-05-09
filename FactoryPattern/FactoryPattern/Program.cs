using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IFactory factory = new UnderGraduateFactory();
            LeiFeng student = factory.CreateLeiFeng();

            student.BuyRice();
            student.Sweep();
            student.Wash();
        }
    }
    class LeiFeng
    {
        public void Sweep()
        {
            Console.WriteLine("扫地");
        }
        public void Wash()
        {
            Console.WriteLine("洗衣");
        }
        public void BuyRice()
        {
            Console.WriteLine("买米");
        }
    }
    class UnderGraduate : LeiFeng
    { }
    class Volunteer : LeiFeng
    { }
    //雷锋工厂
    interface IFactory
    {
        LeiFeng CreateLeiFeng();
    }
    //学雷锋的大学生工厂
    class UnderGraduateFactory : IFactory
    {
        public LeiFeng CreateLeiFeng()
        {
            return new UnderGraduate();
        }
    }
    class VolunteerFactory : IFactory
    {
        public LeiFeng CreateLeiFeng()
        {
            return new Volunteer();
        }
    }
}

