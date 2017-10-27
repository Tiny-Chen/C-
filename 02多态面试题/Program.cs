using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02多态面试题
{
    class Program
    {
        static void Main(string[] args)
        {
            D d = new D();//创建对象
            C c = d;//父类装子对象
            B b = d;//父类装子对象
            A a = d;//父类装子对象
            Console.WriteLine(d.Str);//D，对象是d，调用的是其本身的
            Console.WriteLine(c.Str);//B，本身没有，查找父类的，所以值是父类的
            Console.WriteLine(b.Str);//B，对象是b，调用的是其本身的
            Console.WriteLine(a.Str);//A，对象是a,
            Console.WriteLine("------------");
            d.Show();//D
            c.Show();//C,重写
            b.Show();//C，被重写了
            a.Show();//A
            Console.ReadLine();
        }
    }
    //父类
    class A
    {
        public string Str = "A";

        public void Show() { Console.WriteLine("Show A"); }
    }

    class B : A
    {
        public string Str = "B";

        public virtual void Show() { Console.WriteLine("Show B"); }
    }

    class C : B
    {
        public override void Show() { Console.WriteLine("Show C"); }
    }

    class D : C
    {
        public string Str = "D";

        public void Show() { Console.WriteLine("Show D"); }
    }


    }


















