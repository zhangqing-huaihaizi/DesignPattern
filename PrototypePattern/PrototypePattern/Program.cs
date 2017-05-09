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
    class WorkExperience : ICloneable
    {
        private string workDate;
        public string WorkDate
        {
            get { return workDate; }
            set { workDate = value; }
        }
        private string company;
        public string Company
        {
            get { return company; }
            set { company = value; }
        }
        public Object Clone()
        {
            return (Object)this.MemberwiseClone();
        }
    }
    class Resume : ICloneable
    {
        private string name;
        private string sex;
        private string age;
        private WorkExperience work;

        public Resume(string name)
        {
            this.name = name;
            work = new WorkExperience();
        }
        private Resume(WorkExperience work)
        {
            this.work = (WorkExperience)work.Clone();
        }

        public void setPersonalInfo(string sex, string age)
        {
            this.sex = sex;
            this.age = age;
        }

        public void setWorkExperience(string workDate, string company)
        {
            work.WorkDate = workDate;
            work.Company = company;
        }

        //显示
        public void Display()
        {
            Console.WriteLine("{0} {1} {2}", name, sex, age);
            Console.WriteLine("工作经历：{0} {1}", work.WorkDate, work.Company);
        }

        public Object Clone()
        {
            Resume obj = new Resume(this.work);
            obj.name = this.name;
            obj.sex = this.sex;
            obj.age = this.age;
            return obj;
        }
    }
}
