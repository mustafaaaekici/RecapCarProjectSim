using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public void Add(Brand brand)
        {
            _brandDal.Add(brand);
            Console.WriteLine("Başarılı Şekilde Brand Tablosuna Ekleme Yapıldı");
        }

        public void Delete(Brand brand)
        {
            Console.WriteLine("Brand Silindi");
            _brandDal.GetAll(b => b.BrandId == brand.BrandId);
            _brandDal.Delete(brand);
        }

        public List<Brand> GetAll()
        {
            return _brandDal.GetAll();
        }

        public Brand GetBrandById(int brandId)
        {
            return _brandDal.Get(b => b.BrandId == brandId);
        }

        public void Update(Brand brand)
        {
            Console.WriteLine("Brand Bilgileri GÜncellendi");
            _brandDal.Update(brand);
        }
    }
}
