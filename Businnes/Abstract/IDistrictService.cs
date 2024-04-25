using Core.Utilities.Result;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businnes.Abstract
{
    public interface IDistrictService
    {
        IDataResult<List<District>> GetAll();
        IResult Add(District district);
        IResult Update(District district);
        IResult Delete(District district);
    }
}
