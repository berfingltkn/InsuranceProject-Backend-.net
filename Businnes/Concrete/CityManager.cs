using Businnes.Abstract;
using Castle.Core.Resource;
using Core.Utilities.Result;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businnes.Concrete
{
    public class CityManager : ICityService
    {
        private readonly ICityDal _cityDal;

        public CityManager(ICityDal cityDal)
        {
            _cityDal = cityDal;
        }

        public IResult Add(City city)
        {
            _cityDal.Add(city);
            return new SuccessResult("city added");
        }

        public IResult Delete(City city)
        {
            var deletedCity = _cityDal.Get(c => c.cityId == city.cityId);
            _cityDal.Delete(deletedCity);
            return new SuccessResult("city deleted");
        }

        public IDataResult<List<City>> GetAll()
        {
            return new SuccessDataResult<List<City>>(_cityDal.GetAll(), "cities listed");

        }

        public IResult Update(City city)
        {
            _cityDal.Update(city);
            return new SuccessResult("city updated");
        }
    }
}
