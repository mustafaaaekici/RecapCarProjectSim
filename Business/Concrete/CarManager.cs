using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager:ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car car)
        {
            if (car.CarName.Length > 2 && car.UnitPrice > 0)
            {
                _carDal.Add(car);
                Console.WriteLine("Araç Başarılı Şekilde Eklendi");
            }
            else
            {
                Console.WriteLine("Araç Bilgilerini istenilen şekilde giriniz.");
            }
        }

        public void Delete(Car car)
        {
            Console.WriteLine("Araç silindi");
            _carDal.GetAll(p => p.CarId == car.CarId);
            _carDal.Delete(car);
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            return _carDal.GetCarDetails();
        }

        public List<Car> GetCarsByBrandId(int id)
        {
            return _carDal.GetAll(p => p.BrandId == id);
        }

        public List<Car> GetCarsByColorId(int id)
        {
            return _carDal.GetAll(p => p.ColorId == id);
        }

        public void Update(Car car)
        {
            Console.WriteLine("Araç Bilgileri Güncellendi");
            _carDal.GetAll(p => p.CarId == car.CarId);

        }
    }
}
