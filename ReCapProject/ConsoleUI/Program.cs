using ReCapProject.Business.Concrete;
using ReCapProject.DataAccess.Concrete;
using System;

namespace ReCapProject
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("Araç Numarası : "+ car.Id);
                Console.WriteLine("Araç Adı : " + car.Description);
                Console.WriteLine("Araç Rengi : " + car.ColorId);
                Console.WriteLine("Araç Model : " + car.ModelYear);
                Console.WriteLine("Araç Model Numarası : " + car.BrandId);
                Console.WriteLine("Araç Günlük Ücret : " + car.DailyPrice);
                Console.WriteLine("***********************************************");
            }
        }
    }
}
