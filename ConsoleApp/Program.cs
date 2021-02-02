using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            InMemoryCarDal ınMemoryCarDal = new InMemoryCarDal();
            CarManager carManager = new CarManager(ınMemoryCarDal);

            Console.WriteLine("--------ADD---------");
            ınMemoryCarDal.Add(new Car { Id = 6, BrandId = 3, ColorId = 5, DailyPrice = 1350, ModelYear = 2012, Description = "240.000 km" });
            ınMemoryCarDal.JoinShow(carManager.GetAll());

            Console.WriteLine("---------UPDATE---------");
            ınMemoryCarDal.Update(new Car {Id = 4, BrandId = 2, ColorId = 4, DailyPrice = 4000, ModelYear = 2011, Description = "100.000 km" });
            ınMemoryCarDal.JoinShow(carManager.GetAll());

            Console.WriteLine("-----------DELETE--------------");
            ınMemoryCarDal.Delete(carManager.GetAll()[1]);
            ınMemoryCarDal.JoinShow(carManager.GetAll());

            Console.WriteLine("----------GETBYID--------");
            var sonuc = ınMemoryCarDal.GetById(4);
            ınMemoryCarDal.JoinShow(sonuc);
        }
    }
}
