using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07
{
    internal class Program
    {
        // class MyClass<T> where T : class
        class MyClass<T> where T : new()
        {
           public T FactoryMethod() => new T();
        }

        static void Main(string[] args)
        {
            //// MyClass<MyClass<Str>> myClass = new MyClass<MyClass<Str>>();

            MyClass<Struct> myClass = new MyClass<Struct>();

            Struct a = myClass.FactoryMethod();
            Struct b = myClass.FactoryMethod();



            MyClass<Class> myClass2 = new MyClass<Class>();

            Class a2 = myClass2.FactoryMethod();
            Class b2 = myClass2.FactoryMethod();



            Console.ReadKey();
        }



        struct Struct
        {
            int a;
            string b;
        }

        class Class
        {
            int a;
            string b;
        }
    }
}
