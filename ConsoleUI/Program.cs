using Business.Concrete;
using DataAccess.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            Color color1 = new Color() { ColorId = 8, ColorName = "Orange" };
            colorManager.Delete(color1);
            Color color2 = new Color() { ColorId = 9, ColorName = "Magenta" };
            colorManager.Add(color2);
            foreach (var colors in colorManager.GetAll())
            {
                Console.WriteLine("{0}-{1}", colors.ColorId, colors.ColorName);
            }

            BrandManager brandManager = new BrandManager(new EfBrandDal());
            Brand brand1 = new Brand() { BrandId = 7, BrandName = "Porsche" };
            Brand brand2 = new Brand() { BrandId = 8, BrandName = "Nissan" };
            brandManager.Add(brand1);
            brandManager.Delete(brand2);

            foreach (var brands in brandManager.GetAll())
            {
                Console.WriteLine("{0}-{1}", brands.BrandId, brands.BrandName);
            }

            CarManager carManager = new CarManager(new EfCarDal());
            Car car1 = new Car() { CarId = 8, CarName = "Nissan", BrandId = 8, ColorId = 8, ModelYear = 2021, UnitPrice = 400000, Description = "Araba1" };
            Car car2 = new Car() { CarId = 9, CarName = "Fiat", BrandId = 9, ColorId = 9, ModelYear = 2016, UnitPrice = 90000, Description = "Araba2" };
            carManager.Delete(car1);
            carManager.Add(car2);
            foreach (var cars in carManager.GetCarDetails())
            {
                Console.WriteLine("{0}-{1}-{2}-{3}", cars.CarId, cars.CarName,
                    cars.BrandId, cars.UnitPrice);
            }
        }
    }
}
