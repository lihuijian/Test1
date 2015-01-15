using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GitTest
{
    public delegate void MyDelegate(string message);

    public delegate bool MyDel<T>(T value);
    class MyClass2
    {
         
    }
    class MyClass1<T,U>:MyClass<int>,ICloneable
    {
        private U u { get; set; }
        private T t { get; set; }
        public void MyClass1Method()
        {
            Console.WriteLine("MyClass1Method");
        }

        public object Clone()
        {
            return this;
        }
    }
    class MyClass<T>
    {
        private T Number { get; set; }

        public void Method(T t)
        {
            this.Number = default(T);
            Console.WriteLine(this.Number);
        }
    }
    class Program
    {
        public static void Methed(string message)
        {
             Console.WriteLine(message);
        }

        public static bool ss(int s)
        {
            return true;
        }

        static void Main(string[] args)
        {
            MyDel<int> sDel=new MyDel<int>(ss);
            sDel(10);
            MyClass1<int,string> jjj=new MyClass1<int, string>();
            jjj.Method(10);
            jjj.MyClass1Method();
            var myThis= jjj.Clone();
             MyClass<int> MyObject=new MyClass<int>();
             MyObject.Method(10);
            Console.WriteLine("13"+(char)13+"13");
            Console.WriteLine("10"+(char)10+"10");
            while (true)
            {


                var myChar1 = Console.Read();
                //char myChar1 = Convert.ToChar(myChar);
                if ((myChar1 >= 65 && myChar1 <= 91) || (myChar1 >= 97 && myChar1 <= 122))
                {
                    Console.WriteLine("English");
                }
                else
                {
                    Console.WriteLine("中文");
                }
                Console.WriteLine(myChar1);
            }
           
        }
    }
}
