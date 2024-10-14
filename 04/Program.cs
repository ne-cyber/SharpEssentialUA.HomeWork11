using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04
{

    class ArrayList
    {
        public ArrayList()
        {
            array = new object[0];
        }
        private object[] array;


        public void Add(object item)
        {
            Array.Resize(ref array, array.Length + 1);
            array[array.Length - 1] = item;
        }
        public object this[int index]
        {
            get
            {
                if (index < array.Length)
                    return array[index];
                else
                {
                    Console.WriteLine("Спроба виходу за межі масиву");
                    return null;
                }
            }
        }
        public int Count { get { return array.Length; } }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList array = new ArrayList();
            array.Add(2);
            array.Add("три");


            for (int i = 0; i < array.Count; i++)
            {
                Console.WriteLine(array[i]);
            }

            Console.WriteLine(new string('-', 30));




            System.Collections.ArrayList array2 = new System.Collections.ArrayList();
            array2.Add(2);
            array2.Add("три");

            for (int i = 0; i < array2.Count; i++)
            {
                Console.WriteLine(array2[i]);
            }


            Console.ReadKey();
        }
    }
}
