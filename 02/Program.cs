using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{

    interface ICarCollection
    {
        void Add(Car car);
        void Add(string name, int yearProduction);
        Car this[int i]
        {
            get;
        }
        int Count
        {
            get;
        }
    }

    class CarCollection : ICarCollection
    {
        public void Add(Car car)
        {
            cars.Add(car);
        }
        public void Add(string name, int yearProduction)
        {
            Car newCar = new Car();
            newCar.name = name;
            newCar.yearProduction = yearProduction;
            Add(newCar);
        }

        public Car this[int i]
        {
            get 
            {
                if(i < cars.Count)
                    return cars[i];
                else
                {
                    Console.WriteLine("Спроба доступу за межі масиву");
                    return default(Car);
                }
            }
        }
        public int Count
        {
            get { return cars.Count; }
        }


        private List<Car> cars;

        public CarCollection()
        {
            cars = new List<Car>();
        }

        public void Clear()
        {
            cars.Clear();
        }
    }



    struct Car
    {
        public string name;
        public int yearProduction;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            CarCollection cars = new CarCollection();
            cars.Add(new Car() { name = "car1", yearProduction = 1990});
            cars.Add(new Car() { name = "car2", yearProduction = 1993});
            cars.Add(new Car() { name = "car3", yearProduction = 1997});

            Car c = cars[0];

            cars.Clear();


            Console.ReadKey();
        }
    }
}
