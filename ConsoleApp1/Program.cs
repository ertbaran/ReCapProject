using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entities.Concrete;
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
            VehicleManager vehicleManager = new VehicleManager(new InMemoryVehicleDal());
            foreach (var vehicle in vehicleManager.GetAll())
            {
                Console.WriteLine(vehicle.ModelYear+" Model"+", "+vehicle.BrandId+" Marka Kodlu Araç: "+ vehicle.DailyPrice+" TL");
            }
            Console.Read();
        }
    }
}
