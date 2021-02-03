using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete
{
    public class InMemoryVehicleDal : IVehicleDal
    {
        List<Car> _cars;

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            _cars.Remove(_cars.SingleOrDefault(c => c.ID == car.ID));
        }
        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.ID == car.ID);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int carId)
        {
            List<Car> carsToGetById = _cars.Where(ci => ci.ID == carId).ToList();
            return carsToGetById;
        }
        public InMemoryVehicleDal()
        {
            // Normalde Oracle, Sql Server, MongoDb, Postgress gibi veri tabanlarından gelir.  
            _cars = new List<Car>() {
                new Car{ID=1, BrandId=1, ColorId = 3, DailyPrice = 250, ModelYear = 2010, Description ="Oluşabilecek sorunlardan müşteri sorumludur. "},
                new Car{ID=2, BrandId=1, ColorId = 1, DailyPrice = 400, ModelYear = 2018, Description ="Oluşabilecek sorunlardan müşteri sorumludur. "},
                new Car{ID=3, BrandId=3, ColorId = 1, DailyPrice = 600, ModelYear = 2020, Description ="Oluşabilecek sorunlardan müşteri sorumludur. "},
                new Car{ID=4, BrandId=4, ColorId = 2, DailyPrice = 1200, ModelYear = 2019, Description ="Oluşabilecek sorunlardan müşteri sorumludur. "},
                new Car{ID=5, BrandId=2, ColorId = 3, DailyPrice = 800, ModelYear = 2020, Description ="Oluşabilecek sorunlardan müşteri sorumludur. "},
            };
        }

    }
}
