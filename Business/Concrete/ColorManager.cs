using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public void Add(Color color)
        {
            _colorDal.Add(color);
            Console.WriteLine("Color Tablosuna Başarılı Şekilde Eklenmiştir.");
        }

        public void Delete(Color color)
        {
            Console.WriteLine("Renk Silindi");
            _colorDal.GetAll(c => c.ColorId == color.ColorId);
            _colorDal.Delete(color);
        }

        public List<Color> GetAll()
        {
            return _colorDal.GetAll();
        }

        public Color GetColorById(int colorId)
        {
            throw new NotImplementedException();
        }

        public void Update(Color color)
        {
            Console.WriteLine("Renk Bilgileri Güncellendi");
            _colorDal.GetAll(c => c.ColorId == color.ColorId);
            _colorDal.Update(color);
        }
    }
}
