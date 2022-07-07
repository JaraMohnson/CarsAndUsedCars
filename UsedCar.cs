using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsAndUsedCars
{
    internal class UsedCar : Car
    {
        //property 
        public double Mileage { get; set; }


        // Constructor 
        public UsedCar(string _make, string _model, int _year, decimal _price, double _mileage): 
            base( _make,  _model,  _year,  _price)
        {
            Mileage = _mileage;
        }


        // tentative method.... 
        public override string ToString()
        {
            return base.ToString();
        }






    }
}
