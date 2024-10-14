using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    interface IDictionary<TKey, TValue>
    {
        void Add(TKey key, TValue value);
        TValue this[TKey key] { get; }
        int Count { get; }
    }

    class Dictionary<TKey, TValue> : IDictionary<TKey, TValue>
    {
        struct Entry
        {
            public TKey Key;
            public TValue Value;
        }

        public void Add(TKey key, TValue value)
        {
            Entry newEntry = new Entry();
            newEntry.Key = key;
            newEntry.Value = value;

            Array.Resize(ref entries, entries.Length + 1);
            entries[entries.Length - 1] = newEntry;
        }
        public TValue this[TKey key]
        {
            get
            {
                for (int i = 0; i < entries.Length; i++)
                {
                    if (entries[i].Key.Equals(key))
                        return entries[i].Value;
                }

                Console.WriteLine("Немає значення з таким \"{0}\" ключем", key);
                return default(TValue);

            }

        }
        public int Count
        {
            get { return entries.Length; }
        }



        private Entry[] entries;

        public Dictionary()
        {
            entries = new Entry[0];
        }


    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            Dictionary<string, string> dic = new Dictionary<string, string>();

            dic.Add("перший", "01");
            dic.Add("другий", "02");
            dic.Add("третій", "03");

            Console.WriteLine(dic["другий"]);
            Console.WriteLine(dic["другий"]);

            Console.WriteLine(dic.Count + " елементів");

            Console.WriteLine(new string('-', 30));





            System.Collections.Generic.Dictionary<string, string> dic2 = new System.Collections.Generic.Dictionary<string, string>();

            dic2.Add("перший", "01");
            dic2.Add("другий", "02");
            dic2.Add("третій", "03");

            Console.WriteLine(dic2["другий"]);
            Console.WriteLine(dic2["другий"]);

            Console.WriteLine(dic2.Count + "елементів");








            Console.ReadKey();

        }
    }
}
