using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyT
{
    /// <summary>
    /// 泛型类
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class MyClass<T>
    {
        public T Unknow { get; set; }

        public MyClass(T t)
        {
            this.Unknow = t;
        }
        public void Method(T t1)
        {
        }
    }

    interface IInterface<T>
    {
        void Method(T);
    }
    internal delegate void MyDel<T>(T t);
    class Program
    {
        public static void TestMethod(int a)
        {
        }

        public static void TestMethod1(string s)
        {
        }

        static void Main(string[] args)
        {
            MyClass<int> myClass=new MyClass<int>(10);//声明一个MyClass对象，T这个位置用int代替
            MyDel<int> del=new MyDel<int>(TestMethod);//声明一个参数为int类型的MyDel委托
            MyDel<string> del1=new MyDel<string>(TestMethod1);//声明一个参数为string类型的MyDel委托
        }
    }
}
