using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrototypePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Resume a = new Resume("大鸟");
            a.setPersonalInfo("男","29");
            a.setWorkExperience("1998-2000", "XX公司");

            Resume b = (Resume)a.Clone();
            b.setWorkExperience("1998-2006","YY企业");

            Resume c = (Resume)a.Clone();
            c.setPersonalInfo("男","24");

            a.Display();
            b.Display();
            c.Display();

            Console.Read();
        }
    }
    class Resume : ICloneable
    {
        private string name;
        private string sex;
        private string age;
        private string timeArea;
        private string company;

        public Resume(string name)
        {
            this.name = name;
        }
        public void setPersonalInfo(string sex, string age)
        {
            this.sex = sex;
            this.age = age;
        }

        public void setWorkExperience(string timeArea, string company)
        {
            this.timeArea = timeArea;
            this.company = company;
        }

        //显示
        public void Display()
        {
            Console.WriteLine("{0} {1} {2}", name, sex, age);
            Console.WriteLine("工作经历：{0} {1}", timeArea, company);
        }

        public Object Clone()
        {
            return (Object)this.MemberwiseClone();
        }
    }
}
