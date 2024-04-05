using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab21
{
    public class Gallery
    {
        public string Name { get; set; }
        public Car[] Cars { get; set; }

        
        public Gallery(string name, Car[] cars)
        {
            Name = name;
            Cars = cars;
        }

        
        public void GetGalleryCarShow()
        {
            Console.WriteLine($"Gallery Adi: {Name}\nMasinlar:");
            foreach (Car car in Cars)
            {
                Console.WriteLine(car.GetInfoCar());
            }
        }

        
        public void GetGalleryCarById(int id)
        {
            foreach (Car car in Cars)
            {
                if (car.Id == id)
                {
                    Console.WriteLine($"Gallerdeki car-i id {id}:\n{car.GetInfoCar()}");
                    return;
                }
            }
            Console.WriteLine($"Bu {id}  Gallery de yoxdu.");
        }

        public decimal SumCar()
        {
            decimal sum = 0;
            foreach (Car car in Cars)
            {
                sum += car.Price;
            }
            return sum;
        }
        public string GetGalleryInfo()
        {
            string info = $"Gallery Adi: {Name}\nMasinlar:\n";
            foreach (Car car in Cars)
            {
                info += car.GetInfoCar() + "\n";
            }
            return info;
        }

    }
}
