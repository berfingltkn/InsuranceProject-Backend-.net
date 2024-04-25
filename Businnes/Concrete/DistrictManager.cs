using Businnes.Abstract;
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
    public class DistrictManager : IDistrictService
    {
        IDistrictDal _districtDal;

        public DistrictManager(IDistrictDal districtDal)
        {
            _districtDal = districtDal;
        }

        public IResult Add(District district)
        {
            _districtDal.Add(district);
            return new SuccessResult("district added");

        }

        public IResult Delete(District district)
        {
           var deletedDistrict=_districtDal.Get(c=>c.districtId==district.districtId);
            _districtDal.Delete(deletedDistrict);
            return new SuccessResult("district deleted");
        }

        public IDataResult<List<District>> GetAll()
        {
            return new SuccessDataResult<List<District>>(_districtDal.GetAll(), "districts listed");

        }

        public IResult Update(District district)
        {
           _districtDal.Update(district);
            return new SuccessResult("district updated");
        }
    }
}
