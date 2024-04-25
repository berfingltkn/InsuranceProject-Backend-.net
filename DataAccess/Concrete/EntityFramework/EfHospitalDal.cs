using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfHospitalDal : EfEntityRepositoryBase<Hospital, InsuranceDBContext>, IHospitalDal
    {
        

        public List<HospitalDetailDto> GetHospitalDetails(Expression<Func<HospitalDetailDto, bool>> filter = null)
        {
            using (InsuranceDBContext context=new InsuranceDBContext())
            {
                var result = from h in context.hospital
                             join c in context.city
                             on h.cityID equals c.cityId

                             join d in context.district
                             on h.districtID equals d.districtId
                             select new HospitalDetailDto
                             {
                                 hospitalName = h.hospitalName,
                                 districtID = h.districtID,
                                 districtName = d.districtName,
                                 cityID = h.cityID,
                                 cityName = c.cityName,

                             };
                return filter==null
                    ?result.ToList()
                    :result.Where(filter).ToList();
            }
        }


    }
}
