
namespace Lab21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            car1.Name = "Toyota";
            car1.Speed = 120;
            car1.Price = 25000;

            Car car2 = new Car();
            car2.Name = "BMW";
            car2.Speed = 180;
            car2.Price = 50000;

          


            Car[] cars = { car1, car2 };

            
            Gallery gallery = new Gallery("MyGallery", cars);

            

            
            Console.WriteLine(gallery.GetGalleryInfo());

            gallery.GetGalleryCarShow();

            
            gallery.GetGalleryCarById(1); 

            
            Console.WriteLine($"Galeriyadaki butun masinlarin qiymetleri: {gallery.SumCar()}");

        }
    }
}