using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06
{
    internal class Program
    {
        struct MyStruct
        { }

        class MyClass
        {

        }

        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();
            // аргумент передається як "тип за значенням", тому буде Boxing
            arrayList.Add(3);
            arrayList.Add("чотири");

            for(int i = 0; i < arrayList.Count; i++)
            {
                // Boxing/Unboxing тут не буде, так як WriteLine() тип що приймає є object, тобто тип за посилальним
                Console.WriteLine(arrayList[i]);
                // ще неможна ось так:
                //Console.WriteLine((int)arrayList[i]);

            }

           


            Console.ReadKey();
        }
    }
}
