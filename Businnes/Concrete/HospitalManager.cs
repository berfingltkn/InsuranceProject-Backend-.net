using Businnes.Abstract;
using Castle.Core.Resource;
using Core.Utilities.Result;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businnes.Concrete
{
    public class HospitalManager : IHospitalService
    {
        IHospitalDal _hospitalDal;

        public HospitalManager(IHospitalDal hospitalDal) {
        _hospitalDal = hospitalDal;
        }
        public IResult Add(Hospital hospital)
        {
            _hospitalDal.Add(hospital);
            return new SuccessResult("hospital added");
        }

        public IResult Delete(Hospital hospital)
        {
            var deletedHospital = _hospitalDal.Get(h=>h.hospitalName==hospital.hospitalName);
            _hospitalDal.Delete(deletedHospital);
            return new SuccessResult("hospital deleted");
        }

        public IDataResult<List<Hospital>> GetAll()
        {
            return new SuccessDataResult<List<Hospital>>(_hospitalDal.GetAll(), "hospital listed");
        }

        public IDataResult<List<HospitalDetailDto>> GetDistrictByCityID(int cityID)
        {
            return new SuccessDataResult<List<HospitalDetailDto>>(_hospitalDal.GetHospitalDetails(h => h.cityID == cityID ), "get district by cityID and districtID");

        }

        public IDataResult<List<HospitalDetailDto>> GetHospitalsByCityAndDistrict(int cityID, int distructID)
        {
            return new SuccessDataResult<List<HospitalDetailDto>>(_hospitalDal.GetHospitalDetails(h=>h.cityID==cityID && h.districtID==distructID),"get hospital by cityID and districtID");
        }

       
        public IDataResult<List<HospitalDetailDto>> GetHospitalWithDetails()
        {
            return new SuccessDataResult<List<HospitalDetailDto>>( _hospitalDal.GetHospitalDetails(),"hospital detail listed.");
        }

        public IResult Update(Hospital hospital)
        {
            _hospitalDal.Update(hospital);
            return new SuccessResult("hospital updated");
        }
    }
}
