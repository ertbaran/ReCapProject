using Business.Concrete;
using DataAccess.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var vehicle in carManager.GetAll())
            {
                Console.WriteLine(vehicle.ModelYear + " Model" + ", " + vehicle.BrandId + " Marka Kodlu Araç: " + vehicle.DailyPrice + " TL");
            }
            Console.Read();

        }
    }
}
