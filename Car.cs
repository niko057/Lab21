using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab21
{
    public class Car
    {

        public int Id { get; private set; }
        public string Name { get; set; }
        public double Speed { get; set; }
        public decimal Price { get; set; }

        private static int _count = 0;

       
        public Car()
        {
            Id = ++_count; 
        }

       
        public static int GetCount()
        {
            return _count;
        }
        public string GetInfoCar()
        {
            return $"Id: {Id}, Adi: {Name}, Suret: {Speed}, Qiymet: {Price}";
        }

    }
}
