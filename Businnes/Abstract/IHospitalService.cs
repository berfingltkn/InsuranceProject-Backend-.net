using Core.Utilities.Result;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businnes.Abstract
{
    public interface IHospitalService
    {
        IDataResult<List<HospitalDetailDto>> GetHospitalWithDetails();//tüm hospitalDto bilgileri gelsin
        IDataResult<List<HospitalDetailDto>> GetHospitalsByCityAndDistrict(string cityName,string distructName);//city ve district a göre hastane getirecek.
        IDataResult<List<HospitalDetailDto>> GetDistrictByCityID(string cityName);//şehir id sine göre ilçe getirecek.
        IDataResult<List<Hospital>> GetAll();
        IResult Add(Hospital hospital);
        IResult Delete(Hospital hospital);
        IResult Update(Hospital hospital);
    }
}
