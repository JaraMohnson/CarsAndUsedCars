using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsAndUsedCars
{
    internal class Car
    {
        //properties
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }

        //default constructor 
        public Car()
        {
            Make = "";
            Model = "";
            Year = 0;
            Price = 0;
        }

        // 4 argument constructor 
        public Car(string _make, string _model, int _year, decimal _price)
        {
            Make = _make;
            Model = _model;
            Year = _year;
            Price = _price;
        }

        // methods
        public override string ToString()
        {
            return String.Format("{0,-10} {1,-15} {2,-10} {3,-10}", Make, Model, Year, Price);
        }

        public static void ListCars(List<Car> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine((i + 1) + " " + list[i]);
            }
        }

        public static void Remove(int index, List<Car> List)
        {

            List.Remove(List[index]);
        }
    }
}
