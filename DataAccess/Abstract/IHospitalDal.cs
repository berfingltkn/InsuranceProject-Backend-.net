using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IHospitalDal:IEntityRepository<Hospital>
    {
        List<HospitalDetailDto> GetHospitalDetails(Expression<Func<HospitalDetailDto, bool>> filter = null);
       // List<HospitalDetailDto> GetHospitalsByCityAndDistrict(int cityID, int districtID);

    }
}
